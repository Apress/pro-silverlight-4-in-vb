﻿'------------------------------------------------------------------------------
' <auto-generated>
'     This code was generated by a tool.
'     Runtime Version:4.0.30319.1
'
'     Changes to this file may cause incorrect behavior and will be lost if
'     the code is regenerated.
' </auto-generated>
'------------------------------------------------------------------------------

Option Strict On
Option Explicit On


'
'This code was auto-generated by Microsoft.Silverlight.ServiceReference, version 4.0.50401.0
'
Namespace ServiceReference1
    
    <System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0"),  _
     System.ServiceModel.ServiceContractAttribute([Namespace]:="", ConfigurationName:="ServiceReference1.TestService")>  _
    Public Interface TestService
        
        <System.ServiceModel.OperationContractAttribute(AsyncPattern:=true, Action:="urn:TestService/GetServerTime", ReplyAction:="urn:TestService/GetServerTimeResponse")>  _
        Function BeginGetServerTime(ByVal callback As System.AsyncCallback, ByVal asyncState As Object) As System.IAsyncResult
        
        Function EndGetServerTime(ByVal result As System.IAsyncResult) As Date
        
        <System.ServiceModel.OperationContractAttribute(AsyncPattern:=true, Action:="urn:TestService/GetCachedServerTime", ReplyAction:="urn:TestService/GetCachedServerTimeResponse")>  _
        Function BeginGetCachedServerTime(ByVal callback As System.AsyncCallback, ByVal asyncState As Object) As System.IAsyncResult
        
        Function EndGetCachedServerTime(ByVal result As System.IAsyncResult) As Date
    End Interface
    
    <System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")>  _
    Public Interface TestServiceChannel
        Inherits ServiceReference1.TestService, System.ServiceModel.IClientChannel
    End Interface
    
    <System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")>  _
    Partial Public Class GetServerTimeCompletedEventArgs
        Inherits System.ComponentModel.AsyncCompletedEventArgs
        
        Private results() As Object
        
        Public Sub New(ByVal results() As Object, ByVal exception As System.Exception, ByVal cancelled As Boolean, ByVal userState As Object)
            MyBase.New(exception, cancelled, userState)
            Me.results = results
        End Sub
        
        Public ReadOnly Property Result() As Date
            Get
                MyBase.RaiseExceptionIfNecessary
                Return CType(Me.results(0),Date)
            End Get
        End Property
    End Class
    
    <System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")>  _
    Partial Public Class GetCachedServerTimeCompletedEventArgs
        Inherits System.ComponentModel.AsyncCompletedEventArgs
        
        Private results() As Object
        
        Public Sub New(ByVal results() As Object, ByVal exception As System.Exception, ByVal cancelled As Boolean, ByVal userState As Object)
            MyBase.New(exception, cancelled, userState)
            Me.results = results
        End Sub
        
        Public ReadOnly Property Result() As Date
            Get
                MyBase.RaiseExceptionIfNecessary
                Return CType(Me.results(0),Date)
            End Get
        End Property
    End Class
    
    <System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")>  _
    Partial Public Class TestServiceClient
        Inherits System.ServiceModel.ClientBase(Of ServiceReference1.TestService)
        Implements ServiceReference1.TestService
        
        Private onBeginGetServerTimeDelegate As BeginOperationDelegate
        
        Private onEndGetServerTimeDelegate As EndOperationDelegate
        
        Private onGetServerTimeCompletedDelegate As System.Threading.SendOrPostCallback
        
        Private onBeginGetCachedServerTimeDelegate As BeginOperationDelegate
        
        Private onEndGetCachedServerTimeDelegate As EndOperationDelegate
        
        Private onGetCachedServerTimeCompletedDelegate As System.Threading.SendOrPostCallback
        
        Private onBeginOpenDelegate As BeginOperationDelegate
        
        Private onEndOpenDelegate As EndOperationDelegate
        
        Private onOpenCompletedDelegate As System.Threading.SendOrPostCallback
        
        Private onBeginCloseDelegate As BeginOperationDelegate
        
        Private onEndCloseDelegate As EndOperationDelegate
        
        Private onCloseCompletedDelegate As System.Threading.SendOrPostCallback
        
        Public Sub New()
            MyBase.New
        End Sub
        
        Public Sub New(ByVal endpointConfigurationName As String)
            MyBase.New(endpointConfigurationName)
        End Sub
        
        Public Sub New(ByVal endpointConfigurationName As String, ByVal remoteAddress As String)
            MyBase.New(endpointConfigurationName, remoteAddress)
        End Sub
        
        Public Sub New(ByVal endpointConfigurationName As String, ByVal remoteAddress As System.ServiceModel.EndpointAddress)
            MyBase.New(endpointConfigurationName, remoteAddress)
        End Sub
        
        Public Sub New(ByVal binding As System.ServiceModel.Channels.Binding, ByVal remoteAddress As System.ServiceModel.EndpointAddress)
            MyBase.New(binding, remoteAddress)
        End Sub
        
        Public Property CookieContainer() As System.Net.CookieContainer
            Get
                Dim httpCookieContainerManager As System.ServiceModel.Channels.IHttpCookieContainerManager = Me.InnerChannel.GetProperty(Of System.ServiceModel.Channels.IHttpCookieContainerManager)
                If (Not (httpCookieContainerManager) Is Nothing) Then
                    Return httpCookieContainerManager.CookieContainer
                Else
                    Return Nothing
                End If
            End Get
            Set
                Dim httpCookieContainerManager As System.ServiceModel.Channels.IHttpCookieContainerManager = Me.InnerChannel.GetProperty(Of System.ServiceModel.Channels.IHttpCookieContainerManager)
                If (Not (httpCookieContainerManager) Is Nothing) Then
                    httpCookieContainerManager.CookieContainer = value
                Else
                    Throw New System.InvalidOperationException("Unable to set the CookieContainer. Please make sure the binding contains an HttpC"& _ 
                            "ookieContainerBindingElement.")
                End If
            End Set
        End Property
        
        Public Event GetServerTimeCompleted As System.EventHandler(Of GetServerTimeCompletedEventArgs)
        
        Public Event GetCachedServerTimeCompleted As System.EventHandler(Of GetCachedServerTimeCompletedEventArgs)
        
        Public Event OpenCompleted As System.EventHandler(Of System.ComponentModel.AsyncCompletedEventArgs)
        
        Public Event CloseCompleted As System.EventHandler(Of System.ComponentModel.AsyncCompletedEventArgs)
        
        <System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)>  _
        Function ServiceReference1_TestService_BeginGetServerTime(ByVal callback As System.AsyncCallback, ByVal asyncState As Object) As System.IAsyncResult Implements ServiceReference1.TestService.BeginGetServerTime
            Return MyBase.Channel.BeginGetServerTime(callback, asyncState)
        End Function
        
        <System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)>  _
        Function ServiceReference1_TestService_EndGetServerTime(ByVal result As System.IAsyncResult) As Date Implements ServiceReference1.TestService.EndGetServerTime
            Return MyBase.Channel.EndGetServerTime(result)
        End Function
        
        Private Function OnBeginGetServerTime(ByVal inValues() As Object, ByVal callback As System.AsyncCallback, ByVal asyncState As Object) As System.IAsyncResult
            Return CType(Me,ServiceReference1.TestService).BeginGetServerTime(callback, asyncState)
        End Function
        
        Private Function OnEndGetServerTime(ByVal result As System.IAsyncResult) As Object()
            Dim retVal As Date = CType(Me,ServiceReference1.TestService).EndGetServerTime(result)
            Return New Object() {retVal}
        End Function
        
        Private Sub OnGetServerTimeCompleted(ByVal state As Object)
            If (Not (Me.GetServerTimeCompletedEvent) Is Nothing) Then
                Dim e As InvokeAsyncCompletedEventArgs = CType(state,InvokeAsyncCompletedEventArgs)
                RaiseEvent GetServerTimeCompleted(Me, New GetServerTimeCompletedEventArgs(e.Results, e.Error, e.Cancelled, e.UserState))
            End If
        End Sub
        
        Public Overloads Sub GetServerTimeAsync()
            Me.GetServerTimeAsync(Nothing)
        End Sub
        
        Public Overloads Sub GetServerTimeAsync(ByVal userState As Object)
            If (Me.onBeginGetServerTimeDelegate Is Nothing) Then
                Me.onBeginGetServerTimeDelegate = AddressOf Me.OnBeginGetServerTime
            End If
            If (Me.onEndGetServerTimeDelegate Is Nothing) Then
                Me.onEndGetServerTimeDelegate = AddressOf Me.OnEndGetServerTime
            End If
            If (Me.onGetServerTimeCompletedDelegate Is Nothing) Then
                Me.onGetServerTimeCompletedDelegate = AddressOf Me.OnGetServerTimeCompleted
            End If
            MyBase.InvokeAsync(Me.onBeginGetServerTimeDelegate, Nothing, Me.onEndGetServerTimeDelegate, Me.onGetServerTimeCompletedDelegate, userState)
        End Sub
        
        <System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)>  _
        Function ServiceReference1_TestService_BeginGetCachedServerTime(ByVal callback As System.AsyncCallback, ByVal asyncState As Object) As System.IAsyncResult Implements ServiceReference1.TestService.BeginGetCachedServerTime
            Return MyBase.Channel.BeginGetCachedServerTime(callback, asyncState)
        End Function
        
        <System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)>  _
        Function ServiceReference1_TestService_EndGetCachedServerTime(ByVal result As System.IAsyncResult) As Date Implements ServiceReference1.TestService.EndGetCachedServerTime
            Return MyBase.Channel.EndGetCachedServerTime(result)
        End Function
        
        Private Function OnBeginGetCachedServerTime(ByVal inValues() As Object, ByVal callback As System.AsyncCallback, ByVal asyncState As Object) As System.IAsyncResult
            Return CType(Me,ServiceReference1.TestService).BeginGetCachedServerTime(callback, asyncState)
        End Function
        
        Private Function OnEndGetCachedServerTime(ByVal result As System.IAsyncResult) As Object()
            Dim retVal As Date = CType(Me,ServiceReference1.TestService).EndGetCachedServerTime(result)
            Return New Object() {retVal}
        End Function
        
        Private Sub OnGetCachedServerTimeCompleted(ByVal state As Object)
            If (Not (Me.GetCachedServerTimeCompletedEvent) Is Nothing) Then
                Dim e As InvokeAsyncCompletedEventArgs = CType(state,InvokeAsyncCompletedEventArgs)
                RaiseEvent GetCachedServerTimeCompleted(Me, New GetCachedServerTimeCompletedEventArgs(e.Results, e.Error, e.Cancelled, e.UserState))
            End If
        End Sub
        
        Public Overloads Sub GetCachedServerTimeAsync()
            Me.GetCachedServerTimeAsync(Nothing)
        End Sub
        
        Public Overloads Sub GetCachedServerTimeAsync(ByVal userState As Object)
            If (Me.onBeginGetCachedServerTimeDelegate Is Nothing) Then
                Me.onBeginGetCachedServerTimeDelegate = AddressOf Me.OnBeginGetCachedServerTime
            End If
            If (Me.onEndGetCachedServerTimeDelegate Is Nothing) Then
                Me.onEndGetCachedServerTimeDelegate = AddressOf Me.OnEndGetCachedServerTime
            End If
            If (Me.onGetCachedServerTimeCompletedDelegate Is Nothing) Then
                Me.onGetCachedServerTimeCompletedDelegate = AddressOf Me.OnGetCachedServerTimeCompleted
            End If
            MyBase.InvokeAsync(Me.onBeginGetCachedServerTimeDelegate, Nothing, Me.onEndGetCachedServerTimeDelegate, Me.onGetCachedServerTimeCompletedDelegate, userState)
        End Sub
        
        Private Function OnBeginOpen(ByVal inValues() As Object, ByVal callback As System.AsyncCallback, ByVal asyncState As Object) As System.IAsyncResult
            Return CType(Me,System.ServiceModel.ICommunicationObject).BeginOpen(callback, asyncState)
        End Function
        
        Private Function OnEndOpen(ByVal result As System.IAsyncResult) As Object()
            CType(Me,System.ServiceModel.ICommunicationObject).EndOpen(result)
            Return Nothing
        End Function
        
        Private Sub OnOpenCompleted(ByVal state As Object)
            If (Not (Me.OpenCompletedEvent) Is Nothing) Then
                Dim e As InvokeAsyncCompletedEventArgs = CType(state,InvokeAsyncCompletedEventArgs)
                RaiseEvent OpenCompleted(Me, New System.ComponentModel.AsyncCompletedEventArgs(e.[Error], e.Cancelled, e.UserState))
            End If
        End Sub
        
        Public Overloads Sub OpenAsync()
            Me.OpenAsync(Nothing)
        End Sub
        
        Public Overloads Sub OpenAsync(ByVal userState As Object)
            If (Me.onBeginOpenDelegate Is Nothing) Then
                Me.onBeginOpenDelegate = AddressOf Me.OnBeginOpen
            End If
            If (Me.onEndOpenDelegate Is Nothing) Then
                Me.onEndOpenDelegate = AddressOf Me.OnEndOpen
            End If
            If (Me.onOpenCompletedDelegate Is Nothing) Then
                Me.onOpenCompletedDelegate = AddressOf Me.OnOpenCompleted
            End If
            MyBase.InvokeAsync(Me.onBeginOpenDelegate, Nothing, Me.onEndOpenDelegate, Me.onOpenCompletedDelegate, userState)
        End Sub
        
        Private Function OnBeginClose(ByVal inValues() As Object, ByVal callback As System.AsyncCallback, ByVal asyncState As Object) As System.IAsyncResult
            Return CType(Me,System.ServiceModel.ICommunicationObject).BeginClose(callback, asyncState)
        End Function
        
        Private Function OnEndClose(ByVal result As System.IAsyncResult) As Object()
            CType(Me,System.ServiceModel.ICommunicationObject).EndClose(result)
            Return Nothing
        End Function
        
        Private Sub OnCloseCompleted(ByVal state As Object)
            If (Not (Me.CloseCompletedEvent) Is Nothing) Then
                Dim e As InvokeAsyncCompletedEventArgs = CType(state,InvokeAsyncCompletedEventArgs)
                RaiseEvent CloseCompleted(Me, New System.ComponentModel.AsyncCompletedEventArgs(e.[Error], e.Cancelled, e.UserState))
            End If
        End Sub
        
        Public Overloads Sub CloseAsync()
            Me.CloseAsync(Nothing)
        End Sub
        
        Public Overloads Sub CloseAsync(ByVal userState As Object)
            If (Me.onBeginCloseDelegate Is Nothing) Then
                Me.onBeginCloseDelegate = AddressOf Me.OnBeginClose
            End If
            If (Me.onEndCloseDelegate Is Nothing) Then
                Me.onEndCloseDelegate = AddressOf Me.OnEndClose
            End If
            If (Me.onCloseCompletedDelegate Is Nothing) Then
                Me.onCloseCompletedDelegate = AddressOf Me.OnCloseCompleted
            End If
            MyBase.InvokeAsync(Me.onBeginCloseDelegate, Nothing, Me.onEndCloseDelegate, Me.onCloseCompletedDelegate, userState)
        End Sub
        
        Protected Overrides Function CreateChannel() As ServiceReference1.TestService
            Return New TestServiceClientChannel(Me)
        End Function
        
        Private Class TestServiceClientChannel
            Inherits ChannelBase(Of ServiceReference1.TestService)
            Implements ServiceReference1.TestService
            
            Public Sub New(ByVal client As System.ServiceModel.ClientBase(Of ServiceReference1.TestService))
                MyBase.New(client)
            End Sub
            
            Public Function BeginGetServerTime(ByVal callback As System.AsyncCallback, ByVal asyncState As Object) As System.IAsyncResult Implements ServiceReference1.TestService.BeginGetServerTime
                Dim _args((0) - 1) As Object
                Dim _result As System.IAsyncResult = MyBase.BeginInvoke("GetServerTime", _args, callback, asyncState)
                Return _result
            End Function
            
            Public Function EndGetServerTime(ByVal result As System.IAsyncResult) As Date Implements ServiceReference1.TestService.EndGetServerTime
                Dim _args((0) - 1) As Object
                Dim _result As Date = CType(MyBase.EndInvoke("GetServerTime", _args, result),Date)
                Return _result
            End Function
            
            Public Function BeginGetCachedServerTime(ByVal callback As System.AsyncCallback, ByVal asyncState As Object) As System.IAsyncResult Implements ServiceReference1.TestService.BeginGetCachedServerTime
                Dim _args((0) - 1) As Object
                Dim _result As System.IAsyncResult = MyBase.BeginInvoke("GetCachedServerTime", _args, callback, asyncState)
                Return _result
            End Function
            
            Public Function EndGetCachedServerTime(ByVal result As System.IAsyncResult) As Date Implements ServiceReference1.TestService.EndGetCachedServerTime
                Dim _args((0) - 1) As Object
                Dim _result As Date = CType(MyBase.EndInvoke("GetCachedServerTime", _args, result),Date)
                Return _result
            End Function
        End Class
    End Class
End Namespace
