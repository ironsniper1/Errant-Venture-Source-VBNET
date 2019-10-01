<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> Partial Class frmHostGame
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
	Public WithEvents _Socket2_0 As AxSocketWrenchCtrl.AxSocket
	Public WithEvents _Socket1_0 As AxSocketWrenchCtrl.AxSocket
	Public WithEvents txtpwd As System.Windows.Forms.TextBox
	Public WithEvents cboPwd As System.Windows.Forms.CheckBox
	Public WithEvents keepalive As System.Windows.Forms.Timer
	Public WithEvents btnBOP As System.Windows.Forms.Button
	Public WithEvents btnBoot As System.Windows.Forms.Button
	Public WithEvents optBop As System.Windows.Forms.RadioButton
	Public WithEvents optXWA As System.Windows.Forms.RadioButton
	Public WithEvents optXVT As System.Windows.Forms.RadioButton
	Public WithEvents Frame1 As System.Windows.Forms.GroupBox
	Public WithEvents btnBack As System.Windows.Forms.Button
	Public WithEvents Timer1 As System.Windows.Forms.Timer
	Public WithEvents btnLeave As System.Windows.Forms.Button
	Public WithEvents txtLaunchXWA As System.Windows.Forms.Button
	Public WithEvents txtLaunchXVT As System.Windows.Forms.Button
	Public WithEvents btnSend As System.Windows.Forms.Button
	Public WithEvents txtSend As System.Windows.Forms.TextBox
	Public WithEvents lstReply As System.Windows.Forms.ListBox
	Public WithEvents lstPlayers As System.Windows.Forms.ListBox
	Public WithEvents WebBrowser1 As System.Windows.Forms.WebBrowser
	Public WithEvents Socket1 As AxSocketArray
	Public WithEvents Socket2 As AxSocketArray
	'NOTE: The following procedure is required by the Windows Form Designer
	'It can be modified using the Windows Form Designer.
	'Do not modify it using the code editor.
	<System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
		Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(frmHostGame))
		Me.components = New System.ComponentModel.Container()
		Me.ToolTip1 = New System.Windows.Forms.ToolTip(components)
		Me._Socket2_0 = New AxSocketWrenchCtrl.AxSocket
		Me._Socket1_0 = New AxSocketWrenchCtrl.AxSocket
		Me.txtpwd = New System.Windows.Forms.TextBox
		Me.cboPwd = New System.Windows.Forms.CheckBox
		Me.keepalive = New System.Windows.Forms.Timer(components)
		Me.btnBOP = New System.Windows.Forms.Button
		Me.btnBoot = New System.Windows.Forms.Button
		Me.Frame1 = New System.Windows.Forms.GroupBox
		Me.optBop = New System.Windows.Forms.RadioButton
		Me.optXWA = New System.Windows.Forms.RadioButton
		Me.optXVT = New System.Windows.Forms.RadioButton
		Me.btnBack = New System.Windows.Forms.Button
		Me.Timer1 = New System.Windows.Forms.Timer(components)
		Me.btnLeave = New System.Windows.Forms.Button
		Me.txtLaunchXWA = New System.Windows.Forms.Button
		Me.txtLaunchXVT = New System.Windows.Forms.Button
		Me.btnSend = New System.Windows.Forms.Button
		Me.txtSend = New System.Windows.Forms.TextBox
		Me.lstReply = New System.Windows.Forms.ListBox
		Me.lstPlayers = New System.Windows.Forms.ListBox
		Me.WebBrowser1 = New System.Windows.Forms.WebBrowser
		Me.Socket1 = New AxSocketArray(components)
		Me.Socket2 = New AxSocketArray(components)
		Me.Frame1.SuspendLayout()
		Me.SuspendLayout()
		Me.ToolTip1.Active = True
		CType(Me._Socket2_0, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me._Socket1_0, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.Socket1, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.Socket2, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.Text = "XvT Hosting Window"
		Me.ClientSize = New System.Drawing.Size(636, 383)
		Me.Location = New System.Drawing.Point(4, 23)
		Me.Icon = CType(resources.GetObject("frmHostGame.Icon"), System.Drawing.Icon)
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
		Me.Name = "frmHostGame"
		_Socket2_0.OcxState = CType(resources.GetObject("_Socket2_0.OcxState"), System.Windows.Forms.AxHost.State)
		Me._Socket2_0.Location = New System.Drawing.Point(408, 56)
		Me._Socket2_0.Name = "_Socket2_0"
		_Socket1_0.OcxState = CType(resources.GetObject("_Socket1_0.OcxState"), System.Windows.Forms.AxHost.State)
		Me._Socket1_0.Location = New System.Drawing.Point(408, 24)
		Me._Socket1_0.Name = "_Socket1_0"
		Me.txtpwd.AutoSize = False
		Me.txtpwd.BackColor = System.Drawing.Color.FromARGB(21, 21, 21)
		Me.txtpwd.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.txtpwd.ForeColor = System.Drawing.Color.Red
		Me.txtpwd.Size = New System.Drawing.Size(233, 25)
		Me.txtpwd.IMEMode = System.Windows.Forms.ImeMode.Disable
		Me.txtpwd.Location = New System.Drawing.Point(200, 216)
		Me.txtpwd.Maxlength = 300
		Me.txtpwd.PasswordChar = ChrW(42)
		Me.txtpwd.TabIndex = 16
		Me.txtpwd.Visible = False
		Me.txtpwd.AcceptsReturn = True
		Me.txtpwd.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
		Me.txtpwd.CausesValidation = True
		Me.txtpwd.Enabled = True
		Me.txtpwd.HideSelection = True
		Me.txtpwd.ReadOnly = False
		Me.txtpwd.Cursor = System.Windows.Forms.Cursors.IBeam
		Me.txtpwd.MultiLine = False
		Me.txtpwd.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.txtpwd.ScrollBars = System.Windows.Forms.ScrollBars.None
		Me.txtpwd.TabStop = True
		Me.txtpwd.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.txtpwd.Name = "txtpwd"
		Me.cboPwd.BackColor = System.Drawing.Color.Black
		Me.cboPwd.Text = "Use A password?"
		Me.cboPwd.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.cboPwd.ForeColor = System.Drawing.Color.FromARGB(128, 128, 255)
		Me.cboPwd.Size = New System.Drawing.Size(121, 17)
		Me.cboPwd.Location = New System.Drawing.Point(200, 200)
		Me.cboPwd.TabIndex = 15
		Me.cboPwd.CheckAlign = System.Drawing.ContentAlignment.MiddleLeft
		Me.cboPwd.FlatStyle = System.Windows.Forms.FlatStyle.Standard
		Me.cboPwd.CausesValidation = True
		Me.cboPwd.Enabled = True
		Me.cboPwd.Cursor = System.Windows.Forms.Cursors.Default
		Me.cboPwd.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.cboPwd.Appearance = System.Windows.Forms.Appearance.Normal
		Me.cboPwd.TabStop = True
		Me.cboPwd.CheckState = System.Windows.Forms.CheckState.Unchecked
		Me.cboPwd.Visible = True
		Me.cboPwd.Name = "cboPwd"
		Me.keepalive.Interval = 3000
		Me.keepalive.Enabled = True
		Me.btnBOP.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		Me.btnBOP.Text = "Launch Balance of Power"
		Me.btnBOP.Size = New System.Drawing.Size(153, 41)
		Me.btnBOP.Location = New System.Drawing.Point(464, 96)
		Me.btnBOP.TabIndex = 13
		Me.btnBOP.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.btnBOP.BackColor = System.Drawing.SystemColors.Control
		Me.btnBOP.CausesValidation = True
		Me.btnBOP.Enabled = True
		Me.btnBOP.ForeColor = System.Drawing.SystemColors.ControlText
		Me.btnBOP.Cursor = System.Windows.Forms.Cursors.Default
		Me.btnBOP.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.btnBOP.TabStop = True
		Me.btnBOP.Name = "btnBOP"
		Me.btnBoot.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		Me.btnBoot.Text = "Remove Player"
		Me.btnBoot.Enabled = False
		Me.btnBoot.Size = New System.Drawing.Size(169, 33)
		Me.btnBoot.Location = New System.Drawing.Point(8, 208)
		Me.btnBoot.TabIndex = 11
		Me.btnBoot.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.btnBoot.BackColor = System.Drawing.SystemColors.Control
		Me.btnBoot.CausesValidation = True
		Me.btnBoot.ForeColor = System.Drawing.SystemColors.ControlText
		Me.btnBoot.Cursor = System.Windows.Forms.Cursors.Default
		Me.btnBoot.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.btnBoot.TabStop = True
		Me.btnBoot.Name = "btnBoot"
		Me.Frame1.BackColor = System.Drawing.Color.FromARGB(21, 21, 21)
		Me.Frame1.Text = "Game to Play"
		Me.Frame1.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Frame1.ForeColor = System.Drawing.Color.Red
		Me.Frame1.Size = New System.Drawing.Size(153, 81)
		Me.Frame1.Location = New System.Drawing.Point(464, 8)
		Me.Frame1.TabIndex = 8
		Me.Frame1.Enabled = True
		Me.Frame1.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.Frame1.Visible = True
		Me.Frame1.Padding = New System.Windows.Forms.Padding(0)
		Me.Frame1.Name = "Frame1"
		Me.optBop.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
		Me.optBop.BackColor = System.Drawing.Color.FromARGB(21, 21, 21)
		Me.optBop.Text = "Balance Of Power"
		Me.optBop.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.optBop.ForeColor = System.Drawing.Color.FromARGB(51, 255, 0)
		Me.optBop.Size = New System.Drawing.Size(137, 17)
		Me.optBop.Location = New System.Drawing.Point(8, 40)
		Me.optBop.TabIndex = 12
		Me.optBop.CheckAlign = System.Drawing.ContentAlignment.MiddleLeft
		Me.optBop.CausesValidation = True
		Me.optBop.Enabled = True
		Me.optBop.Cursor = System.Windows.Forms.Cursors.Default
		Me.optBop.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.optBop.Appearance = System.Windows.Forms.Appearance.Normal
		Me.optBop.TabStop = True
		Me.optBop.Checked = False
		Me.optBop.Visible = True
		Me.optBop.Name = "optBop"
		Me.optXWA.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
		Me.optXWA.BackColor = System.Drawing.Color.FromARGB(21, 21, 21)
		Me.optXWA.Text = "X-Wing Alliance"
		Me.optXWA.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.optXWA.ForeColor = System.Drawing.Color.FromARGB(51, 255, 0)
		Me.optXWA.Size = New System.Drawing.Size(129, 17)
		Me.optXWA.Location = New System.Drawing.Point(8, 56)
		Me.optXWA.TabIndex = 10
		Me.optXWA.CheckAlign = System.Drawing.ContentAlignment.MiddleLeft
		Me.optXWA.CausesValidation = True
		Me.optXWA.Enabled = True
		Me.optXWA.Cursor = System.Windows.Forms.Cursors.Default
		Me.optXWA.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.optXWA.Appearance = System.Windows.Forms.Appearance.Normal
		Me.optXWA.TabStop = True
		Me.optXWA.Checked = False
		Me.optXWA.Visible = True
		Me.optXWA.Name = "optXWA"
		Me.optXVT.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
		Me.optXVT.BackColor = System.Drawing.Color.FromARGB(21, 21, 21)
		Me.optXVT.Text = "X-Wing Vs Tie"
		Me.optXVT.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.optXVT.ForeColor = System.Drawing.Color.FromARGB(51, 255, 0)
		Me.optXVT.Size = New System.Drawing.Size(121, 17)
		Me.optXVT.Location = New System.Drawing.Point(8, 24)
		Me.optXVT.TabIndex = 9
		Me.optXVT.CheckAlign = System.Drawing.ContentAlignment.MiddleLeft
		Me.optXVT.CausesValidation = True
		Me.optXVT.Enabled = True
		Me.optXVT.Cursor = System.Windows.Forms.Cursors.Default
		Me.optXVT.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.optXVT.Appearance = System.Windows.Forms.Appearance.Normal
		Me.optXVT.TabStop = True
		Me.optXVT.Checked = False
		Me.optXVT.Visible = True
		Me.optXVT.Name = "optXVT"
		Me.btnBack.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		Me.btnBack.Text = "Back"
		Me.btnBack.Enabled = False
		Me.btnBack.Size = New System.Drawing.Size(153, 41)
		Me.btnBack.Location = New System.Drawing.Point(464, 144)
		Me.btnBack.TabIndex = 7
		Me.btnBack.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.btnBack.BackColor = System.Drawing.SystemColors.Control
		Me.btnBack.CausesValidation = True
		Me.btnBack.ForeColor = System.Drawing.SystemColors.ControlText
		Me.btnBack.Cursor = System.Windows.Forms.Cursors.Default
		Me.btnBack.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.btnBack.TabStop = True
		Me.btnBack.Name = "btnBack"
		Me.Timer1.Interval = 1000
		Me.Timer1.Enabled = True
		Me.btnLeave.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		Me.btnLeave.Text = "Leave"
		Me.btnLeave.Size = New System.Drawing.Size(153, 41)
		Me.btnLeave.Location = New System.Drawing.Point(464, 192)
		Me.btnLeave.TabIndex = 6
		Me.btnLeave.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.btnLeave.BackColor = System.Drawing.SystemColors.Control
		Me.btnLeave.CausesValidation = True
		Me.btnLeave.Enabled = True
		Me.btnLeave.ForeColor = System.Drawing.SystemColors.ControlText
		Me.btnLeave.Cursor = System.Windows.Forms.Cursors.Default
		Me.btnLeave.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.btnLeave.TabStop = True
		Me.btnLeave.Name = "btnLeave"
		Me.txtLaunchXWA.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		Me.txtLaunchXWA.Text = "Launch XWA"
		Me.txtLaunchXWA.Size = New System.Drawing.Size(153, 41)
		Me.txtLaunchXWA.Location = New System.Drawing.Point(464, 96)
		Me.txtLaunchXWA.TabIndex = 5
		Me.txtLaunchXWA.Visible = False
		Me.txtLaunchXWA.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.txtLaunchXWA.BackColor = System.Drawing.SystemColors.Control
		Me.txtLaunchXWA.CausesValidation = True
		Me.txtLaunchXWA.Enabled = True
		Me.txtLaunchXWA.ForeColor = System.Drawing.SystemColors.ControlText
		Me.txtLaunchXWA.Cursor = System.Windows.Forms.Cursors.Default
		Me.txtLaunchXWA.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.txtLaunchXWA.TabStop = True
		Me.txtLaunchXWA.Name = "txtLaunchXWA"
		Me.txtLaunchXVT.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		Me.txtLaunchXVT.Text = "Launch XVT"
		Me.txtLaunchXVT.Size = New System.Drawing.Size(153, 41)
		Me.txtLaunchXVT.Location = New System.Drawing.Point(464, 96)
		Me.txtLaunchXVT.TabIndex = 4
		Me.txtLaunchXVT.Visible = False
		Me.txtLaunchXVT.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.txtLaunchXVT.BackColor = System.Drawing.SystemColors.Control
		Me.txtLaunchXVT.CausesValidation = True
		Me.txtLaunchXVT.Enabled = True
		Me.txtLaunchXVT.ForeColor = System.Drawing.SystemColors.ControlText
		Me.txtLaunchXVT.Cursor = System.Windows.Forms.Cursors.Default
		Me.txtLaunchXVT.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.txtLaunchXVT.TabStop = True
		Me.txtLaunchXVT.Name = "txtLaunchXVT"
		Me.btnSend.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		Me.btnSend.Text = "Send"
		Me.AcceptButton = Me.btnSend
		Me.btnSend.Size = New System.Drawing.Size(73, 25)
		Me.btnSend.Location = New System.Drawing.Point(560, 248)
		Me.btnSend.TabIndex = 3
		Me.btnSend.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.btnSend.BackColor = System.Drawing.SystemColors.Control
		Me.btnSend.CausesValidation = True
		Me.btnSend.Enabled = True
		Me.btnSend.ForeColor = System.Drawing.SystemColors.ControlText
		Me.btnSend.Cursor = System.Windows.Forms.Cursors.Default
		Me.btnSend.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.btnSend.TabStop = True
		Me.btnSend.Name = "btnSend"
		Me.txtSend.AutoSize = False
		Me.txtSend.BackColor = System.Drawing.Color.FromARGB(21, 21, 21)
		Me.txtSend.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.txtSend.ForeColor = System.Drawing.Color.Red
		Me.txtSend.Size = New System.Drawing.Size(545, 25)
		Me.txtSend.Location = New System.Drawing.Point(8, 248)
		Me.txtSend.Maxlength = 300
		Me.txtSend.TabIndex = 2
		Me.txtSend.AcceptsReturn = True
		Me.txtSend.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
		Me.txtSend.CausesValidation = True
		Me.txtSend.Enabled = True
		Me.txtSend.HideSelection = True
		Me.txtSend.ReadOnly = False
		Me.txtSend.Cursor = System.Windows.Forms.Cursors.IBeam
		Me.txtSend.MultiLine = False
		Me.txtSend.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.txtSend.ScrollBars = System.Windows.Forms.ScrollBars.None
		Me.txtSend.TabStop = True
		Me.txtSend.Visible = True
		Me.txtSend.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.txtSend.Name = "txtSend"
		Me.lstReply.BackColor = System.Drawing.Color.FromARGB(21, 21, 21)
		Me.lstReply.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lstReply.ForeColor = System.Drawing.Color.Red
		Me.lstReply.Size = New System.Drawing.Size(625, 103)
		Me.lstReply.Location = New System.Drawing.Point(8, 280)
		Me.lstReply.TabIndex = 1
		Me.lstReply.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.lstReply.CausesValidation = True
		Me.lstReply.Enabled = True
		Me.lstReply.IntegralHeight = True
		Me.lstReply.Cursor = System.Windows.Forms.Cursors.Default
		Me.lstReply.SelectionMode = System.Windows.Forms.SelectionMode.One
		Me.lstReply.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.lstReply.Sorted = False
		Me.lstReply.TabStop = True
		Me.lstReply.Visible = True
		Me.lstReply.MultiColumn = False
		Me.lstReply.Name = "lstReply"
		Me.lstPlayers.BackColor = System.Drawing.Color.FromARGB(21, 21, 21)
		Me.lstPlayers.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lstPlayers.ForeColor = System.Drawing.Color.Red
		Me.lstPlayers.Size = New System.Drawing.Size(169, 199)
		Me.lstPlayers.Location = New System.Drawing.Point(8, 8)
		Me.lstPlayers.TabIndex = 0
		Me.lstPlayers.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.lstPlayers.CausesValidation = True
		Me.lstPlayers.Enabled = True
		Me.lstPlayers.IntegralHeight = True
		Me.lstPlayers.Cursor = System.Windows.Forms.Cursors.Default
		Me.lstPlayers.SelectionMode = System.Windows.Forms.SelectionMode.One
		Me.lstPlayers.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.lstPlayers.Sorted = False
		Me.lstPlayers.TabStop = True
		Me.lstPlayers.Visible = True
		Me.lstPlayers.MultiColumn = False
		Me.lstPlayers.Name = "lstPlayers"
		Me.WebBrowser1.Size = New System.Drawing.Size(665, 393)
		Me.WebBrowser1.Location = New System.Drawing.Point(-8, 0)
		Me.WebBrowser1.TabIndex = 14
		Me.WebBrowser1.AllowWebBrowserDrop = True
		Me.WebBrowser1.Name = "WebBrowser1"
		Me.Controls.Add(_Socket2_0)
		Me.Controls.Add(_Socket1_0)
		Me.Controls.Add(txtpwd)
		Me.Controls.Add(cboPwd)
		Me.Controls.Add(btnBOP)
		Me.Controls.Add(btnBoot)
		Me.Controls.Add(Frame1)
		Me.Controls.Add(btnBack)
		Me.Controls.Add(btnLeave)
		Me.Controls.Add(txtLaunchXWA)
		Me.Controls.Add(txtLaunchXVT)
		Me.Controls.Add(btnSend)
		Me.Controls.Add(txtSend)
		Me.Controls.Add(lstReply)
		Me.Controls.Add(lstPlayers)
		Me.Controls.Add(WebBrowser1)
		Me.Frame1.Controls.Add(optBop)
		Me.Frame1.Controls.Add(optXWA)
		Me.Frame1.Controls.Add(optXVT)
		Me.Socket1.SetIndex(_Socket1_0, CType(0, Short))
		Me.Socket2.SetIndex(_Socket2_0, CType(0, Short))
		CType(Me.Socket2, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.Socket1, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me._Socket1_0, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me._Socket2_0, System.ComponentModel.ISupportInitialize).EndInit()
		Me.Frame1.ResumeLayout(False)
		Me.ResumeLayout(False)
		Me.PerformLayout()
	End Sub
#End Region 
End Class