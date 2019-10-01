Option Strict Off
Option Explicit On
Friend Class frmClient
	Inherits System.Windows.Forms.Form
	Public GameHost As String
	
	Public MacAddy As String
	
	Public game As String
	
	Private FlagFocus As Boolean
	
	Private lstReplyarray(100) As String
	
	Public gameName As String
	Public numberOfPlayers As Short
	
	Private lstArray(1000) As String
	Private lstArrayIp(1000) As String
	Private lstArrayLat(1000) As String
	Public lstArrayCount As Short
	
	
	Private lstGameArrayIP(1000) As String
	Private lstGameArrayPlayers(1000) As String
	Private lstGameArrayNames(1000) As String
	Private lstGameArrayGame(1000) As String
	Private lstGameArrayGRPL(1000) As String
	
	Public lstGameArrayCount As Short
	
	Public exposedIP As String
	
	Public XVTGamePath As String
	Public BOPGamePath As String
	Public XWAGamePath As String
	
	Public curVersion As String
	
	Private IMUID As String
	
	Private pingIndex As Short
	
	Private pingAll As Boolean
	
	Private rtfReply As String
	
	Private talk As Boolean
	
	Public playing As Boolean
	
	Private booted As Boolean
	
	Private BannedUser(10000) As String
	Public BannedUserCounter As Short
	
	'UPGRADE_NOTE: Filter was upgraded to Filter_Renamed. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="A9E4979A-37FA-4718-9994-97DD76ED70A7"'
	Private Filter_Renamed(10000) As String
	Public FilterCount As Short
	
	Public Function getBannedUsers() As String()
		On Error GoTo Failed
		
		getBannedUsers = VB6.CopyArray(BannedUser)
		Exit Function
Failed: 
		FileOpen(4, CurDir() & "\errorlog.txt", OpenMode.Append)
		PrintLine(4, "getbanneduser " & Str(Err.Number) & " - " & Err.Description & " - frmclient")
		FileClose(4)
		Resume Next
		
	End Function
	
	Public Function getFilter() As String()
		
		On Error GoTo Failed
		
		getFilter = VB6.CopyArray(Filter_Renamed)
		Exit Function
Failed: 
		FileOpen(4, CurDir() & "\errorlog.txt", OpenMode.Append)
		PrintLine(4, "getfilter " & Str(Err.Number) & " - " & Err.Description & " - frmclient")
		FileClose(4)
		Resume Next
		
	End Function
	
	'UPGRADE_NOTE: name was upgraded to name_Renamed. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="A9E4979A-37FA-4718-9994-97DD76ED70A7"'
	Public Function does_exist(ByRef name_Renamed As String) As Boolean
		Dim i As Object
		
		On Error GoTo Failed
		
		does_exist = False
		For i = 0 To lstGameArrayCount - 1
			'UPGRADE_WARNING: Couldn't resolve default property of object i. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			If name_Renamed = lstGameArrayNames(i) Then does_exist = True
		Next i
		Exit Function
Failed: 
		FileOpen(4, CurDir() & "\errorlog.txt", OpenMode.Append)
		PrintLine(4, "doesexist " & Str(Err.Number) & " - " & Err.Description & " - frmclient")
		FileClose(4)
		Resume Next
		
	End Function
	
	
	'UPGRADE_WARNING: Event cboMute.CheckStateChanged may fire when form is initialized. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="88B12AE1-6DE0-48A0-86F1-60C0686C026A"'
	Private Sub cboMute_CheckStateChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cboMute.CheckStateChanged
		
	End Sub
	
	Private Sub cmdAdmin_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdAdmin.Click
		On Error GoTo Failed
		If IMUID <> "" Then
			If MsgBox("Make " & IMUID & " an Administrator?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Errant Venture Main Computer") = MsgBoxResult.Yes Then
				Socket1.SendLen = Len("MKAM" & IMUID & Chr(3))
				Socket1.SendData = "MKAM" & IMUID & Chr(3)
			End If
		End If
		Exit Sub
Failed: 
		FileOpen(4, CurDir() & "\errorlog.txt", OpenMode.Append)
		PrintLine(4, "cmdadmin_click " & Str(Err.Number) & " - " & Err.Description & " - frmclient")
		FileClose(4)
		Resume Next
		
	End Sub
	
	Private Sub cmdBan_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdBan.Click
		On Error GoTo Failed
		Dim reason As String
		
		If IMUID <> "" Then
			Do 
				reason = InputBox("Reason For Banning" & IMUID & "?", "Errant Venture Main Computer", " ")
			Loop Until reason <> " "
			
			If reason <> "" Then
				
				Socket1.SendLen = Len("BNMC" & IMUID & Chr(30) & reason & Chr(3))
				Socket1.SendData = "BNMC" & IMUID & Chr(30) & reason & Chr(3)
				
				Call cmdPunt_Click(cmdPunt, New System.EventArgs())
			End If
			
		End If
		Exit Sub
Failed: 
		FileOpen(4, CurDir() & "\errorlog.txt", OpenMode.Append)
		PrintLine(4, "cmdban_click " & Str(Err.Number) & " - " & Err.Description & " - frmclient")
		FileClose(4)
		Resume Next
		
	End Sub
	
	
	
	Private Sub cmdModerator_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdModerator.Click
		On Error GoTo Failed
		If IMUID <> "" Then
			If MsgBox("Make " & IMUID & " a Moderator?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Errant Venture Main Computer") = MsgBoxResult.Yes Then
				Socket1.SendLen = Len("MKMD" & IMUID & Chr(3))
				Socket1.SendData = "MKMD" & IMUID & Chr(3)
			End If
		End If
		Exit Sub
Failed: 
		FileOpen(4, CurDir() & "\errorlog.txt", OpenMode.Append)
		PrintLine(4, "cmdModerator_Click " & Str(Err.Number) & " - " & Err.Description & " - frmclient")
		FileClose(4)
		Resume Next
		
	End Sub
	
	Private Sub cmdNotAdmin_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdNotAdmin.Click
		On Error GoTo Failed
		If IMUID <> "" Then
			If MsgBox("remove " & IMUID & "'s Administrator abilities?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Errant Venture Main Computer") = MsgBoxResult.Yes Then
				Socket1.SendLen = Len("RMAM" & IMUID & Chr(3))
				Socket1.SendData = "RMAM" & IMUID & Chr(3)
				Call cmdPunt_Click(cmdPunt, New System.EventArgs())
			End If
		End If
		
		Exit Sub
		
Failed: 
		FileOpen(4, CurDir() & "\errorlog.txt", OpenMode.Append)
		PrintLine(4, "cmdNotAdmin_Click - " & Str(Err.Number) & " - " & Err.Description & " - frmclient")
		FileClose(4)
		Resume Next
		
	End Sub
	
	Private Sub cmdNotModerator_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdNotModerator.Click
		On Error GoTo Failed
		If IMUID <> "" Then
			If MsgBox("Remove " & IMUID & "'s Moderator abilities?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Errant Venture Main Computer") = MsgBoxResult.Yes Then
				Socket1.SendLen = Len("RMMD" & IMUID & Chr(3))
				Socket1.SendData = "RMMD" & IMUID & Chr(3)
				Call cmdPunt_Click(cmdPunt, New System.EventArgs())
			End If
		End If
		Exit Sub
		
Failed: 
		FileOpen(4, CurDir() & "\errorlog.txt", OpenMode.Append)
		PrintLine(4, "cmdNotModerator_Click - " & Str(Err.Number) & " - " & Err.Description & " - frmclient")
		FileClose(4)
		Resume Next
		
	End Sub
	
	Private Sub cmdNotSuper_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdNotSuper.Click
		On Error GoTo Failed
		If IMUID <> "" Then
			If MsgBox("Remove " & IMUID & "'s Super Administrator abilities?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Errant Venture Main Computer") = MsgBoxResult.Yes Then
				Socket1.SendLen = Len("RMSU" & IMUID & Chr(3))
				Socket1.SendData = "RMSU" & IMUID & Chr(3)
				Call cmdPunt_Click(cmdPunt, New System.EventArgs())
			End If
		End If
		Exit Sub
		
