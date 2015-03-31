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
        Me.button = New System.Windows.Forms.Button()
        Me.pnlinstallto = New System.Windows.Forms.Panel()
        Me.CheckBox1 = New System.Windows.Forms.CheckBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Combobeta = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Combostable = New System.Windows.Forms.ComboBox()
        Me.versioninfo = New System.Windows.Forms.Label()
        Me.txtlicenses = New System.Windows.Forms.TextBox()
        Me.loading = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.folder = New System.Windows.Forms.PictureBox()
        Me.pathpre = New System.Windows.Forms.Label()
        Me.lblintro = New System.Windows.Forms.Label()
        Me.openfolder = New System.Windows.Forms.FolderBrowserDialog()
        Me.tmrmove = New System.Windows.Forms.Timer(Me.components)
        Me.trmload = New System.Windows.Forms.Timer(Me.components)
        Me.pnlversion = New System.Windows.Forms.Panel()
        Me.pnlinstallto.SuspendLayout()
        Me.loading.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.folder, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlversion.SuspendLayout()
        Me.SuspendLayout()
        '
        'button
        '
        Me.button.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.button.Location = New System.Drawing.Point(745, 439)
        Me.button.Name = "button"
        Me.button.Size = New System.Drawing.Size(120, 23)
        Me.button.TabIndex = 2
        Me.button.Text = "Procced"
        Me.button.UseVisualStyleBackColor = True
        '
        'pnlinstallto
        '
        Me.pnlinstallto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pnlinstallto.Controls.Add(Me.pnlversion)
        Me.pnlinstallto.Controls.Add(Me.button)
        Me.pnlinstallto.Controls.Add(Me.txtlicenses)
        Me.pnlinstallto.Controls.Add(Me.loading)
        Me.pnlinstallto.Controls.Add(Me.folder)
        Me.pnlinstallto.Controls.Add(Me.pathpre)
        Me.pnlinstallto.Controls.Add(Me.lblintro)
        Me.pnlinstallto.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlinstallto.Location = New System.Drawing.Point(0, 0)
        Me.pnlinstallto.Name = "pnlinstallto"
        Me.pnlinstallto.Size = New System.Drawing.Size(878, 475)
        Me.pnlinstallto.TabIndex = 4
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
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(16, 106)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(75, 13)
        Me.Label3.TabIndex = 10
        Me.Label3.Text = "Beta Versions:"
        '
        'Combobeta
        '
        Me.Combobeta.FormattingEnabled = True
        Me.Combobeta.Location = New System.Drawing.Point(19, 119)
        Me.Combobeta.Name = "Combobeta"
        Me.Combobeta.Size = New System.Drawing.Size(121, 21)
        Me.Combobeta.TabIndex = 9
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
        'Combostable
        '
        Me.Combostable.FormattingEnabled = True
        Me.Combostable.Items.AddRange(New Object() {"I'm Still adding all the versions, try beta builds"})
        Me.Combostable.Location = New System.Drawing.Point(19, 49)
        Me.Combostable.Name = "Combostable"
        Me.Combostable.Size = New System.Drawing.Size(121, 21)
        Me.Combostable.TabIndex = 7
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
        'txtlicenses
        '
        Me.txtlicenses.Location = New System.Drawing.Point(-1, 3)
        Me.txtlicenses.Multiline = True
        Me.txtlicenses.Name = "txtlicenses"
        Me.txtlicenses.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtlicenses.Size = New System.Drawing.Size(850, 422)
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
        'tmrmove
        '
        Me.tmrmove.Interval = 1
        '
        'trmload
        '
        Me.trmload.Interval = 10
        '
        'pnlversion
        '
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
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(878, 475)
        Me.Controls.Add(Me.pnlinstallto)
        Me.Name = "Form1"
        Me.Text = "ShiftOS Installer and Updater"
        Me.pnlinstallto.ResumeLayout(False)
        Me.pnlinstallto.PerformLayout()
        Me.loading.ResumeLayout(False)
        Me.loading.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.folder, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlversion.ResumeLayout(False)
        Me.pnlversion.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents button As System.Windows.Forms.Button
    Friend WithEvents pnlinstallto As System.Windows.Forms.Panel
    Friend WithEvents folder As System.Windows.Forms.PictureBox
    Friend WithEvents pathpre As System.Windows.Forms.Label
    Friend WithEvents lblintro As System.Windows.Forms.Label
    Friend WithEvents openfolder As System.Windows.Forms.FolderBrowserDialog
    Friend WithEvents tmrmove As System.Windows.Forms.Timer
    Friend WithEvents loading As System.Windows.Forms.Panel
    Friend WithEvents trmload As System.Windows.Forms.Timer
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents txtlicenses As System.Windows.Forms.TextBox
    Friend WithEvents CheckBox1 As System.Windows.Forms.CheckBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Combobeta As System.Windows.Forms.ComboBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Combostable As System.Windows.Forms.ComboBox
    Friend WithEvents versioninfo As System.Windows.Forms.Label
    Friend WithEvents pnlversion As System.Windows.Forms.Panel

End Class
