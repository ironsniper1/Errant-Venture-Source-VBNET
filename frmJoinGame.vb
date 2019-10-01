Option Strict Off
Option Explicit On
Imports VB = Microsoft.VisualBasic
Friend Class frmJoinGame
	Inherits System.Windows.Forms.Form
	
	Private Declare Function ShellExecute Lib "shell32.dll"  Alias "ShellExecuteA"(ByVal hwnd As Integer, ByVal lpOperation As String, ByVal lpFile As String, ByVal lpParameters As String, ByVal lpDirectory As String, ByVal nShowCmd As Integer) As Integer
	
	Private lstReplyarray(100) As String
	Private lstArray(100) As String
	Private lstArrayCount As Short
	Private remPort As Integer
	Private rport(3) As String
	Private launchedGame As String
	
	Private killed As Boolean
	
	Private backFlag As Boolean
	
	'UPGRADE_NOTE: Filter was upgraded to Filter_Renamed. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="A9E4979A-37FA-4718-9994-97DD76ED70A7"'
	Private Filter_Renamed() As String
	
	
	
	Private Sub btnBack_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles btnBack.Click
		
		On Error GoTo Failed
		
		btnLeave.Enabled = True
		btnBack.Enabled = False
		'btnIPIN.Enabled = False
		btnSend.Enabled = True
		backFlag = True
		
		frmClient.playing = False
		
		frmClient.Socket1.SendLen = Len("^^^^" & "(G)" & frmClient.txtUID.Text & Chr(3))
		frmClient.Socket1.SendData = "^^^^" & "(G)" & frmClient.txtUID.Text & Chr(3)
		Exit Sub
Failed: 
		FileOpen(4, CurDir() & "\errorlog.txt", OpenMode.Append)
		PrintLine(4, "btnBack_click - " & Str(Err.Number) & " - " & Err.Description & " - frmJoinGame")
		FileClose(4)
		Resume Next
		
	End Sub
	
	Private Sub btnIPIN_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles btnIPIN.Click
		
		On Error GoTo Failed
		
		Dim path As String
		backFlag = False
		btnBack.Enabled = True
		frmClient.playing = True
		
		
		
		If launchedGame = "XWA" Then
			
			
			path = Chr(34) & frmClient.XWAGamePath & Chr(34) & " isclient /" & Chr(34) & "a=" & Socket1.HostAddress & Chr(34) & " /" & Chr(34) & "n=client" & Chr(34) & " /" & Chr(34) & "skipintro" & Chr(34)
			
			
			Shell_Renamed(path)
			
		ElseIf launchedGame = "BOP" Then 
			
			
			FileOpen(1, CurDir() & "\joingamepath.bat", OpenMode.Output)
			
			PrintLine(1, Chr(34) & frmClient.BOPGamePath & Chr(34) & " isclient /" & Chr(34) & "a=" & Socket1.HostAddress & Chr(34) & " /" & Chr(34) & "n=client" & Chr(34))
			
			FileClose(1)
			
			Shell_Renamed(CurDir() & "\joinGamePath.bat")
			
		Else
			
			FileOpen(1, CurDir() & "\joingamepath.bat", OpenMode.Output)
			
			PrintLine(1, Chr(34) & frmClient.XVTGamePath & Chr(34) & " isclient /" & Chr(34) & "a=" & Socket1.HostAddress & Chr(34) & " /" & Chr(34) & "n=client" & Chr(34))
			
			FileClose(1)
			
			Shell_Renamed(CurDir() & "\joinGamePath.bat")
			
		End If
		Exit Sub
Failed: 
		FileOpen(4, CurDir() & "\errorlog.txt", OpenMode.Append)
		PrintLine(4, "btnIPIN_Click - " & Str(Err.Number) & " - " & Err.Description & " - frmJoinGame")
		FileClose(4)
		Resume Next
		
	End Sub
	
	Private Sub btnLeave_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles btnLeave.Click
		On Error GoTo Failed
		Me.Close()
		Exit Sub
