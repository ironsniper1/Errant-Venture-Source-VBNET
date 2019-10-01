Option Strict Off
Option Explicit On
Imports VB = Microsoft.VisualBasic
Friend Class frmHostGame
	Inherits System.Windows.Forms.Form
	
	Private Declare Function ShellExecute Lib "shell32.dll"  Alias "ShellExecuteA"(ByVal hwnd As Integer, ByVal lpOperation As String, ByVal lpFile As String, ByVal lpParameters As String, ByVal lpDirectory As String, ByVal nShowCmd As Integer) As Integer
	
	Private lstReplyarray(100) As String
	
	
	Private lstArray(100) As String
	Private lstArraySocket(100) As Short
	Private lstArrayLat(100) As String
	
	Private lstArrayCount As Short
	
	Private selectedSocket As Short
	
	Private lastsocket As Short
	
	Private numsockets As Short
	
	Private backFlag As Boolean
	
	'UPGRADE_NOTE: Filter was upgraded to Filter_Renamed. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="A9E4979A-37FA-4718-9994-97DD76ED70A7"'
	Private Filter_Renamed() As String
	
	
	
	
	
	
	Private Sub btnBOP_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles btnBOP.Click
		
		On Error GoTo Failed
		
		Dim path As String
		Dim i As Short
		
		
		backFlag = False
		
		path = Chr(34) & frmClient.BOPGamePath & Chr(34) & " ishost /" & Chr(34) & "a=" & frmClient.exposedIP & Chr(34) & " /" & Chr(34) & "n=host" & Chr(34) & " /" & Chr(34) & "skipintro" & Chr(34)
		
		
		Shell_Renamed(path)
		
		
		For i = 0 To lastsocket
			
			If Socket2(i).Connected Then
				Socket2(i).SendLen = Len("#@+%BOP" & Chr(3))
				Socket2(i).SendData = "#@+%BOP" & Chr(3)
			End If
		Next i
		
		GoSleepEX(1)
		
		frmClient.Socket1.SendLen = Len("^^^^" & "(P)" & frmClient.txtUID.Text & Chr(3))
		frmClient.Socket1.SendData = "^^^^" & "(P)" & frmClient.txtUID.Text & Chr(3)
		
		txtLaunchXVT.Enabled = False
		btnBOP.Enabled = False
		txtLaunchXWA.Enabled = False
		btnLeave.Enabled = False
		'btnLeave.Enabled = True
		btnBack.Enabled = True
		btnSend.Enabled = False
		frmClient.playing = True
		Exit Sub
Failed: 
		FileOpen(4, CurDir() & "\errorlog.txt", OpenMode.Append)
		PrintLine(4, "btnBOP_Click - " & Str(Err.Number) & " - " & Err.Description & " - frmHostGame")
		FileClose(4)
		Resume Next
		
		
	End Sub
	
	
	'UPGRADE_WARNING: Event cboPwd.CheckStateChanged may fire when form is initialized. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="88B12AE1-6DE0-48A0-86F1-60C0686C026A"'
	Private Sub cboPwd_CheckStateChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cboPwd.CheckStateChanged
		On Error GoTo Failed
		If cboPwd.CheckState = 1 Then txtPWD.Visible = True Else txtPWD.Visible = False
		Exit Sub
