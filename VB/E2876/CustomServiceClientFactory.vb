Imports Microsoft.VisualBasic
Imports System.ServiceModel
Imports DevExpress.Xpf.Printing.ServiceModel
' ...

Namespace E2876
	Public Class CustomServiceClientFactory
		Inherits ReportServiceClientFactory
		Private privateEndpointConfigurationName As String
		Public Property EndpointConfigurationName() As String
			Get
				Return privateEndpointConfigurationName
			End Get
			Set(ByVal value As String)
				privateEndpointConfigurationName = value
			End Set
		End Property

		Public Overrides Function Create(ByVal serviceAddress As EndpointAddress) As IReportServiceClient
			Dim channelFactory = New ChannelFactory(Of IAsyncReportService)(EndpointConfigurationName)
			Dim channel = channelFactory.CreateChannel()
			Return CreateClient(channel)
		End Function
	End Class
End Namespace
