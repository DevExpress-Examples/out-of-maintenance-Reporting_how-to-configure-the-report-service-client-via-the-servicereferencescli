Imports System
Imports System.ServiceModel
Imports System.ServiceModel.Channels
Imports DevExpress.Xpf.Printing
Imports DevExpress.Xpf.Printing.ServiceReference
' ...

Namespace SilverlightApplication1
    Public Class MyServiceClientFactory
        Implements IServiceClientFactory

        Private privateEndpointConfigurationName As String

        Public Property EndpointConfigurationName() As String
            Get
                Return privateEndpointConfigurationName
            End Get
            Set(ByVal value As String)
                privateEndpointConfigurationName = value
            End Set
        End Property

#Region "IServiceClientFactory Members"
        Public Overloads Property Binding() _ 
        As Binding Implements IServiceClientFactory.Binding
            Get
                Throw New NotSupportedException()
            End Get
            Set(ByVal value As Binding)
                Throw New NotSupportedException()
            End Set
        End Property

        Public Overloads Function Create(ByVal serviceAddress As EndpointAddress) _ 
        As ServiceClient Implements IServiceClientFactory.Create
            Return New ServiceClient(Me.EndpointConfigurationName)
        End Function
#End Region

    End Class
End Namespace
