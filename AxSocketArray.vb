'UPGRADE_WARNING: The entire project must be compiled once before a form with an ActiveX Control Array can be displayed

Imports System.ComponentModel

<ProvideProperty("Index",GetType(AxSocketWrenchCtrl.AxSocket))> Public Class AxSocketArray
	Inherits Microsoft.VisualBasic.Compatibility.VB6.BaseOcxArray
	Implements IExtenderProvider

	Public Sub New()
		MyBase.New()
	End Sub

	Public Sub New(ByVal Container As IContainer)
		MyBase.New(Container)
	End Sub

	Public Shadows Event [AcceptEvent] (ByVal sender As System.Object, ByVal e As AxSocketWrenchCtrl._DSocketWrenchEvents_AcceptEvent)
	Public Shadows Event [BlockingEvent] (ByVal sender As System.Object, ByVal e As AxSocketWrenchCtrl._DSocketWrenchEvents_BlockingEvent)
	Public Shadows Event [CancelEvent] (ByVal sender As System.Object, ByVal e As AxSocketWrenchCtrl._DSocketWrenchEvents_CancelEvent)
	Public Shadows Event [ConnectEvent] (ByVal sender As System.Object, ByVal e As System.EventArgs)
	Public Shadows Event [LastErrorEvent] (ByVal sender As System.Object, ByVal e As AxSocketWrenchCtrl._DSocketWrenchEvents_LastErrorEvent)
	Public Shadows Event [ReadEvent] (ByVal sender As System.Object, ByVal e As AxSocketWrenchCtrl._DSocketWrenchEvents_ReadEvent)
	Public Shadows Event [TimeoutEvent] (ByVal sender As System.Object, ByVal e As AxSocketWrenchCtrl._DSocketWrenchEvents_TimeoutEvent)
	Public Shadows Event [Timer] (ByVal sender As System.Object, ByVal e As System.EventArgs)
	Public Shadows Event [WriteEvent] (ByVal sender As System.Object, ByVal e As System.EventArgs)
	Public Shadows Event [DisconnectEvent] (ByVal sender As System.Object, ByVal e As System.EventArgs)

	<System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)> Public Function CanExtend(ByVal target As Object) As Boolean Implements IExtenderProvider.CanExtend
		If TypeOf target Is AxSocketWrenchCtrl.AxSocket Then
			Return BaseCanExtend(target)
		End If
	End Function

	Public Function GetIndex(ByVal o As AxSocketWrenchCtrl.AxSocket) As Short
		Return BaseGetIndex(o)
	End Function

	<System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)> Public Sub SetIndex(ByVal o As AxSocketWrenchCtrl.AxSocket, ByVal Index As Short)
		BaseSetIndex(o, Index)
	End Sub

	<System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)> Public Function ShouldSerializeIndex(ByVal o As AxSocketWrenchCtrl.AxSocket) As Boolean
		Return BaseShouldSerializeIndex(o)
	End Function

	<System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)> Public Sub ResetIndex(ByVal o As AxSocketWrenchCtrl.AxSocket)
		BaseResetIndex(o)
	End Sub

	Default Public ReadOnly Property Item(ByVal Index As Short) As AxSocketWrenchCtrl.AxSocket
		Get
			Item = CType(BaseGetItem(Index), AxSocketWrenchCtrl.AxSocket)
		End Get
	End Property

	Protected Overrides Function GetControlInstanceType() As System.Type
		Return GetType(AxSocketWrenchCtrl.AxSocket)
	End Function

	Protected Overrides Sub HookUpControlEvents(ByVal o As Object)
		Dim ctl As AxSocketWrenchCtrl.AxSocket = CType(o, AxSocketWrenchCtrl.AxSocket)
		MyBase.HookUpControlEvents(o)
		If Not AcceptEventEvent Is Nothing Then
			AddHandler ctl.AcceptEvent, New AxSocketWrenchCtrl._DSocketWrenchEvents_AcceptEventHandler(AddressOf HandleAcceptEvent)
		End If
		If Not BlockingEventEvent Is Nothing Then
			AddHandler ctl.BlockingEvent, New AxSocketWrenchCtrl._DSocketWrenchEvents_BlockingEventHandler(AddressOf HandleBlockingEvent)
		End If
		If Not CancelEventEvent Is Nothing Then
			AddHandler ctl.CancelEvent, New AxSocketWrenchCtrl._DSocketWrenchEvents_CancelEventHandler(AddressOf HandleCancelEvent)
		End If
		If Not ConnectEventEvent Is Nothing Then
			AddHandler ctl.ConnectEvent, New System.EventHandler(AddressOf HandleConnectEvent)
		End If
		If Not LastErrorEventEvent Is Nothing Then
			AddHandler ctl.LastErrorEvent, New AxSocketWrenchCtrl._DSocketWrenchEvents_LastErrorEventHandler(AddressOf HandleLastErrorEvent)
		End If
		If Not ReadEventEvent Is Nothing Then
			AddHandler ctl.ReadEvent, New AxSocketWrenchCtrl._DSocketWrenchEvents_ReadEventHandler(AddressOf HandleReadEvent)
		End If
		If Not TimeoutEventEvent Is Nothing Then
			AddHandler ctl.TimeoutEvent, New AxSocketWrenchCtrl._DSocketWrenchEvents_TimeoutEventHandler(AddressOf HandleTimeoutEvent)
		End If
		If Not TimerEvent Is Nothing Then
			AddHandler ctl.Timer, New System.EventHandler(AddressOf HandleTimer)
		End If
		If Not WriteEventEvent Is Nothing Then
			AddHandler ctl.WriteEvent, New System.EventHandler(AddressOf HandleWriteEvent)
		End If
		If Not DisconnectEventEvent Is Nothing Then
			AddHandler ctl.DisconnectEvent, New System.EventHandler(AddressOf HandleDisconnectEvent)
		End If
	End Sub

	Private Sub HandleAcceptEvent (ByVal sender As System.Object, ByVal e As AxSocketWrenchCtrl._DSocketWrenchEvents_AcceptEvent) 
		RaiseEvent [AcceptEvent] (sender, e)
	End Sub

	Private Sub HandleBlockingEvent (ByVal sender As System.Object, ByVal e As AxSocketWrenchCtrl._DSocketWrenchEvents_BlockingEvent) 
		RaiseEvent [BlockingEvent] (sender, e)
	End Sub

	Private Sub HandleCancelEvent (ByVal sender As System.Object, ByVal e As AxSocketWrenchCtrl._DSocketWrenchEvents_CancelEvent) 
		RaiseEvent [CancelEvent] (sender, e)
	End Sub

	Private Sub HandleConnectEvent (ByVal sender As System.Object, ByVal e As System.EventArgs) 
		RaiseEvent [ConnectEvent] (sender, e)
	End Sub

	Private Sub HandleLastErrorEvent (ByVal sender As System.Object, ByVal e As AxSocketWrenchCtrl._DSocketWrenchEvents_LastErrorEvent) 
		RaiseEvent [LastErrorEvent] (sender, e)
	End Sub

	Private Sub HandleReadEvent (ByVal sender As System.Object, ByVal e As AxSocketWrenchCtrl._DSocketWrenchEvents_ReadEvent) 
		RaiseEvent [ReadEvent] (sender, e)
	End Sub

	Private Sub HandleTimeoutEvent (ByVal sender As System.Object, ByVal e As AxSocketWrenchCtrl._DSocketWrenchEvents_TimeoutEvent) 
		RaiseEvent [TimeoutEvent] (sender, e)
	End Sub

	Private Sub HandleTimer (ByVal sender As System.Object, ByVal e As System.EventArgs) 
		RaiseEvent [Timer] (sender, e)
	End Sub

	Private Sub HandleWriteEvent (ByVal sender As System.Object, ByVal e As System.EventArgs) 
		RaiseEvent [WriteEvent] (sender, e)
	End Sub

	Private Sub HandleDisconnectEvent (ByVal sender As System.Object, ByVal e As System.EventArgs) 
		RaiseEvent [DisconnectEvent] (sender, e)
	End Sub

End Class

