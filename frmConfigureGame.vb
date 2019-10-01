Option Strict Off
Option Explicit On
Friend Class frmConfigureGame
	Inherits System.Windows.Forms.Form
	'UPGRADE_NOTE: Filter was upgraded to Filter_Renamed. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="A9E4979A-37FA-4718-9994-97DD76ED70A7"'
	Private Filter_Renamed() As String
	
	
	Private Sub btnCancel_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles btnCancel.Click
		On Error GoTo Failed
		Me.Close()
		Exit Sub
Failed: 
		FileOpen(4, CurDir() & "\errorlog.txt", OpenMode.Append)
		PrintLine(4, "btnCancel_Click - " & Str(Err.Number) & " - " & Err.Description & " - frmconfiguregame")
		FileClose(4)
		Resume Next
		
	End Sub
	
	Private Sub frmConfigureGame_Load(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles MyBase.Load
		On Error GoTo Failed
		
		Filter_Renamed = frmClient.getFilter()
		
		
		frmClient.numberOfPlayers = 4
		
		'UPGRADE_WARNING: Navigate2 was upgraded to Navigate and has a new behavior. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
		WebBrowser1.Navigate(New System.URI(CurDir() & "\configure.htm"))
		
		
		If frmClient.XWAGamePath = "" Then
			optXWA.Visible = False
		Else
			frmClient.game = "XWA"
			optXWA.Checked = True
		End If
		
		If frmClient.BOPGamePath = "" Then
			optBop.Visible = False
		Else
			frmClient.game = "BOP"
			optBop.Checked = True
		End If
		
		If frmClient.XVTGamePath = "" Then
			optXVT.Visible = False
		Else
			frmClient.game = "XVT"
			optXVT.Checked = True
		End If
		
		If frmClient.game = "" Then
			
			MsgBox("You can't host a game because you do not have any supported games installed", MsgBoxStyle.Critical + MsgBoxStyle.OKOnly, "No Games installed")
			Me.Close()
		End If
		Exit Sub
Failed: 
		FileOpen(4, CurDir() & "\errorlog.txt", OpenMode.Append)
		PrintLine(4, "Form_Load - " & Str(Err.Number) & " - " & Err.Description & " - frmconfiguregame")
		FileClose(4)
		Resume Next
		
	End Sub
	
	'UPGRADE_WARNING: Event optBOP.CheckedChanged may fire when form is initialized. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="88B12AE1-6DE0-48A0-86F1-60C0686C026A"'
	Private Sub optBOP_CheckedChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles optBOP.CheckedChanged
		If eventSender.Checked Then
			On Error GoTo Failed
			frmClient.game = "BOP"
			Exit Sub
Failed: 
			FileOpen(4, CurDir() & "\errorlog.txt", OpenMode.Append)
			PrintLine(4, "optBOP_Click - " & Str(Err.Number) & " - " & Err.Description & " - frmconfiguregame")
			FileClose(4)
			Resume Next
			
		End If
	End Sub
	
	'UPGRADE_WARNING: Event optXVT.CheckedChanged may fire when form is initialized. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="88B12AE1-6DE0-48A0-86F1-60C0686C026A"'
	Private Sub optXVT_CheckedChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles optXVT.CheckedChanged
		If eventSender.Checked Then
			On Error GoTo Failed
			frmClient.game = "XVT"
			Exit Sub
Failed: 
			FileOpen(4, CurDir() & "\errorlog.txt", OpenMode.Append)
			PrintLine(4, "optXVT_Click - " & Str(Err.Number) & " - " & Err.Description & " - frmconfiguregame")
			FileClose(4)
			Resume Next
			
		End If
	End Sub
	
	'UPGRADE_WARNING: Event optXWA.CheckedChanged may fire when form is initialized. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="88B12AE1-6DE0-48A0-86F1-60C0686C026A"'
	Private Sub optXWA_CheckedChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles optXWA.CheckedChanged
		If eventSender.Checked Then
			On Error GoTo Failed
			frmClient.game = "XWA"
			Exit Sub
Failed: 
			FileOpen(4, CurDir() & "\errorlog.txt", OpenMode.Append)
			PrintLine(4, "optXWA_Click - " & Str(Err.Number) & " - " & Err.Description & " - frmconfiguregame")
			FileClose(4)
			Resume Next
			
			
		End If
	End Sub
	
	'UPGRADE_NOTE: scrlPlayers.Change was changed from an event to a procedure. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="4E2DC008-5EDA-4547-8317-C9316952674F"'
	'UPGRADE_WARNING: VScrollBar event scrlPlayers.Change has a new behavior. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6BA9B8D2-2A32-4B6E-8D36-44949974A5B4"'
	Private Sub scrlPlayers_Change(ByVal newScrollValue As Integer)
		On Error GoTo Failed
		txtPlayers.Text = CStr(newScrollValue)
		Exit Sub
Failed: 
		FileOpen(4, CurDir() & "\errorlog.txt", OpenMode.Append)
		PrintLine(4, "scrlPlayers_Change - " & Str(Err.Number) & " - " & Err.Description & " - frmconfiguregame")
		FileClose(4)
		Resume Next
		
		
	End Sub
	Private Sub btnOK_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles btnOK.Click
		Dim i As Object
		On Error GoTo Failed
		Dim ip As String
		ip = frmClient.exposedIP
		Dim exists As Boolean
		exists = False
		
		
		
		If txtGameName.Text <> "" Then
			
			For i = 1 To 30 - Len(txtGameName.Text)
				txtGameName.Text = txtGameName.Text & " "
			Next i
			
			
			
			If frmClient.does_exist((txtGameName.Text)) = False Then
				
				frmClient.gameName = txtGameName.Text
				
				
				frmClient.btnHost.Enabled = False
				frmClient.btnJoin.Enabled = False
				frmClient.btnAway.Enabled = False
				
				frmClient.lstGameRooms.Enabled = False
				
				frmClient.Socket1.SendLen = Len("++++" & "1/" & txtPlayers.Text & " " & frmClient.game & " " & frmClient.gameName & ip & Chr(3))
				frmClient.Socket1.SendData = "++++" & "1/" & txtPlayers.Text & " " & frmClient.game & " " & frmClient.gameName & ip & Chr(3)
				
				frmClient.Socket1.SendLen = Len("GRPL" & frmClient.gameName & Chr(30) & "Host: " & frmClient.txtUID.Text & Chr(3))
				frmClient.Socket1.SendData = "GRPL" & frmClient.gameName & Chr(30) & "Host: " & frmClient.txtUID.Text & Chr(3)
				
				frmHostGame.Show()
				
				Me.Close()
			Else
				MsgBox("That Game Name already exists", MsgBoxStyle.OKOnly, "Validation Error")
			End If
			
		Else
			MsgBox("Enter a Game Name", MsgBoxStyle.OKOnly, "Validation Error")
		End If
		Exit Sub
Failed: 
		FileOpen(4, CurDir() & "\errorlog.txt", OpenMode.Append)
		PrintLine(4, "btnOK_Click - " & Str(Err.Number) & " - " & Err.Description & " - frmconfiguregame")
		FileClose(4)
		Resume Next
		
		
	End Sub
	
	
	
	
	
	'UPGRADE_WARNING: Event txtGameName.TextChanged may fire when form is initialized. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="88B12AE1-6DE0-48A0-86F1-60C0686C026A"'
	Private Sub txtGameName_TextChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles txtGameName.TextChanged
		Dim i As Object
		On Error GoTo Failed
		For i = 0 To frmClient.FilterCount
			
			If frmClient.cboFilterOff.CheckState <> 1 Then
				
				txtGameName.Text = Replace(txtGameName.Text, Filter_Renamed(i), "Smurf",  ,  , CompareMethod.Text)
				
			End If
			
		Next i
		Exit Sub
Failed: 
		FileOpen(4, CurDir() & "\errorlog.txt", OpenMode.Append)
		PrintLine(4, "txtGameNameChange - " & Str(Err.Number) & " - " & Err.Description & " - frmconfiguregame")
		FileClose(4)
		Resume Next
		
	End Sub
	
	'UPGRADE_WARNING: Event txtPlayers.TextChanged may fire when form is initialized. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="88B12AE1-6DE0-48A0-86F1-60C0686C026A"'
	Private Sub txtPlayers_TextChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles txtPlayers.TextChanged
		On Error GoTo Failed
		frmClient.numberOfPlayers = CShort(txtPlayers.Text)
		
		Exit Sub
Failed: 
		FileOpen(4, CurDir() & "\errorlog.txt", OpenMode.Append)
		PrintLine(4, "txtPlayers_Change - " & Str(Err.Number) & " - " & Err.Description & " - frmconfiguregame")
		FileClose(4)
		Resume Next
		
	End Sub
	Private Sub scrlPlayers_Scroll(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.ScrollEventArgs) Handles scrlPlayers.Scroll
		Select Case eventArgs.type
			Case System.Windows.Forms.ScrollEventType.EndScroll
				scrlPlayers_Change(eventArgs.newValue)
		End Select
	End Sub
End Class