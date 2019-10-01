<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> Partial Class frmClient
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
	Public WithEvents Socket1 As AxSocketWrenchCtrl.AxSocket
	Public WithEvents txtHost As System.Windows.Forms.ComboBox
	Public WithEvents cboFilterOff As System.Windows.Forms.CheckBox
	Public WithEvents cmdunBan As System.Windows.Forms.Button
	Public WithEvents Text6 As System.Windows.Forms.TextBox
	Public WithEvents Text5 As System.Windows.Forms.TextBox
	Public WithEvents Text4 As System.Windows.Forms.TextBox
	Public WithEvents Text1 As System.Windows.Forms.TextBox
	Public WithEvents Text3 As System.Windows.Forms.TextBox
	Public WithEvents Text2 As System.Windows.Forms.TextBox
	Public WithEvents cmdBan As System.Windows.Forms.Button
	Public WithEvents cmdNotSuper As System.Windows.Forms.Button
	Public WithEvents cmdSuper As System.Windows.Forms.Button
	Public WithEvents cmdNotAdmin As System.Windows.Forms.Button
	Public WithEvents cmdAdmin As System.Windows.Forms.Button
	Public WithEvents cmdNotModerator As System.Windows.Forms.Button
	Public WithEvents cmdModerator As System.Windows.Forms.Button
	Public WithEvents cmdPunt As System.Windows.Forms.Button
	Public WithEvents wbReply As System.Windows.Forms.WebBrowser
	Public WithEvents cboMute As System.Windows.Forms.CheckBox
	Public WithEvents pingtimer As System.Windows.Forms.Timer
	Public WithEvents btnIM As System.Windows.Forms.Button
	Public WithEvents Timer1 As System.Windows.Forms.Timer
	Public WithEvents txtPWD As System.Windows.Forms.TextBox
	Public WithEvents cboTalk As System.Windows.Forms.CheckBox
	Public WithEvents btnAway As System.Windows.Forms.Button
	Public WithEvents btnJoin As System.Windows.Forms.Button
	Public WithEvents btnHost As System.Windows.Forms.Button
	Public WithEvents lstGameRooms As System.Windows.Forms.ListBox
	Public WithEvents lstPlayers As System.Windows.Forms.ListBox
	Public WithEvents btnUID As System.Windows.Forms.Button
	Public WithEvents btnSend As System.Windows.Forms.Button
	Public WithEvents txtUID As System.Windows.Forms.TextBox
	Public WithEvents btnGo As System.Windows.Forms.Button
	Public WithEvents txtSend As System.Windows.Forms.TextBox
	Public WithEvents WebBrowser1 As System.Windows.Forms.WebBrowser
	'NOTE: The following procedure is required by the Windows Form Designer
	'It can be modified using the Windows Form Designer.
	'Do not modify it using the code editor.
	<System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
		Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(frmClient))
		Me.components = New System.ComponentModel.Container()
		Me.ToolTip1 = New System.Windows.Forms.ToolTip(components)
		Me.Socket1 = New AxSocketWrenchCtrl.AxSocket
		Me.txtHost = New System.Windows.Forms.ComboBox
		Me.cboFilterOff = New System.Windows.Forms.CheckBox
		Me.cmdunBan = New System.Windows.Forms.Button
		Me.Text6 = New System.Windows.Forms.TextBox
		Me.Text5 = New System.Windows.Forms.TextBox
		Me.Text4 = New System.Windows.Forms.TextBox
		Me.Text1 = New System.Windows.Forms.TextBox
		Me.Text3 = New System.Windows.Forms.TextBox
		Me.Text2 = New System.Windows.Forms.TextBox
		Me.cmdBan = New System.Windows.Forms.Button
		Me.cmdNotSuper = New System.Windows.Forms.Button
		Me.cmdSuper = New System.Windows.Forms.Button
		Me.cmdNotAdmin = New System.Windows.Forms.Button
		Me.cmdAdmin = New System.Windows.Forms.Button
		Me.cmdNotModerator = New System.Windows.Forms.Button
		Me.cmdModerator = New System.Windows.Forms.Button
		Me.cmdPunt = New System.Windows.Forms.Button
		Me.wbReply = New System.Windows.Forms.WebBrowser
		Me.cboMute = New System.Windows.Forms.CheckBox
		Me.pingtimer = New System.Windows.Forms.Timer(components)
		Me.btnIM = New System.Windows.Forms.Button
		Me.Timer1 = New System.Windows.Forms.Timer(components)
		Me.txtPWD = New System.Windows.Forms.TextBox
		Me.cboTalk = New System.Windows.Forms.CheckBox
		Me.btnAway = New System.Windows.Forms.Button
		Me.btnJoin = New System.Windows.Forms.Button
		Me.btnHost = New System.Windows.Forms.Button
		Me.lstGameRooms = New System.Windows.Forms.ListBox
		Me.lstPlayers = New System.Windows.Forms.ListBox
		Me.btnUID = New System.Windows.Forms.Button
		Me.btnSend = New System.Windows.Forms.Button
		Me.txtUID = New System.Windows.Forms.TextBox
		Me.btnGo = New System.Windows.Forms.Button
		Me.txtSend = New System.Windows.Forms.TextBox
		Me.WebBrowser1 = New System.Windows.Forms.WebBrowser
		Me.SuspendLayout()
		Me.ToolTip1.Active = True
		CType(Me.Socket1, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
		Me.BackColor = System.Drawing.Color.Black
		Me.Text = "XvT Client"
		Me.ClientSize = New System.Drawing.Size(798, 543)
		Me.Location = New System.Drawing.Point(124, 163)
		Me.Icon = CType(resources.GetObject("frmClient.Icon"), System.Drawing.Icon)
		Me.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
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
		Me.Name = "frmClient"
		Socket1.OcxState = CType(resources.GetObject("Socket1.OcxState"), System.Windows.Forms.AxHost.State)
		Me.Socket1.Location = New System.Drawing.Point(496, 56)
		Me.Socket1.Name = "Socket1"
		Me.txtHost.BackColor = System.Drawing.Color.Black
		Me.txtHost.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.txtHost.ForeColor = System.Drawing.Color.FromARGB(51, 255, 0)
		Me.txtHost.Size = New System.Drawing.Size(145, 24)
		Me.txtHost.Location = New System.Drawing.Point(48, 8)
		Me.txtHost.TabIndex = 32
		Me.txtHost.CausesValidation = True
		Me.txtHost.Enabled = True
		Me.txtHost.IntegralHeight = True
		Me.txtHost.Cursor = System.Windows.Forms.Cursors.Default
		Me.txtHost.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.txtHost.Sorted = False
		Me.txtHost.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown
		Me.txtHost.TabStop = True
		Me.txtHost.Visible = True
		Me.txtHost.Name = "txtHost"
		Me.cboFilterOff.BackColor = System.Drawing.Color.Black
		Me.cboFilterOff.Text = "Disable Language Filter?"
		Me.cboFilterOff.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.cboFilterOff.ForeColor = System.Drawing.Color.Red
		Me.cboFilterOff.Size = New System.Drawing.Size(185, 17)
		Me.cboFilterOff.Location = New System.Drawing.Point(304, 328)
		Me.cboFilterOff.TabIndex = 31
		Me.cboFilterOff.CheckAlign = System.Drawing.ContentAlignment.MiddleLeft
		Me.cboFilterOff.FlatStyle = System.Windows.Forms.FlatStyle.Standard
		Me.cboFilterOff.CausesValidation = True
		Me.cboFilterOff.Enabled = True
		Me.cboFilterOff.Cursor = System.Windows.Forms.Cursors.Default
		Me.cboFilterOff.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.cboFilterOff.Appearance = System.Windows.Forms.Appearance.Normal
		Me.cboFilterOff.TabStop = True
		Me.cboFilterOff.CheckState = System.Windows.Forms.CheckState.Unchecked
		Me.cboFilterOff.Visible = True
		Me.cboFilterOff.Name = "cboFilterOff"
		Me.cmdunBan.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		Me.cmdunBan.Text = "UnBan Player"
		Me.cmdunBan.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.cmdunBan.Size = New System.Drawing.Size(89, 41)
		Me.cmdunBan.Location = New System.Drawing.Point(392, 80)
		Me.cmdunBan.TabIndex = 30
		Me.cmdunBan.Visible = False
		Me.cmdunBan.BackColor = System.Drawing.SystemColors.Control
		Me.cmdunBan.CausesValidation = True
		Me.cmdunBan.Enabled = True
		Me.cmdunBan.ForeColor = System.Drawing.SystemColors.ControlText
		Me.cmdunBan.Cursor = System.Windows.Forms.Cursors.Default
		Me.cmdunBan.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.cmdunBan.TabStop = True
		Me.cmdunBan.Name = "cmdunBan"
		Me.Text6.AutoSize = False
		Me.Text6.BackColor = System.Drawing.Color.Black
		Me.Text6.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Text6.ForeColor = System.Drawing.Color.Red
		Me.Text6.Size = New System.Drawing.Size(73, 19)
		Me.Text6.Location = New System.Drawing.Point(8, 16)
		Me.Text6.TabIndex = 29
		Me.Text6.Text = "Players"
		Me.Text6.Visible = False
		Me.Text6.AcceptsReturn = True
		Me.Text6.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
		Me.Text6.CausesValidation = True
		Me.Text6.Enabled = True
		Me.Text6.HideSelection = True
		Me.Text6.ReadOnly = False
		Me.Text6.Maxlength = 0
		Me.Text6.Cursor = System.Windows.Forms.Cursors.IBeam
		Me.Text6.MultiLine = False
		Me.Text6.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.Text6.ScrollBars = System.Windows.Forms.ScrollBars.None
		Me.Text6.TabStop = True
		Me.Text6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
		Me.Text6.Name = "Text6"
		Me.Text5.AutoSize = False
		Me.Text5.BackColor = System.Drawing.Color.Black
		Me.Text5.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Text5.ForeColor = System.Drawing.Color.Red
		Me.Text5.Size = New System.Drawing.Size(81, 19)
		Me.Text5.Location = New System.Drawing.Point(544, 24)
		Me.Text5.TabIndex = 28
		Me.Text5.Text = "Game Rooms"
		Me.Text5.Visible = False
		Me.Text5.AcceptsReturn = True
		Me.Text5.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
		Me.Text5.CausesValidation = True
		Me.Text5.Enabled = True
		Me.Text5.HideSelection = True
		Me.Text5.ReadOnly = False
		Me.Text5.Maxlength = 0
		Me.Text5.Cursor = System.Windows.Forms.Cursors.IBeam
		Me.Text5.MultiLine = False
		Me.Text5.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.Text5.ScrollBars = System.Windows.Forms.ScrollBars.None
		Me.Text5.TabStop = True
		Me.Text5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
		Me.Text5.Name = "Text5"
		Me.Text4.AutoSize = False
		Me.Text4.BackColor = System.Drawing.Color.Black
		Me.Text4.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Text4.ForeColor = System.Drawing.Color.Red
		Me.Text4.Size = New System.Drawing.Size(41, 19)
		Me.Text4.Location = New System.Drawing.Point(8, 328)
		Me.Text4.TabIndex = 27
		Me.Text4.Text = "Chat"
		Me.Text4.Visible = False
		Me.Text4.AcceptsReturn = True
		Me.Text4.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
		Me.Text4.CausesValidation = True
		Me.Text4.Enabled = True
		Me.Text4.HideSelection = True
		Me.Text4.ReadOnly = False
		Me.Text4.Maxlength = 0
		Me.Text4.Cursor = System.Windows.Forms.Cursors.IBeam
		Me.Text4.MultiLine = False
		Me.Text4.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.Text4.ScrollBars = System.Windows.Forms.ScrollBars.None
		Me.Text4.TabStop = True
		Me.Text4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
		Me.Text4.Name = "Text4"
		Me.Text1.AutoSize = False
		Me.Text1.BackColor = System.Drawing.Color.Black
		Me.Text1.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Text1.ForeColor = System.Drawing.Color.Red
		Me.Text1.Size = New System.Drawing.Size(33, 19)
		Me.Text1.Location = New System.Drawing.Point(8, 8)
		Me.Text1.TabIndex = 26
		Me.Text1.Text = "Host"
		Me.Text1.AcceptsReturn = True
		Me.Text1.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
		Me.Text1.CausesValidation = True
		Me.Text1.Enabled = True
		Me.Text1.HideSelection = True
		Me.Text1.ReadOnly = False
		Me.Text1.Maxlength = 0
		Me.Text1.Cursor = System.Windows.Forms.Cursors.IBeam
		Me.Text1.MultiLine = False
		Me.Text1.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.Text1.ScrollBars = System.Windows.Forms.ScrollBars.None
		Me.Text1.TabStop = True
		Me.Text1.Visible = True
		Me.Text1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
		Me.Text1.Name = "Text1"
		Me.Text3.AutoSize = False
		Me.Text3.BackColor = System.Drawing.Color.Black
		Me.Text3.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Text3.ForeColor = System.Drawing.Color.Red
		Me.Text3.Size = New System.Drawing.Size(57, 19)
		Me.Text3.Location = New System.Drawing.Point(480, 8)
		Me.Text3.TabIndex = 25
		Me.Text3.Text = "Pasword"
		Me.Text3.Visible = False
		Me.Text3.AcceptsReturn = True
		Me.Text3.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
		Me.Text3.CausesValidation = True
		Me.Text3.Enabled = True
		Me.Text3.HideSelection = True
		Me.Text3.ReadOnly = False
		Me.Text3.Maxlength = 0
		Me.Text3.Cursor = System.Windows.Forms.Cursors.IBeam
		Me.Text3.MultiLine = False
		Me.Text3.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.Text3.ScrollBars = System.Windows.Forms.ScrollBars.None
		Me.Text3.TabStop = True
		Me.Text3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
		Me.Text3.Name = "Text3"
		Me.Text2.AutoSize = False
		Me.Text2.BackColor = System.Drawing.Color.Black
		Me.Text2.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Text2.ForeColor = System.Drawing.Color.Red
		Me.Text2.Size = New System.Drawing.Size(49, 19)
		Me.Text2.Location = New System.Drawing.Point(264, 8)
		Me.Text2.TabIndex = 24
		Me.Text2.Text = "User ID"
		Me.Text2.Visible = False
		Me.Text2.AcceptsReturn = True
		Me.Text2.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
		Me.Text2.CausesValidation = True
		Me.Text2.Enabled = True
		Me.Text2.HideSelection = True
		Me.Text2.ReadOnly = False
		Me.Text2.Maxlength = 0
		Me.Text2.Cursor = System.Windows.Forms.Cursors.IBeam
		Me.Text2.MultiLine = False
		Me.Text2.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.Text2.ScrollBars = System.Windows.Forms.ScrollBars.None
		Me.Text2.TabStop = True
		Me.Text2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
		Me.Text2.Name = "Text2"
		Me.cmdBan.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		Me.cmdBan.Text = "Ban Player"
		Me.cmdBan.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.cmdBan.Size = New System.Drawing.Size(89, 41)
		Me.cmdBan.Location = New System.Drawing.Point(296, 80)
		Me.cmdBan.TabIndex = 23
		Me.cmdBan.Visible = False
		Me.cmdBan.BackColor = System.Drawing.SystemColors.Control
		Me.cmdBan.CausesValidation = True
		Me.cmdBan.Enabled = True
		Me.cmdBan.ForeColor = System.Drawing.SystemColors.ControlText
		Me.cmdBan.Cursor = System.Windows.Forms.Cursors.Default
		Me.cmdBan.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.cmdBan.TabStop = True
		Me.cmdBan.Name = "cmdBan"
		Me.cmdNotSuper.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		Me.cmdNotSuper.Text = "Remove Super Admin Access"
		Me.cmdNotSuper.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.cmdNotSuper.Size = New System.Drawing.Size(89, 41)
		Me.cmdNotSuper.Location = New System.Drawing.Point(392, 224)
		Me.cmdNotSuper.TabIndex = 22
		Me.cmdNotSuper.Visible = False
		Me.cmdNotSuper.BackColor = System.Drawing.SystemColors.Control
		Me.cmdNotSuper.CausesValidation = True
		Me.cmdNotSuper.Enabled = True
		Me.cmdNotSuper.ForeColor = System.Drawing.SystemColors.ControlText
		Me.cmdNotSuper.Cursor = System.Windows.Forms.Cursors.Default
		Me.cmdNotSuper.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.cmdNotSuper.TabStop = True
		Me.cmdNotSuper.Name = "cmdNotSuper"
		Me.cmdSuper.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		Me.cmdSuper.Text = "Make User Super Admin"
		Me.cmdSuper.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.cmdSuper.Size = New System.Drawing.Size(89, 41)
		Me.cmdSuper.Location = New System.Drawing.Point(296, 224)
		Me.cmdSuper.TabIndex = 21
		Me.cmdSuper.Visible = False
		Me.cmdSuper.BackColor = System.Drawing.SystemColors.Control
		Me.cmdSuper.CausesValidation = True
		Me.cmdSuper.Enabled = True
		Me.cmdSuper.ForeColor = System.Drawing.SystemColors.ControlText
		Me.cmdSuper.Cursor = System.Windows.Forms.Cursors.Default
		Me.cmdSuper.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.cmdSuper.TabStop = True
		Me.cmdSuper.Name = "cmdSuper"
		Me.cmdNotAdmin.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		Me.cmdNotAdmin.Text = "Remove Admin Access"
		Me.cmdNotAdmin.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.cmdNotAdmin.Size = New System.Drawing.Size(89, 41)
		Me.cmdNotAdmin.Location = New System.Drawing.Point(392, 176)
		Me.cmdNotAdmin.TabIndex = 20
		Me.cmdNotAdmin.Visible = False
		Me.cmdNotAdmin.BackColor = System.Drawing.SystemColors.Control
		Me.cmdNotAdmin.CausesValidation = True
		Me.cmdNotAdmin.Enabled = True
		Me.cmdNotAdmin.ForeColor = System.Drawing.SystemColors.ControlText
		Me.cmdNotAdmin.Cursor = System.Windows.Forms.Cursors.Default
		Me.cmdNotAdmin.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.cmdNotAdmin.TabStop = True
		Me.cmdNotAdmin.Name = "cmdNotAdmin"
		Me.cmdAdmin.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		Me.cmdAdmin.Text = "Make User Admin"
		Me.cmdAdmin.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.cmdAdmin.Size = New System.Drawing.Size(89, 41)
		Me.cmdAdmin.Location = New System.Drawing.Point(296, 176)
		Me.cmdAdmin.TabIndex = 19
		Me.cmdAdmin.Visible = False
		Me.cmdAdmin.BackColor = System.Drawing.SystemColors.Control
		Me.cmdAdmin.CausesValidation = True
		Me.cmdAdmin.Enabled = True
		Me.cmdAdmin.ForeColor = System.Drawing.SystemColors.ControlText
		Me.cmdAdmin.Cursor = System.Windows.Forms.Cursors.Default
		Me.cmdAdmin.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.cmdAdmin.TabStop = True
		Me.cmdAdmin.Name = "cmdAdmin"
		Me.cmdNotModerator.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		Me.cmdNotModerator.Text = "Remove     Mod Access"
		Me.cmdNotModerator.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.cmdNotModerator.Size = New System.Drawing.Size(89, 41)
		Me.cmdNotModerator.Location = New System.Drawing.Point(392, 128)
		Me.cmdNotModerator.TabIndex = 18
		Me.cmdNotModerator.Visible = False
		Me.cmdNotModerator.BackColor = System.Drawing.SystemColors.Control
		Me.cmdNotModerator.CausesValidation = True
		Me.cmdNotModerator.Enabled = True
		Me.cmdNotModerator.ForeColor = System.Drawing.SystemColors.ControlText
		Me.cmdNotModerator.Cursor = System.Windows.Forms.Cursors.Default
		Me.cmdNotModerator.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.cmdNotModerator.TabStop = True
		Me.cmdNotModerator.Name = "cmdNotModerator"
		Me.cmdModerator.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		Me.cmdModerator.Text = "Make User A Moderator"
		Me.cmdModerator.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.cmdModerator.Size = New System.Drawing.Size(89, 41)
		Me.cmdModerator.Location = New System.Drawing.Point(296, 128)
		Me.cmdModerator.TabIndex = 17
		Me.cmdModerator.Visible = False
		Me.cmdModerator.BackColor = System.Drawing.SystemColors.Control
		Me.cmdModerator.CausesValidation = True
		Me.cmdModerator.Enabled = True
		Me.cmdModerator.ForeColor = System.Drawing.SystemColors.ControlText
		Me.cmdModerator.Cursor = System.Windows.Forms.Cursors.Default
		Me.cmdModerator.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.cmdModerator.TabStop = True
		Me.cmdModerator.Name = "cmdModerator"
		Me.cmdPunt.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		Me.cmdPunt.Text = "Punt Player"
		Me.cmdPunt.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.cmdPunt.Size = New System.Drawing.Size(89, 25)
		Me.cmdPunt.Location = New System.Drawing.Point(296, 48)
		Me.cmdPunt.TabIndex = 16
		Me.cmdPunt.Visible = False
		Me.cmdPunt.BackColor = System.Drawing.SystemColors.Control
		Me.cmdPunt.CausesValidation = True
		Me.cmdPunt.Enabled = True
		Me.cmdPunt.ForeColor = System.Drawing.SystemColors.ControlText
		Me.cmdPunt.Cursor = System.Windows.Forms.Cursors.Default
		Me.cmdPunt.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.cmdPunt.TabStop = True
		Me.cmdPunt.Name = "cmdPunt"
		Me.wbReply.Size = New System.Drawing.Size(785, 153)
		Me.wbReply.Location = New System.Drawing.Point(8, 352)
		Me.wbReply.TabIndex = 14
		Me.wbReply.Visible = False
		Me.wbReply.AllowWebBrowserDrop = True
		Me.wbReply.Name = "wbReply"
		Me.cboMute.BackColor = System.Drawing.Color.Black
		Me.cboMute.Text = "Mute Sounds?"
		Me.cboMute.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.cboMute.ForeColor = System.Drawing.Color.Red
		Me.cboMute.Size = New System.Drawing.Size(121, 17)
		Me.cboMute.Location = New System.Drawing.Point(536, 328)
		Me.cboMute.TabIndex = 13
		Me.cboMute.CheckAlign = System.Drawing.ContentAlignment.MiddleLeft
		Me.cboMute.FlatStyle = System.Windows.Forms.FlatStyle.Standard
		Me.cboMute.CausesValidation = True
		Me.cboMute.Enabled = True
		Me.cboMute.Cursor = System.Windows.Forms.Cursors.Default
		Me.cboMute.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.cboMute.Appearance = System.Windows.Forms.Appearance.Normal
		Me.cboMute.TabStop = True
		Me.cboMute.CheckState = System.Windows.Forms.CheckState.Unchecked
		Me.cboMute.Visible = True
		Me.cboMute.Name = "cboMute"
		Me.pingtimer.Enabled = False
		Me.pingtimer.Interval = 1000
		Me.btnIM.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		Me.btnIM.Text = "Page"
		Me.btnIM.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.btnIM.Size = New System.Drawing.Size(137, 25)
		Me.btnIM.Location = New System.Drawing.Point(152, 288)
		Me.btnIM.TabIndex = 12
		Me.btnIM.Visible = False
		Me.btnIM.BackColor = System.Drawing.SystemColors.Control
		Me.btnIM.CausesValidation = True
		Me.btnIM.Enabled = True
		Me.btnIM.ForeColor = System.Drawing.SystemColors.ControlText
		Me.btnIM.Cursor = System.Windows.Forms.Cursors.Default
		Me.btnIM.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.btnIM.TabStop = True
		Me.btnIM.Name = "btnIM"
		Me.Timer1.Enabled = False
		Me.Timer1.Interval = 5000
		Me.txtPWD.AutoSize = False
		Me.txtPWD.BackColor = System.Drawing.Color.FromARGB(21, 21, 21)
		Me.txtPWD.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.txtPWD.ForeColor = System.Drawing.Color.Green
		Me.txtPWD.Size = New System.Drawing.Size(145, 25)
		Me.txtPWD.IMEMode = System.Windows.Forms.ImeMode.Disable
		Me.txtPWD.Location = New System.Drawing.Point(544, 8)
		Me.txtPWD.PasswordChar = ChrW(42)
		Me.txtPWD.TabIndex = 2
		Me.txtPWD.Visible = False
		Me.txtPWD.AcceptsReturn = True
		Me.txtPWD.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
		Me.txtPWD.CausesValidation = True
		Me.txtPWD.Enabled = True
		Me.txtPWD.HideSelection = True
		Me.txtPWD.ReadOnly = False
		Me.txtPWD.Maxlength = 0
		Me.txtPWD.Cursor = System.Windows.Forms.Cursors.IBeam
		Me.txtPWD.MultiLine = False
		Me.txtPWD.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.txtPWD.ScrollBars = System.Windows.Forms.ScrollBars.None
		Me.txtPWD.TabStop = True
		Me.txtPWD.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.txtPWD.Name = "txtPWD"
		Me.cboTalk.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.cboTalk.BackColor = System.Drawing.Color.Black
		Me.cboTalk.Text = "Talk?"
		Me.cboTalk.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.cboTalk.ForeColor = System.Drawing.Color.Red
		Me.cboTalk.Size = New System.Drawing.Size(73, 17)
		Me.cboTalk.Location = New System.Drawing.Point(720, 328)
		Me.cboTalk.TabIndex = 11
		Me.cboTalk.Visible = False
		Me.cboTalk.CheckAlign = System.Drawing.ContentAlignment.MiddleLeft
		Me.cboTalk.CausesValidation = True
		Me.cboTalk.Enabled = True
		Me.cboTalk.Cursor = System.Windows.Forms.Cursors.Default
		Me.cboTalk.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.cboTalk.Appearance = System.Windows.Forms.Appearance.Normal
		Me.cboTalk.TabStop = True
		Me.cboTalk.CheckState = System.Windows.Forms.CheckState.Unchecked
		Me.cboTalk.Name = "cboTalk"
		Me.btnAway.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		Me.btnAway.BackColor = System.Drawing.SystemColors.Control
		Me.btnAway.Text = "Away"
		Me.btnAway.Font = New System.Drawing.Font("Arial", 9!, System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.btnAway.Size = New System.Drawing.Size(137, 25)
		Me.btnAway.Location = New System.Drawing.Point(8, 288)
		Me.btnAway.TabIndex = 10
		Me.btnAway.Visible = False
		Me.btnAway.CausesValidation = True
		Me.btnAway.Enabled = True
		Me.btnAway.ForeColor = System.Drawing.SystemColors.ControlText
		Me.btnAway.Cursor = System.Windows.Forms.Cursors.Default
		Me.btnAway.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.btnAway.TabStop = True
		Me.btnAway.Name = "btnAway"
		Me.btnJoin.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		Me.btnJoin.BackColor = System.Drawing.SystemColors.Control
		Me.btnJoin.Text = "Join Game"
		Me.btnJoin.Enabled = False
		Me.btnJoin.Font = New System.Drawing.Font("Arial", 9!, System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.btnJoin.Size = New System.Drawing.Size(113, 25)
		Me.btnJoin.Location = New System.Drawing.Point(672, 288)
		Me.btnJoin.TabIndex = 9
		Me.ToolTip1.SetToolTip(Me.btnJoin, "Join a Game Room")
		Me.btnJoin.Visible = False
		Me.btnJoin.CausesValidation = True
		Me.btnJoin.ForeColor = System.Drawing.SystemColors.ControlText
		Me.btnJoin.Cursor = System.Windows.Forms.Cursors.Default
		Me.btnJoin.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.btnJoin.TabStop = True
		Me.btnJoin.Name = "btnJoin"
		Me.btnHost.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		Me.btnHost.BackColor = System.Drawing.SystemColors.Control
		Me.btnHost.Text = "Host Game"
		Me.btnHost.Font = New System.Drawing.Font("Arial", 9!, System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.btnHost.Size = New System.Drawing.Size(121, 25)
		Me.btnHost.Location = New System.Drawing.Point(544, 288)
		Me.btnHost.TabIndex = 8
		Me.ToolTip1.SetToolTip(Me.btnHost, "Create and Host a new Game Room")
		Me.btnHost.Visible = False
		Me.btnHost.CausesValidation = True
		Me.btnHost.Enabled = True
		Me.btnHost.ForeColor = System.Drawing.SystemColors.ControlText
		Me.btnHost.Cursor = System.Windows.Forms.Cursors.Default
		Me.btnHost.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.btnHost.TabStop = True
		Me.btnHost.Name = "btnHost"
		Me.lstGameRooms.BackColor = System.Drawing.Color.FromARGB(21, 21, 21)
		Me.lstGameRooms.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lstGameRooms.ForeColor = System.Drawing.Color.FromARGB(35, 255, 17)
		Me.lstGameRooms.Size = New System.Drawing.Size(241, 231)
		Me.lstGameRooms.Location = New System.Drawing.Point(544, 48)
		Me.lstGameRooms.TabIndex = 7
		Me.lstGameRooms.Visible = False
		Me.lstGameRooms.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.lstGameRooms.CausesValidation = True
		Me.lstGameRooms.Enabled = True
		Me.lstGameRooms.IntegralHeight = True
		Me.lstGameRooms.Cursor = System.Windows.Forms.Cursors.Default
		Me.lstGameRooms.SelectionMode = System.Windows.Forms.SelectionMode.One
		Me.lstGameRooms.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.lstGameRooms.Sorted = False
		Me.lstGameRooms.TabStop = True
		Me.lstGameRooms.MultiColumn = False
		Me.lstGameRooms.Name = "lstGameRooms"
		Me.lstPlayers.BackColor = System.Drawing.Color.FromARGB(21, 21, 21)
		Me.lstPlayers.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lstPlayers.ForeColor = System.Drawing.Color.FromARGB(35, 255, 17)
		Me.lstPlayers.Size = New System.Drawing.Size(281, 247)
		Me.lstPlayers.Location = New System.Drawing.Point(8, 40)
		Me.lstPlayers.TabIndex = 6
		Me.ToolTip1.SetToolTip(Me.lstPlayers, "List of Players Currently online")
		Me.lstPlayers.Visible = False
		Me.lstPlayers.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.lstPlayers.CausesValidation = True
		Me.lstPlayers.Enabled = True
		Me.lstPlayers.IntegralHeight = True
		Me.lstPlayers.Cursor = System.Windows.Forms.Cursors.Default
		Me.lstPlayers.SelectionMode = System.Windows.Forms.SelectionMode.One
		Me.lstPlayers.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.lstPlayers.Sorted = False
		Me.lstPlayers.TabStop = True
		Me.lstPlayers.MultiColumn = False
		Me.lstPlayers.Name = "lstPlayers"
		Me.btnUID.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		Me.btnUID.BackColor = System.Drawing.SystemColors.Control
		Me.btnUID.Text = "Login/Register"
		Me.btnUID.Enabled = False
		Me.btnUID.Font = New System.Drawing.Font("Arial", 9!, System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.btnUID.Size = New System.Drawing.Size(97, 25)
		Me.btnUID.Location = New System.Drawing.Point(696, 8)
		Me.btnUID.TabIndex = 3
		Me.ToolTip1.SetToolTip(Me.btnUID, "Log onto the Server")
		Me.btnUID.Visible = False
		Me.btnUID.CausesValidation = True
		Me.btnUID.ForeColor = System.Drawing.SystemColors.ControlText
		Me.btnUID.Cursor = System.Windows.Forms.Cursors.Default
		Me.btnUID.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.btnUID.TabStop = True
		Me.btnUID.Name = "btnUID"
		Me.btnSend.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		Me.btnSend.Text = "Send"
		Me.btnSend.Font = New System.Drawing.Font("Arial", 9!, System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.btnSend.Size = New System.Drawing.Size(73, 25)
		Me.btnSend.Location = New System.Drawing.Point(720, 512)
		Me.btnSend.TabIndex = 5
		Me.ToolTip1.SetToolTip(Me.btnSend, "Press this to send messages")
		Me.btnSend.Visible = False
		Me.btnSend.BackColor = System.Drawing.SystemColors.Control
		Me.btnSend.CausesValidation = True
		Me.btnSend.Enabled = True
		Me.btnSend.ForeColor = System.Drawing.SystemColors.ControlText
		Me.btnSend.Cursor = System.Windows.Forms.Cursors.Default
		Me.btnSend.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.btnSend.TabStop = True
		Me.btnSend.Name = "btnSend"
		Me.txtUID.AutoSize = False
		Me.txtUID.BackColor = System.Drawing.Color.FromARGB(21, 21, 21)
		Me.txtUID.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.txtUID.ForeColor = System.Drawing.Color.FromARGB(35, 255, 17)
		Me.txtUID.Size = New System.Drawing.Size(153, 25)
		Me.txtUID.Location = New System.Drawing.Point(320, 8)
		Me.txtUID.TabIndex = 1
		Me.ToolTip1.SetToolTip(Me.txtUID, "enter Your User Name")
		Me.txtUID.Visible = False
		Me.txtUID.AcceptsReturn = True
		Me.txtUID.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
		Me.txtUID.CausesValidation = True
		Me.txtUID.Enabled = True
		Me.txtUID.HideSelection = True
		Me.txtUID.ReadOnly = False
		Me.txtUID.Maxlength = 0
		Me.txtUID.Cursor = System.Windows.Forms.Cursors.IBeam
		Me.txtUID.MultiLine = False
		Me.txtUID.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.txtUID.ScrollBars = System.Windows.Forms.ScrollBars.None
		Me.txtUID.TabStop = True
		Me.txtUID.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.txtUID.Name = "txtUID"
		Me.btnGo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		Me.btnGo.BackColor = System.Drawing.SystemColors.Control
		Me.btnGo.Text = "Connect"
		Me.AcceptButton = Me.btnGo
		Me.btnGo.Font = New System.Drawing.Font("Arial", 9!, System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.btnGo.Size = New System.Drawing.Size(57, 25)
		Me.btnGo.Location = New System.Drawing.Point(192, 8)
		Me.btnGo.TabIndex = 0
		Me.btnGo.CausesValidation = True
		Me.btnGo.Enabled = True
		Me.btnGo.ForeColor = System.Drawing.SystemColors.ControlText
		Me.btnGo.Cursor = System.Windows.Forms.Cursors.Default
		Me.btnGo.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.btnGo.TabStop = True
		Me.btnGo.Name = "btnGo"
		Me.txtSend.AutoSize = False
		Me.txtSend.BackColor = System.Drawing.Color.FromARGB(21, 21, 21)
		Me.txtSend.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.txtSend.ForeColor = System.Drawing.Color.FromARGB(35, 255, 17)
		Me.txtSend.Size = New System.Drawing.Size(705, 27)
		Me.txtSend.Location = New System.Drawing.Point(8, 512)
		Me.txtSend.Maxlength = 300
		Me.txtSend.TabIndex = 4
		Me.ToolTip1.SetToolTip(Me.txtSend, "Type your Message here")
		Me.txtSend.Visible = False
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
		Me.txtSend.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.txtSend.Name = "txtSend"
		Me.WebBrowser1.Size = New System.Drawing.Size(833, 577)
		Me.WebBrowser1.Location = New System.Drawing.Point(0, 0)
		Me.WebBrowser1.TabIndex = 15
		Me.WebBrowser1.AllowWebBrowserDrop = True
		Me.WebBrowser1.Name = "WebBrowser1"
		Me.Controls.Add(Socket1)
		Me.Controls.Add(txtHost)
		Me.Controls.Add(cboFilterOff)
		Me.Controls.Add(cmdunBan)
		Me.Controls.Add(Text6)
		Me.Controls.Add(Text5)
		Me.Controls.Add(Text4)
		Me.Controls.Add(Text1)
		Me.Controls.Add(Text3)
		Me.Controls.Add(Text2)
		Me.Controls.Add(cmdBan)
		Me.Controls.Add(cmdNotSuper)
		Me.Controls.Add(cmdSuper)
		Me.Controls.Add(cmdNotAdmin)
		Me.Controls.Add(cmdAdmin)
		Me.Controls.Add(cmdNotModerator)
		Me.Controls.Add(cmdModerator)
		Me.Controls.Add(cmdPunt)
		Me.Controls.Add(wbReply)
		Me.Controls.Add(cboMute)
		Me.Controls.Add(btnIM)
		Me.Controls.Add(txtPWD)
		Me.Controls.Add(cboTalk)
		Me.Controls.Add(btnAway)
		Me.Controls.Add(btnJoin)
		Me.Controls.Add(btnHost)
		Me.Controls.Add(lstGameRooms)
		Me.Controls.Add(lstPlayers)
		Me.Controls.Add(btnUID)
		Me.Controls.Add(btnSend)
		Me.Controls.Add(txtUID)
		Me.Controls.Add(btnGo)
		Me.Controls.Add(txtSend)
		Me.Controls.Add(WebBrowser1)
		CType(Me.Socket1, System.ComponentModel.ISupportInitialize).EndInit()
		Me.ResumeLayout(False)
		Me.PerformLayout()
	End Sub
#End Region 
End Class