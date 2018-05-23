Imports Microsoft.VisualBasic
Imports System.Windows.Controls
Imports DevExpress.Xpf.Printing
Imports DevExpress.Xpf.Printing.ServiceModel

Namespace E2876
	Partial Public Class MainPage
		Inherits UserControl
		Public Sub New()
			InitializeComponent()

			preview.Model = New ReportPreviewModel() With {.ReportName = "E2876.Web.SampleReport, E2876.Web", .ServiceClientFactory = New ReportServiceClientFactory("endpointConfiguration")}
		End Sub
	End Class
End Namespace
