Option Strict Off
Option Explicit On
Module multilinetooltexttip
	
	'************************************************************
	' Constants
	'************************************************************
	
	Private Const GWL_WNDPROC As Short = -4
	Private Const GWL_STYLE As Short = (-16)
	
	Private Const WS_BORDER As Integer = &H800000
	
	Private Const FW_NORMAL As Short = 400
	Private Const FW_HEAVY As Short = 900
	Private Const FW_SEMIBOLD As Short = 600
	Private Const FW_BLACK As Short = FW_HEAVY
	Private Const FW_BOLD As Short = 700
	Private Const FW_DEMIBOLD As Short = FW_SEMIBOLD
	Private Const FW_DONTCARE As Short = 0
	Private Const FW_EXTRABOLD As Short = 800
	Private Const FW_EXTRALIGHT As Short = 200
	Private Const FW_LIGHT As Short = 300
	Private Const FW_MEDIUM As Short = 500
	Private Const FW_REGULAR As Short = FW_NORMAL
	Private Const FW_THIN As Short = 100
	Private Const FW_ULTRABOLD As Short = FW_EXTRABOLD
	Private Const FW_ULTRALIGHT As Short = FW_EXTRALIGHT
	
	Private Const SW_SHOWNA As Short = 8
	Private Const TRANSPARENT As Short = 1
	Private Const ALTERNATE As Short = 1
	Private Const BLACK_BRUSH As Short = 4
	Private Const DKGRAY_BRUSH As Short = 3
	
	Private Const DT_SINGLELINE As Integer = &H20
	Private Const DT_NOCLIP As Integer = &H100
	Private Const DT_CENTER As Integer = &H1
	Private Const DT_VCENTER As Integer = &H4
	Private Const DT_WORDBREAK As Integer = &H10
	Private Const DT_CALCRECT As Integer = &H400
	
	Private Const CW_USEDEFAULT As Integer = &H80000000
	
	Private Const TTS_ALWAYSTIP As Short = 1
	
	Private Const TTF_IDISHWND As Short = 1
	Private Const TTF_CENTERTIP As Short = 2
	Private Const TTF_RTLREADING As Short = 4
	Private Const TTF_SUBCLASS As Integer = &H10
	Private Const TTF_TRACK As Integer = &H20
	Private Const TTF_ABSOLUTE As Integer = &H80
	Private Const TTF_TRANSPARENT As Integer = &H100
	Private Const TTF_DI_SETITEM As Integer = &H8000
	
	Private Const WM_USER As Integer = &H400
	Private Const WM_PAINT As Integer = &HF
	Private Const WM_PRINT As Integer = &H317
	
	Private Const TTM_ACTIVATE As Decimal = WM_USER + 1
	Private Const TTM_SETDELAYTIME As Decimal = WM_USER + 3
	Private Const TTM_ADDTOOL As Decimal = WM_USER + 4
	Private Const TTM_DELTOOL As Decimal = WM_USER + 5
	Private Const TTM_NEWTOOLRECT As Decimal = WM_USER + 6
	Private Const TTM_RELAYEVENT As Decimal = WM_USER + 7
	
	Private Const LF_FACESIZE As Short = 32
	Private Const COLOR_INFOTEXT As Short = 23
	Private Const COLOR_INFOBK As Short = 24
	Private Const COLOR_GRAYTEXT As Short = 17
	Private Const COLOR_3DLIGHT As Short = 22
	
	Private Const RGN_OR As Short = 2
	
	'************************************************************
	' API Functions
	'************************************************************
	
	'UPGRADE_ISSUE: Declaring a parameter 'As Any' is not supported. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="FAE78A8D-8978-4FD4-8208-5B7324A8F795"'
    Private Declare Function CreateWindowEx Lib "user32.dll" Alias "CreateWindowExA" (ByVal dwExStyle As Integer, ByVal lpClassName As String, ByVal lpWindowName As String, ByVal dwStyle As Integer, ByVal x As Integer, ByVal y As Integer, ByVal nWidth As Integer, ByVal nHeight As Integer, ByVal hWndParent As Integer, ByVal hMenu As Integer, ByVal hInstance As Integer, ByRef lpParam As Object) As Integer
	
	'UPGRADE_ISSUE: Declaring a parameter 'As Any' is not supported. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="FAE78A8D-8978-4FD4-8208-5B7324A8F795"'
    Private Declare Function SendMessage Lib "user32.dll" Alias "SendMessageA" (ByVal hwnd As Integer, ByVal wMsg As Integer, ByVal wParam As Integer, ByRef lParam As Object) As Integer
	
	Private Declare Function CallWindowProc Lib "user32.dll"  Alias "CallWindowProcA"(ByVal lpPrevWndFunc As Integer, ByVal hwnd As Integer, ByVal Msg As Integer, ByVal wParam As Integer, ByVal lParam As Integer) As Integer
	
	Private Declare Function SetWindowLong Lib "user32.dll"  Alias "SetWindowLongA"(ByVal hwnd As Integer, ByVal nIndex As Integer, ByVal dwNewLong As Integer) As Integer
	
	Private Declare Function PostMessage Lib "user32.dll"  Alias "PostMessageA"(ByVal hwnd As Integer, ByVal wMsg As Integer, ByVal wParam As Integer, ByVal lParam As Integer) As Integer
	
	Private Declare Function GetWindowLong Lib "user32.dll"  Alias "GetWindowLongA"(ByVal hwnd As Integer, ByVal nIndex As Integer) As Integer
	
	'UPGRADE_WARNING: Structure RECT may require marshalling attributes to be passed as an argument in this Declare statement. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="C429C3A5-5D47-4CD9-8F51-74A1616405DC"'
	Private Declare Function GetWindowRect Lib "user32.dll" (ByVal hwnd As Integer, ByRef lpRect As RECT) As Integer
	
	Private Declare Function ShowWindow Lib "user32.dll" (ByVal hwnd As Integer, ByVal nCmdShow As Integer) As Integer
	
	Private Declare Function MoveWindow Lib "user32.dll" (ByVal hwnd As Integer, ByVal x As Integer, ByVal y As Integer, ByVal nWidth As Integer, ByVal nHeight As Integer, ByVal bRepaint As Integer) As Integer
	
	'UPGRADE_WARNING: Structure PAINTSTRUCT may require marshalling attributes to be passed as an argument in this Declare statement. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="C429C3A5-5D47-4CD9-8F51-74A1616405DC"'
	Private Declare Function BeginPaint Lib "user32.dll" (ByVal hwnd As Integer, ByRef lpPaint As PAINTSTRUCT) As Integer
	
	Private Declare Function GetWindowTextLength Lib "user32.dll"  Alias "GetWindowTextLengthA"(ByVal hwnd As Integer) As Integer
	
	Private Declare Function GetWindowText Lib "user32.dll"  Alias "GetWindowTextA"(ByVal hwnd As Integer, ByVal lpString As String, ByVal cch As Integer) As Integer
	
	'UPGRADE_WARNING: Structure PAINTSTRUCT may require marshalling attributes to be passed as an argument in this Declare statement. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="C429C3A5-5D47-4CD9-8F51-74A1616405DC"'
	Private Declare Function EndPaint Lib "user32.dll" (ByVal hwnd As Integer, ByRef lpPaint As PAINTSTRUCT) As Integer
	
	Private Declare Function GetSysColor Lib "user32.dll" (ByVal nIndex As Integer) As Integer
	
	'UPGRADE_WARNING: Structure RECT may require marshalling attributes to be passed as an argument in this Declare statement. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="C429C3A5-5D47-4CD9-8F51-74A1616405DC"'
	Private Declare Function GetClientRect Lib "user32.dll" (ByVal hwnd As Integer, ByRef lpRect As RECT) As Integer
	
	'UPGRADE_WARNING: Structure RECT may require marshalling attributes to be passed as an argument in this Declare statement. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="C429C3A5-5D47-4CD9-8F51-74A1616405DC"'
	Private Declare Function DrawText Lib "user32.dll"  Alias "DrawTextA"(ByVal hdc As Integer, ByVal lpStr As String, ByVal nCount As Integer, ByRef lpRect As RECT, ByVal wFormat As Integer) As Integer
	
	'UPGRADE_WARNING: Structure POINTAPI may require marshalling attributes to be passed as an argument in this Declare statement. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="C429C3A5-5D47-4CD9-8F51-74A1616405DC"'
	Private Declare Function GetCursorPos Lib "user32.dll" (ByRef lpPoint As POINTAPI) As Integer
	
	Private Declare Function SetBkMode Lib "gdi32.dll" (ByVal hdc As Integer, ByVal nBkMode As Integer) As Integer
	
	'UPGRADE_WARNING: Structure LOGFONT may require marshalling attributes to be passed as an argument in this Declare statement. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="C429C3A5-5D47-4CD9-8F51-74A1616405DC"'
	Private Declare Function CreateFontIndirect Lib "gdi32.dll"  Alias "CreateFontIndirectA"(ByRef lpLogFont As LOGFONT) As Integer
	
	Private Declare Function SetTextColor Lib "gdi32.dll" (ByVal hdc As Integer, ByVal crColor As Integer) As Integer
	
	Private Declare Function CreateRectRgn Lib "gdi32.dll" (ByVal X1 As Integer, ByVal Y1 As Integer, ByVal X2 As Integer, ByVal Y2 As Integer) As Integer
	
	Private Declare Function CreateRoundRectRgn Lib "gdi32.dll" (ByVal X1 As Integer, ByVal Y1 As Integer, ByVal X2 As Integer, ByVal Y2 As Integer, ByVal X3 As Integer, ByVal Y3 As Integer) As Integer
	
	'UPGRADE_WARNING: Structure POINTAPI may require marshalling attributes to be passed as an argument in this Declare statement. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="C429C3A5-5D47-4CD9-8F51-74A1616405DC"'
	Private Declare Function CreatePolygonRgn Lib "gdi32.dll" (ByRef lpPoint As POINTAPI, ByVal nCount As Integer, ByVal nPolyFillMode As Integer) As Integer
	
	Private Declare Function CombineRgn Lib "gdi32.dll" (ByVal hDestRgn As Integer, ByVal hSrcRgn1 As Integer, ByVal hSrcRgn2 As Integer, ByVal nCombineMode As Integer) As Integer
	
	Private Declare Function FillRgn Lib "gdi32.dll" (ByVal hdc As Integer, ByVal hRgn As Integer, ByVal hBrush As Integer) As Integer
	
	Private Declare Function GetSysColorBrush Lib "user32.dll" (ByVal nIndex As Integer) As Integer
	
	Private Declare Function FrameRgn Lib "gdi32.dll" (ByVal hdc As Integer, ByVal hRgn As Integer, ByVal hBrush As Integer, ByVal nWidth As Integer, ByVal nHeight As Integer) As Integer
	
	Private Declare Function GetStockObject Lib "gdi32.dll" (ByVal nIndex As Integer) As Integer
	
	Private Declare Function SelectObject Lib "gdi32.dll" (ByVal hdc As Integer, ByVal hObject As Integer) As Integer
	
	Private Declare Function DeleteObject Lib "gdi32.dll" (ByVal hObject As Integer) As Integer
	
	'************************************************************
	' Types
	'************************************************************
	
	Private Structure POINTAPI
		Dim x As Integer
		Dim y As Integer
	End Structure
	
	Private Structure RECT
		'UPGRADE_NOTE: Left was upgraded to Left_Renamed. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="A9E4979A-37FA-4718-9994-97DD76ED70A7"'
		Dim Left_Renamed As Integer
		Dim Top As Integer
		'UPGRADE_NOTE: Right was upgraded to Right_Renamed. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="A9E4979A-37FA-4718-9994-97DD76ED70A7"'
		Dim Right_Renamed As Integer
		Dim Bottom As Integer
	End Structure
	
	Private Structure TOOLINFO
		Dim cbSize As Integer
		Dim uFlags As Integer
		Dim hwnd As Integer
		Dim uId As Integer
		Dim r As RECT
		Dim hinst As Integer
		Dim lpszText As String
	End Structure
	
	Private Structure PAINTSTRUCT
		Dim hdc As Integer
		Dim fErase As Integer
		Dim rcPaint As RECT
		Dim fRestore As Integer
		Dim fIncUpdate As Integer
		<VBFixedArray(32)> Dim rgbReserved() As Byte
		
		'UPGRADE_TODO: "Initialize" must be called to initialize instances of this structure. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="B4BFF9E0-8631-45CF-910E-62AB3970F27B"'
		Public Sub Initialize()
			ReDim rgbReserved(32)
		End Sub
	End Structure
	
	Private Structure LOGFONT
		Dim lfHeight As Integer
		Dim lfWidth As Integer
		Dim lfEscapement As Integer
		Dim lfOrientation As Integer
		Dim lfWeight As Integer
		Dim lfItalic As Byte
		Dim lfUnderline As Byte
		Dim lfStrikeOut As Byte
		Dim lfCharSet As Byte
		Dim lfOutPrecision As Byte
		Dim lfClipPrecision As Byte
		Dim lfQuality As Byte
		Dim lfPitchAndFamily As Byte
		<VBFixedArray(LF_FACESIZE)> Dim lfFaceName() As Byte
		
		'UPGRADE_TODO: "Initialize" must be called to initialize instances of this structure. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="B4BFF9E0-8631-45CF-910E-62AB3970F27B"'
		Public Sub Initialize()
			'UPGRADE_WARNING: Lower bound of array lfFaceName was changed from 1 to 0. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="0F1C9BE1-AF9D-476E-83B1-17D43BECFF20"'
			ReDim lfFaceName(LF_FACESIZE)
		End Sub
	End Structure
	'************************************************************
	' Variables and Constants
	'************************************************************
	
	Private Structure TOldWndProc
		Dim hwnd As Integer
		Dim lPrevWndProc As Integer
	End Structure
	
	Private WndProc() As TOldWndProc
	Private NumTips As Integer
	Const iOffset As Short = 8
	Const FontType As String = "Tahoma" & vbNullChar
	Const FontSize As Short = 13
	
	'*************************************************************
	' Custom WindowProc for the ToolTip
	'*************************************************************
	Private Function CustomTipProc(ByVal hwnd As Integer, ByVal uiMsg As Integer, ByVal wParam As Integer, ByVal lParam As Integer) As Integer
		
		'UPGRADE_WARNING: Arrays in structure ps may need to be initialized before they can be used. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="814DF224-76BD-4BB4-BFFB-EA359CB9FC48"'
		Dim ps As PAINTSTRUCT
		Dim lpszText As String
		Dim iTextLen As Short
		Dim rc As RECT
		Dim hFont As Integer
		Dim hFontOld As Integer
		'UPGRADE_WARNING: Arrays in structure lf may need to be initialized before they can be used. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="814DF224-76BD-4BB4-BFFB-EA359CB9FC48"'
		Dim lf As LOGFONT
		Dim i As Short
		Dim CurPos As POINTAPI
		
		Select Case uiMsg
			Case WM_PRINT
				PostMessage(hwnd, WM_PAINT, 0, 0)
				CustomTipProc = 1
			Case WM_PAINT
				' Get the Current Window Rect
				GetWindowRect(hwnd, rc)
				GetCursorPos(CurPos)
				rc.Right_Renamed = CurPos.x - iOffset + 6 + rc.Right_Renamed - rc.Left_Renamed
				rc.Bottom = CurPos.y + 20 + rc.Bottom - rc.Top
				rc.Left_Renamed = CurPos.x - iOffset + 6
				rc.Top = CurPos.y + 20
				MoveWindow(hwnd, rc.Left_Renamed, rc.Top, rc.Right_Renamed - rc.Left_Renamed, rc.Bottom - rc.Top, False)
				' Get the Window Text (the ToolTip Text)
				iTextLen = GetWindowTextLength(hwnd) + 1
				lpszText = Space(iTextLen)
				GetWindowText(hwnd, lpszText, iTextLen)
				lpszText = Left(lpszText, Len(lpszText) - 1)
				' prepare the DC for drawing
				BeginPaint(hwnd, ps)
				' create and select the font to be used
				lf.lfHeight = FontSize
				lf.lfWeight = FW_NORMAL
				For i = 1 To Len(FontType)
					lf.lfFaceName(i) = Asc(Mid(FontType, i, 1))
				Next 
				hFont = CreateFontIndirect(lf)
				hFontOld = SelectObject(ps.hdc, hFont)
				' enlarge the window to exactly fit the size of the tooltip text
				
				' using DT_CALCRECT the function extends the base of the
				' rectangle to bound the last line of text but does not draw the text.
				DrawText(ps.hdc, lpszText, Len(lpszText), rc, DT_VCENTER + DT_NOCLIP + DT_CALCRECT)
				rc.Right_Renamed = rc.Right_Renamed + 2 * iOffset
				rc.Bottom = rc.Bottom + 3 * iOffset
				' show the window before changing its size
				' (work around the WM_PRINT problem/feature)
				ShowWindow(hwnd, SW_SHOWNA)
				' apply new size
				MoveWindow(hwnd, rc.Left_Renamed, rc.Top, rc.Right_Renamed - rc.Left_Renamed, rc.Bottom - rc.Top, True)
				SetBkMode(ps.hdc, TRANSPARENT)
				' draw the balloon
				ToolTip_DrawBalloon(hwnd, ps.hdc, lpszText)
				' Restore the Old Font
				SelectObject(ps.hdc, hFontOld)
				DeleteObject(hFont)
				' End Paint
				EndPaint(hwnd, ps)
				CustomTipProc = 0
			Case Else
				' Sends message to previous procedure
				For i = 0 To NumTips - 1
					If WndProc(i).hwnd = hwnd Then
						CustomTipProc = CallWindowProc(WndProc(i).lPrevWndProc, hwnd, uiMsg, wParam, lParam)
						Exit For
					End If
				Next 
		End Select
	End Function
	
	Private Sub ToolTip_DrawBalloon(ByRef hwndTip As Integer, ByRef hdc As Integer, ByRef lpszText As String)
		Dim rc As RECT
		Dim hRgn, hrgn1 As Object
		Dim hrgn2 As Integer
		Dim pts(2) As POINTAPI
		
		GetClientRect(hwndTip, rc)
		pts(0).x = rc.Left_Renamed + iOffset
		pts(0).y = rc.Top
		pts(1).x = pts(0).x
		pts(1).y = pts(0).y + iOffset
		pts(2).x = pts(1).x + iOffset
		pts(2).y = pts(1).y
		'UPGRADE_WARNING: Couldn't resolve default property of object hRgn. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		hRgn = CreateRectRgn(0, 0, 0, 0)
		' Create the rounded box
		'UPGRADE_WARNING: Couldn't resolve default property of object hrgn1. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		hrgn1 = CreateRoundRectRgn(rc.Left_Renamed, rc.Top + iOffset, rc.Right_Renamed, rc.Bottom, 15, 15)
		' Create the arrow
		hrgn2 = CreatePolygonRgn(pts(0), 3, ALTERNATE)
		' combine the two regions
		'UPGRADE_WARNING: Couldn't resolve default property of object hrgn1. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		'UPGRADE_WARNING: Couldn't resolve default property of object hRgn. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		CombineRgn(hRgn, hrgn1, hrgn2, RGN_OR)
		' Fill the Region with the Standard BackColor of the ToolTip Window
		'UPGRADE_WARNING: Couldn't resolve default property of object hRgn. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		FillRgn(hdc, hRgn, GetSysColorBrush(COLOR_INFOBK))
		' Draw the Frame Region
		'UPGRADE_WARNING: Couldn't resolve default property of object hRgn. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		FrameRgn(hdc, hRgn, GetStockObject(DKGRAY_BRUSH), 1, 1)
		rc.Top = rc.Top + iOffset * 2
		rc.Bottom = rc.Bottom - iOffset
		rc.Left_Renamed = rc.Left_Renamed + iOffset
		rc.Right_Renamed = rc.Right_Renamed - iOffset
		' Draw the Shadow Text
		SetTextColor(hdc, GetSysColor(COLOR_3DLIGHT))
		DrawText(hdc, lpszText, Len(lpszText), rc, DT_VCENTER + DT_NOCLIP)
		rc.Left_Renamed = rc.Left_Renamed - 1
		rc.Top = rc.Top - 1
		' Draw the Text
		SetTextColor(hdc, GetSysColor(COLOR_INFOTEXT))
		DrawText(hdc, lpszText, Len(lpszText), rc, DT_VCENTER + DT_NOCLIP)
	End Sub
	
	' Add the Custom ToolTip to the specified object
	Public Sub AddCustomToolTip(ByRef x As Object, ByRef ToolTipText As String, ByRef FormOwner As System.Windows.Forms.Form)
		Dim ti As TOOLINFO
		Dim dwStyle As Integer
		Dim hTip As Integer
		
		' A tooltip control with the TTS_ALWAYSTIP style appears when the cursor is
		' on a tool, regardless of whether the tooltip control's owner window is active
		' or inactive. Without this style, the tooltip control appears when the tool's
		' owner window is active, but not when it is inactive.
		hTip = CreateWindowEx(0, "tooltips_class32", "", TTS_ALWAYSTIP, CW_USEDEFAULT, CW_USEDEFAULT, CW_USEDEFAULT, CW_USEDEFAULT, FormOwner.Handle.ToInt32, 0, VB6.GetHInstance.ToInt32, 0)
		ti.cbSize = Len(ti)
		ti.uFlags = TTF_IDISHWND + TTF_SUBCLASS
		'UPGRADE_WARNING: Couldn't resolve default property of object x.hwnd. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		ti.hwnd = x.hwnd
		'UPGRADE_WARNING: Couldn't resolve default property of object x.hwnd. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		ti.uId = x.hwnd
		ti.lpszText = ToolTipText
		'UPGRADE_WARNING: Couldn't resolve default property of object ti. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		SendMessage(hTip, TTM_ADDTOOL, 0, ti)
		' SubClass the tooltip window
		ReDim Preserve WndProc(NumTips)
		'UPGRADE_WARNING: Add a delegate for AddressOf CustomTipProc Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="E9E157F7-EF0C-4016-87B7-7D7FBBC6EE08"'
        WndProc(NumTips).lPrevWndProc = SetWindowLong(hTip, GWL_WNDPROC, AddressOf CustomTipProc)
		WndProc(NumTips).hwnd = hTip
		NumTips = NumTips + 1
		' Remove Border from ToolTip
		dwStyle = GetWindowLong(hTip, GWL_STYLE)
		dwStyle = dwStyle And (Not WS_BORDER)
		SetWindowLong(hTip, GWL_STYLE, dwStyle)
	End Sub
End Module