Failed: 
		FileOpen(4, CurDir() & "\errorlog.txt", OpenMode.Append)
		PrintLine(4, "cboPwd_click - " & Str(Err.Number) & " - " & Err.Description & " - frmHostGame")
		FileClose(4)
		Resume Next
		
		
	End Sub
	
	Private Sub frmHostGame_FormClosing(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
		Dim Cancel As Boolean = eventArgs.Cancel
		Dim UnloadMode As System.Windows.Forms.CloseReason = eventArgs.CloseReason
		On Error GoTo Failed
		If backFlag = False Then Cancel = 1
		Exit Sub
Failed: 
		FileOpen(4, CurDir() & "\errorlog.txt", OpenMode.Append)
		PrintLine(4, "form_QueryUnload - " & Str(Err.Number) & " - " & Err.Description & " - frmHostGame")
		FileClose(4)
		Resume Next
		
		
		eventArgs.Cancel = Cancel
	End Sub
	
	Private Sub keepalive_Tick(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles keepalive.Tick
		On Error GoTo Failed
		frmClient.Socket1.SendLen = Len("KALV" & frmClient.gameName & Chr(3))
		frmClient.Socket1.SendData = "KALV" & frmClient.gameName & Chr(3)
		Exit Sub
Failed: 
		FileOpen(4, CurDir() & "\errorlog.txt", OpenMode.Append)
		PrintLine(4, "keepalive_timer - " & Str(Err.Number) & " - " & Err.Description & " - frmHostGame")
		FileClose(4)
		Resume Next
		
		
	End Sub
	
	Private Sub Timer1_Tick(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles Timer1.Tick
		On Error GoTo Failed
		
		Dim cnt As Short
		Dim lstarraytemp() As String
		Dim lstarraysockettemp() As Short
		Dim j As Short
		Dim parsed As String
		Dim i As Short
		' loop through the list of players in room
		For j = 1 To lstArrayCount - 1
			'check to see that the player is still connected
			If Socket2(lstArraySocket(j)).Connected = False Then
				
				'if not connected then get the name of player
				parsed = lstArray(j)
				' clear the list of players
				lstPlayers.Items.Clear()
				' set the count to 0
				cnt = 0
				' redimention the temp arrays
				ReDim lstarraytemp(lstArrayCount)
				ReDim lstarraysockettemp(lstArrayCount)
				
				' loop through the list and re add everyone except the disconnected player
				For i = 0 To lstArrayCount - 1
					
					'if the disconnected player name does not equal the current name
					If parsed <> lstArray(i) Then
						'add the name back into the list
						lstPlayers.Items.Add(lstArray(i))
						'add the player info back to the array
						lstarraytemp(cnt) = lstArray(i)
						lstarraysockettemp(cnt) = lstArraySocket(i)
						'increment the counter
						cnt = cnt + 1
						
					End If
				Next i
				
				' set the array to equal the count (removed players not connected)
				lstArrayCount = cnt
				
				' decrement the number of sockets checked
				lastsocket = lastsocket - 1
				' loop through the list of elements
				For i = 0 To lstArrayCount - 1
					'copy from the temp array back into the arrays
					lstArray(i) = lstarraytemp(i)
					lstArraySocket(i) = lstarraysockettemp(i)
					
				Next i
				' update the game stats
				frmClient.Socket1.SendLen = Len("^++^" & Trim(Str(lstArrayCount)) & "/" & Trim(Str(frmClient.numberOfPlayers)) & " " & frmClient.game & " " & frmClient.gameName & Chr(3))
				frmClient.Socket1.SendData = "^++^" & Trim(Str(lstArrayCount)) & "/" & Trim(Str(frmClient.numberOfPlayers)) & " " & frmClient.game & " " & frmClient.gameName & Chr(3)
				
				
				
				
			End If
			
		Next j
		Exit Sub
Failed: 
		FileOpen(4, CurDir() & "\errorlog.txt", OpenMode.Append)
		PrintLine(4, "timer1_timer - " & Str(Err.Number) & " - " & Err.Description & " - frmHostGame")
		FileClose(4)
		Resume Next
		
		
		
	End Sub
	
	
	
	Private Sub btnBoot_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles btnBoot.Click
		On Error GoTo Failed
		Dim ok2boot As Short
		
		ok2boot = MsgBox("Are you sure you want to Boot player " & lstPlayers.Text & "?", MsgBoxStyle.YesNo + MsgBoxStyle.Question, "Really boot Player?")
		
		If ok2boot = 6 Then
			
			Socket2(selectedSocket).SendLen = Len("$&&$" & Chr(3))
			Socket2(selectedSocket).SendData = "$&&$" & Chr(3)
			
			btnBoot.Enabled = True
			
		End If
		Exit Sub
Failed: 
		FileOpen(4, CurDir() & "\errorlog.txt", OpenMode.Append)
		PrintLine(4, "btnboot_click - " & Str(Err.Number) & " - " & Err.Description & " - frmHostGame")
		FileClose(4)
		Resume Next
		
		
		
	End Sub
	
	'UPGRADE_WARNING: Event lstPlayers.SelectedIndexChanged may fire when form is initialized. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="88B12AE1-6DE0-48A0-86F1-60C0686C026A"'
	Private Sub lstPlayers_SelectedIndexChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles lstPlayers.SelectedIndexChanged
		
		On Error GoTo Failed
		If lstPlayers.Text <> "" And lstPlayers.Text <> frmClient.txtUID.Text Then
			selectedSocket = lstArraySocket(lstPlayers.SelectedIndex)
			btnBoot.Enabled = True
		End If
		Exit Sub
Failed: 
		FileOpen(4, CurDir() & "\errorlog.txt", OpenMode.Append)
		PrintLine(4, "lstPlayers_Click - " & Str(Err.Number) & " - " & Err.Description & " - frmHostGame")
		FileClose(4)
		Resume Next
		
		
	End Sub
	
	
	Private Sub btnBack_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles btnBack.Click
		On Error GoTo Failed
		backFlag = True
		
		frmClient.playing = False
		
		
		txtLaunchXVT.Enabled = True
		btnBOP.Enabled = True
		txtLaunchXWA.Enabled = True
		
		btnLeave.Enabled = True
		btnBack.Enabled = False
		
		frmClient.Socket1.SendLen = Len("^^^^" & "(H)" & frmClient.txtUID.Text & Chr(3))
		frmClient.Socket1.SendData = "^^^^" & "(H)" & frmClient.txtUID.Text & Chr(3)
		btnSend.Enabled = True
		Exit Sub
Failed: 
		FileOpen(4, CurDir() & "\errorlog.txt", OpenMode.Append)
		PrintLine(4, "btnBack_Click - " & Str(Err.Number) & " - " & Err.Description & " - frmHostGame")
		FileClose(4)
		Resume Next
		
		
	End Sub
	
	Private Sub btnLeave_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles btnLeave.Click
		On Error GoTo Failed
		Me.Close()
		Exit Sub
Failed: 
		FileOpen(4, CurDir() & "\errorlog.txt", OpenMode.Append)
		PrintLine(4, "btnLeave_Click - " & Str(Err.Number) & " - " & Err.Description & " - frmHostGame")
		FileClose(4)
		Resume Next
		
		
	End Sub
	
	Private Sub btnSend_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles btnSend.Click
		On Error GoTo Failed
		
		Dim i As Short
		Dim w As Short
		Dim parsed As String
		Dim wrapLines(10) As String
		
		
		If txtSend.Text <> "" Then
			
			For i = 0 To lastsocket
				
				If Socket2(i).Connected Then
					Socket2(i).SendLen = Len("MMMM" & "- " & frmClient.txtUID.Text & " - " & txtSend.Text & Chr(3))
					Socket2(i).SendData = "MMMM" & "- " & frmClient.txtUID.Text & " - " & txtSend.Text & Chr(3)
					
					
				End If
			Next i
			
			parsed = "- " & frmClient.txtUID.Text & " - " & txtSend.Text
			
			For w = 0 To Int(Len(parsed) / 60)
				
				wrapLines(w) = Mid(parsed, (w * 60) + 1, 60)
				
			Next w
			
			For w = Int(Len(parsed) / 60) To 0 Step -1
				newMessage(wrapLines(w))
			Next w
			
			txtSend.Text = ""
		End If
		Exit Sub
Failed: 
		FileOpen(4, CurDir() & "\errorlog.txt", OpenMode.Append)
		PrintLine(4, "btnSend - " & Str(Err.Number) & " - " & Err.Description & " - frmHostGame")
		FileClose(4)
		Resume Next
		
		
	End Sub
	
	Private Sub frmHostGame_Load(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles MyBase.Load
		
		On Error GoTo Failed
		Filter_Renamed = frmClient.getFilter()
		
		'UPGRADE_WARNING: Navigate2 was upgraded to Navigate and has a new behavior. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
		WebBrowser1.Navigate(New System.URI(CurDir() & "\gameroom.htm"))
		
		Dim i As Short
		backFlag = True
		For i = 0 To 100
			lstReplyarray(i) = ""
			lstArray(i) = ""
		Next i
		lstArrayCount = 0
		lastsocket = 0
		On Error GoTo errorhandler
		Me.Text = Trim(Str(lstArrayCount + 1)) & "/" & Trim(Str(frmClient.numberOfPlayers)) & " " & frmClient.game & " " & frmClient.gameName
		numsockets = 1
		For i = 1 To numsockets
			Socket1.Load(i)
			Socket1(i).AddressFamily = AF_INET
			Socket1(i).Protocol = IPPROTO_IP
			Socket1(i).SocketType = SOCK_STREAM
			Socket1(i).Blocking = False
			Socket1(i).LocalPort = 2303 + i
			Socket1(i).Action = SOCKET_LISTEN
			lastsocket = 0
			
		Next i
		Socket1.Load(i)
		Socket1(i).AddressFamily = AF_INET
		Socket1(i).Protocol = IPPROTO_IP
		Socket1(i).SocketType = SOCK_STREAM
		Socket1(i).Blocking = False
		Socket1(i).LocalPort = 1001
		Socket1(i).Action = SOCKET_LISTEN
		
		frmClient.Socket1.SendLen = Len("^^^^" & "(H)" & frmClient.txtUID.Text & Chr(3))
		frmClient.Socket1.SendData = "^^^^" & "(H)" & frmClient.txtUID.Text & Chr(3)
		
		lstArrayCount = 1
		lstArray(0) = frmClient.txtUID.Text
		lstPlayers.Items.Add(frmClient.txtUID.Text)
		If frmClient.XVTGamePath = "" Then
			optXVT.Visible = False
		End If
		
		If frmClient.BOPGamePath = "" Then
			optBop.Visible = False
		End If
		
		If frmClient.XWAGamePath = "" Then
			optXWA.Visible = False
		End If
		
		
		
		If frmClient.game = "XVT" Then
			optXVT.Checked = True
		ElseIf frmClient.game = "BOP" Then 
			optBop.Checked = True
		Else
			optXWA.Checked = True
		End If
		
		'does this in the gameroom configuration window
		'frmClient.Socket1.SendLen = Len("GRPL" + frmClient.gameName + chr$(30) + "Host: " + frmClient.txtuid.Text + chr$(3))
		'frmClient.Socket1.SendData = "GRPL" + frmClient.gameName + chr$(30) + "Host: " + frmClient.txtuid.Text + chr$(3)
		Exit Sub
errorhandler: 
		If CDbl(Str(Err.Number)) = 24048 Then
			MsgBox("Port " & Str(2303 + i) & " is already being used... Ports 2303 and 2304 are the two ports used for listening, at least one needs to be open", MsgBoxStyle.Exclamation + MsgBoxStyle.OKOnly, "Warning")
			Resume Next
		End If
		Exit Sub
Failed: 
		FileOpen(4, CurDir() & "\errorlog.txt", OpenMode.Append)
		PrintLine(4, "Form_Load - " & Str(Err.Number) & " - " & Err.Description & " - frmHostGame")
		FileClose(4)
		Resume Next
		
		
	End Sub
	
	'UPGRADE_WARNING: Event optXVT.CheckedChanged may fire when form is initialized. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="88B12AE1-6DE0-48A0-86F1-60C0686C026A"'
	Private Sub optXVT_CheckedChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles optXVT.CheckedChanged
		If eventSender.Checked Then
			
			On Error GoTo Failed
			txtLaunchXWA.Visible = False
			txtLaunchXVT.Visible = True
			btnBOP.Visible = False
			
			frmClient.game = "XVT"
			
			frmClient.Socket1.SendLen = Len("^++^" & Trim(Str(lstArrayCount)) & "/" & Trim(Str(frmClient.numberOfPlayers)) & " " & frmClient.game & " " & frmClient.gameName & Chr(3))
			frmClient.Socket1.SendData = "^++^" & Trim(Str(lstArrayCount)) & "/" & Trim(Str(frmClient.numberOfPlayers)) & " " & frmClient.game & " " & frmClient.gameName & Chr(3)
			Exit Sub
Failed: 
			FileOpen(4, CurDir() & "\errorlog.txt", OpenMode.Append)
			PrintLine(4, "optXVT_Click - " & Str(Err.Number) & " - " & Err.Description & " - frmHostGame")
			FileClose(4)
			Resume Next
			
			
		End If
	End Sub
	
	'UPGRADE_WARNING: Event optXWA.CheckedChanged may fire when form is initialized. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="88B12AE1-6DE0-48A0-86F1-60C0686C026A"'
	Private Sub optXWA_CheckedChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles optXWA.CheckedChanged
		If eventSender.Checked Then
			On Error GoTo Failed
			txtLaunchXWA.Visible = True
			txtLaunchXVT.Visible = False
			btnBOP.Visible = False
			
			frmClient.game = "XWA"
			
			frmClient.Socket1.SendLen = Len("^++^" & Trim(Str(lstArrayCount)) & "/" & Trim(Str(frmClient.numberOfPlayers)) & " " & frmClient.game & " " & frmClient.gameName & Chr(3))
			frmClient.Socket1.SendData = "^++^" & Trim(Str(lstArrayCount)) & "/" & Trim(Str(frmClient.numberOfPlayers)) & " " & frmClient.game & " " & frmClient.gameName & Chr(3)
			Exit Sub
Failed: 
			FileOpen(4, CurDir() & "\errorlog.txt", OpenMode.Append)
			PrintLine(4, "optXWA_Click - " & Str(Err.Number) & " - " & Err.Description & " - frmHostGame")
			FileClose(4)
			Resume Next
			
			
		End If
	End Sub
	'UPGRADE_WARNING: Event optBOP.CheckedChanged may fire when form is initialized. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="88B12AE1-6DE0-48A0-86F1-60C0686C026A"'
	Private Sub optBOP_CheckedChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles optBOP.CheckedChanged
		If eventSender.Checked Then
			On Error GoTo Failed
			txtLaunchXWA.Visible = False
			txtLaunchXVT.Visible = False
			btnBOP.Visible = True
			
			frmClient.game = "BOP"
			
			frmClient.Socket1.SendLen = Len("^++^" & Trim(Str(lstArrayCount)) & "/" & Trim(Str(frmClient.numberOfPlayers)) & " " & frmClient.game & " " & frmClient.gameName & Chr(3))
			frmClient.Socket1.SendData = "^++^" & Trim(Str(lstArrayCount)) & "/" & Trim(Str(frmClient.numberOfPlayers)) & " " & frmClient.game & " " & frmClient.gameName & Chr(3)
			Exit Sub
Failed: 
			FileOpen(4, CurDir() & "\errorlog.txt", OpenMode.Append)
			PrintLine(4, "optBop_Click - " & Str(Err.Number) & " - " & Err.Description & " - frmHostGame")
			FileClose(4)
			Resume Next
			
			
		End If
	End Sub
	
	
	
	Private Sub txtLaunchXWA_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles txtLaunchXWA.Click
		
		On Error GoTo Failed
		Dim path As String
		Dim i As Short
		
		backFlag = False
		
		
		path = Chr(34) & frmClient.XWAGamePath & Chr(34) & " ishost /" & Chr(34) & "a=" & frmClient.exposedIP & Chr(34) & " /" & Chr(34) & "n=host" & Chr(34) & " /" & Chr(34) & "skipintro" & Chr(34)
		
		Shell_Renamed(path)
		
		
		For i = 0 To lastsocket
			
			If Socket2(i).Connected Then
				Socket2(i).SendLen = Len("#@+%XWA" & Chr(3))
				Socket2(i).SendData = "#@+%XWA" & Chr(3)
			End If
		Next i
		
		GoSleepEX(1)
		
		frmClient.Socket1.SendLen = Len("^^^^" & "(P)" & frmClient.txtUID.Text & Chr(3))
		frmClient.Socket1.SendData = "^^^^" & "(P)" & frmClient.txtUID.Text & Chr(3)
		
		txtLaunchXVT.Enabled = False
		txtLaunchXWA.Enabled = False
		btnLeave.Enabled = False
		'btnLeave.Enabled = True
		btnBack.Enabled = True
		btnSend.Enabled = False
		frmClient.playing = True
		Exit Sub
Failed: 
		FileOpen(4, CurDir() & "\errorlog.txt", OpenMode.Append)
		PrintLine(4, "txtLaunchXWA - " & Str(Err.Number) & " - " & Err.Description & " - frmHostGame")
		FileClose(4)
		Resume Next
		
		
	End Sub
	
	Private Sub txtSend_KeyPress(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyPressEventArgs) Handles txtSend.KeyPress
		Dim KeyAscii As Short = Asc(eventArgs.KeyChar)
		On Error GoTo Failed
		If KeyAscii = Asc(Chr(3)) Then KeyAscii = 0
		GoTo EventExitSub
Failed: 
		FileOpen(4, CurDir() & "\errorlog.txt", OpenMode.Append)
		PrintLine(4, "txtSend_Keypress - " & Str(Err.Number) & " - " & Err.Description & " - frmHostGame")
		FileClose(4)
		Resume Next
		
		
EventExitSub: 
		eventArgs.KeyChar = Chr(KeyAscii)
		If KeyAscii = 0 Then
			eventArgs.Handled = True
		End If
	End Sub
	Private Sub Socket1_AcceptEvent(ByVal eventSender As System.Object, ByVal eventArgs As AxSocketWrenchCtrl._DSocketWrenchEvents_AcceptEvent) Handles Socket1.AcceptEvent
		Dim index As Short = Socket1.GetIndex(eventSender)
		
		On Error GoTo Failed
		
		Dim i As Short
		For i = 0 To lastsocket
			If Not Socket2(i).Connected Then Exit For
		Next i
		If i > lastsocket Then
			lastsocket = lastsocket + 1 : i = lastsocket
			Socket2.Load(i)
		End If
		
		Socket2(i).AddressFamily = AF_INET
		Socket2(i).Protocol = IPPROTO_IP
		Socket2(i).SocketType = SOCK_STREAM
		Socket2(i).Binary = True
		Socket2(i).BufferSize = 1024
		Socket2(i).Blocking = False
		Socket2(i).Accept = eventArgs.SocketId
		
		If cboPwd.CheckState = 1 Then
			Socket2(i).SendLen = Len("GRPW" & txtPWD.Text & Chr(3))
			Socket2(i).SendData = "GRPW" & txtPWD.Text & Chr(3)
		Else
			Socket2(i).SendLen = Len("GRPW" & Chr(3))
			Socket2(i).SendData = "GRPW" & Chr(3)
		End If
		
		Exit Sub
Failed: 
		FileOpen(4, CurDir() & "\errorlog.txt", OpenMode.Append)
		PrintLine(4, "socket1.accept - " & Str(Err.Number) & " - " & Err.Description & " - frmHostGame")
		FileClose(4)
		Resume Next
		
		
		
	End Sub
	Private Sub Socket2_ReadEvent(ByVal eventSender As System.Object, ByVal eventArgs As AxSocketWrenchCtrl._DSocketWrenchEvents_ReadEvent) Handles Socket2.ReadEvent
		Dim index As Short = Socket2.GetIndex(eventSender)
		
		On Error GoTo Failed
		
		Dim strData As String
		Dim first4 As String
		Dim parsed As String
		Dim cnt As Short
		Dim wrapLines(10) As String
		
		Dim i As Short
		Dim w As Short
		Dim B As Short
		Dim numMsgs As Short
		Dim msgs(100) As String
		Dim nextMsgStart As Short
		
		Dim lstarraytemp() As String
		Dim lstarraysockettemp() As Short
		
		Dim GRPLString As String
		
		
		
		nextMsgStart = 1
		numMsgs = 0
		
		Socket2(index).Read(strData, eventArgs.DataLength)
		
		
		For B = 1 To Len(strData)
			
			If Mid(strData, B, 1) = Chr(3) Then
				msgs(numMsgs) = Mid(strData, nextMsgStart, B - nextMsgStart)
				numMsgs = numMsgs + 1
				nextMsgStart = B + 1
			End If
		Next B
		
		For B = 0 To numMsgs - 1
			
			strData = msgs(B)
			
			first4 = Mid(strData, 1, 4)
			
			parsed = Mid(strData, 5)
			
			Select Case first4
				
				Case "$$$$"
					If frmClient.cboMute.CheckState <> 1 And btnBack.Enabled = False Then frmClient.PlayWave(My.Application.Info.DirectoryPath & "/joingameroom.wav")
					
					parsed = Mid(strData, 5)
					
					lstPlayers.Items.Add(parsed)
					lstArray(lstArrayCount) = parsed
					lstArraySocket(lstArrayCount) = index
					lstArrayCount = lstArrayCount + 1
					
					For i = 0 To lstArrayCount - 1
						
						Socket2(index).SendLen = Len("$$$$" & lstArray(i) & Chr(3))
						Socket2(index).SendData = "$$$$" & lstArray(i) & Chr(3)
						
						
						'GoSleepEx 0.1
					Next i
					
					For i = 0 To lastsocket
						
						If Socket2(i).Connected And i <> index Then
							Socket2(i).SendLen = Len(strData & Chr(3))
							Socket2(i).SendData = strData & Chr(3)
							
						End If
					Next i
					
					frmClient.Socket1.SendLen = Len("^++^" & Trim(Str(lstArrayCount)) & "/" & Trim(Str(frmClient.numberOfPlayers)) & " " & frmClient.game & " " & frmClient.gameName & Chr(3))
					frmClient.Socket1.SendData = "^++^" & Trim(Str(lstArrayCount)) & "/" & Trim(Str(frmClient.numberOfPlayers)) & " " & frmClient.game & " " & frmClient.gameName & Chr(3)
					
					GRPLString = "Host:" & " " & frmClient.txtUID.Text & ", "
					
					For i = 1 To lstArrayCount - 1
						GRPLString = GRPLString & ", " & lstArray(i)
					Next i
					
					
					frmClient.Socket1.SendLen = Len("GRPL" & frmClient.gameName & Chr(30) & GRPLString & Chr(3))
					frmClient.Socket1.SendData = "GRPL" & frmClient.gameName & Chr(30) & GRPLString & Chr(3)
					
					
					
				Case "&&&&"
					If frmClient.cboMute.CheckState <> 1 And btnBack.Enabled = False Then frmClient.PlayWave(My.Application.Info.DirectoryPath & "/leavegameroom.wav")
					
					For i = 0 To lastsocket
						
						If Socket2(i).Connected Then
							Socket2(i).SendLen = Len("&&&&" & parsed & Chr(3))
							Socket2(i).SendData = "&&&&" & parsed & Chr(3)
						End If
					Next i
					
					lstPlayers.Items.Clear()
					cnt = 0
					ReDim lstarraytemp(lstArrayCount)
					ReDim lstarraysockettemp(lstArrayCount)
					
					
					For i = 0 To lstArrayCount - 1
						
						
						If parsed <> lstArray(i) Then
							
							lstPlayers.Items.Add(lstArray(i))
							lstarraytemp(cnt) = lstArray(i)
							lstarraysockettemp(cnt) = lstArraySocket(i)
							cnt = cnt + 1
							
						End If
						
						
					Next i
					
					lstArrayCount = cnt
					For i = 0 To lstArrayCount - 1
						
						lstArray(i) = lstarraytemp(i)
						lstArraySocket(i) = lstarraysockettemp(i)
						
					Next i
					
					
					'lstArrayCount = lstArrayCount - 1
					
					frmClient.Socket1.SendLen = Len("^++^" & Trim(Str(lstArrayCount)) & "/" & Trim(Str(frmClient.numberOfPlayers)) & " " & frmClient.game & " " & frmClient.gameName & Chr(3))
					frmClient.Socket1.SendData = "^++^" & Trim(Str(lstArrayCount)) & "/" & Trim(Str(frmClient.numberOfPlayers)) & " " & frmClient.game & " " & frmClient.gameName & Chr(3)
					
					GRPLString = "Host:" & " " & frmClient.txtUID.Text & ", "
					
					For i = 1 To lstArrayCount - 1
						GRPLString = GRPLString & ", " & lstArray(i)
					Next i
					
					
					frmClient.Socket1.SendLen = Len("GRPL" & frmClient.gameName & Chr(30) & GRPLString & Chr(3))
					frmClient.Socket1.SendData = "GRPL" & frmClient.gameName & Chr(30) & GRPLString & Chr(3)
					
					' Case "#@+%":
					
					
					
					
					
					
				Case "MMMM"
					
					
					
					For i = 0 To lastsocket
						
						If Socket2(i).Connected Then
							Socket2(i).SendLen = Len(strData & Chr(3))
							Socket2(i).SendData = strData & Chr(3)
							
						End If
					Next i
					
					
					For w = 0 To Int(Len(parsed) / 60)
						
						wrapLines(w) = Mid(parsed, (w * 60) + 1, 60)
						
					Next w
					
					For w = Int(Len(parsed) / 60) To 0 Step -1
						newMessage(wrapLines(w))
					Next w
					
			End Select
			
		Next B
		
		Me.Text = Trim(Str(lstArrayCount)) & "/" & Trim(Str(frmClient.numberOfPlayers)) & " " & frmClient.game & " " & frmClient.gameName
		Exit Sub
Failed: 
		FileOpen(4, CurDir() & "\errorlog.txt", OpenMode.Append)
		PrintLine(4, "socket2_Read - " & Str(Err.Number) & " - " & Err.Description & " - frmHostGame")
		FileClose(4)
		Resume Next
		
	End Sub
	
	Private Sub newMessage(ByRef msg As String)
		
		On Error GoTo Failed
		
		Dim i As Short
		
		For i = 0 To frmClient.FilterCount
			
			If frmClient.cboFilterOff.CheckState <> 1 Then
				
				msg = Replace(msg, Filter_Renamed(i), "Smurf",  ,  , CompareMethod.Text)
				
			End If
			
		Next i
		
		
		lstReply.Items.Clear()
		
		For i = 99 To 0 Step -1
			
			lstReplyarray(i + 1) = lstReplyarray(i)
			
		Next i
		
		lstReplyarray(0) = msg
		For i = 0 To 100
			lstReply.Items.Add(lstReplyarray(i))
		Next i
		
		'If Not focusFlag Then Beep
		
		Exit Sub
Failed: 
		FileOpen(4, CurDir() & "\errorlog.txt", OpenMode.Append)
		PrintLine(4, "NewMessage - " & Str(Err.Number) & " - " & Err.Description & " - frmHostGame")
		FileClose(4)
		Resume Next
		
		
		
	End Sub
	Private Sub Socket2_DisconnectEvent(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles Socket2.DisconnectEvent
		Dim index As Short = Socket2.GetIndex(eventSender)
		On Error GoTo Failed
		Socket2(index).Action = SOCKET_CLOSE
		Exit Sub
Failed: 
		FileOpen(4, CurDir() & "\errorlog.txt", OpenMode.Append)
		PrintLine(4, "Socket2_Disconnect - " & Str(Err.Number) & " - " & Err.Description & " - frmHostGame")
		FileClose(4)
		Resume Next
		
		
	End Sub
	
	Private Sub frmHostGame_FormClosed(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
		On Error GoTo Failed
		Dim i As Short
		Dim temp As Short
		
		
		If btnBack.Enabled Then Call btnBack_Click(btnBack, New System.EventArgs())
		
		frmClient.Socket1.SendLen = Len("%%%%" & frmClient.gameName & Chr(3))
		frmClient.Socket1.SendData = "%%%%" & frmClient.gameName & Chr(3)
		
		'GoSleepEx 0.3
		
		For i = 0 To lastsocket
			
			If Socket2(i).Connected Then
				Socket2(i).SendLen = Len("%&&%" & Chr(3))
				Socket2(i).SendData = "%&&%" & Chr(3)
				
			End If
		Next i
		
		GoSleep(0.3)
		
		For i = 0 To numsockets + 1
			If Socket1(0).Listening Then Socket1(0).Action = SOCKET_CLOSE
		Next i
		
		For i = 0 To lastsocket
			If Socket2(i).Connected Then Socket2(i).Action = SOCKET_CLOSE
		Next i
		
		
		
		
		
		
		frmClient.btnHost.Enabled = True
		frmClient.btnAway.Enabled = True
		frmClient.lstGameRooms.Enabled = True
		
		'GoSleepEx 0.3
		
		frmClient.Socket1.SendLen = Len("^^^^" & "(L)" & frmClient.txtUID.Text & Chr(3))
		frmClient.Socket1.SendData = "^^^^" & "(L)" & frmClient.txtUID.Text & Chr(3)
		
		
		Exit Sub
Failed: 
		FileOpen(4, CurDir() & "\errorlog.txt", OpenMode.Append)
		PrintLine(4, "Foram_UnLoad - " & Str(Err.Number) & " - " & Err.Description & " - frmHostGame")
		FileClose(4)
		Resume Next
		
	End Sub
	
	Private Sub txtLaunchXVT_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles txtLaunchXVT.Click
		
		On Error GoTo Failed
		Dim i As Short
		
		backFlag = False
		
		
		
		FileOpen(1, CurDir() & "\hostgamepath.bat", OpenMode.Output)
		PrintLine(1, Chr(34) & frmClient.XVTGamePath & Chr(34) & " ishost /" & Chr(34) & "a=" & frmClient.exposedIP & Chr(34) & " /" & Chr(34) & "n=host" & Chr(34) & Chr(13) & "exit")
		FileClose(1)
		
		Shell_Renamed(CurDir() & "\hostGamePath.bat")
		
		For i = 0 To lastsocket
			
			If Socket2(i).Connected Then
				Socket2(i).SendLen = Len("#@+%XVT" & Chr(3))
				Socket2(i).SendData = "#@+%XVT" & Chr(3)
			End If
		Next i
		
		frmClient.Socket1.SendLen = Len("^^^^" & "(P)" & frmClient.txtUID.Text & Chr(3))
		frmClient.Socket1.SendData = "^^^^" & "(P)" & frmClient.txtUID.Text & Chr(3)
		
		txtLaunchXVT.Enabled = False
		txtLaunchXWA.Enabled = False
		btnLeave.Enabled = False
		btnBack.Enabled = True
		btnSend.Enabled = False
		frmClient.playing = True
		
		
		
		Exit Sub
Failed: 
		FileOpen(4, CurDir() & "\errorlog.txt", OpenMode.Append)
		PrintLine(4, "txtLaunchXvT_Click - " & Str(Err.Number) & " - " & Err.Description & " - frmHostGame")
		FileClose(4)
		Resume Next
		
	End Sub
	
	'UPGRADE_NOTE: Shell was upgraded to Shell_Renamed. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="A9E4979A-37FA-4718-9994-97DD76ED70A7"'
	Function Shell_Renamed(ByRef Program As String, Optional ByRef ShowCmd As Integer = AppWinStyle.NormalNoFocus, Optional ByVal WorkDir As Object = Nothing) As Integer
		
		On Error GoTo Failed
		Dim FirstSpace, Slash As Short
		
		If VB.Left(Program, 1) = """" Then
			FirstSpace = InStr(2, Program, """")
			
			
			If FirstSpace <> 0 Then
				Program = Mid(Program, 2, FirstSpace - 2) & Mid(Program, FirstSpace + 1)
				FirstSpace = FirstSpace - 1
			End If
			
		Else
			FirstSpace = InStr(Program, " ")
		End If
		
		If FirstSpace = 0 Then FirstSpace = Len(Program) + 1
		
		'UPGRADE_NOTE: IsMissing() was changed to IsNothing(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="8AE1CB93-37AB-439A-A4FF-BE3B6760BB23"'
		If IsNothing(WorkDir) Then
			
			For Slash = FirstSpace - 1 To 1 Step -1
				If Mid(Program, Slash, 1) = "\" Then Exit For
			Next 
			
			If Slash = 0 Then
				'UPGRADE_WARNING: Couldn't resolve default property of object WorkDir. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				WorkDir = CurDir()
			ElseIf Slash = 1 Or Mid(Program, Slash - 1, 1) = ":" Then 
				'UPGRADE_WARNING: Couldn't resolve default property of object WorkDir. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				WorkDir = VB.Left(Program, Slash)
			Else
				'UPGRADE_WARNING: Couldn't resolve default property of object WorkDir. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				WorkDir = VB.Left(Program, Slash - 1)
			End If
			
		End If
		
		'UPGRADE_WARNING: Couldn't resolve default property of object WorkDir. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		Shell_Renamed = ShellExecute(0, vbNullString, VB.Left(Program, FirstSpace - 1), LTrim(Mid(Program, FirstSpace)), WorkDir, ShowCmd)
		If Shell_Renamed < 32 Then Shell(Program, ShowCmd) 'To raise Error
		
		Exit Function
Failed: 
		FileOpen(4, CurDir() & "\errorlog.txt", OpenMode.Append)
		PrintLine(4, "shell - " & Str(Err.Number) & " - " & Err.Description & " - frmHostGame")
		FileClose(4)
		Resume Next
		
	End Function
End Class