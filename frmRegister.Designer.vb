<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> Partial Class frmRegister
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
	Public WithEvents txtpwd2 As System.Windows.Forms.TextBox
	Public WithEvents btnRegister As System.Windows.Forms.Button
	Public WithEvents txtpwd As System.Windows.Forms.TextBox
	Public WithEvents txtuid As System.Windows.Forms.TextBox
	Public WithEvents Label3 As System.Windows.Forms.Label
	Public WithEvents Label2 As System.Windows.Forms.Label
	Public WithEvents Label1 As System.Windows.Forms.Label
	'NOTE: The following procedure is required by the Windows Form Designer
	'It can be modified using the Windows Form Designer.
	'Do not modify it using the code editor.
	<System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
		Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(frmRegister))
		Me.components = New System.ComponentModel.Container()
		Me.ToolTip1 = New System.Windows.Forms.ToolTip(components)
		Me.txtpwd2 = New System.Windows.Forms.TextBox
		Me.btnRegister = New System.Windows.Forms.Button
		Me.txtpwd = New System.Windows.Forms.TextBox
		Me.txtuid = New System.Windows.Forms.TextBox
		Me.Label3 = New System.Windows.Forms.Label
		Me.Label2 = New System.Windows.Forms.Label
		Me.Label1 = New System.Windows.Forms.Label
		Me.SuspendLayout()
		Me.ToolTip1.Active = True
		Me.Text = "Register"
		Me.ClientSize = New System.Drawing.Size(312, 213)
		Me.Location = New System.Drawing.Point(4, 23)
		Me.Icon = CType(resources.GetObject("frmRegister.Icon"), System.Drawing.Icon)
		Me.StartPosition = System.Windows.Forms.FormStartPosition.WindowsDefaultLocation
		Me.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.BackColor = System.Drawing.SystemColors.Control
		Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Sizable
		Me.ControlBox = True
		Me.Enabled = True
		Me.KeyPreview = False
		Me.MaximizeBox = True
		Me.MinimizeBox = True
		Me.Cursor = System.Windows.Forms.Cursors.Default
		Me.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.ShowInTaskbar = True
		Me.HelpButton = False
		Me.WindowState = System.Windows.Forms.FormWindowState.Normal
		Me.Name = "frmRegister"
		Me.txtpwd2.AutoSize = False
		Me.txtpwd2.Size = New System.Drawing.Size(297, 25)
		Me.txtpwd2.IMEMode = System.Windows.Forms.ImeMode.Disable
		Me.txtpwd2.Location = New System.Drawing.Point(8, 144)
		Me.txtpwd2.PasswordChar = ChrW(42)
		Me.txtpwd2.TabIndex = 5
		Me.txtpwd2.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.txtpwd2.AcceptsReturn = True
		Me.txtpwd2.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
		Me.txtpwd2.BackColor = System.Drawing.SystemColors.Window
		Me.txtpwd2.CausesValidation = True
		Me.txtpwd2.Enabled = True
		Me.txtpwd2.ForeColor = System.Drawing.SystemColors.WindowText
		Me.txtpwd2.HideSelection = True
		Me.txtpwd2.ReadOnly = False
		Me.txtpwd2.Maxlength = 0
		Me.txtpwd2.Cursor = System.Windows.Forms.Cursors.IBeam
		Me.txtpwd2.MultiLine = False
		Me.txtpwd2.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.txtpwd2.ScrollBars = System.Windows.Forms.ScrollBars.None
		Me.txtpwd2.TabStop = True
		Me.txtpwd2.Visible = True
		Me.txtpwd2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.txtpwd2.Name = "txtpwd2"
		Me.btnRegister.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		Me.btnRegister.Text = "Register"
		Me.AcceptButton = Me.btnRegister
		Me.btnRegister.Size = New System.Drawing.Size(129, 25)
		Me.btnRegister.Location = New System.Drawing.Point(176, 176)
		Me.btnRegister.TabIndex = 6
		Me.btnRegister.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.btnRegister.BackColor = System.Drawing.SystemColors.Control
		Me.btnRegister.CausesValidation = True
		Me.btnRegister.Enabled = True
		Me.btnRegister.ForeColor = System.Drawing.SystemColors.ControlText
		Me.btnRegister.Cursor = System.Windows.Forms.Cursors.Default
		Me.btnRegister.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.btnRegister.TabStop = True
		Me.btnRegister.Name = "btnRegister"
		Me.txtpwd.AutoSize = False
		Me.txtpwd.Size = New System.Drawing.Size(297, 25)
		Me.txtpwd.IMEMode = System.Windows.Forms.ImeMode.Disable
		Me.txtpwd.Location = New System.Drawing.Point(8, 88)
		Me.txtpwd.PasswordChar = ChrW(42)
		Me.txtpwd.TabIndex = 3
		Me.txtpwd.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.txtpwd.AcceptsReturn = True
		Me.txtpwd.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
		Me.txtpwd.BackColor = System.Drawing.SystemColors.Window
		Me.txtpwd.CausesValidation = True
		Me.txtpwd.Enabled = True
		Me.txtpwd.ForeColor = System.Drawing.SystemColors.WindowText
		Me.txtpwd.HideSelection = True
		Me.txtpwd.ReadOnly = False
		Me.txtpwd.Maxlength = 0
		Me.txtpwd.Cursor = System.Windows.Forms.Cursors.IBeam
		Me.txtpwd.MultiLine = False
		Me.txtpwd.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.txtpwd.ScrollBars = System.Windows.Forms.ScrollBars.None
		Me.txtpwd.TabStop = True
		Me.txtpwd.Visible = True
		Me.txtpwd.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.txtpwd.Name = "txtpwd"
		Me.txtuid.AutoSize = False
		Me.txtuid.Size = New System.Drawing.Size(297, 25)
		Me.txtuid.Location = New System.Drawing.Point(8, 32)
		Me.txtuid.TabIndex = 1
		Me.txtuid.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.txtuid.AcceptsReturn = True
		Me.txtuid.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
		Me.txtuid.BackColor = System.Drawing.SystemColors.Window
		Me.txtuid.CausesValidation = True
		Me.txtuid.Enabled = True
		Me.txtuid.ForeColor = System.Drawing.SystemColors.WindowText
		Me.txtuid.HideSelection = True
		Me.txtuid.ReadOnly = False
		Me.txtuid.Maxlength = 0
		Me.txtuid.Cursor = System.Windows.Forms.Cursors.IBeam
		Me.txtuid.MultiLine = False
		Me.txtuid.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.txtuid.ScrollBars = System.Windows.Forms.ScrollBars.None
		Me.txtuid.TabStop = True
		Me.txtuid.Visible = True
		Me.txtuid.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.txtuid.Name = "txtuid"
		Me.Label3.Text = "Confirm Password"
		Me.Label3.Size = New System.Drawing.Size(129, 17)
		Me.Label3.Location = New System.Drawing.Point(8, 120)
		Me.Label3.TabIndex = 4
		Me.Label3.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label3.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me.Label3.BackColor = System.Drawing.SystemColors.Control
		Me.Label3.Enabled = True
		Me.Label3.ForeColor = System.Drawing.SystemColors.ControlText
		Me.Label3.Cursor = System.Windows.Forms.Cursors.Default
		Me.Label3.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.Label3.UseMnemonic = True
		Me.Label3.Visible = True
		Me.Label3.AutoSize = False
		Me.Label3.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.Label3.Name = "Label3"
		Me.Label2.Text = "Password"
		Me.Label2.Size = New System.Drawing.Size(201, 17)
		Me.Label2.Location = New System.Drawing.Point(8, 64)
		Me.Label2.TabIndex = 2
		Me.Label2.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label2.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me.Label2.BackColor = System.Drawing.SystemColors.Control
		Me.Label2.Enabled = True
		Me.Label2.ForeColor = System.Drawing.SystemColors.ControlText
		Me.Label2.Cursor = System.Windows.Forms.Cursors.Default
		Me.Label2.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.Label2.UseMnemonic = True
		Me.Label2.Visible = True
		Me.Label2.AutoSize = False
		Me.Label2.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.Label2.Name = "Label2"
		Me.Label1.Text = "UserID including Club (ie TRA_Stresser)"
		Me.Label1.Size = New System.Drawing.Size(193, 17)
		Me.Label1.Location = New System.Drawing.Point(8, 8)
		Me.Label1.TabIndex = 0
		Me.Label1.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label1.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me.Label1.BackColor = System.Drawing.SystemColors.Control
		Me.Label1.Enabled = True
		Me.Label1.ForeColor = System.Drawing.SystemColors.ControlText
		Me.Label1.Cursor = System.Windows.Forms.Cursors.Default
		Me.Label1.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.Label1.UseMnemonic = True
		Me.Label1.Visible = True
		Me.Label1.AutoSize = False
		Me.Label1.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.Label1.Name = "Label1"
		Me.Controls.Add(txtpwd2)
		Me.Controls.Add(btnRegister)
		Me.Controls.Add(txtpwd)
		Me.Controls.Add(txtuid)
		Me.Controls.Add(Label3)
		Me.Controls.Add(Label2)
		Me.Controls.Add(Label1)
		Me.ResumeLayout(False)
		Me.PerformLayout()
	End Sub
#End Region 
End Class