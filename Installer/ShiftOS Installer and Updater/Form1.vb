Imports System.IO
Imports IWshRuntimeLibrary
Imports System.ComponentModel

Public Class Form1

    Dim sw As StreamWriter
    Dim serverPath As String = "https://raw.githubusercontent.com/william1008/ShiftOS-GameFiles/master/Database/"
    Dim InstallPath As String = "C:\ShiftOS-GameFiles\"
    Dim state As String
    Dim movespeed As Integer = 40

    Dim versionstate As String
    Dim file_ As String
    Dim name_() As String

    Dim WithEvents bw As BackgroundWorker = New BackgroundWorker
    Dim WithEvents bw_exedown As BackgroundWorker = New BackgroundWorker
    Dim WithEvents bw_depdown As BackgroundWorker = New BackgroundWorker

    Private Sub bwdepdown_DoWork(ByVal sender As Object, ByVal e As DoWorkEventArgs) Handles bw_depdown.DoWork
        Dim dependencies(2000) As String
        Dim sr As IO.StreamReader = New StreamReader(InstallPath & file_ & "-dependencies.dat")
        For i As Integer = 0 To 1999
            dependencies(i) = sr.ReadLine()
            If IO.File.Exists(InstallPath & dependencies(i)) Then
                ' Already have dependencies, no download needed
            Else
                Try
                    My.Computer.Network.DownloadFile(serverPath & "Dependencies/" & dependencies(i), InstallPath & dependencies(i))
                Catch ex As Exception
                    ' Move on, this line is propably blank
                End Try
            End If
        Next
        bw_depdown.ReportProgress(100)
    End Sub

    Private Sub bwexedown_DoWork(ByVal sender As Object, ByVal e As DoWorkEventArgs) Handles bw_exedown.DoWork
        Dim worker As BackgroundWorker = CType(sender, BackgroundWorker)
        If bw.CancellationPending = True Then
            e.Cancel = True
        Else
            My.Computer.Network.DownloadFile(serverPath & "Versions/" & versionstate & name_(0) & "%20" & name_(1) & ".exe", InstallPath & file_ & ".exe")
            If onlyexe.Checked = False Then
                Try
                    My.Computer.Network.DownloadFile(serverPath & "Versions/" & versionstate & name_(0) & "%20" & name_(1) & "-dependencies.dat", InstallPath & file_ & "-dependencies.dat")
                Catch ex As Exception
                    'version has no dependencies, move on
                End Try
            End If
            bw_exedown.ReportProgress(100)
            End If
    End Sub

    Private Sub bwexedown_progressreport() Handles bw_exedown.ProgressChanged
        ' Check dependencies
        If onlyexe.Checked = False Then
            If IO.File.Exists(InstallPath & file_ & "-dependencies.dat") Then
                bw_depdown.RunWorkerAsync()
            Else
                If noshort.Checked = False Then
                    'Create desktop shortcut
                    Dim shell As New WshShell
                    Dim shortcut As WshShortcut = shell.CreateShortcut(My.Computer.FileSystem.SpecialDirectories.Desktop & "\" & file_ & ".lnk")
                    shortcut.TargetPath = InstallPath & file_ & ".exe"
                    shortcut.IconLocation = InstallPath & file_ & ".exe"
                    shortcut.Description = "Evolve an experimental operating system called ShiftOS"
                    shortcut.Save()
                End If
                state = "done"
                tmrmove.Start()
            End If
        Else
            If noshort.Checked = False Then
                'Create desktop shortcut
                Dim shell As New WshShell
                Dim shortcut As WshShortcut = shell.CreateShortcut(My.Computer.FileSystem.SpecialDirectories.Desktop & "\" & file_ & ".lnk")
                shortcut.TargetPath = InstallPath & file_ & ".exe"
                shortcut.IconLocation = InstallPath & file_ & ".exe"
                shortcut.Description = "Evolve an experimental operating system called ShiftOS"
                shortcut.Save()
            End If
            state = "done"
            tmrmove.Start()
        End If
    End Sub

    Private Sub bwdepdown_progressreport() Handles bw_depdown.ProgressChanged
        If noshort.Checked = False Then
            'Create desktop shortcut
            Dim shell As New WshShell
            Dim shortcut As WshShortcut = shell.CreateShortcut(My.Computer.FileSystem.SpecialDirectories.Desktop & "\" & file_ & ".lnk")
            shortcut.TargetPath = InstallPath & file_ & ".exe"
            shortcut.IconLocation = InstallPath & file_ & ".exe"
            shortcut.Description = "Evolve an experimental operating system called ShiftOS"
            shortcut.Save()
        End If
        state = "done"
        tmrmove.Start()
    End Sub


    Private Sub bw_DoWork(ByVal sender As Object, ByVal e As DoWorkEventArgs) Handles bw.DoWork
        Dim worker As BackgroundWorker = CType(sender, BackgroundWorker)
        If bw.CancellationPending = True Then
            e.Cancel = True
        Else
            My.Computer.Network.DownloadFile(serverPath & "License.txt", InstallPath & "License.txt")
            My.Computer.Network.DownloadFile(serverPath & "Beta.dat", InstallPath & "Beta.dat")
            My.Computer.Network.DownloadFile(serverPath & "Stable.dat", InstallPath & "Stable.dat")
            bw.ReportProgress(100)
        End If
    End Sub

    Private Sub bw_progressreport() Handles bw.ProgressChanged
        txtlicenses.Text = IO.File.ReadAllText(InstallPath & "License.txt")
        tmrmove.Start()
    End Sub


    Private Sub titlebar_MouseDown(sender As Object, e As MouseEventArgs) Handles titlebar.MouseDown, lbltitletext.MouseDown
        ' Handle Draggable Windows
        If e.Button = MouseButtons.Left Then
            titlebar.Capture = False
            Const WM_NCLBUTTONDOWN As Integer = &HA1S
            Const HTCAPTION As Integer = 2
            Dim msg As Message = _
                Message.Create(Me.Handle, WM_NCLBUTTONDOWN, _
                    New IntPtr(HTCAPTION), IntPtr.Zero)
            Me.DefWndProc(msg)
        End If
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        pathpre.Text = InstallPath
        lblintro.Location = New Point(12, 8)
        folder.Location = New Point(15, 60)
        pathpre.Location = New Point(73, 88)
        loading.Location = New Point(401 + 812, 163)
        txtlicenses.Location = New Point(15 + 1000, 11)
        pnlversion.Location = New Point(11 + 1422, 11)
        done.Location = New Point(11 + 1422, 11)
        Label1.Text = "CRUCHING DATA"
        button.Text = "Confirm Path"
        state = "Get Path"
        Combobeta.Enabled = False
        Combostable.Enabled = True
        bw.WorkerSupportsCancellation = True
        bw.WorkerReportsProgress = True
        bw_exedown.WorkerSupportsCancellation = True
        bw_depdown.WorkerSupportsCancellation = True
        bw_depdown.WorkerReportsProgress = True
        bw_exedown.WorkerReportsProgress = True
    End Sub

    Private Sub folder_Click(sender As Object, e As EventArgs) Handles folder.Click
        openfolder.ShowDialog()
        InstallPath = openfolder.SelectedPath()
        pathpre.Text = InstallPath
    End Sub

    Private Sub Install(file As String)
        'do slide thing
        loading.Location = New Point(401 + 812, 163)
        state = "download-install"
        tmrmove.Start()
        ' Download EXE
        file_ = file
        If CheckBox1.Checked = True Then
            versionstate = "Beta/"
        Else
            versionstate = "Stable/"
        End If
        name_ = file.Split(" ")
        If IO.File.Exists(InstallPath & file & ".exe") Then IO.File.Delete(InstallPath & file & ".exe")
        Try
            bw_exedown.RunWorkerAsync()
        Catch ex As Exception
            MessageBox.Show("We are unable to contact the server, please check you internet connection and try again.")
            Me.Close()
        End Try
        
    End Sub

    Private Sub button_Click(sender As Object, e As EventArgs) Handles button.Click
        Select Case state
            Case "Get Path"
                tmrmove.Start()
            Case "licenses"
                state = "version"
                Combostable.Items.AddRange(IO.File.ReadAllLines(InstallPath & "Stable.dat"))
                Combobeta.Items.AddRange(IO.File.ReadAllLines(InstallPath & "Beta.dat"))
                button.Text = "Download & Install"
                tmrmove.Start()
            Case "version"
                Try
                    If CheckBox1.Checked = False Then
                        If Combostable.SelectedItem.ToString = "" Then MessageBox.Show("No version selected") Else Install(Combostable.SelectedItem.ToString)
                    Else
                        If Combobeta.SelectedItem.ToString = "" Then MessageBox.Show("No version selected") Else Install(Combobeta.SelectedItem.ToString)
                    End If
                Catch ex As Exception
                    MessageBox.Show("No version selected")
                End Try
            Case "done"
                Me.Close()
        End Select
    End Sub

    Private Sub tmrmove_Tick(sender As Object, e As EventArgs) Handles tmrmove.Tick
        Select Case state
            Case "Get Path"
                button.Enabled = False
                lblintro.Location = New Point(lblintro.Location.X - movespeed, 8)
                folder.Location = New Point(folder.Location.X - movespeed, 60)
                pathpre.Location = New Point(pathpre.Location.X - movespeed, 88)
                loading.Location = New Point(loading.Location.X - movespeed, 163)
                If lblintro.Location.X < -800 Then
                    tmrmove.Stop()
                    downloadlicenses()
                    state = "licenses"
                    button.Enabled = False
                    button.Text = "Waiting"
                End If
            Case "licenses"
                button.Enabled = False
                loading.Location = New Point(loading.Location.X - movespeed, 163)
                txtlicenses.Location = New Point(txtlicenses.Location.X - movespeed, 11)
                If loading.Location.X < -600 Then
                    tmrmove.Stop()
                    button.Enabled = True
                    button.Text = "Agree"
                End If
            Case "version"
                button.Enabled = False
                button.Text = "Download and Install"
                pnlversion.Location = New Point(pnlversion.Location.X - movespeed, 11)
                txtlicenses.Location = New Point(txtlicenses.Location.X - movespeed, 11)
                If pnlversion.Location.X <= 11 Then
                    tmrmove.Stop()
                    button.Enabled = True
                End If
            Case "download-install"
                Label1.Text = "   DOWNLOADING"
                button.Enabled = False
                pnlversion.Location = New Point(pnlversion.Location.X - movespeed, 11)
                loading.Location = New Point(loading.Location.X - movespeed, 163)
                button.Text = "Awaiting Download"
                If pnlversion.Location.X < -800 Then
                    tmrmove.Stop()
                    button.Enabled = False
                    button.Text = "Awaiting Download"
                End If
            Case "done"
                button.Enabled = False
                button.Text = "Close"
                done.Location = New Point(pnlversion.Location.X - movespeed, 11)
                loading.Location = New Point(txtlicenses.Location.X - movespeed, 11)
                If done.Location.X <= 11 Then
                    tmrmove.Stop()
                    button.Enabled = True
                End If
        End Select
    End Sub

    Private Sub downloadlicenses()
        If IO.File.Exists(InstallPath & "License.txt") Then IO.File.Delete(InstallPath & "License.txt")
        If IO.File.Exists(InstallPath & "Beta.dat") Then IO.File.Delete(InstallPath & "Beta.dat")
        If IO.File.Exists(InstallPath & "Stable.dat") Then IO.File.Delete(InstallPath & "Stable.dat")
        Try
            bw.RunWorkerAsync()
        Catch ex As Exception
            MessageBox.Show("We are unable to contact the server, please check you internet connection and try again.")
            Me.Close()
        End Try
    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
        If CheckBox1.Checked = True Then
            Combobeta.Enabled = True
            Combostable.Enabled = False
        Else
            Combobeta.Enabled = False
            Combostable.Enabled = True
        End If
    End Sub

    Private Sub pnlclose_click(sender As Object, e As EventArgs) Handles pnlclose.Click
        Me.Close()
    End Sub

    Private Sub pnlclose_mouseover(sender As Object, e As EventArgs) Handles pnlclose.MouseEnter
        pnlclose.BackColor = Color.Red
    End Sub
    Private Sub pnlclose_mouseoverout(sender As Object, e As EventArgs) Handles pnlclose.MouseLeave
        pnlclose.BackColor = Color.White
    End Sub
End Class