Failed: 
		FileOpen(4, CurDir() & "\errorlog.txt", OpenMode.Append)
		PrintLine(4, "btnLeave_Click - " & Str(Err.Number) & " - " & Err.Description & " - frmJoinGame")
		FileClose(4)
		Resume Next
		
	End Sub
	
	Private Sub Socket1_ReadEvent(ByVal eventSender As System.Object, ByVal eventArgs As AxSocketWrenchCtrl._DSocketWrenchEvents_ReadEvent) Handles Socket1.ReadEvent
		On Error GoTo Failed
		Dim strBuffer As String
		Dim first4 As String
		Dim parsed As String
		Dim cnt As Short
		Dim lstarraytemp() As String
		
		Dim wrapLines(10) As String
		
		
		Dim B As Short
		Dim numMsgs As Short
		Dim msgs(100) As String
		Dim nextMsgStart As Short
		Dim w As Short
		
		Dim path As String
		
		Dim i As Short
		
		Dim tempPassword As String
		tempPassword = " "
		
		nextMsgStart = 1
		numMsgs = 0
		
		Socket1.Read(strBuffer, eventArgs.DataLength)
		
		For B = 1 To Len(strBuffer)
			
			If Mid(strBuffer, B, 1) = Chr(3) Then
				msgs(numMsgs) = Mid(strBuffer, nextMsgStart, B - nextMsgStart)
				numMsgs = numMsgs + 1
				nextMsgStart = B + 1
			End If
		Next B
		
		For B = 0 To numMsgs - 1
			
			strBuffer = msgs(B)
			
			first4 = Mid(strBuffer, 1, 4)
			
			parsed = Mid(strBuffer, 5)
			
			
			Select Case first4
				
				Case "%&&%"
					
					killed = True
					Me.Close()
					
					
				Case "$$$$"
					
					
					
					If frmClient.cboMute.CheckState <> 1 And btnBack.Enabled = False Then frmClient.PlayWave(My.Application.Info.DirectoryPath & "/joingameroom.wav")
					
					
					lstPlayers.Items.Add(parsed)
					lstArray(lstArrayCount) = parsed
					lstArrayCount = lstArrayCount + 1
					
					Me.Text = Trim(Str(lstArrayCount)) & "/" & Trim(Str(frmClient.numberOfPlayers)) & " " & frmClient.game & " " & frmClient.gameName
					
					
					
				Case "&&&&"
					If frmClient.cboMute.CheckState <> 1 And btnBack.Enabled = False Then frmClient.PlayWave(My.Application.Info.DirectoryPath & "/leavegameroom.wav")
					
					lstPlayers.Items.Clear()
					cnt = 0
					ReDim lstarraytemp(lstArrayCount)
					
					
					For i = 0 To lstArrayCount - 1
						
						
						If parsed <> lstArray(i) Then
							
							lstPlayers.Items.Add(lstArray(i))
							lstarraytemp(cnt) = lstArray(i)
							cnt = cnt + 1
							
						End If
						
						
					Next i
					
					lstArrayCount = cnt
					For i = 0 To lstArrayCount - 1
						
						lstArray(i) = lstarraytemp(i)
						
					Next i
					
				Case "$&&$"
					
					backFlag = True
					
					Me.Close()
					
					MsgBox("The Host has removed you from the Gameroom", MsgBoxStyle.OKOnly, "Bye")
					
					
					
				Case "#@+%"
					
					PlayASound(My.Application.Info.DirectoryPath & "\" & "launch.wav")
					frmClient.playing = True
					
					launchedGame = Mid(parsed, 1, 3)
					
					If Mid(parsed, 1, 3) = "XWA" Then
						
						
						path = Chr(34) & frmClient.XWAGamePath & Chr(34) & " isclient /" & Chr(34) & "a=" & Socket1.HostAddress & Chr(34) & " /" & Chr(34) & "n=client" & Chr(34) & " /" & Chr(34) & "skipintro" & Chr(34)
						
						
						Shell_Renamed(path)
						
					ElseIf Mid(parsed, 1, 3) = "BOP" Then 
						
						
						FileOpen(1, CurDir() & "\joingamepath.bat", OpenMode.Output)
						
						PrintLine(1, Chr(34) & frmClient.BOPGamePath & Chr(34) & " isclient /" & Chr(34) & "a=" & Socket1.HostAddress & Chr(34) & " /" & Chr(34) & "n=client" & Chr(34) & Chr(13) & "exit")
						
						FileClose(1)
						
						Shell_Renamed(CurDir() & "\joinGamePath.bat")
						
					Else
						
						FileOpen(1, CurDir() & "\joingamepath.bat", OpenMode.Output)
						
						PrintLine(1, Chr(34) & frmClient.XVTGamePath & Chr(34) & " isclient /" & Chr(34) & "a=" & Socket1.HostAddress & Chr(34) & " /" & Chr(34) & "n=client" & Chr(34) & Chr(13) & "exit")
						
						FileClose(1)
						
						Shell_Renamed(CurDir() & "\joinGamePath.bat")
						
					End If
					
					'btnIPIN.Enabled = True
					
					backFlag = False
					
					
					frmClient.Socket1.SendLen = Len("^^^^" & "(P)" & frmClient.txtUID.Text & Chr(3))
					frmClient.Socket1.SendData = "^^^^" & "(P)" & frmClient.txtUID.Text & Chr(3)
					
					btnLeave.Enabled = False
					btnBack.Enabled = True
					btnSend.Enabled = False
					
				Case "MMMM"
					
					
					For w = 0 To Int(Len(parsed) / 60)
						
						wrapLines(w) = Mid(parsed, (w * 60) + 1, 60)
						
					Next w
					
					For w = Int(Len(parsed) / 60) To 0 Step -1
						newMessage(wrapLines(w))
					Next w
					
				Case "GRPW"
					
					If parsed <> "" Then
						
						Do While tempPassword = " "
							tempPassword = InputBox("The Host requires a password to join this gameroom", "Enter Password", " ")
						Loop 
						
						If tempPassword <> parsed Then
							MsgBox("Bad Password", MsgBoxStyle.OKOnly + MsgBoxStyle.Critical, "Incorrect Password")
							Call btnLeave_Click(btnLeave, New System.EventArgs())
							Exit Sub
						End If
					End If
					Timer1.Enabled = True
					
					
					
			End Select
		Next B
		
		Me.Text = Trim(Str(lstArrayCount)) & "/" & Trim(Str(frmClient.numberOfPlayers)) & " " & frmClient.game & " " & frmClient.gameName
		Exit Sub
Failed: 
		FileOpen(4, CurDir() & "\errorlog.txt", OpenMode.Append)
		PrintLine(4, "socket1_Read - " & Str(Err.Number) & " - " & Err.Description & " - frmJoinGame")
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
		
		Exit Sub
Failed: 
		FileOpen(4, CurDir() & "\errorlog.txt", OpenMode.Append)
		PrintLine(4, "newmessage - " & Str(Err.Number) & " - " & Err.Description & " - frmJoinGame")
		FileClose(4)
		Resume Next
		
		
		
	End Sub
	
	
	Private Sub timerconnection_Tick(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles timerconnection.Tick
		On Error GoTo Failed
		If Not Socket1.Connected Then
			MsgBox("The Connection to the host has been terminated", MsgBoxStyle.Exclamation + MsgBoxStyle.OKOnly, "Lost Connection")
			Me.Close()
			
		End If
		Exit Sub
Failed: 
		FileOpen(4, CurDir() & "\errorlog.txt", OpenMode.Append)
		PrintLine(4, "timerconnection_Timer - " & Str(Err.Number) & " - " & Err.Description & " - frmJoinGame")
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
		PrintLine(4, "txtSend_Keypress - " & Str(Err.Number) & " - " & Err.Description & " - frmJoinGame")
		FileClose(4)
		Resume Next
		
EventExitSub: 
		eventArgs.KeyChar = Chr(KeyAscii)
		If KeyAscii = 0 Then
			eventArgs.Handled = True
		End If
	End Sub
	
	
	
	Private Sub frmJoinGame_FormClosing(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
		Dim Cancel As Boolean = eventArgs.Cancel
		Dim UnloadMode As System.Windows.Forms.CloseReason = eventArgs.CloseReason
		On Error GoTo Failed
		If backFlag = False Then Cancel = 1
		Exit Sub
Failed: 
		FileOpen(4, CurDir() & "\errorlog.txt", OpenMode.Append)
		PrintLine(4, "Form_QueryUnload - " & Str(Err.Number) & " - " & Err.Description & " - frmJoinGame")
		FileClose(4)
		Resume Next
		eventArgs.Cancel = Cancel
	End Sub
	Private Sub frmJoinGame_Load(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles MyBase.Load
		
		On Error GoTo Failed
		Filter_Renamed = frmClient.getFilter()
		
		'UPGRADE_WARNING: Navigate2 was upgraded to Navigate and has a new behavior. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
		WebBrowser1.Navigate(New System.URI(CurDir() & "\gameroom.htm"))
		
		rport(0) = "1001"
		rport(1) = "2303"
		rport(2) = "2304"
		
		backFlag = True
		Dim i As Short
		
		For i = 0 To 100
			lstReplyarray(i) = ""
			lstArray(i) = ""
		Next i
		lstArrayCount = 0
		
		remPort = 1
		
		Socket1.AddressFamily = AF_INET
		Socket1.Protocol = IPPROTO_IP
		Socket1.SocketType = SOCK_STREAM
		Socket1.Binary = False
		Socket1.Blocking = False
		Socket1.BufferSize = 1024
		lstArrayCount = 0
		'focusFlag = True
		killed = False
		
		
		Dim strng As String
		
		lstArrayCount = 0
		
		strng = Trim(frmClient.txtUID.Text)
		
		' On Error GoTo Failed
		Socket1.HostName = Trim(frmClient.GameHost)
		
		
		Socket1.RemotePort = 1001
		Socket1.Action = SOCKET_CONNECT
		
		'GoSleepEx 0.1
		
		
		frmClient.Socket1.SendLen = Len("^^^^" & "(G)" & frmClient.txtUID.Text & Chr(3))
		frmClient.Socket1.SendData = "^^^^" & "(G)" & frmClient.txtUID.Text & Chr(3)
		
		
		
		'GoSleepEx 2
		
		Exit Sub
		
Failed: 
		FileOpen(4, CurDir() & "\errorlog.txt", OpenMode.Append)
		PrintLine(4, "form_Load - " & Str(Err.Number) & " - " & Err.Description & " - frmJoinGame")
		FileClose(4)
		Resume Next
		
		
	End Sub
	Private Sub btnSend_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles btnSend.Click
		
		On Error GoTo Failed
		Dim parse As String
		
		
		If txtSend.Text <> "" Then
			
			parse = "MMMM" & "- " & frmClient.txtUID.Text & " - " & txtSend.Text
			
			
			Socket1.SendLen = Len(parse & Chr(3))
			Socket1.SendData = parse & Chr(3)
			txtSend.Text = ""
		End If
		Exit Sub
Failed: 
		FileOpen(4, CurDir() & "\errorlog.txt", OpenMode.Append)
		PrintLine(4, "btnSend_Click - " & Str(Err.Number) & " - " & Err.Description & " - frmJoinGame")
		FileClose(4)
		Resume Next
		
	End Sub
	
	Sub frmJoinGame_FormClosed(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
		
		On Error GoTo Failed
		If btnBack.Enabled = True Then Call btnBack_Click(btnBack, New System.EventArgs())
		
		On Error GoTo failsafe
		If Socket1.Connected Then
			frmClient.Socket1.SendLen = Len("^^^^" & "(L)" & frmClient.txtUID.Text & Chr(3))
			frmClient.Socket1.SendData = "^^^^" & "(L)" & frmClient.txtUID.Text & Chr(3)
			
			'GoSleepEx 0.1
			
			If killed = False Then
				
				Socket1.SendLen = Len("&&&&" & frmClient.txtUID.Text & Chr(3))
				Socket1.SendData = "&&&&" & frmClient.txtUID.Text & Chr(3)
				Socket1.Action = SOCKET_CLOSE
				
			End If
			
		End If
		
		
		frmClient.btnHost.Enabled = True
		frmClient.btnAway.Enabled = True
		frmClient.lstGameRooms.Enabled = True
		
		Exit Sub
		
		
		
failsafe: 
		frmClient.btnHost.Enabled = True
		frmClient.lstGameRooms.Enabled = True
		
		MsgBox("Disconnected", MsgBoxStyle.OKOnly, "Game Room lost connection to Host or never got connected")
		
		Me.Close()
		Exit Sub
Failed: 
		FileOpen(4, CurDir() & "\errorlog.txt", OpenMode.Append)
		PrintLine(4, "Form_UnLoad - " & Str(Err.Number) & " - " & Err.Description & " - frmJoinGame")
		FileClose(4)
		Resume Next
		
	End Sub
	
	Private Sub Timer1_Tick(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles Timer1.Tick
		
		On Error GoTo Failed
		On Error GoTo cannotconnect
		
		If Socket1.Connected Then
			
			
			Socket1.SendLen = Len("$$$$" & frmClient.txtUID.Text & Chr(3))
			Socket1.SendData = "$$$$" & frmClient.txtUID.Text & Chr(3)
			Timer1.Enabled = False
			timerconnection.Enabled = True
			
		Else
			
			Socket1.RemotePort = CShort(rport(remPort))
			Socket1.Action = SOCKET_CONNECT
			remPort = remPort + 1
			If remPort = 3 Then remPort = 0
		End If
		
		Exit Sub
		
cannotconnect: 
		MsgBox("The Host cannot be connected to, they may be behind a firewall, or router that is blocking access", MsgBoxStyle.OKOnly + MsgBoxStyle.Critical, "UN Reachable host")
		
		frmClient.Socket1.SendLen = Len("^^^^" & "(L)" & frmClient.txtUID.Text & Chr(3))
		frmClient.Socket1.SendData = "^^^^" & "(L)" & frmClient.txtUID.Text & Chr(3)
		
		Me.Close()
		Exit Sub
Failed: 
		FileOpen(4, CurDir() & "\errorlog.txt", OpenMode.Append)
		PrintLine(4, "timer1 - " & Str(Err.Number) & " - " & Err.Description & " - frmJoinGame")
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
		PrintLine(4, " - " & Str(Err.Number) & " - " & Err.Description & " - frmJoinGame")
		FileClose(4)
		Resume Next
		
		
	End Function
End Class