Failed: 
		FileOpen(4, CurDir() & "\errorlog.txt", OpenMode.Append)
		PrintLine(4, "cmdNotSuper_Click - " & Str(Err.Number) & " - " & Err.Description & " - frmclient")
		FileClose(4)
		Resume Next
		
	End Sub
	
	Private Sub cmdPunt_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdPunt.Click
		On Error GoTo Failed
		If IMUID <> "" Then
			If MsgBox("Are you Sure you want to punt " & IMUID & "?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Errant Venture Main Computer") = MsgBoxResult.Yes Then
				Socket1.SendLen = Len("BPWD" & IMUID & Chr(3))
				Socket1.SendData = "BPWD" & IMUID & Chr(3)
			End If
		End If
		Exit Sub
		
Failed: 
		FileOpen(4, CurDir() & "\errorlog.txt", OpenMode.Append)
		PrintLine(4, "cmdPunt_Click - " & Str(Err.Number) & " - " & Err.Description & " - frmclient")
		FileClose(4)
		Resume Next
		
	End Sub
	
	Private Sub cmdSuper_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdSuper.Click
		On Error GoTo Failed
		If IMUID <> "" Then
			If MsgBox("Make " & IMUID & " a Super Administrator?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Errant Venture Main Computer") = MsgBoxResult.Yes Then
				Socket1.SendLen = Len("MKSU" & IMUID & Chr(3))
				Socket1.SendData = "MKSU" & IMUID & Chr(3)
			End If
		End If
		Exit Sub
		
Failed: 
		FileOpen(4, CurDir() & "\errorlog.txt", OpenMode.Append)
		PrintLine(4, "cmdSuper_Click - " & Str(Err.Number) & " - " & Err.Description & " - frmclient")
		FileClose(4)
		Resume Next
		
	End Sub
	
	Private Sub cmdunBan_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdunBan.Click
		On Error GoTo Failed
		Socket1.SendLen = Len("UNBN" & Chr(3))
		Socket1.SendData = "UNBN" & Chr(3)
		Exit Sub
		
