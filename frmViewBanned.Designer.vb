<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> Partial Class frmViewBanned
#Region "Windows Form Designer generated code "
	<System.Diagnostics.DebuggerNonUserCode()> Public Sub New()
		MyBase.New()
		'This call is required by the Windows Form Designer.
		InitializeComponent()
	End Sub
	'Form overrides dispose to clean up the component list.
	<System.Diagnostics.DebuggerNonUserCode()> Protected Overloads Overrides Sub Dispose(ByVal Disposing As Boolean)
		If Disposing Then
			If Not components Is Nothing Then
				components.Dispose()
			End If
		End If
		MyBase.Dispose(Disposing)
	End Sub
	'Required by the Windows Form Designer
	Private components As System.ComponentModel.IContainer
	Public ToolTip1 As System.Windows.Forms.ToolTip
	Public WithEvents cmdunban As System.Windows.Forms.Button
	Public WithEvents lstBanned As System.Windows.Forms.ListBox
	'NOTE: The following procedure is required by the Windows Form Designer
	'It can be modified using the Windows Form Designer.
	'Do not modify it using the code editor.
	<System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmViewBanned))
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.cmdunban = New System.Windows.Forms.Button
        Me.lstBanned = New System.Windows.Forms.ListBox
        Me.SuspendLayout()
        '
        'cmdunban
        '
        Me.cmdunban.BackColor = System.Drawing.SystemColors.Control
        Me.cmdunban.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmdunban.Enabled = False
        Me.cmdunban.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdunban.ForeColor = System.Drawing.SystemColors.ControlText
        Me.cmdunban.Location = New System.Drawing.Point(8, 216)
        Me.cmdunban.Name = "cmdunban"
        Me.cmdunban.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmdunban.Size = New System.Drawing.Size(193, 25)
        Me.cmdunban.TabIndex = 1
        Me.cmdunban.Text = "User Has Turned From the Dark side"
        Me.cmdunban.UseVisualStyleBackColor = False
        '
        'lstBanned
        '
        Me.lstBanned.BackColor = System.Drawing.SystemColors.Window
        Me.lstBanned.Cursor = System.Windows.Forms.Cursors.Default
        Me.lstBanned.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lstBanned.ForeColor = System.Drawing.SystemColors.WindowText
        Me.lstBanned.ItemHeight = 14
        Me.lstBanned.Location = New System.Drawing.Point(8, 8)
        Me.lstBanned.Name = "lstBanned"
        Me.lstBanned.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lstBanned.Size = New System.Drawing.Size(641, 200)
        Me.lstBanned.TabIndex = 0
        '
        'frmViewBanned
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 14.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(653, 245)
        Me.Controls.Add(Me.cmdunban)
        Me.Controls.Add(Me.lstBanned)
        Me.Cursor = System.Windows.Forms.Cursors.Default
        Me.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Location = New System.Drawing.Point(4, 23)
        Me.Name = "frmViewBanned"
        Me.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Text = "Banned Users"
        Me.ResumeLayout(False)

    End Sub
#End Region 
End Class