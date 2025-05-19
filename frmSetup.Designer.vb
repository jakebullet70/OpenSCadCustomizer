<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSetup
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtSlicerEXE = New System.Windows.Forms.TextBox()
        Me.txtSaveFolder = New System.Windows.Forms.TextBox()
        Me.btnPathSlicer = New System.Windows.Forms.Button()
        Me.btnPath2 = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtCadFolder = New System.Windows.Forms.TextBox()
        Me.btnPathSCad = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.LinkLabel1 = New System.Windows.Forms.LinkLabel()
        Me.chkDebug = New System.Windows.Forms.CheckBox()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(9, 18)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(85, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Slicer path / exe"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(9, 64)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(147, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Default folder to save STL file"
        '
        'txtSlicerEXE
        '
        Me.txtSlicerEXE.Location = New System.Drawing.Point(12, 34)
        Me.txtSlicerEXE.Name = "txtSlicerEXE"
        Me.txtSlicerEXE.Size = New System.Drawing.Size(350, 20)
        Me.txtSlicerEXE.TabIndex = 1
        '
        'txtSaveFolder
        '
        Me.txtSaveFolder.Location = New System.Drawing.Point(12, 80)
        Me.txtSaveFolder.Name = "txtSaveFolder"
        Me.txtSaveFolder.Size = New System.Drawing.Size(350, 20)
        Me.txtSaveFolder.TabIndex = 4
        '
        'btnPathSlicer
        '
        Me.btnPathSlicer.Location = New System.Drawing.Point(362, 34)
        Me.btnPathSlicer.Name = "btnPathSlicer"
        Me.btnPathSlicer.Size = New System.Drawing.Size(26, 20)
        Me.btnPathSlicer.TabIndex = 2
        Me.btnPathSlicer.Text = "..."
        Me.btnPathSlicer.UseVisualStyleBackColor = True
        '
        'btnPath2
        '
        Me.btnPath2.Location = New System.Drawing.Point(362, 80)
        Me.btnPath2.Name = "btnPath2"
        Me.btnPath2.Size = New System.Drawing.Size(26, 20)
        Me.btnPath2.TabIndex = 5
        Me.btnPath2.Text = "..."
        Me.btnPath2.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(12, 116)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(86, 13)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "OpenSCAD path"
        '
        'txtCadFolder
        '
        Me.txtCadFolder.Location = New System.Drawing.Point(12, 132)
        Me.txtCadFolder.Name = "txtCadFolder"
        Me.txtCadFolder.Size = New System.Drawing.Size(350, 20)
        Me.txtCadFolder.TabIndex = 8
        '
        'btnPathSCad
        '
        Me.btnPathSCad.Location = New System.Drawing.Point(362, 133)
        Me.btnPathSCad.Name = "btnPathSCad"
        Me.btnPathSCad.Size = New System.Drawing.Size(26, 20)
        Me.btnPathSCad.TabIndex = 9
        Me.btnPathSCad.Text = "..."
        Me.btnPathSCad.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Red
        Me.Label4.Location = New System.Drawing.Point(91, 116)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(21, 25)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "*"
        '
        'btnClose
        '
        Me.btnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnClose.Location = New System.Drawing.Point(303, 163)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(85, 33)
        Me.btnClose.TabIndex = 11
        Me.btnClose.Text = "&Close"
        Me.btnClose.UseVisualStyleBackColor = True
        '
        'btnSave
        '
        Me.btnSave.Location = New System.Drawing.Point(210, 163)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(87, 33)
        Me.btnSave.TabIndex = 10
        Me.btnSave.Text = "&Save"
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'LinkLabel1
        '
        Me.LinkLabel1.AutoSize = True
        Me.LinkLabel1.Location = New System.Drawing.Point(286, 116)
        Me.LinkLabel1.Name = "LinkLabel1"
        Me.LinkLabel1.Size = New System.Drawing.Size(79, 13)
        Me.LinkLabel1.TabIndex = 12
        Me.LinkLabel1.TabStop = True
        Me.LinkLabel1.Text = "Download here"
        '
        'chkDebug
        '
        Me.chkDebug.AutoSize = True
        Me.chkDebug.Location = New System.Drawing.Point(12, 163)
        Me.chkDebug.Name = "chkDebug"
        Me.chkDebug.Size = New System.Drawing.Size(173, 30)
        Me.chkDebug.TabIndex = 13
        Me.chkDebug.Text = "Add PAUSE when in batch file " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "when generating STL (Debug)"
        Me.chkDebug.UseVisualStyleBackColor = True
        '
        'frmSetup
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(96.0!, 96.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.CancelButton = Me.btnClose
        Me.ClientSize = New System.Drawing.Size(397, 206)
        Me.Controls.Add(Me.chkDebug)
        Me.Controls.Add(Me.LinkLabel1)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.btnPathSCad)
        Me.Controls.Add(Me.txtCadFolder)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.btnPath2)
        Me.Controls.Add(Me.btnPathSlicer)
        Me.Controls.Add(Me.txtSaveFolder)
        Me.Controls.Add(Me.txtSlicerEXE)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label4)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "frmSetup"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Setup"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txtSlicerEXE As TextBox
    Friend WithEvents txtSaveFolder As TextBox
    Friend WithEvents btnPathSlicer As Button
    Friend WithEvents btnPath2 As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents txtCadFolder As TextBox
    Friend WithEvents btnPathSCad As Button
    Friend WithEvents Label4 As Label
    Friend WithEvents btnClose As Button
    Friend WithEvents btnSave As Button
    Friend WithEvents LinkLabel1 As LinkLabel
    Friend WithEvents chkDebug As CheckBox
End Class
