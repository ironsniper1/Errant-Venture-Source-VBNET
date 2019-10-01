<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> Partial Class frmJoinGame
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
	Public WithEvents btnIPIN As System.Windows.Forms.Button
	Public WithEvents btnBack As System.Windows.Forms.Button
	Public WithEvents btnLeave As System.Windows.Forms.Button
	Public WithEvents timerconnection As System.Windows.Forms.Timer
	Public WithEvents Timer1 As System.Windows.Forms.Timer
	Public WithEvents btnSend As System.Windows.Forms.Button
	Public WithEvents txtSend As System.Windows.Forms.TextBox
	Public WithEvents lstReply As System.Windows.Forms.ListBox
	Public WithEvents lstPlayers As System.Windows.Forms.ListBox
	Public WithEvents WebBrowser1 As System.Windows.Forms.WebBrowser
	'NOTE: The following procedure is required by the Windows Form Designer
	'It can be modified using the Windows Form Designer.
	'Do not modify it using the code editor.
	<System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
		Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(frmJoinGame))
		Me.components = New System.ComponentModel.Container()
		Me.ToolTip1 = New System.Windows.Forms.ToolTip(components)
		Me.Socket1 = New AxSocketWrenchCtrl.AxSocket
		Me.btnIPIN = New System.Windows.Forms.Button
		Me.btnBack = New System.Windows.Forms.Button
		Me.btnLeave = New System.Windows.Forms.Button
		Me.timerconnection = New System.Windows.Forms.Timer(components)
		Me.Timer1 = New System.Windows.Forms.Timer(components)
		Me.btnSend = New System.Windows.Forms.Button
		Me.txtSend = New System.Windows.Forms.TextBox
		Me.lstReply = New System.Windows.Forms.ListBox
		Me.lstPlayers = New System.Windows.Forms.ListBox
		Me.WebBrowser1 = New System.Windows.Forms.WebBrowser
		Me.SuspendLayout()
		Me.ToolTip1.Active = True
		CType(Me.Socket1, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.Text = "XvT Join Game Window"
		Me.ClientSize = New System.Drawing.Size(637, 382)
		Me.Location = New System.Drawing.Point(4, 23)
		Me.Icon = CType(resources.GetObject("frmJoinGame.Icon"), System.Drawing.Icon)
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
		Me.Name = "frmJoinGame"
		Socket1.OcxState = CType(resources.GetObject("Socket1.OcxState"), System.Windows.Forms.AxHost.State)
		Me.Socket1.Location = New System.Drawing.Point(432, 80)
		Me.Socket1.Name = "Socket1"
		Me.btnIPIN.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		Me.btnIPIN.Text = "IP In"
		Me.btnIPIN.Size = New System.Drawing.Size(129, 41)
		Me.btnIPIN.Location = New System.Drawing.Point(504, 104)
		Me.btnIPIN.TabIndex = 6
		Me.btnIPIN.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.btnIPIN.BackColor = System.Drawing.SystemColors.Control
		Me.btnIPIN.CausesValidation = True
		Me.btnIPIN.Enabled = True
		Me.btnIPIN.ForeColor = System.Drawing.SystemColors.ControlText
		Me.btnIPIN.Cursor = System.Windows.Forms.Cursors.Default
		Me.btnIPIN.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.btnIPIN.TabStop = True
		Me.btnIPIN.Name = "btnIPIN"
		Me.btnBack.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		Me.btnBack.Text = "Back"
		Me.btnBack.Enabled = False
		Me.btnBack.Size = New System.Drawing.Size(129, 41)
		Me.btnBack.Location = New System.Drawing.Point(504, 8)
		Me.btnBack.TabIndex = 5
		Me.btnBack.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.btnBack.BackColor = System.Drawing.SystemColors.Control
		Me.btnBack.CausesValidation = True
		Me.btnBack.ForeColor = System.Drawing.SystemColors.ControlText
		Me.btnBack.Cursor = System.Windows.Forms.Cursors.Default
		Me.btnBack.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.btnBack.TabStop = True
		Me.btnBack.Name = "btnBack"
		Me.btnLeave.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		Me.btnLeave.Text = "Leave"
		Me.btnLeave.Size = New System.Drawing.Size(129, 41)
		Me.btnLeave.Location = New System.Drawing.Point(504, 56)
		Me.btnLeave.TabIndex = 4
		Me.btnLeave.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.btnLeave.BackColor = System.Drawing.SystemColors.Control
		Me.btnLeave.CausesValidation = True
		Me.btnLeave.Enabled = True
		Me.btnLeave.ForeColor = System.Drawing.SystemColors.ControlText
		Me.btnLeave.Cursor = System.Windows.Forms.Cursors.Default
		Me.btnLeave.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.btnLeave.TabStop = True
		Me.btnLeave.Name = "btnLeave"
		Me.timerconnection.Enabled = False
		Me.timerconnection.Interval = 1000
		Me.Timer1.Enabled = False
		Me.Timer1.Interval = 2000
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
		Me.lstPlayers.Size = New System.Drawing.Size(169, 231)
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
		Me.WebBrowser1.Size = New System.Drawing.Size(681, 393)
		Me.WebBrowser1.Location = New System.Drawing.Point(0, 0)
		Me.WebBrowser1.TabIndex = 7
		Me.WebBrowser1.AllowWebBrowserDrop = True
		Me.WebBrowser1.Name = "WebBrowser1"
		Me.Controls.Add(Socket1)
		Me.Controls.Add(btnIPIN)
		Me.Controls.Add(btnBack)
		Me.Controls.Add(btnLeave)
		Me.Controls.Add(btnSend)
		Me.Controls.Add(txtSend)
		Me.Controls.Add(lstReply)
		Me.Controls.Add(lstPlayers)
		Me.Controls.Add(WebBrowser1)
		CType(Me.Socket1, System.ComponentModel.ISupportInitialize).EndInit()
		Me.ResumeLayout(False)
		Me.PerformLayout()
	End Sub
#End Region 
End Class