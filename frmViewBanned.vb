Option Strict Off
Option Explicit On
Friend Class frmViewBanned
	Inherits System.Windows.Forms.Form
	Private selectedUser As String
	Private BannedUser() As String
	
	Private Sub cmdunBan_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdunBan.Click
		On Error GoTo Failed
		If selectedUser <> "" Then
			
			frmClient.Socket1.SendLen = Len("RMBN" & selectedUser & Chr(3))
			frmClient.Socket1.SendData = "RMBN" & selectedUser & Chr(3)
		End If
		cmdunBan.Enabled = False
		Me.Close()
		Exit Sub
Failed: 
		FileOpen(4, CurDir() & "\errorlog.txt", OpenMode.Append)
		PrintLine(4, "cmdunBan_Click - " & Str(Err.Number) & " - " & Err.Description & " - frmViewBanned")
		FileClose(4)
		Resume Next
		
	End Sub
	
	Private Sub frmViewBanned_Load(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles MyBase.Load
		Dim i As Object

		
		BannedUser = VB6.CopyArray(frmClient.getBannedUsers())
		
		For i = 0 To frmClient.BannedUserCounter
			'UPGRADE_WARNING: Couldn't resolve default property of object i. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
            lstBanned.Items.Add(BannedUser(i))
            Exit Sub
Failed:
			FileOpen(4, CurDir() & "\errorlog.txt", OpenMode.Append)
			PrintLine(4, "Form_Load - " & Str(Err.Number) & " - " & Err.Description & " - frmViewBanned")
			FileClose(4)
			Resume Next
		Next i
		
	End Sub
	
	'UPGRADE_WARNING: Event lstBanned.SelectedIndexChanged may fire when form is initialized. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="88B12AE1-6DE0-48A0-86F1-60C0686C026A"'
	Private Sub lstBanned_SelectedIndexChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles lstBanned.SelectedIndexChanged
		On Error GoTo Failed
		
		Dim selectedData As String
		
		selectedData = BannedUser(lstBanned.SelectedIndex)
		
		selectedUser = Mid(selectedData, 1, InStr(1, selectedData, Chr(30)) - 1)
		
		cmdunBan.Enabled = True
		Exit Sub
Failed: 
		FileOpen(4, CurDir() & "\errorlog.txt", OpenMode.Append)
		PrintLine(4, "lstBanned_Click - " & Str(Err.Number) & " - " & Err.Description & " - frmViewBanned")
		FileClose(4)
		Resume Next
		
	End Sub

    Private Sub cmdunban_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdunban.Click

    End Sub
End Class