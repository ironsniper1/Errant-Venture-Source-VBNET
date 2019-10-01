<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> Partial Class frmConfigureGame
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
	Public WithEvents Text2 As System.Windows.Forms.TextBox
	Public WithEvents Text1 As System.Windows.Forms.TextBox
	Public WithEvents btnCancel As System.Windows.Forms.Button
	Public WithEvents btnOK As System.Windows.Forms.Button
	Public WithEvents optBOP As System.Windows.Forms.RadioButton
	Public WithEvents optXWA As System.Windows.Forms.RadioButton
	Public WithEvents optXVT As System.Windows.Forms.RadioButton
	Public WithEvents Frame1 As System.Windows.Forms.GroupBox
	Public WithEvents txtGameName As System.Windows.Forms.TextBox
	Public WithEvents scrlPlayers As System.Windows.Forms.VScrollBar
	Public WithEvents txtPlayers As System.Windows.Forms.TextBox
	Public WithEvents WebBrowser1 As System.Windows.Forms.WebBrowser
	Public WithEvents Label2 As System.Windows.Forms.Label
	Public WithEvents Label1 As System.Windows.Forms.Label
	'NOTE: The following procedure is required by the Windows Form Designer
	'It can be modified using the Windows Form Designer.
	'Do not modify it using the code editor.
	<System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
		Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(frmConfigureGame))
		Me.components = New System.ComponentModel.Container()
		Me.ToolTip1 = New System.Windows.Forms.ToolTip(components)
		Me.Text2 = New System.Windows.Forms.TextBox
		Me.Text1 = New System.Windows.Forms.TextBox
		Me.btnCancel = New System.Windows.Forms.Button
		Me.btnOK = New System.Windows.Forms.Button
		Me.Frame1 = New System.Windows.Forms.GroupBox
		Me.optBOP = New System.Windows.Forms.RadioButton
		Me.optXWA = New System.Windows.Forms.RadioButton
		Me.optXVT = New System.Windows.Forms.RadioButton
		Me.txtGameName = New System.Windows.Forms.TextBox
		Me.scrlPlayers = New System.Windows.Forms.VScrollBar
		Me.txtPlayers = New System.Windows.Forms.TextBox
		Me.WebBrowser1 = New System.Windows.Forms.WebBrowser
		Me.Label2 = New System.Windows.Forms.Label
		Me.Label1 = New System.Windows.Forms.Label
		Me.Frame1.SuspendLayout()
		Me.SuspendLayout()
		Me.ToolTip1.Active = True
		Me.Text = "Configure Game"
		Me.ClientSize = New System.Drawing.Size(310, 194)
		Me.Location = New System.Drawing.Point(4, 23)
		Me.Icon = CType(resources.GetObject("frmConfigureGame.Icon"), System.Drawing.Icon)
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
		Me.Name = "frmConfigureGame"
		Me.Text2.AutoSize = False
		Me.Text2.BackColor = System.Drawing.Color.Black
		Me.Text2.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Text2.ForeColor = System.Drawing.Color.Red
		Me.Text2.Size = New System.Drawing.Size(145, 17)
		Me.Text2.Location = New System.Drawing.Point(8, 56)
		Me.Text2.ReadOnly = True
		Me.Text2.TabIndex = 13
		Me.Text2.TabStop = False
		Me.Text2.Text = "Game Title"
		Me.Text2.AcceptsReturn = True
		Me.Text2.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
		Me.Text2.CausesValidation = True
		Me.Text2.Enabled = True
		Me.Text2.HideSelection = True
		Me.Text2.Maxlength = 0
		Me.Text2.Cursor = System.Windows.Forms.Cursors.IBeam
		Me.Text2.MultiLine = False
		Me.Text2.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.Text2.ScrollBars = System.Windows.Forms.ScrollBars.None
		Me.Text2.Visible = True
		Me.Text2.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.Text2.Name = "Text2"
		Me.Text1.AutoSize = False
		Me.Text1.BackColor = System.Drawing.Color.Black
		Me.Text1.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Text1.ForeColor = System.Drawing.Color.Red
		Me.Text1.Size = New System.Drawing.Size(145, 17)
		Me.Text1.Location = New System.Drawing.Point(8, 8)
		Me.Text1.ReadOnly = True
		Me.Text1.TabIndex = 12
		Me.Text1.TabStop = False
		Me.Text1.Text = "Number of Players"
		Me.Text1.AcceptsReturn = True
		Me.Text1.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
		Me.Text1.CausesValidation = True
		Me.Text1.Enabled = True
		Me.Text1.HideSelection = True
		Me.Text1.Maxlength = 0
		Me.Text1.Cursor = System.Windows.Forms.Cursors.IBeam
		Me.Text1.MultiLine = False
		Me.Text1.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.Text1.ScrollBars = System.Windows.Forms.ScrollBars.None
		Me.Text1.Visible = True
		Me.Text1.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.Text1.Name = "Text1"
		Me.btnCancel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		Me.btnCancel.Text = "Cancel"
		Me.btnCancel.Size = New System.Drawing.Size(97, 33)
		Me.btnCancel.Location = New System.Drawing.Point(208, 152)
		Me.btnCancel.TabIndex = 10
		Me.btnCancel.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.btnCancel.BackColor = System.Drawing.SystemColors.Control
		Me.btnCancel.CausesValidation = True
		Me.btnCancel.Enabled = True
		Me.btnCancel.ForeColor = System.Drawing.SystemColors.ControlText
		Me.btnCancel.Cursor = System.Windows.Forms.Cursors.Default
		Me.btnCancel.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.btnCancel.TabStop = True
		Me.btnCancel.Name = "btnCancel"
		Me.btnOK.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		Me.btnOK.Text = "OK"
		Me.AcceptButton = Me.btnOK
		Me.btnOK.Size = New System.Drawing.Size(97, 33)
		Me.btnOK.Location = New System.Drawing.Point(208, 112)
		Me.btnOK.TabIndex = 9
		Me.btnOK.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.btnOK.BackColor = System.Drawing.SystemColors.Control
		Me.btnOK.CausesValidation = True
		Me.btnOK.Enabled = True
		Me.btnOK.ForeColor = System.Drawing.SystemColors.ControlText
		Me.btnOK.Cursor = System.Windows.Forms.Cursors.Default
		Me.btnOK.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.btnOK.TabStop = True
		Me.btnOK.Name = "btnOK"
		Me.Frame1.BackColor = System.Drawing.Color.Black
		Me.Frame1.Text = "Game To Play"
		Me.Frame1.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Frame1.ForeColor = System.Drawing.Color.FromARGB(0, 192, 0)
		Me.Frame1.Size = New System.Drawing.Size(193, 81)
		Me.Frame1.Location = New System.Drawing.Point(8, 104)
		Me.Frame1.TabIndex = 5
		Me.Frame1.Enabled = True
		Me.Frame1.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.Frame1.Visible = True
		Me.Frame1.Padding = New System.Windows.Forms.Padding(0)
		Me.Frame1.Name = "Frame1"
		Me.optBOP.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
		Me.optBOP.BackColor = System.Drawing.Color.Black
		Me.optBOP.Text = "Balance Of Power"
		Me.optBOP.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.optBOP.ForeColor = System.Drawing.Color.Red
		Me.optBOP.Size = New System.Drawing.Size(129, 17)
		Me.optBOP.Location = New System.Drawing.Point(8, 40)
		Me.optBOP.TabIndex = 7
		Me.optBOP.CheckAlign = System.Drawing.ContentAlignment.MiddleLeft
		Me.optBOP.CausesValidation = True
		Me.optBOP.Enabled = True
		Me.optBOP.Cursor = System.Windows.Forms.Cursors.Default
		Me.optBOP.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.optBOP.Appearance = System.Windows.Forms.Appearance.Normal
		Me.optBOP.TabStop = True
		Me.optBOP.Checked = False
		Me.optBOP.Visible = True
		Me.optBOP.Name = "optBOP"
		Me.optXWA.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
		Me.optXWA.BackColor = System.Drawing.Color.Black
		Me.optXWA.Text = "X-Wing Alliance"
		Me.optXWA.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.optXWA.ForeColor = System.Drawing.Color.Red
		Me.optXWA.Size = New System.Drawing.Size(177, 17)
		Me.optXWA.Location = New System.Drawing.Point(8, 56)
		Me.optXWA.TabIndex = 8
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
		Me.optXVT.BackColor = System.Drawing.Color.Black
		Me.optXVT.Text = "X-Wing vs Tie"
		Me.optXVT.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.optXVT.ForeColor = System.Drawing.Color.Red
		Me.optXVT.Size = New System.Drawing.Size(177, 17)
		Me.optXVT.Location = New System.Drawing.Point(8, 24)
		Me.optXVT.TabIndex = 6
		Me.optXVT.Checked = True
		Me.optXVT.CheckAlign = System.Drawing.ContentAlignment.MiddleLeft
		Me.optXVT.CausesValidation = True
		Me.optXVT.Enabled = True
		Me.optXVT.Cursor = System.Windows.Forms.Cursors.Default
		Me.optXVT.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.optXVT.Appearance = System.Windows.Forms.Appearance.Normal
		Me.optXVT.TabStop = True
		Me.optXVT.Visible = True
		Me.optXVT.Name = "optXVT"
		Me.txtGameName.AutoSize = False
		Me.txtGameName.BackColor = System.Drawing.Color.Black
		Me.txtGameName.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.txtGameName.ForeColor = System.Drawing.Color.FromARGB(0, 192, 0)
		Me.txtGameName.Size = New System.Drawing.Size(297, 25)
		Me.txtGameName.Location = New System.Drawing.Point(8, 72)
		Me.txtGameName.Maxlength = 30
		Me.txtGameName.TabIndex = 1
		Me.txtGameName.AcceptsReturn = True
		Me.txtGameName.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
		Me.txtGameName.CausesValidation = True
		Me.txtGameName.Enabled = True
		Me.txtGameName.HideSelection = True
		Me.txtGameName.ReadOnly = False
		Me.txtGameName.Cursor = System.Windows.Forms.Cursors.IBeam
		Me.txtGameName.MultiLine = False
		Me.txtGameName.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.txtGameName.ScrollBars = System.Windows.Forms.ScrollBars.None
		Me.txtGameName.TabStop = True
		Me.txtGameName.Visible = True
		Me.txtGameName.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.txtGameName.Name = "txtGameName"
		Me.scrlPlayers.Size = New System.Drawing.Size(17, 25)
		Me.scrlPlayers.Location = New System.Drawing.Point(32, 24)
		Me.scrlPlayers.Maximum = 2
		Me.scrlPlayers.Minimum = 8
		Me.scrlPlayers.TabIndex = 2
		Me.scrlPlayers.Value = 4
		Me.scrlPlayers.CausesValidation = True
		Me.scrlPlayers.Enabled = True
		Me.scrlPlayers.LargeChange = 1
		Me.scrlPlayers.Cursor = System.Windows.Forms.Cursors.Default
		Me.scrlPlayers.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.scrlPlayers.SmallChange = 1
		Me.scrlPlayers.TabStop = True
		Me.scrlPlayers.Visible = True
		Me.scrlPlayers.Name = "scrlPlayers"
		Me.txtPlayers.AutoSize = False
		Me.txtPlayers.BackColor = System.Drawing.Color.Black
		Me.txtPlayers.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.txtPlayers.ForeColor = System.Drawing.Color.Blue
		Me.txtPlayers.Size = New System.Drawing.Size(25, 25)
		Me.txtPlayers.Location = New System.Drawing.Point(8, 24)
		Me.txtPlayers.ReadOnly = True
		Me.txtPlayers.TabIndex = 3
		Me.txtPlayers.TabStop = False
		Me.txtPlayers.Text = "4"
		Me.txtPlayers.AcceptsReturn = True
		Me.txtPlayers.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
		Me.txtPlayers.CausesValidation = True
		Me.txtPlayers.Enabled = True
		Me.txtPlayers.HideSelection = True
		Me.txtPlayers.Maxlength = 0
		Me.txtPlayers.Cursor = System.Windows.Forms.Cursors.IBeam
		Me.txtPlayers.MultiLine = False
		Me.txtPlayers.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.txtPlayers.ScrollBars = System.Windows.Forms.ScrollBars.None
		Me.txtPlayers.Visible = True
		Me.txtPlayers.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.txtPlayers.Name = "txtPlayers"
		Me.WebBrowser1.Size = New System.Drawing.Size(345, 225)
		Me.WebBrowser1.Location = New System.Drawing.Point(0, 0)
		Me.WebBrowser1.TabIndex = 11
		Me.WebBrowser1.AllowWebBrowserDrop = True
		Me.WebBrowser1.Name = "WebBrowser1"
		Me.Label2.Text = "Game Name"
		Me.Label2.Size = New System.Drawing.Size(97, 17)
		Me.Label2.Location = New System.Drawing.Point(8, 56)
		Me.Label2.TabIndex = 4
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
		Me.Label1.Text = "Number Of Players"
		Me.Label1.Size = New System.Drawing.Size(97, 17)
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
		Me.Controls.Add(Text2)
		Me.Controls.Add(Text1)
		Me.Controls.Add(btnCancel)
		Me.Controls.Add(btnOK)
		Me.Controls.Add(Frame1)
		Me.Controls.Add(txtGameName)
		Me.Controls.Add(scrlPlayers)
		Me.Controls.Add(txtPlayers)
		Me.Controls.Add(WebBrowser1)
		Me.Controls.Add(Label2)
		Me.Controls.Add(Label1)
		Me.Frame1.Controls.Add(optBOP)
		Me.Frame1.Controls.Add(optXWA)
		Me.Frame1.Controls.Add(optXVT)
		Me.Frame1.ResumeLayout(False)
		Me.ResumeLayout(False)
		Me.PerformLayout()
	End Sub
#End Region 
End Class