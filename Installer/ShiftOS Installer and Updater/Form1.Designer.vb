<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.openfolder = New System.Windows.Forms.FolderBrowserDialog()
        Me.tmrmove = New System.Windows.Forms.Timer(Me.components)
        Me.trmload = New System.Windows.Forms.Timer(Me.components)
        Me.titlebar = New System.Windows.Forms.Panel()
        Me.pnlclose = New System.Windows.Forms.Panel()
        Me.lbltitletext = New System.Windows.Forms.Label()
        Me.pnlinstallto = New System.Windows.Forms.Panel()
        Me.pnlversion = New System.Windows.Forms.Panel()
        Me.noshort = New System.Windows.Forms.CheckBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.onlyexe = New System.Windows.Forms.CheckBox()
        Me.versioninfo = New System.Windows.Forms.Label()
        Me.CheckBox1 = New System.Windows.Forms.CheckBox()
        Me.Combostable = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Combobeta = New System.Windows.Forms.ComboBox()
        Me.button = New System.Windows.Forms.Button()
        Me.txtlicenses = New System.Windows.Forms.TextBox()
        Me.loading = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.folder = New System.Windows.Forms.PictureBox()
        Me.pathpre = New System.Windows.Forms.Label()
        Me.lblintro = New System.Windows.Forms.Label()
        Me.done = New System.Windows.Forms.Panel()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.titlebar.SuspendLayout()
        Me.pnlinstallto.SuspendLayout()
        Me.pnlversion.SuspendLayout()
        Me.loading.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.folder, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.done.SuspendLayout()
        Me.SuspendLayout()
        '
        'tmrmove
        '
        Me.tmrmove.Interval = 1
        '
        'trmload
        '
        Me.trmload.Interval = 10
        '
        'titlebar
        '
        Me.titlebar.Controls.Add(Me.pnlclose)
        Me.titlebar.Controls.Add(Me.lbltitletext)
        Me.titlebar.Dock = System.Windows.Forms.DockStyle.Top
        Me.titlebar.Location = New System.Drawing.Point(0, 0)
        Me.titlebar.Name = "titlebar"
        Me.titlebar.Size = New System.Drawing.Size(880, 29)
        Me.titlebar.TabIndex = 5
        '
        'pnlclose
        '
        Me.pnlclose.BackgroundImage = CType(resources.GetObject("pnlclose.BackgroundImage"), System.Drawing.Image)
        Me.pnlclose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.pnlclose.Location = New System.Drawing.Point(852, 7)
        Me.pnlclose.Name = "pnlclose"
        Me.pnlclose.Size = New System.Drawing.Size(16, 16)
        Me.pnlclose.TabIndex = 1
        '
        'lbltitletext
        '
        Me.lbltitletext.AutoSize = True
        Me.lbltitletext.Font = New System.Drawing.Font("Lucida Sans Unicode", 11.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbltitletext.Location = New System.Drawing.Point(358, 8)
        Me.lbltitletext.Name = "lbltitletext"
        Me.lbltitletext.Size = New System.Drawing.Size(140, 18)
        Me.lbltitletext.TabIndex = 0
        Me.lbltitletext.Text = "ShiftOS Installer"
        '
        'pnlinstallto
        '
        Me.pnlinstallto.Controls.Add(Me.done)
        Me.pnlinstallto.Controls.Add(Me.pnlversion)
        Me.pnlinstallto.Controls.Add(Me.button)
        Me.pnlinstallto.Controls.Add(Me.txtlicenses)
        Me.pnlinstallto.Controls.Add(Me.loading)
        Me.pnlinstallto.Controls.Add(Me.folder)
        Me.pnlinstallto.Controls.Add(Me.pathpre)
        Me.pnlinstallto.Controls.Add(Me.lblintro)
        Me.pnlinstallto.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlinstallto.Location = New System.Drawing.Point(0, 29)
        Me.pnlinstallto.Name = "pnlinstallto"
        Me.pnlinstallto.Size = New System.Drawing.Size(880, 487)
        Me.pnlinstallto.TabIndex = 6
        '
        'pnlversion
        '
        Me.pnlversion.Controls.Add(Me.noshort)
        Me.pnlversion.Controls.Add(Me.Label4)
        Me.pnlversion.Controls.Add(Me.onlyexe)
        Me.pnlversion.Controls.Add(Me.versioninfo)
        Me.pnlversion.Controls.Add(Me.CheckBox1)
        Me.pnlversion.Controls.Add(Me.Combostable)
        Me.pnlversion.Controls.Add(Me.Label3)
        Me.pnlversion.Controls.Add(Me.Label2)
        Me.pnlversion.Controls.Add(Me.Combobeta)
        Me.pnlversion.Location = New System.Drawing.Point(11, 11)
        Me.pnlversion.Name = "pnlversion"
        Me.pnlversion.Size = New System.Drawing.Size(533, 206)
        Me.pnlversion.TabIndex = 12
        '
        'noshort
        '
        Me.noshort.AutoSize = True
        Me.noshort.Location = New System.Drawing.Point(189, 143)
        Me.noshort.Name = "noshort"
        Me.noshort.Size = New System.Drawing.Size(271, 17)
        Me.noshort.TabIndex = 14
        Me.noshort.Text = "Don't create a desktop shortcut (Not recommended)"
        Me.noshort.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.ForeColor = System.Drawing.SystemColors.AppWorkspace
        Me.Label4.Location = New System.Drawing.Point(186, 59)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(241, 81)
        Me.Label4.TabIndex = 13
        Me.Label4.Text = resources.GetString("Label4.Text")
        '
        'onlyexe
        '
        Me.onlyexe.AutoSize = True
        Me.onlyexe.Location = New System.Drawing.Point(189, 36)
        Me.onlyexe.Name = "onlyexe"
        Me.onlyexe.Size = New System.Drawing.Size(250, 17)
        Me.onlyexe.TabIndex = 12
        Me.onlyexe.Text = "Don't check dependencies (Not recommended)"
        Me.onlyexe.UseVisualStyleBackColor = True
        '
        'versioninfo
        '
        Me.versioninfo.AutoSize = True
        Me.versioninfo.Location = New System.Drawing.Point(16, 9)
        Me.versioninfo.Name = "versioninfo"
        Me.versioninfo.Size = New System.Drawing.Size(411, 13)
        Me.versioninfo.TabIndex = 6
        Me.versioninfo.Text = "Thanks for that, we just need to know what version to install and you'll be ready" & _
    " to go!"
        '
        'CheckBox1
        '
        Me.CheckBox1.AutoSize = True
        Me.CheckBox1.Location = New System.Drawing.Point(19, 86)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(115, 17)
        Me.CheckBox1.TabIndex = 11
        Me.CheckBox1.Text = "Enable Beta Builds"
        Me.CheckBox1.UseVisualStyleBackColor = True
        '
        'Combostable
        '
        Me.Combostable.FormattingEnabled = True
        Me.Combostable.Location = New System.Drawing.Point(19, 49)
        Me.Combostable.Name = "Combostable"
        Me.Combostable.Size = New System.Drawing.Size(121, 21)
        Me.Combostable.TabIndex = 7
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(16, 106)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(75, 13)
        Me.Label3.TabIndex = 10
        Me.Label3.Text = "Beta Versions:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(16, 36)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(83, 13)
        Me.Label2.TabIndex = 8
        Me.Label2.Text = "Stable Versions:"
        '
        'Combobeta
        '
        Me.Combobeta.FormattingEnabled = True
        Me.Combobeta.Location = New System.Drawing.Point(19, 119)
        Me.Combobeta.Name = "Combobeta"
        Me.Combobeta.Size = New System.Drawing.Size(121, 21)
        Me.Combobeta.TabIndex = 9
        '
        'button
        '
        Me.button.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.button.Location = New System.Drawing.Point(748, 452)
        Me.button.Name = "button"
        Me.button.Size = New System.Drawing.Size(120, 23)
        Me.button.TabIndex = 2
        Me.button.Text = "Procced"
        Me.button.UseVisualStyleBackColor = True
        '
        'txtlicenses
        '
        Me.txtlicenses.Location = New System.Drawing.Point(-1, 3)
        Me.txtlicenses.Multiline = True
        Me.txtlicenses.Name = "txtlicenses"
        Me.txtlicenses.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtlicenses.Size = New System.Drawing.Size(869, 434)
        Me.txtlicenses.TabIndex = 5
        '
        'loading
        '
        Me.loading.Controls.Add(Me.Label1)
        Me.loading.Controls.Add(Me.PictureBox1)
        Me.loading.Location = New System.Drawing.Point(401, 163)
        Me.loading.Name = "loading"
        Me.loading.Size = New System.Drawing.Size(97, 87)
        Me.loading.TabIndex = 4
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.0!, System.Drawing.FontStyle.Bold)
        Me.Label1.ForeColor = System.Drawing.SystemColors.AppWorkspace
        Me.Label1.Location = New System.Drawing.Point(2, 70)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(92, 9)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "CRUNCHING DATA"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(19, 3)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(64, 64)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'folder
        '
        Me.folder.Image = CType(resources.GetObject("folder.Image"), System.Drawing.Image)
        Me.folder.Location = New System.Drawing.Point(15, 60)
        Me.folder.Name = "folder"
        Me.folder.Size = New System.Drawing.Size(52, 41)
        Me.folder.TabIndex = 3
        Me.folder.TabStop = False
        '
        'pathpre
        '
        Me.pathpre.AutoSize = True
        Me.pathpre.ForeColor = System.Drawing.SystemColors.AppWorkspace
        Me.pathpre.Location = New System.Drawing.Point(73, 88)
        Me.pathpre.Name = "pathpre"
        Me.pathpre.Size = New System.Drawing.Size(131, 13)
        Me.pathpre.TabIndex = 2
        Me.pathpre.Text = "C:\Program Files\ShiftOS\"
        '
        'lblintro
        '
        Me.lblintro.AutoSize = True
        Me.lblintro.Location = New System.Drawing.Point(12, 8)
        Me.lblintro.Name = "lblintro"
        Me.lblintro.Size = New System.Drawing.Size(626, 39)
        Me.lblintro.TabIndex = 1
        Me.lblintro.Text = "Hello and welcome to you freindly ShiftOS installer, no hijacking, no running out" & _
    " of code points, this is entirely free and simple to use!" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Firstly, where woul" & _
    "d you like to install ShiftOS?"
        '
        'done
        '
        Me.done.Controls.Add(Me.Label6)
        Me.done.Location = New System.Drawing.Point(150, 231)
        Me.done.Name = "done"
        Me.done.Size = New System.Drawing.Size(533, 206)
        Me.done.TabIndex = 13
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(16, 9)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(241, 13)
        Me.Label6.TabIndex = 6
        Me.Label6.Text = "All Done, ShiftOS is downloaded and ready to roll!"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(880, 516)
        Me.Controls.Add(Me.pnlinstallto)
        Me.Controls.Add(Me.titlebar)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Form1"
        Me.Text = "ShiftOS Installer and Updater"
        Me.titlebar.ResumeLayout(False)
        Me.titlebar.PerformLayout()
        Me.pnlinstallto.ResumeLayout(False)
        Me.pnlinstallto.PerformLayout()
        Me.pnlversion.ResumeLayout(False)
        Me.pnlversion.PerformLayout()
        Me.loading.ResumeLayout(False)
        Me.loading.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.folder, System.ComponentModel.ISupportInitialize).EndInit()
        Me.done.ResumeLayout(False)
        Me.done.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents openfolder As System.Windows.Forms.FolderBrowserDialog
    Friend WithEvents tmrmove As System.Windows.Forms.Timer
    Friend WithEvents trmload As System.Windows.Forms.Timer
    Friend WithEvents titlebar As System.Windows.Forms.Panel
    Friend WithEvents pnlinstallto As System.Windows.Forms.Panel
    Friend WithEvents pnlversion As System.Windows.Forms.Panel
    Friend WithEvents versioninfo As System.Windows.Forms.Label
    Friend WithEvents CheckBox1 As System.Windows.Forms.CheckBox
    Friend WithEvents Combostable As System.Windows.Forms.ComboBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Combobeta As System.Windows.Forms.ComboBox
    Friend WithEvents button As System.Windows.Forms.Button
    Friend WithEvents txtlicenses As System.Windows.Forms.TextBox
    Friend WithEvents loading As System.Windows.Forms.Panel
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents folder As System.Windows.Forms.PictureBox
    Friend WithEvents pathpre As System.Windows.Forms.Label
    Friend WithEvents lblintro As System.Windows.Forms.Label
    Friend WithEvents pnlclose As System.Windows.Forms.Panel
    Friend WithEvents lbltitletext As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents onlyexe As System.Windows.Forms.CheckBox
    Friend WithEvents noshort As System.Windows.Forms.CheckBox
    Friend WithEvents done As System.Windows.Forms.Panel
    Friend WithEvents Label6 As System.Windows.Forms.Label

End Class
