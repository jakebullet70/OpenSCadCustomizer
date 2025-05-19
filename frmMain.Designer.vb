<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMain
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMain))
        Me.btnGenerate = New System.Windows.Forms.Button()
        Me.picBoxStyle = New System.Windows.Forms.PictureBox()
        Me.cboModels = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.btnSetup = New System.Windows.Forms.Button()
        Me.btnAbout = New System.Windows.Forms.Button()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.replace_val = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Width = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Value = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.chkOpen = New System.Windows.Forms.CheckBox()
        Me.chkPrompt = New System.Windows.Forms.CheckBox()
        Me.LinkLabel1 = New System.Windows.Forms.LinkLabel()
        Me.btnOpenInCad = New System.Windows.Forms.Button()
        Me.lblWarning = New System.Windows.Forms.Label()
        CType(Me.picBoxStyle, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnGenerate
        '
        Me.btnGenerate.Location = New System.Drawing.Point(514, 315)
        Me.btnGenerate.Name = "btnGenerate"
        Me.btnGenerate.Size = New System.Drawing.Size(101, 44)
        Me.btnGenerate.TabIndex = 8
        Me.btnGenerate.Text = "&Generate STL"
        Me.btnGenerate.UseVisualStyleBackColor = True
        '
        'picBoxStyle
        '
        Me.picBoxStyle.Location = New System.Drawing.Point(333, 72)
        Me.picBoxStyle.Name = "picBoxStyle"
        Me.picBoxStyle.Size = New System.Drawing.Size(282, 226)
        Me.picBoxStyle.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picBoxStyle.TabIndex = 7
        Me.picBoxStyle.TabStop = False
        '
        'cboModels
        '
        Me.cboModels.FormattingEnabled = True
        Me.cboModels.Location = New System.Drawing.Point(24, 39)
        Me.cboModels.Name = "cboModels"
        Me.cboModels.Size = New System.Drawing.Size(293, 21)
        Me.cboModels.TabIndex = 1
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(21, 23)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(94, 13)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "OpenSCAD &Model"
        '
        'btnSetup
        '
        Me.btnSetup.Location = New System.Drawing.Point(449, 17)
        Me.btnSetup.Name = "btnSetup"
        Me.btnSetup.Size = New System.Drawing.Size(80, 45)
        Me.btnSetup.TabIndex = 4
        Me.btnSetup.Text = "Se&tup"
        Me.btnSetup.UseVisualStyleBackColor = True
        '
        'btnAbout
        '
        Me.btnAbout.Location = New System.Drawing.Point(535, 17)
        Me.btnAbout.Name = "btnAbout"
        Me.btnAbout.Size = New System.Drawing.Size(80, 45)
        Me.btnAbout.TabIndex = 5
        Me.btnAbout.Text = "&About Me"
        Me.btnAbout.UseVisualStyleBackColor = True
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.replace_val, Me.Width, Me.Value})
        Me.DataGridView1.Location = New System.Drawing.Point(24, 72)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(293, 284)
        Me.DataGridView1.TabIndex = 2
        '
        'replace_val
        '
        Me.replace_val.HeaderText = "replace_val"
        Me.replace_val.Name = "replace_val"
        Me.replace_val.Visible = False
        '
        'Width
        '
        Me.Width.HeaderText = "Property"
        Me.Width.Name = "Width"
        Me.Width.ReadOnly = True
        Me.Width.Width = 150
        '
        'Value
        '
        Me.Value.HeaderText = "Value"
        Me.Value.Name = "Value"
        '
        'chkOpen
        '
        Me.chkOpen.AutoSize = True
        Me.chkOpen.Location = New System.Drawing.Point(344, 318)
        Me.chkOpen.Name = "chkOpen"
        Me.chkOpen.Size = New System.Drawing.Size(165, 17)
        Me.chkOpen.TabIndex = 6
        Me.chkOpen.Text = "Open in slicer when &complete"
        Me.chkOpen.UseVisualStyleBackColor = True
        '
        'chkPrompt
        '
        Me.chkPrompt.AutoSize = True
        Me.chkPrompt.Location = New System.Drawing.Point(344, 342)
        Me.chkPrompt.Name = "chkPrompt"
        Me.chkPrompt.Size = New System.Drawing.Size(124, 17)
        Me.chkPrompt.TabIndex = 7
        Me.chkPrompt.Text = "Prompt for save &path"
        Me.chkPrompt.UseVisualStyleBackColor = True
        '
        'LinkLabel1
        '
        Me.LinkLabel1.AutoSize = True
        Me.LinkLabel1.Location = New System.Drawing.Point(250, 23)
        Me.LinkLabel1.Name = "LinkLabel1"
        Me.LinkLabel1.Size = New System.Drawing.Size(67, 13)
        Me.LinkLabel1.TabIndex = 2
        Me.LinkLabel1.TabStop = True
        Me.LinkLabel1.Text = "About Model"
        '
        'btnOpenInCad
        '
        Me.btnOpenInCad.Location = New System.Drawing.Point(333, 17)
        Me.btnOpenInCad.Name = "btnOpenInCad"
        Me.btnOpenInCad.Size = New System.Drawing.Size(83, 45)
        Me.btnOpenInCad.TabIndex = 3
        Me.btnOpenInCad.Text = "&Open in SCAD"
        Me.btnOpenInCad.UseVisualStyleBackColor = True
        '
        'lblWarning
        '
        Me.lblWarning.AutoSize = True
        Me.lblWarning.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblWarning.ForeColor = System.Drawing.Color.Red
        Me.lblWarning.Location = New System.Drawing.Point(323, 72)
        Me.lblWarning.Name = "lblWarning"
        Me.lblWarning.Size = New System.Drawing.Size(310, 24)
        Me.lblWarning.TabIndex = 9
        Me.lblWarning.Text = "SCAD path is empty, go to setup"
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(96.0!, 96.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.ClientSize = New System.Drawing.Size(637, 368)
        Me.Controls.Add(Me.lblWarning)
        Me.Controls.Add(Me.btnOpenInCad)
        Me.Controls.Add(Me.LinkLabel1)
        Me.Controls.Add(Me.chkPrompt)
        Me.Controls.Add(Me.chkOpen)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.btnAbout)
        Me.Controls.Add(Me.btnSetup)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.cboModels)
        Me.Controls.Add(Me.picBoxStyle)
        Me.Controls.Add(Me.btnGenerate)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(653, 407)
        Me.Name = "frmMain"
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.Text = "Customizer - OpenSCAD"
        CType(Me.picBoxStyle, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnGenerate As Button
    Friend WithEvents picBoxStyle As PictureBox
    Friend WithEvents cboModels As ComboBox
    Friend WithEvents Label4 As Label
    Friend WithEvents btnSetup As Button
    Friend WithEvents btnAbout As Button
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents replace_val As DataGridViewTextBoxColumn
    Friend WithEvents Width As DataGridViewTextBoxColumn
    Friend WithEvents Value As DataGridViewTextBoxColumn
    Friend WithEvents chkOpen As CheckBox
    Friend WithEvents chkPrompt As CheckBox
    Friend WithEvents LinkLabel1 As LinkLabel
    Friend WithEvents btnOpenInCad As Button
    Friend WithEvents lblWarning As Label
End Class
