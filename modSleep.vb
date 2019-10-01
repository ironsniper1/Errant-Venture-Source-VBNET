Option Strict Off
Option Explicit On
Module modSleep
	' modSleep - Use API which allows other processes to continue
	' 1998/05/07 Copyright 1998, Larry Rebich
	
	'UPGRADE_NOTE: DefLng A-Z statement was removed. Variables were explicitly declared as type Integer. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="92AFD3E3-440D-4D49-A8BF-580D74A8C9F2"'
	
	Private Declare Sub Sleep Lib "kernel32" (ByVal dwMilliseconds As Integer)
	'
	
	Public Sub GoSleep(ByRef lSeconds As Integer) 'pass seconds as long [original function]
		Const clMillPerSec As Integer = 1000 'milliseconds per second
		Sleep(lSeconds * clMillPerSec) 'convert seconds to milliseconds then call sleep
	End Sub
	
	Public Sub GoSleepEX(ByRef rSeconds As Single) 'pass seconds as single to allow decimal
		Const clMillPerSec As Integer = 1000 'milliseconds per second
		Dim lSeconds As Integer
		lSeconds = rSeconds * clMillPerSec 'convert to long
		Sleep(lSeconds) 'call sleep
	End Sub
End Module