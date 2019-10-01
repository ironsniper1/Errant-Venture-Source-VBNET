Option Strict Off
Option Explicit On
Module sound
	'Written for form or class module, change declarations to public
	'for .bas modules
	
	Public Declare Function PlaySound Lib "winmm.dll"  Alias "PlaySoundA"(ByVal lpszName As String, ByVal hModule As Integer, ByVal dwFlags As Integer) As Integer
	
	Const SND_ASYNC As Integer = &H1 'continue executing code even
	'if sound isn't finished
	Const SND_FILENAME As Integer = &H20000 '  name is a file name
	Const SND_SYNC As Integer = &H0 'suspend execution until sound is finished
	Const SND_NODEFAULT As Integer = &H2 'if file name is not found, don't play
	'default sound
	Const SND_LOOP As Integer = &H8 'loop the sound until next call to the
	'function
	Const SND_NOSTOP As Integer = &H10 'don't stop any currently playing sound
	Const SND_NOWAIT As Integer = &H2000 'return immediately if driver is busy
	
	'PURPOSE: Plays a .WAV file
	'PARAMETER: .WAV to play
	'RETURNS: True if Successful, false otherwise
	Public Function PlayASound(ByRef SoundFile As String) As Boolean
		
		Dim bSuccess As Boolean
		
		'Flags indicate that sound is a file, to play asynchrounously,
		'not to stop any currently playing sound, and not to play the
		'default sound (and return false) if file
		'is not found.  See declarations for other options.
		
		bSuccess = PlaySound(SoundFile, VariantType.Null, SND_FILENAME + SND_SYNC + SND_NOSTOP + SND_NODEFAULT)
		
		PlayASound = bSuccess
		
	End Function
End Module