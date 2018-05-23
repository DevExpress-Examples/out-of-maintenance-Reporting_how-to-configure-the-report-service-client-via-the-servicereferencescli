Imports Microsoft.VisualBasic
Imports System.Windows.Controls
Imports DevExpress.Xpf.Printing

Namespace E2876
	Partial Public Class MainPage
		Inherits UserControl
		Public Sub New()
			InitializeComponent()
			' B187159 workaround
			CType(preview.Model, ReportPreviewModel).ServiceUri = "../ReportService.svc"
		End Sub
	End Class
End Namespace
