<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> Partial Class frmSplash
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
	Public WithEvents cmddeny As System.Windows.Forms.Button
	Public WithEvents cmdAccept As System.Windows.Forms.Button
	Public WithEvents WebBrowser2 As System.Windows.Forms.WebBrowser
	Public WithEvents WebBrowser1 As System.Windows.Forms.WebBrowser
	'NOTE: The following procedure is required by the Windows Form Designer
	'It can be modified using the Windows Form Designer.
	'Do not modify it using the code editor.
	<System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
		Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(frmSplash))
		Me.components = New System.ComponentModel.Container()
		Me.ToolTip1 = New System.Windows.Forms.ToolTip(components)
		Me.cmddeny = New System.Windows.Forms.Button
		Me.cmdAccept = New System.Windows.Forms.Button
		Me.WebBrowser2 = New System.Windows.Forms.WebBrowser
		Me.WebBrowser1 = New System.Windows.Forms.WebBrowser
		Me.SuspendLayout()
		Me.ToolTip1.Active = True
		Me.ControlBox = False
		Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
		Me.ClientSize = New System.Drawing.Size(569, 574)
		Me.Location = New System.Drawing.Point(17, 94)
		Me.Icon = CType(resources.GetObject("frmSplash.Icon"), System.Drawing.Icon)
		Me.KeyPreview = True
		Me.MaximizeBox = False
		Me.MinimizeBox = False
		Me.ShowInTaskbar = False
		Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
		Me.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.BackColor = System.Drawing.SystemColors.Control
		Me.Enabled = True
		Me.Cursor = System.Windows.Forms.Cursors.Default
		Me.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.HelpButton = False
		Me.WindowState = System.Windows.Forms.FormWindowState.Normal
		Me.Name = "frmSplash"
		Me.cmddeny.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		Me.cmddeny.Text = "I want to show I'm a rebel by flaunting the authority of an online gamming community, or in otherwords I'm a Smurfhead"
		Me.cmddeny.Size = New System.Drawing.Size(273, 33)
		Me.cmddeny.Location = New System.Drawing.Point(288, 536)
		Me.cmddeny.TabIndex = 3
		Me.cmddeny.BackColor = System.Drawing.SystemColors.Control
		Me.cmddeny.CausesValidation = True
		Me.cmddeny.Enabled = True
		Me.cmddeny.ForeColor = System.Drawing.SystemColors.ControlText
		Me.cmddeny.Cursor = System.Windows.Forms.Cursors.Default
		Me.cmddeny.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.cmddeny.TabStop = True
		Me.cmddeny.Name = "cmddeny"
		Me.cmdAccept.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		Me.cmdAccept.Text = "I Agree to abide by the TOS"
		Me.cmdAccept.Font = New System.Drawing.Font("Arial", 12!, System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.cmdAccept.Size = New System.Drawing.Size(265, 33)
		Me.cmdAccept.Location = New System.Drawing.Point(8, 536)
		Me.cmdAccept.TabIndex = 2
		Me.cmdAccept.BackColor = System.Drawing.SystemColors.Control
		Me.cmdAccept.CausesValidation = True
		Me.cmdAccept.Enabled = True
		Me.cmdAccept.ForeColor = System.Drawing.SystemColors.ControlText
		Me.cmdAccept.Cursor = System.Windows.Forms.Cursors.Default
		Me.cmdAccept.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.cmdAccept.TabStop = True
		Me.cmdAccept.Name = "cmdAccept"
		Me.WebBrowser2.Size = New System.Drawing.Size(569, 209)
		Me.WebBrowser2.Location = New System.Drawing.Point(0, 320)
		Me.WebBrowser2.TabIndex = 1
		Me.WebBrowser2.AllowWebBrowserDrop = True
		Me.WebBrowser2.Name = "WebBrowser2"
		Me.WebBrowser1.Size = New System.Drawing.Size(569, 313)
		Me.WebBrowser1.Location = New System.Drawing.Point(0, 0)
		Me.WebBrowser1.TabIndex = 0
		Me.WebBrowser1.AllowWebBrowserDrop = True
		Me.WebBrowser1.Name = "WebBrowser1"
		Me.Controls.Add(cmddeny)
		Me.Controls.Add(cmdAccept)
		Me.Controls.Add(WebBrowser2)
		Me.Controls.Add(WebBrowser1)
		Me.ResumeLayout(False)
		Me.PerformLayout()
	End Sub
#End Region 
End Class