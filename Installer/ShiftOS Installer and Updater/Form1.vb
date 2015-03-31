Imports System.IO
Imports IWshRuntimeLibrary

Public Class Form1

    Dim sw As StreamWriter
    Dim serverPath As String = "https://raw.githubusercontent.com/william1008/ShiftOS-GameFiles/master/"
    Dim InstallPath As String = "C:\ShiftOS-GameFiles\"
    Dim state As String
    Dim movespeed As Integer = 20

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lblintro.Location = New Point(12, 8)
        folder.Location = New Point(15, 60)
        pathpre.Location = New Point(73, 88)
        loading.Location = New Point(401 + 812, 163)
        txtlicenses.Location = New Point(15 + 1000, 11)
        pnlversion.Location = New Point(11 + 1422, 11)
        button.Text = "Confirm Path"
        state = "Get Path"
        Combobeta.Enabled = False
        Combostable.Enabled = True
    End Sub

    Private Sub folder_Click(sender As Object, e As EventArgs) Handles folder.Click
        openfolder.ShowDialog()
        InstallPath = openfolder.SelectedPath()
        pathpre.Text = InstallPath
    End Sub

    Private Sub Install(file As String)
        My.Computer.Network.DownloadFile(serverPath & file & ".zip", InstallPath & file & ".zip")
        Compression.ZipFile.ExtractToDirectory(InstallPath & file & ".zip", InstallPath & file)
        Dim shell As New WshShell
        Dim shortcut As WshShortcut = shell.CreateShortcut(My.Computer.FileSystem.SpecialDirectories.Desktop & "\ShiftOS.lnk")
        shortcut.TargetPath = InstallPath & file & "\ShiftOS.exe"
        shortcut.IconLocation = InstallPath & file & "\ShiftOS.exe"
        shortcut.Description = "ShiftOS"
        shortcut.Save()
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
                If CheckBox1.Checked = False Then
                    If Combostable.SelectedItem.ToString = "" Then MessageBox.Show("No version selected") Else Install(Combostable.SelectedItem.ToString)
                Else
                    If Combobeta.SelectedItem.ToString = "" Then MessageBox.Show("No version selected") Else Install(Combobeta.SelectedItem.ToString)
                End If
        End Select
    End Sub

    Private Sub tmrmove_Tick(sender As Object, e As EventArgs) Handles tmrmove.Tick
        Select Case state
            Case "Get Path"
                lblintro.Location = New Point(lblintro.Location.X - movespeed, 8)
                folder.Location = New Point(folder.Location.X - movespeed, 60)
                pathpre.Location = New Point(pathpre.Location.X - movespeed, 88)
                loading.Location = New Point(loading.Location.X - movespeed, 163)
                If lblintro.Location.X < -800 Then
                    tmrmove.Stop()
                    downloadlicenses()
                    state = "licenses"
                    button.Text = "Agree"
                End If
            Case "licenses"
                loading.Location = New Point(loading.Location.X - movespeed, 163)
                txtlicenses.Location = New Point(txtlicenses.Location.X - movespeed, 11)
                If loading.Location.X < -600 Then
                    tmrmove.Stop()
                End If
            Case "version"
                pnlversion.Location = New Point(pnlversion.Location.X - movespeed, 11)
                txtlicenses.Location = New Point(txtlicenses.Location.X - movespeed, 11)
                If pnlversion.Location.X <= 11 Then
                    tmrmove.Stop()
                End If
        End Select
    End Sub

    Private Sub downloadlicenses()
        If IO.File.Exists(InstallPath & "License.txt") Then IO.File.Delete(InstallPath & "License.txt")
        If IO.File.Exists(InstallPath & "Beta.dat") Then IO.File.Delete(InstallPath & "Beta.dat")
        If IO.File.Exists(InstallPath & "Stable.dat") Then IO.File.Delete(InstallPath & "Stable.dat")
        Try
            My.Computer.Network.DownloadFile(serverPath & "License.txt", InstallPath & "License.txt")
            My.Computer.Network.DownloadFile(serverPath & "Beta.dat", InstallPath & "Beta.dat")
            My.Computer.Network.DownloadFile(serverPath & "Stable.dat", InstallPath & "Stable.dat")
            txtlicenses.Text = IO.File.ReadAllText(InstallPath & "License.txt")
            tmrmove.Start()
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
End Class