Failed: 
		FileOpen(4, CurDir() & "\errorlog.txt", OpenMode.Append)
		PrintLine(4, "cmdUnBan_Click - " & Str(Err.Number) & " - " & Err.Description & " - frmclient")
		FileClose(4)
		Resume Next
		
	End Sub
	
	Private Sub frmClient_Load(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles MyBase.Load
		Dim MMControl1 As Object
		
		Dim readhost As String
		
		On Error GoTo Failed
		booted = False
		
		' Set properties needed by MCI to open.
		'UPGRADE_WARNING: Couldn't resolve default property of object MMControl1.Notify. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		MMControl1.Notify = False
		'UPGRADE_WARNING: Couldn't resolve default property of object MMControl1.Wait. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		MMControl1.Wait = False
		'UPGRADE_WARNING: Couldn't resolve default property of object MMControl1.Shareable. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		MMControl1.Shareable = False
		'UPGRADE_WARNING: Couldn't resolve default property of object MMControl1.DeviceType. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		MMControl1.DeviceType = "WaveAudio"
		
		'UPGRADE_WARNING: Navigate2 was upgraded to Navigate and has a new behavior. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
		WebBrowser1.Navigate(New System.URI(CurDir() & "\connect.htm"))
		
		'UPGRADE_WARNING: Navigate2 was upgraded to Navigate and has a new behavior. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
		wbReply.Navigate(New System.URI("about:blank"))
		newMessage(" ")
		
		talk = False
		
		
		pingAll = True
		
		curVersion = "10.93"
		
		Dim uId As String
		Dim pwd As String
		
		FileOpen(3, CurDir() & "\ipconfig.bat", OpenMode.Append)
		FileClose(3)
		FileOpen(3, CurDir() & "\ipconfig.bat", OpenMode.Output)
		PrintLine(3, "cd \")
		PrintLine(3, "ipconfig /all > " & Chr(34) & CurDir() & "\ipconfig.txt" & Chr(34))
		FileClose(3)
		
		
		
		
		Shell("ipconfig.bat", AppWinStyle.Hide)
		
		
		FileOpen(1, CurDir() & "\xvtpwdlog.dat", OpenMode.Append)
		FileClose(1)
		
		
		FileOpen(1, CurDir() & "\xvtpwdlog.dat", OpenMode.Append)
		FileClose(1)
		FileOpen(1, CurDir() & "\xvtpwdlog.dat", OpenMode.Input)
		If EOF(1) Then
			FileClose(1)
			GoTo filenotfound
		End If
		Input(1, uId)
		Input(1, pwd)
		FileClose(1)
		
		
		
		
		txtUID.Text = uId
		txtPWD.Text = pwd
		
		
		
filenotfound: 
		
		FileOpen(1, CurDir() & "\hosts.dat", OpenMode.Append)
		FileClose(1)
		FileOpen(1, CurDir() & "\hosts.dat", OpenMode.Input)
		
		Do Until EOF(1)
			readhost = LineInput(1)
			txtHost.Items.Add(readhost)
			
			If txtHost.Text = "" Then txtHost.Text = readhost
			
			
		Loop 
		
		FileClose(1)
		
		
		
		Me.Text = "The NRSD Errant Venture - Version " & curVersion & "m"
		
		'UPGRADE_WARNING: Couldn't resolve default property of object regQuery_A_Key(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		XVTGamePath = regQuery_A_Key(HKEY_LOCAL_MACHINE, "SOFTWARE\LucasArts Entertainment Company\X-Wing vs. TIE Fighter\1.0\", "Executable")
		'UPGRADE_WARNING: Couldn't resolve default property of object regQuery_A_Key(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		BOPGamePath = regQuery_A_Key(HKEY_LOCAL_MACHINE, "SOFTWARE\LucasArts Entertainment Company\X-Wing vs. TIE Fighter\2.0\", "Executable")
		'UPGRADE_WARNING: Couldn't resolve default property of object regQuery_A_Key(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		XWAGamePath = regQuery_A_Key(HKEY_LOCAL_MACHINE, "SOFTWARE\LucasArts Entertainment Company LLC\X-Wing Alliance\v1.0", "Executable")
		
		Socket1.AddressFamily = AF_INET
		Socket1.Protocol = IPPROTO_IP
		Socket1.SocketType = SOCK_STREAM
		Socket1.Binary = False
		Socket1.Blocking = False
		Socket1.BufferSize = 1024
		lstArrayCount = 0
		FlagFocus = True
		
		
		Exit Sub
		
Failed: 
		FileOpen(4, CurDir() & "\errorlog.txt", OpenMode.Append)
		PrintLine(4, "from_load - " & Str(Err.Number) & " - " & Err.Description & " - frmclient")
		FileClose(4)
		Resume Next
		
		
	End Sub
	
	Private Sub MMControl1_Done(ByRef NotifyCode As Short)
		
	End Sub
	
	Private Sub pingtimer_Tick(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles pingtimer.Tick
		Dim i As Object
		On Error GoTo Failed
		Dim ECHO As ICMP_ECHO_REPLY
		Dim lat As String
		
		' on load this global variable will be true
		If pingAll = True And playing = False Then
			'set the timer to ping a new address every 30 seconds
			pingtimer.Interval = 30000
			
			lat = ""
			' loop through all players
			For i = 0 To lstArrayCount - 1
				' if the current player is not the player this client services then
				'UPGRADE_WARNING: Couldn't resolve default property of object i. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				If Mid(UCase(lstArray(i)), 4) <> UCase(txtUID.Text) Then
					' ping the player
					'UPGRADE_WARNING: Couldn't resolve default property of object i. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
					Call Ping(lstArrayIp(i), ECHO)
					' get returned latancy time if any
					If ECHO.status = 0 Then
						lat = " [" & Str(ECHO.RoundTripTime) & " ms]"
					Else
						lat = " [N/A]"
					End If
					
					'set the lat
					'UPGRADE_WARNING: Couldn't resolve default property of object i. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
					lstArrayLat(i) = lat
					
				End If
			Next i
			
			' set flag to refresh all to false
			pingAll = False
			
			
		End If
		
		
		' otherwise set i to the global variable that tracks which ip it's pinging
		
		'UPGRADE_WARNING: Couldn't resolve default property of object i. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		i = pingIndex
		' initialize the lat
		lat = ""
		
		
		' if current player is not the one client is servicing
		'UPGRADE_WARNING: Couldn't resolve default property of object i. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		If Mid(UCase(lstArray(i)), 4) <> UCase(txtUID.Text) Then
			' ping the player
			'UPGRADE_WARNING: Couldn't resolve default property of object i. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			Call Ping(lstArrayIp(i), ECHO)
			' get the results if there is any
			If ECHO.status = 0 Then
				lat = " [" & Str(ECHO.RoundTripTime) & " ms]"
			Else
				lat = " [N/A]"
			End If
			' add it to the array
			'UPGRADE_WARNING: Couldn't resolve default property of object i. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			lstArrayLat(i) = lat
			
		End If
		' increment the global variable that keeps track of which player it's updating
		'UPGRADE_WARNING: Couldn't resolve default property of object i. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		pingIndex = i + 1
		' if it's greater than the number of players, reset it
		If pingIndex > lstArrayCount - 1 Then pingIndex = 0
		
		' empty the listbox that the players live in
		lstPlayers.Items.Clear()
		'refill the list box
		For i = 0 To lstArrayCount - 1
			'UPGRADE_WARNING: Couldn't resolve default property of object i. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			lstPlayers.Items.Add(lstArray(i) & lstArrayLat(i))
		Next i
		
		Exit Sub
		
Failed: 
		FileOpen(4, CurDir() & "\errorlog.txt", OpenMode.Append)
		PrintLine(4, "ping timer - " & Str(Err.Number) & " - " & Err.Description & " - frmclient")
		FileClose(4)
		Resume Next
		
		
		
	End Sub
	
	Private Sub btnAway_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles btnAway.Click
		On Error GoTo Failed
		If btnAway.Text = "Away" Then
			btnAway.Text = "Back"
			Socket1.SendLen = Len("^^^^" & "(A)" & txtUID.Text & Chr(3))
			Socket1.SendData = "^^^^" & "(A)" & txtUID.Text & Chr(3)
			btnHost.Enabled = False
			btnJoin.Enabled = False
			
		Else
			btnAway.Text = "Away"
			Socket1.SendLen = Len("^^^^" & "(L)" & txtUID.Text & Chr(3))
			Socket1.SendData = "^^^^" & "(L)" & txtUID.Text & Chr(3)
			btnHost.Enabled = True
			
		End If
		Exit Sub
		
Failed: 
		FileOpen(4, CurDir() & "\errorlog.txt", OpenMode.Append)
		PrintLine(4, "btnaway_click - " & Str(Err.Number) & " - " & Err.Description & " - frmclient")
		FileClose(4)
		Resume Next
		
		
		
	End Sub
	
	'UPGRADE_WARNING: Event cboTalk.CheckStateChanged may fire when form is initialized. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="88B12AE1-6DE0-48A0-86F1-60C0686C026A"'
	Private Sub cboTalk_CheckStateChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cboTalk.CheckStateChanged
		Dim frmTalk As Object
		
		On Error GoTo Failed
		If cboTalk.CheckState = 0 Then
			
			'UPGRADE_ISSUE: Unload frmTalk was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="875EBAD7-D704-4539-9969-BC7DBDAA62A2"'
            frmTalk.close()
		Else
			'UPGRADE_WARNING: Couldn't resolve default property of object frmTalk.Show. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			frmTalk.Show()
			Me.Activate()
		End If
		Exit Sub
		
Failed: 
		FileOpen(4, CurDir() & "\errorlog.txt", OpenMode.Append)
		PrintLine(4, "cboTalk_Click - " & Str(Err.Number) & " - " & Err.Description & " - frmclient")
		FileClose(4)
		Resume Next
		
		
		
	End Sub
	
	
	
	
	
	Private Sub btnGo_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles btnGo.Click
		On Error GoTo Failed
		Dim strng As String
		Dim i As Short
		Dim tempstring As String
		Dim remPort As String
		
		
		On Error GoTo Failed
		
		Me.Text = Me.Text & " Connected to: " & txtHost.Text
		
		
		strng = Trim(txtUID.Text)
		
		FileOpen(1, CurDir() & "\port.dat", OpenMode.Append)
		FileClose(1)
		
		
		FileOpen(1, CurDir() & "\port.dat", OpenMode.Input)
		If Not EOF(1) Then remPort = LineInput(1)
		FileClose(1)
		
		If remPort = "" Then remPort = "2020"
		
		
		'On Error GoTo Failed
		Socket1.HostName = Trim(txtHost.Text)
		Socket1.RemotePort = Val(remPort)
		Socket1.Action = SOCKET_CONNECT
		
		txtHost.Enabled = False
		btnGo.Enabled = False
		txtUID.Visible = True
		btnUID.Visible = True
		txtPWD.Visible = True
		VB6.SetDefault(btnUID, True)
		
		txtUID.Focus()
		
		Text2.Visible = True
		Text3.Visible = True
		
		
		
		
		
		FileOpen(3, CurDir() & "\ipconfig.txt", OpenMode.Input)
		
		Do Until EOF(3)
			
			tempstring = LineInput(3)
			If tempstring <> "" Then
				If Mid(tempstring, Len(tempstring) - 2, 1) = "-" Then
					MacAddy = Mid(tempstring, Len(tempstring) - 16)
				End If
			End If
		Loop 
		
		FileClose(3)
		
		'MacAddy = Socket1.PhysicalAddress
		
		
		
		Exit Sub
		
Failed: 
		FileOpen(4, CurDir() & "\errorlog.txt", OpenMode.Append)
		PrintLine(4, "btnGo_Click - " & Str(Err.Number) & " - " & Err.Description & " - frmclient")
		FileClose(4)
		Resume Next
		
		
		
		
	End Sub
	
	Private Sub btnHost_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles btnHost.Click
		On Error GoTo Failed
		numberOfPlayers = 0
		On Error Resume Next
		
		frmConfigureGame.Show()
		
		
		Exit Sub
		
Failed: 
		FileOpen(4, CurDir() & "\errorlog.txt", OpenMode.Append)
		PrintLine(4, "btnHost_click - " & Str(Err.Number) & " - " & Err.Description & " - frmclient")
		FileClose(4)
		Resume Next
		
		
		
	End Sub
	
	Private Sub btnJoin_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles btnJoin.Click
		
		On Error GoTo Failed
		Dim indx As Short
		
		If Mid(gameName, 5, 3) = "XWA" And XWAGamePath = "" Then
			MsgBox("That Gameroom is for X Wing Alliance, and you do not have it installed", MsgBoxStyle.OKOnly + MsgBoxStyle.Information, "Game Not Installed")
		End If
		
		If Mid(gameName, 5, 3) = "BOP" And BOPGamePath = "" Then
			MsgBox("That Gameroom is for X Wing VS Tie Balance of Power, and you do not have it installed", MsgBoxStyle.OKOnly + MsgBoxStyle.Information, "Game Not Installed")
		End If
		
		If Mid(gameName, 5, 3) = "XVT" And XVTGamePath = "" Then
			MsgBox("That Gameroom is for X Wing VS Tie, and you do not have it installed", MsgBoxStyle.OKOnly + MsgBoxStyle.Information, "Game Not Installed")
		End If
		
		
		indx = lstGameRooms.SelectedIndex
		
		If Val(Mid(lstGameArrayPlayers(indx), 1, 1)) < Val(Mid(lstGameArrayPlayers(indx), 3, 1)) Then
			
			
			btnHost.Enabled = False
			btnJoin.Enabled = False
			btnAway.Enabled = False
			'lstGameRooms.Enabled = False
			
			
			frmJoinGame.Show()
		Else
			MsgBox("That Room is full", MsgBoxStyle.OKOnly, "Sorry")
		End If
		
		Exit Sub
		
Failed: 
		FileOpen(4, CurDir() & "\errorlog.txt", OpenMode.Append)
		PrintLine(4, "btnJoin_Click - " & Str(Err.Number) & " - " & Err.Description & " - frmclient")
		FileClose(4)
		Resume Next
		
		
		
	End Sub
	
	Private Sub btnUID_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles btnUID.Click
		On Error GoTo Failed
		Dim parse As String
		'UPGRADE_NOTE: name was upgraded to name_Renamed. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="A9E4979A-37FA-4718-9994-97DD76ED70A7"'
		Dim name_Renamed As String
		
		btnUID.Enabled = False
		txtUID.Enabled = False
		txtPWD.Enabled = False
		
		
		
		name_Renamed = "(L)" & txtUID.Text
		
		Socket1.SendLen = Len("####" & name_Renamed & Chr(30) & txtPWD.Text & Chr(3))
		Socket1.SendData = "####" & name_Renamed & Chr(30) & txtPWD.Text & Chr(3)
		
		Timer1.Enabled = True
		
		Exit Sub
		
Failed: 
		FileOpen(4, CurDir() & "\errorlog.txt", OpenMode.Append)
		PrintLine(4, "btnUID_Click - " & Str(Err.Number) & " - " & Err.Description & " - frmclient")
		FileClose(4)
		Resume Next
		
		
		
		
	End Sub
	
	'UPGRADE_WARNING: Event lstGameRooms.SelectedIndexChanged may fire when form is initialized. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="88B12AE1-6DE0-48A0-86F1-60C0686C026A"'
	Private Sub lstGameRooms_SelectedIndexChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles lstGameRooms.SelectedIndexChanged
		On Error GoTo Failed
		Dim tempstring As String
		
		If lstGameRooms.Text <> "" Then
			tempstring = Replace(lstGameArrayGRPL(lstGameRooms.SelectedIndex), ", ", vbCrLf)
			
			
			If playing = False Then
				
				GameHost = lstGameArrayIP(lstGameRooms.SelectedIndex)
				numberOfPlayers = Val(Mid(lstGameArrayPlayers(lstGameRooms.SelectedIndex), 3))
				gameName = lstGameArrayNames(lstGameRooms.SelectedIndex)
				If GameHost <> "" And btnAway.Text = "Away" Then
					btnJoin.Enabled = True
				Else
					btnJoin.Enabled = False
				End If
			End If
			
			
		End If
		Exit Sub
		
Failed: 
		FileOpen(4, CurDir() & "\errorlog.txt", OpenMode.Append)
		PrintLine(4, "lstGameRooms_click - " & Str(Err.Number) & " - " & Err.Description & " - frmclient")
		FileClose(4)
		Resume Next
		
		
		
	End Sub
	
	
	'UPGRADE_WARNING: Event lstPlayers.SelectedIndexChanged may fire when form is initialized. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="88B12AE1-6DE0-48A0-86F1-60C0686C026A"'
	Private Sub lstPlayers_SelectedIndexChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles lstPlayers.SelectedIndexChanged
		On Error GoTo Failed
		
		ToolTip1.SetToolTip(lstPlayers, lstArrayIp(lstPlayers.SelectedIndex))
		
		If lstPlayers.SelectedIndex = -1 Then Exit Sub
		IMUID = Mid(lstArray(lstPlayers.SelectedIndex), 4)
		
		If IMUID <> "" Then
			
			btnIM.Enabled = True
			
			
		End If
		Exit Sub
		
Failed: 
		FileOpen(4, CurDir() & "\errorlog.txt", OpenMode.Append)
		PrintLine(4, "lstPlayers_Click - " & Str(Err.Number) & " - " & Err.Description & " - frmclient")
		FileClose(4)
		Resume Next
		
		
		
	End Sub
	'UPGRADE_NOTE: Str was upgraded to Str_Renamed. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="A9E4979A-37FA-4718-9994-97DD76ED70A7"'
	Private Function GetRidofHTML(ByRef Str_Renamed As String) As Object
		'MsgBox Str
		If InStr(1, UCase(Me.Text), "SUPER ADMINISTRATOR") = 0 Then
			Str_Renamed = Replace(Str_Renamed, "<", "&lt;")
			Str_Renamed = Replace(Str_Renamed, ">", "&gt;")
		End If
		'MsgBox Str
		'UPGRADE_WARNING: Couldn't resolve default property of object GetRidofHTML. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		GetRidofHTML = Str_Renamed
	End Function
	Private Sub lstPlayers_DoubleClick(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles lstPlayers.DoubleClick
		On Error GoTo Failed
		Dim imMsg As String
		
		If lstPlayers.SelectedIndex = -1 Then Exit Sub
		
		IMUID = Mid(lstArray(lstPlayers.SelectedIndex), 4)
		If IMUID <> "" And IMUID <> txtUID.Text Then
			imMsg = InputBox("Page User: " & IMUID, "NRSD Errant Venture Comm System")
			
			Socket1.SendLen = Len("IMIM" & txtUID.Text & Chr(30) & IMUID & Chr(30) & imMsg & Chr(3))
			Socket1.SendData = "IMIM" & txtUID.Text & Chr(30) & IMUID & Chr(30) & imMsg & Chr(3)
			newMessage("<font color='#664423'>page to</font> " & IMUID & Chr(198) & "- " & imMsg)
			btnIM.Enabled = False
			
		End If
		Exit Sub
		
Failed: 
		FileOpen(4, CurDir() & "\errorlog.txt", OpenMode.Append)
		PrintLine(4, "lstPlayers_DblClick - " & Str(Err.Number) & " - " & Err.Description & " - frmclient")
		FileClose(4)
		Resume Next
		
		
		
	End Sub
	Private Sub btnIM_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles btnIM.Click
		On Error GoTo Failed
		Dim imMsg As String
		
		If IMUID <> "" And IMUID <> txtUID.Text Then
			imMsg = InputBox("Page User: " & IMUID, "NRSD Errant Venture Comm System")
			
			If imMsg <> "" Then
				'UPGRADE_WARNING: Couldn't resolve default property of object GetRidofHTML(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				imMsg = GetRidofHTML(imMsg)
				Socket1.SendLen = Len("IMIM" & txtUID.Text & Chr(30) & IMUID & Chr(30) & imMsg & Chr(3))
				Socket1.SendData = "IMIM" & txtUID.Text & Chr(30) & IMUID & Chr(30) & imMsg & Chr(3)
				newMessage("<font color='#664423'>page from</font> " & IMUID & Chr(198) & " - " & imMsg)
			End If
			btnIM.Enabled = False
			
		End If
		Exit Sub
		
Failed: 
		FileOpen(4, CurDir() & "\errorlog.txt", OpenMode.Append)
		PrintLine(4, "btnIM_Click - " & Str(Err.Number) & " - " & Err.Description & " - frmclient")
		FileClose(4)
		Resume Next
		
		
		
	End Sub
	
	Private Sub Socket1_ReadEvent(ByVal eventSender As System.Object, ByVal eventArgs As AxSocketWrenchCtrl._DSocketWrenchEvents_ReadEvent) Handles Socket1.ReadEvent
		Dim frmTalk As Object
		Dim first3 As Object
		Dim ok As Object
		Dim parse As Object
		Dim i As Object
		Dim strBuffer As String
		Dim first4 As String
		Dim parsed As String
		Dim cnt As Short
		Dim lstarraytemp() As String
		Dim lstarrayiptemp() As String
		Dim lstarrayLattemp() As String
		Dim B As Short
		Dim numMsgs As Short
		Dim msgs(1000) As String
		Dim nextMsgStart As Short
		Dim wrapLines(100) As String
		Dim w As Short
		Dim result As String
		Dim game As String
		Dim uidIM As String
		Dim msgIM As String
		Dim replyIM As String
		Dim touidIM As Object
		Dim GRPLGamename As String
		Dim GRPLString As String
		Dim playerip As String
		
		Dim args() As String
		
		On Error GoTo Failed
		
		
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
		
		Dim team As Boolean
		Dim wr As String
		Dim lstGameArrayIPtemp() As String
		Dim lstGameArrayPlayerstemp() As String
		Dim lstGameArrayNamestemp() As String
		Dim lstGameArrayGametemp() As String
		Dim lstGameArrayGRPLtemp() As String
		For B = 0 To numMsgs - 1
			
			strBuffer = msgs(B)
			
			first4 = Mid(strBuffer, 1, 4)
			
			
			
			Select Case first4
				Case "BPWD"
					
					'If Socket1.Connected Then
					'    Socket1.SendLen = Len("@@@@" + txtuid.Text + chr$(3))
					'    Socket1.SendData = "@@@@" + txtuid.Text + chr$(3)
					'    Socket1.Action = SOCKET_CLOSE
					'End If
					'MsgBox "You Have been logged in somewhere else", vbExclamation + vbOKOnly, "Warning"
					
					booted = True
					
					Me.Close()
					
				Case "IMIM"
					If playing = True Then
						Socket1.SendLen = Len("IMIM" & "Errant Venture Paging System" & Chr(30) & uidIM & Chr(30) & "The user you are trying to page is unavallible at the moment, please try again later" & Chr(3))
						Socket1.SendData = "IMIM" & "Errant Venture Paging System" & Chr(30) & uidIM & Chr(30) & "The user you are trying to page is unavallible at the moment, please try again later" & Chr(3)
						
					Else
						team = False
						parsed = Mid(strBuffer, 5)
						args = Split(parsed, Chr(30))
						If UBound(args) = 3 Then If args(3) <> "" Then team = True
						
						uidIM = Mid(parsed, 1, InStr(parsed, Chr(30)) - 1)
						msgIM = Mid(parsed, InStr(InStr(parsed, Chr(30)) + 1, parsed, Chr(30)) + 1)
						PlayWave(My.Application.Info.DirectoryPath & "/bing.wav")
						If team = True Then
							'UPGRADE_WARNING: Couldn't resolve default property of object GetRidofHTML(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
							args(2) = GetRidofHTML(args(2))
							newMessage("<font color='#FF0000'>team chat * " & args(3) & " *</font> " & uidIM & Chr(198) & " - " & args(2))
						Else
							'UPGRADE_WARNING: Couldn't resolve default property of object GetRidofHTML(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
							msgIM = GetRidofHTML(msgIM)
							newMessage("<font color='#664423'>page from</font> " & uidIM & Chr(198) & " - " & msgIM)
							Do 
								replyIM = InputBox(uidIM & " Says: " & msgIM, "Errant Venture Comm System", " ")
							Loop Until replyIM <> " "
							If replyIM <> "" Then
								'UPGRADE_WARNING: Couldn't resolve default property of object GetRidofHTML(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
								replyIM = GetRidofHTML(replyIM)
								Socket1.SendLen = Len("IMIM" & txtUID.Text & Chr(30) & uidIM & Chr(30) & replyIM & Chr(3))
								Socket1.SendData = "IMIM" & txtUID.Text & Chr(30) & uidIM & Chr(30) & replyIM & Chr(3)
								newMessage("<font color='#664423'>page to</font> " & uidIM & Chr(198) & " - " & replyIM)
							End If
						End If
					End If
				Case "VERQ"
					wr = "VERR" & txtUID.Text & Chr(30) & "ORG_" & curVersion & "m" & Chr(3)
					Socket1.SendLen = Len(wr)
					Socket1.SendData = wr
				Case "PICR"
					parsed = Mid(strBuffer, 5)
					args = Split(parsed, Chr(30))
					'UPGRADE_WARNING: Couldn't resolve default property of object GetRidofHTML(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
					args(1) = GetRidofHTML(args(1))
					newMessage(args(0) & " is <img src='" & args(1) & "' width='32' height='32' align=middle> ")
				Case "GRPL"
					
					parsed = Mid(strBuffer, 5)
					
					GRPLGamename = Mid(parsed, 1, InStr(parsed, Chr(30)) - 1)
					GRPLString = Mid(parsed, InStr(parsed, Chr(30)) + 1)
					
					For i = 0 To lstGameArrayCount - 1
						'UPGRADE_WARNING: Couldn't resolve default property of object i. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
						If lstGameArrayNames(i) = GRPLGamename Then
							'UPGRADE_WARNING: Couldn't resolve default property of object i. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
							lstGameArrayGRPL(i) = GRPLString
						End If
					Next i
					
					
					
					
				Case "LLLL"
					
					'UPGRADE_WARNING: Couldn't resolve default property of object parse. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
					parse = Mid(strBuffer, 5)
					
					'UPGRADE_WARNING: Couldn't resolve default property of object parse. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
					'UPGRADE_WARNING: Couldn't resolve default property of object ok. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
					ok = Mid(parse, 1, 1)
					
					'UPGRADE_WARNING: Couldn't resolve default property of object ok. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
					If ok = "1" Then
						
						
						If talk Then cboTalk.Visible = True
						
						txtUID.Enabled = False
						txtPWD.Enabled = False
						btnUID.Enabled = False
						
						btnUID.Visible = False
						txtUID.Visible = False
						txtPWD.Visible = False
						txtHost.Visible = False
						btnGo.Visible = False
						
						
						btnAway.Visible = True
						btnIM.Visible = True
						btnIM.Enabled = False
						
						
						txtSend.Visible = True
						btnSend.Visible = True
						VB6.SetDefault(btnSend, True)
						
						wbReply.Visible = True
						lstPlayers.Visible = True
						
						lstGameRooms.Visible = True
						btnHost.Visible = True
						btnJoin.Visible = True
						
						'UPGRADE_WARNING: Navigate2 was upgraded to Navigate and has a new behavior. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
						WebBrowser1.Navigate(New System.URI(CurDir() & "\lobby.htm"))
						
						txtSend.Focus()
						
						Text1.Visible = False
						Text2.Visible = False
						Text3.Visible = False
						
						Text4.Visible = True
						Text5.Visible = True
						Text6.Visible = True
						
						
						
						pingtimer.Enabled = True
						
						
						
						FileOpen(1, CurDir() & "\xvtpwdlog.dat", OpenMode.Output)
						PrintLine(1, txtUID.Text)
						PrintLine(1, txtPWD.Text)
						FileClose(1)
						
						Socket1.SendLen = Len("PICQ" & Chr(3) & "VERQ" & Chr(3))
						Socket1.SendData = "PICQ" & Chr(3) & "VERQ" & Chr(3)
						
						'UPGRADE_WARNING: Couldn't resolve default property of object ok. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
					ElseIf ok = 0 Then 
						
						result = CStr(MsgBox("Username or Password either does not exist or not registered. " & Chr(13) & "Press cancel to try again, or Press Ok to register in system", MsgBoxStyle.Exclamation + MsgBoxStyle.OKCancel, "Login error"))
						If CDbl(result) = 1 Then
							frmRegister.Show()
							Me.Enabled = False
							
						End If
						
						btnUID.Enabled = True
						txtUID.Enabled = True
						txtPWD.Enabled = True
						
					Else
						
						MsgBox("Already logged in, Logging off other instance", MsgBoxStyle.Exclamation + MsgBoxStyle.OKOnly, "Already Logged in")
						GoSleepEX(3)
						btnUID_Click(btnUID, New System.EventArgs())
						
					End If
					
				Case "RUSR"
					
					parsed = Mid(strBuffer, 5)
					
					If parsed = "0" Then
						MsgBox("User Already exists, Try another", MsgBoxStyle.OKOnly + MsgBoxStyle.Exclamation, "Validation Error")
						frmRegister.Enabled = True
					Else
						MsgBox("You have successfully registered", MsgBoxStyle.OKOnly + MsgBoxStyle.Information, "Succesful Registration")
						frmRegister.Close()
						Me.Enabled = True
					End If
					
					
					
				Case "VVVV"
					
					parsed = Mid(strBuffer, 5)
					
					If parsed <> curVersion Then
						
						MsgBox("this is an old version, please download the latest from http://ccanuk.brinkster.net/xvt/redist.zip", MsgBoxStyle.Critical + MsgBoxStyle.OKOnly, "Old Version")
						Shell(Chr(34) & "c:\program files\internet explorer\iexplore.exe" & Chr(34) & " http://ccanuk.brinkster.net/xvt/redist.zip", AppWinStyle.NormalFocus)
						
						'Unload Me
						
					End If
					
				Case "####"
					
					If cboMute.CheckState <> 1 And pingAll = False And playing = False Then PlayWave(My.Application.Info.DirectoryPath & "/joinlobby.wav")
					parsed = Mid(strBuffer, 5)
					
					
					playerip = Mid(parsed, InStr(parsed, Chr(30)) + 1)
					parsed = Mid(parsed, 1, InStr(parsed, Chr(30)) - 1)
					
					
					lstPlayers.Items.Add(parsed)
					lstArray(lstArrayCount) = parsed
					lstArrayIp(lstArrayCount) = playerip
					
					lstArrayCount = lstArrayCount + 1
					
					newMessage(Mid(parsed, 4) & " Enters")
					
					btnIM.Enabled = False
					
					
					
				Case "@@@@"
					
					If cboMute.CheckState <> 1 And playing = False Then PlayWave(My.Application.Info.DirectoryPath & "/leavelobby.wav")
					parsed = Mid(strBuffer, 5)
					
					cnt = 0
					
					lstPlayers.Items.Clear()
					
					
					ReDim lstarraytemp(lstArrayCount)
					ReDim lstarrayiptemp(lstArrayCount)
					ReDim lstarrayLattemp(lstArrayCount)
					
					For i = 0 To lstArrayCount - 1
						
						'UPGRADE_WARNING: Couldn't resolve default property of object i. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
						If parsed <> Mid(lstArray(i), 4) Then
							'UPGRADE_WARNING: Couldn't resolve default property of object i. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
							lstPlayers.Items.Add(lstArray(i) & lstArrayLat(i))
							'UPGRADE_WARNING: Couldn't resolve default property of object i. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
							lstarraytemp(cnt) = lstArray(i)
							'UPGRADE_WARNING: Couldn't resolve default property of object i. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
							lstarrayiptemp(cnt) = lstArrayIp(i)
							'UPGRADE_WARNING: Couldn't resolve default property of object i. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
							lstarrayLattemp(cnt) = lstArrayLat(i)
							cnt = cnt + 1
						End If
						
						
					Next i
					
					lstArrayCount = cnt
					For i = 0 To lstArrayCount
						'UPGRADE_WARNING: Couldn't resolve default property of object i. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
						lstArray(i) = lstarraytemp(i)
						'UPGRADE_WARNING: Couldn't resolve default property of object i. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
						lstArrayIp(i) = lstarrayiptemp(i)
						'UPGRADE_WARNING: Couldn't resolve default property of object i. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
						lstArrayLat(i) = lstarrayLattemp(i)
					Next i
					
					newMessage(parsed & " Leaves")
					
					pingIndex = 0
					
				Case "%%%%"
					
					
					parsed = Mid(strBuffer, 5)
					
					cnt = 0
					
					lstGameRooms.Items.Clear()
					'gameName = ""
					btnJoin.Enabled = False
					
					
					ReDim lstGameArrayIPtemp(lstGameArrayCount)
					ReDim lstGameArrayPlayerstemp(lstGameArrayCount)
					ReDim lstGameArrayNamestemp(lstGameArrayCount)
					ReDim lstGameArrayGametemp(lstGameArrayCount)
					ReDim lstGameArrayGRPLtemp(lstGameArrayCount)
					
					
					For i = 0 To lstGameArrayCount - 1
						
						'UPGRADE_WARNING: Couldn't resolve default property of object i. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
						If parsed <> lstGameArrayNames(i) Then
							'UPGRADE_WARNING: Couldn't resolve default property of object i. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
							lstGameRooms.Items.Add((Str(i + 1) & " " & lstGameArrayPlayers(i) & " " & lstGameArrayGame(i) & " " & Mid(lstGameArrayNames(i), 1, 30)))
							
							'UPGRADE_WARNING: Couldn't resolve default property of object i. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
							lstGameArrayIPtemp(cnt) = lstGameArrayIP(i)
							'UPGRADE_WARNING: Couldn't resolve default property of object i. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
							lstGameArrayPlayerstemp(cnt) = lstGameArrayPlayers(i)
							'UPGRADE_WARNING: Couldn't resolve default property of object i. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
							lstGameArrayNamestemp(cnt) = lstGameArrayNames(i)
							'UPGRADE_WARNING: Couldn't resolve default property of object i. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
							lstGameArrayGametemp(cnt) = lstGameArrayGame(i)
							'UPGRADE_WARNING: Couldn't resolve default property of object i. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
							lstGameArrayGRPLtemp(cnt) = lstGameArrayGRPL(i)
							cnt = cnt + 1
							
						End If
						
						
					Next i
					
					
					lstGameArrayCount = cnt
					For i = 0 To lstGameArrayCount - 1
						'UPGRADE_WARNING: Couldn't resolve default property of object i. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
						lstGameArrayIP(i) = lstGameArrayIPtemp(i)
						'UPGRADE_WARNING: Couldn't resolve default property of object i. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
						lstGameArrayPlayers(i) = lstGameArrayPlayerstemp(i)
						'UPGRADE_WARNING: Couldn't resolve default property of object i. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
						lstGameArrayNames(i) = lstGameArrayNamestemp(i)
						'UPGRADE_WARNING: Couldn't resolve default property of object i. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
						lstGameArrayGame(i) = lstGameArrayGametemp(i)
						'UPGRADE_WARNING: Couldn't resolve default property of object i. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
						lstGameArrayGRPL(i) = lstGameArrayGRPLtemp(i)
					Next i
					
					
				Case "++++"
					parsed = Mid(strBuffer, 5)
					
					lstGameArrayPlayers(lstGameArrayCount) = Mid(parsed, 1, 3)
					lstGameArrayGame(lstGameArrayCount) = Mid(parsed, 5, 3)
					lstGameArrayNames(lstGameArrayCount) = Mid(parsed, 9, 30)
					lstGameArrayIP(lstGameArrayCount) = Mid(parsed, 39)
					
					lstGameArrayCount = lstGameArrayCount + 1
					
					'UPGRADE_WARNING: Couldn't resolve default property of object i. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
					lstGameRooms.Items.Add((Str(i + 1) & " " & Mid(parsed, 1, 38)))
					
					
				Case "^^^^"
					
					
					
					
					
					
					
					parsed = Mid(strBuffer, 5)
					'UPGRADE_WARNING: Couldn't resolve default property of object first3. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
					first3 = Mid(parsed, 1, 3)
					
					parsed = Mid(parsed, 4)
					
					lstPlayers.Items.Clear()
					For i = 0 To lstArrayCount - 1
						'UPGRADE_WARNING: Couldn't resolve default property of object i. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
						If parsed = Mid(lstArray(i), 4) Then
							
							
							'UPGRADE_WARNING: Couldn't resolve default property of object i. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
							'UPGRADE_WARNING: Couldn't resolve default property of object first3. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
							lstArray(i) = first3 + parsed
							
							
						End If
						'UPGRADE_WARNING: Couldn't resolve default property of object i. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
						lstPlayers.Items.Add(lstArray(i) & lstArrayLat(i))
					Next i
				Case "^++^"
					
					'UPGRADE_WARNING: Couldn't resolve default property of object first3. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
					first3 = Mid(strBuffer, 5, 3)
					game = Mid(strBuffer, 9, 3)
					parsed = Mid(strBuffer, 13)
					
					lstGameRooms.Items.Clear()
					For i = 0 To lstGameArrayCount - 1
						
						'UPGRADE_WARNING: Couldn't resolve default property of object i. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
						If lstGameArrayNames(i) = parsed Then
							'UPGRADE_WARNING: Couldn't resolve default property of object i. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
							'UPGRADE_WARNING: Couldn't resolve default property of object first3. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
							lstGameArrayPlayers(i) = first3
							'UPGRADE_WARNING: Couldn't resolve default property of object i. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
							lstGameArrayGame(i) = game
							
						End If
						'UPGRADE_WARNING: Couldn't resolve default property of object i. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
						lstGameRooms.Items.Add(Str(i + 1) & " " & lstGameArrayPlayers(i) & " " & lstGameArrayGame(i) & " " & lstGameArrayNames(i))
						
						
					Next i
					
					
				Case "%++%"
					
					' tell the server what the Mac Address is
					Socket1.SendLen = Len("MCAD" & MacAddy & Chr(3))
					Socket1.SendData = "MCAD" & MacAddy & Chr(3)
					
					exposedIP = Mid(strBuffer, 5)
					
					
					FileOpen(3, CurDir() & "\OR.dat", OpenMode.Append)
					FileClose(3)
					FileOpen(3, CurDir() & "\OR.dat", OpenMode.Input)
					Do Until EOF(3)
						exposedIP = LineInput(3)
						Socket1.SendLen = Len("ORIP" & exposedIP & Chr(3))
						Socket1.SendData = "ORIP" & exposedIP & Chr(3)
						
					Loop 
					FileClose(3)
					
					
				Case "MMMM"
					
					If cboMute.CheckState <> 1 And pingAll = False And playing = False Then PlayWave(My.Application.Info.DirectoryPath & "/message.wav")
					
					parsed = Mid(strBuffer, 5)
					
					If talk Then
						On Error Resume Next
						If cboTalk.CheckState = 1 Then
							'UPGRADE_WARNING: Couldn't resolve default property of object frmTalk.DirectSS1. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
							frmTalk.DirectSS1.Sayit = parsed
						End If
					End If
					'UPGRADE_WARNING: Couldn't resolve default property of object GetRidofHTML(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
					parsed = GetRidofHTML(parsed)
					newMessage(parsed)
					
				Case "ADMN"
					
					parsed = Mid(strBuffer, 5)
					
					'newMessage "Your Status is " + parsed
					Me.Text = Me.Text & " " & parsed
					
					'here is where we get to the new rights if you have an elevated status
					
					If UCase(parsed) = "SUPERADMIN" Then
						
						cmdPunt.Visible = True
						cmdBan.Visible = True
						cmdunBan.Visible = True
						cmdModerator.Visible = True
						cmdNotModerator.Visible = True
						cmdAdmin.Visible = True
						cmdNotAdmin.Visible = True
						cmdSuper.Visible = True
						cmdNotSuper.Visible = True
						
					ElseIf UCase(parsed) = "ADMIN" Then 
						cmdPunt.Visible = True
						cmdBan.Visible = True
						cmdunBan.Visible = True
						cmdModerator.Visible = True
						cmdNotModerator.Visible = True
						'cmdAdmin.Visible = True
						
					ElseIf UCase(parsed) = "MODERATOR" Then 
						cmdPunt.Visible = True
						cmdBan.Visible = True
						cmdunBan.Visible = True
					End If
					
					
				Case "BNED"
					
					parsed = Mid(strBuffer, 5)
					
					BannedUser(BannedUserCounter) = parsed
					BannedUserCounter = BannedUserCounter + 1
					
				Case "BNND"
					
					frmViewBanned.Show()
					BannedUserCounter = 0
					
				Case "FFFF"
					
					parsed = Mid(strBuffer, 5)
					
					FilterCount = FilterCount + 1
					
					Filter_Renamed(FilterCount) = parsed
					
					
					
			End Select
			
		Next B
		Exit Sub
		
Failed: 
		FileOpen(4, CurDir() & "\errorlog.txt", OpenMode.Append)
		PrintLine(4, "socket1_read - " & Str(Err.Number) & " - " & Err.Description & " - frmclient")
		FileClose(4)
		Resume Next
		
		
		
	End Sub
	
	Private Sub newMessage(ByRef msg As String)
		Dim i As Object
		On Error GoTo Failed
		
		Dim cursestart As Object
		If cboFilterOff.CheckState <> 1 Then
			For i = 0 To FilterCount
				msg = Replace(msg, Filter_Renamed(i), "Smurf",  ,  , CompareMethod.Text)
			Next i
		End If
		'If InStr(1, UCase(frmClient.Caption), "SUPER ADMINISTRATOR") = 0 Then
		'      msg = Replace(msg, "<", "")
		'       msg = Replace(msg, ">", "")
		'End If
		If InStr(rtfReply, msg) And InStr(msg, "<img") Then
			'MsgBox "DOUBLE BARREL!"
			Exit Sub
		End If
		
		If Len(rtfReply) > 32000 Then rtfReply = Mid(rtfReply, Len(rtfReply) - 32000)
		
		If InStr(msg, Chr(198)) <> 0 Then
			
			rtfReply = rtfReply & "<B>"
			If Mid(msg, 1, InStr(msg, Chr(198)) - 1) = txtUID.Text Then
				rtfReply = rtfReply & "<font color=#00FF33>"
			Else
				rtfReply = rtfReply & "<font color=#3300FF>"
			End If
			
			rtfReply = rtfReply & Mid(msg, 1, InStr(msg, Chr(198)) - 1)
			rtfReply = rtfReply & "</B>"
			rtfReply = rtfReply & "<font color=#C0C0C0>"
			rtfReply = rtfReply & Mid(msg, InStr(msg, Chr(198)) + 1) & "<br>"
			
		Else
			
			rtfReply = rtfReply & "<font color=#C0C0C0>"
			rtfReply = rtfReply & Mid(msg, InStr(msg, Chr(198)) + 1) & "<br>"
		End If
		
		
		FileOpen(2, CurDir() & "\chat.htm", OpenMode.Output)
		
		PrintLine(2, "<HTML><BODY BGCOLOR=Black><font size=-1 face=arial>" & rtfReply & "<a name=ender></a></body></html>")
		
		FileClose(2)
		
		'UPGRADE_WARNING: Navigate2 was upgraded to Navigate and has a new behavior. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
		If playing = False Then wbReply.Navigate(New System.URI(CurDir() & "\chat.htm#ender"))
		
		
		Exit Sub
		
Failed: 
		FileOpen(4, CurDir() & "\errorlog.txt", OpenMode.Append)
		PrintLine(4, "newmessage - " & Str(Err.Number) & " - " & Err.Description & " - frmclient")
		FileClose(4)
		Resume Next
		
		
		
		
	End Sub
	
	
	Private Sub btnSend_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles btnSend.Click
		Dim KeyAscii As Object
		
		On Error GoTo Failed
		
		Dim parse As String
		
		If txtSend.Text <> "" Then
			
			parse = "MMMM" & txtUID.Text & Chr(198) & " - " & txtSend.Text
			
			
			Socket1.SendLen = Len(parse & Chr(3))
			Socket1.SendData = parse & Chr(3)
			'UPGRADE_WARNING: Couldn't resolve default property of object KeyAscii. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			KeyAscii = 0 : txtSend.Text = ""
		End If
		
		Exit Sub
		
Failed: 
		FileOpen(4, CurDir() & "\errorlog.txt", OpenMode.Append)
		PrintLine(4, "btnSend_Click - " & Str(Err.Number) & " - " & Err.Description & " - frmclient")
		FileClose(4)
		Resume Next
		
		
		
	End Sub
	
	Sub frmClient_FormClosed(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
		On Error GoTo Failed
		
		Timer1.Enabled = False
		
		
		On Error Resume Next
		
		frmHostGame.Close()
		frmJoinGame.Close()
		
		
		If Socket1.Connected Then
			If btnUID.Enabled = True Then
				Socket1.SendLen = Len("MMMM" & txtUID.Text & " failed to log in" & Chr(3))
				Socket1.SendData = "MMMM" & txtUID.Text & " failed to log in" & Chr(3)
				
			Else
				Socket1.SendLen = Len("@@@@" & txtUID.Text & Chr(3))
				Socket1.SendData = "@@@@" & txtUID.Text & Chr(3)
			End If
			Socket1.Action = SOCKET_CLOSE
		End If
		
		If booted = True Then
			'MsgBox "Connection Terminated - either you have logged in somewhere else or a moderator booted you", vbInformation, "Errant Venture Main Computer"
		End If
		End
		
		Exit Sub
		
Failed: 
		FileOpen(4, CurDir() & "\errorlog.txt", OpenMode.Append)
		PrintLine(4, "from_unload - " & Str(Err.Number) & " - " & Err.Description & " - frmclient")
		FileClose(4)
		Resume Next
		
		
		
	End Sub
	
	
	
	
	
	
	Private Sub Timer1_Tick(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles Timer1.Tick
		On Error GoTo Failed
		
		Dim i As Short
		
		If Socket1.Connected = False Then
			'Socket1.Action = SOCKET_CONNECT
			Socket1.Connect()
			
			newMessage("Lost Connection - Attempting to reconnect to the server")
		End If
		Exit Sub
		
Failed: 
		FileOpen(4, CurDir() & "\errorlog.txt", OpenMode.Append)
		PrintLine(4, "timer1_timer - " & Str(Err.Number) & " - " & Err.Description & " - frmclient")
		FileClose(4)
		Resume Next
		
		
		
	End Sub
	
	Private Sub txtHost_KeyPress(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyPressEventArgs) Handles txtHost.KeyPress
		Dim KeyAscii As Short = Asc(eventArgs.KeyChar)
		Dim msg As Object
		Dim i As Object
		On Error GoTo Failed
		If KeyAscii = Asc(Chr(3)) Then KeyAscii = 0
		
		For i = 0 To FilterCount
			
			If cboFilterOff.CheckState <> 1 Then
				
				'UPGRADE_WARNING: Couldn't resolve default property of object msg. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				msg = Replace(txtHost.Text, Filter_Renamed(i), "Smurf",  ,  , CompareMethod.Text)
				
			End If
			
		Next i
		
		
		
		GoTo EventExitSub
		
Failed: 
		FileOpen(4, CurDir() & "\errorlog.txt", OpenMode.Append)
		PrintLine(4, "txtHost_Keypress - " & Str(Err.Number) & " - " & Err.Description & " - frmclient")
		FileClose(4)
		Resume Next
		
		
		
EventExitSub: 
		eventArgs.KeyChar = Chr(KeyAscii)
		If KeyAscii = 0 Then
			eventArgs.Handled = True
		End If
	End Sub
	
	
	Private Sub txtSend_KeyPress(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyPressEventArgs) Handles txtSend.KeyPress
		Dim KeyAscii As Short = Asc(eventArgs.KeyChar)
		On Error GoTo Failed
		If KeyAscii = Asc(Chr(3)) Then KeyAscii = 0
		
		GoTo EventExitSub
		
Failed: 
		FileOpen(4, CurDir() & "\errorlog.txt", OpenMode.Append)
		PrintLine(4, "txtSend_KeyPress - " & Str(Err.Number) & " - " & Err.Description & " - frmclient")
		FileClose(4)
		Resume Next
		
		
		
EventExitSub: 
		eventArgs.KeyChar = Chr(KeyAscii)
		If KeyAscii = 0 Then
			eventArgs.Handled = True
		End If
	End Sub
	
	
	'UPGRADE_WARNING: Event txtUID.TextChanged may fire when form is initialized. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="88B12AE1-6DE0-48A0-86F1-60C0686C026A"'
	Private Sub txtUID_TextChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles txtUID.TextChanged
		Dim i As Object
		On Error GoTo Failed
		If Len(txtUID.Text) > 2 Then
			btnUID.Enabled = True
		End If
		
		For i = 0 To Me.FilterCount
			
			If cboFilterOff.CheckState <> 1 Then
				
				txtUID.Text = Replace(txtUID.Text, Filter_Renamed(i), "Smurf",  ,  , CompareMethod.Text)
				
			End If
			
		Next i
		Exit Sub
		
Failed: 
		FileOpen(4, CurDir() & "\errorlog.txt", OpenMode.Append)
		PrintLine(4, "txtUID_change - " & Str(Err.Number) & " - " & Err.Description & " - frmclient")
		FileClose(4)
		Resume Next
		
		
		
	End Sub
	
	Private Sub txtUID_KeyPress(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyPressEventArgs) Handles txtUID.KeyPress
		Dim KeyAscii As Short = Asc(eventArgs.KeyChar)
		On Error GoTo Failed
		If KeyAscii = Asc(Chr(3)) Then KeyAscii = 0
		GoTo EventExitSub
		
Failed: 
		FileOpen(4, CurDir() & "\errorlog.txt", OpenMode.Append)
		PrintLine(4, "txtUID_KeyPress - " & Str(Err.Number) & " - " & Err.Description & " - frmclient")
		FileClose(4)
		Resume Next
		
		
		
EventExitSub: 
		eventArgs.KeyChar = Chr(KeyAscii)
		If KeyAscii = 0 Then
			eventArgs.Handled = True
		End If
	End Sub
	Public Sub PlayWave(ByRef path As String)
		Dim MMControl1 As Object
		On Error GoTo Failed
		'UPGRADE_WARNING: Couldn't resolve default property of object MMControl1.FileName. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		MMControl1.FileName = path
		
		' Open the MCI WaveAudio device.
		
		'UPGRADE_WARNING: Couldn't resolve default property of object MMControl1.Command. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		MMControl1.Command = "Close"
		'UPGRADE_WARNING: Couldn't resolve default property of object MMControl1.Command. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		MMControl1.Command = "Back"
		'UPGRADE_WARNING: Couldn't resolve default property of object MMControl1.Command. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		MMControl1.Command = "Open"
		'UPGRADE_WARNING: Couldn't resolve default property of object MMControl1.Command. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		MMControl1.Command = "Play"
		
		Exit Sub
		
Failed: 
		FileOpen(4, CurDir() & "\errorlog.txt", OpenMode.Append)
		PrintLine(4, "PlayWave - " & Str(Err.Number) & " - " & Err.Description & " - frmclient")
		FileClose(4)
		Resume Next
		
		
		
	End Sub
	
	'UPGRADE_NOTE: Text was upgraded to Text_Renamed. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="A9E4979A-37FA-4718-9994-97DD76ED70A7"'
	Private Sub wbReply_StatusTextChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles wbReply.StatusTextChanged
		Dim Text_Renamed As String = CType(eventSender, WebBrowser).StatusText
		
	End Sub
End Class