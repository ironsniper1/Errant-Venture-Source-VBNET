Option Strict Off
Option Explicit On
Friend Class frmSplash
	Inherits System.Windows.Forms.Form
	
	
	
	
	
	
	Private Sub cmdAccept_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdAccept.Click
		On Error GoTo Failed
		Me.Close()
		frmClient.Show()
		Exit Sub
Failed: 
		FileOpen(4, CurDir() & "\errorlog.txt", OpenMode.Append)
		PrintLine(4, "timer1_timer - " & Str(Err.Number) & " - " & Err.Description & " - frmsplash")
		FileClose(4)
		Resume Next
		
	End Sub
	
	Private Sub cmddeny_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmddeny.Click
		Me.Close()
	End Sub
	
	Private Sub frmSplash_Load(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles MyBase.Load
		On Error GoTo Failed
		
		'UPGRADE_WARNING: Navigate2 was upgraded to Navigate and has a new behavior. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
		WebBrowser1.Navigate(New System.URI(CurDir() & "\splash.htm"))
		'UPGRADE_WARNING: Navigate2 was upgraded to Navigate and has a new behavior. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
		WebBrowser2.Navigate(New System.URI(CurDir() & "\TOS.htm"))
		
		'Load frmClient
		Me.Text = "Welcome to the NRSD Errant Venture - Version 10.93"
		
		Exit Sub
Failed: 
		FileOpen(4, CurDir() & "\errorlog.txt", OpenMode.Append)
		PrintLine(4, "Foram_Load - " & Str(Err.Number) & " - " & Err.Description & " - frmsplash")
		FileClose(4)
		Resume Next
		
	End Sub
End Class