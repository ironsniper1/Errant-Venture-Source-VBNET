Option Strict Off
Option Explicit On
Friend Class frmRegister
	Inherits System.Windows.Forms.Form
	Private Sub btnRegister_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles btnRegister.Click
		On Error GoTo Failed
		Dim reg As Boolean
		
		reg = True
		
		
		If txtPWD.Text <> txtpwd2.Text Then
			MsgBox("Passwords don't match, Try again", MsgBoxStyle.Exclamation + MsgBoxStyle.OKOnly, "Validation Error")
			reg = False
		End If
		
		If Len(txtPWD.Text) < 7 Then
			MsgBox("Passwords must be 8 characters or longer", MsgBoxStyle.Exclamation + MsgBoxStyle.OKOnly, "Validation Error")
			reg = False
		End If
		
		'If Mid(txtuid.Text, 3, 1) <> "_" And Mid(txtuid.Text, 4, 1) <> "_" And Mid(txtuid.Text, 5, 1) <> "_" Then
		'    MsgBox "include club info as above" + Chr$(13) + "If you are not a member of a club, enter Newb_ at the start of your userid", vbExclamation + vbOKOnly, "Validation Error"
		'    reg = False
		'End If
		
		If reg Then
			
			frmClient.Socket1.SendLen = Len("RRRR" & txtUID.Text & Chr(30) & txtPWD.Text & Chr(3))
			frmClient.Socket1.SendData = "RRRR" & txtUID.Text & Chr(30) & txtPWD.Text & Chr(3)
			
			Me.Enabled = False
			
		End If
		Exit Sub
Failed: 
		FileOpen(4, CurDir() & "\errorlog.txt", OpenMode.Append)
		PrintLine(4, "btnRegister_Click - " & Str(Err.Number) & " - " & Err.Description & " - frmRegister")
		FileClose(4)
		Resume Next
		
		
	End Sub
	
	
	Private Sub frmRegister_FormClosed(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
		On Error GoTo Failed
		
		Me.Close()
		frmClient.Enabled = True
		
		Exit Sub
Failed: 
		FileOpen(4, CurDir() & "\errorlog.txt", OpenMode.Append)
		PrintLine(4, "form_UnLoad - " & Str(Err.Number) & " - " & Err.Description & " - frmRegister")
		FileClose(4)
		Resume Next
		
	End Sub
End Class