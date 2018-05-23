Imports Microsoft.VisualBasic
Imports System.ServiceModel
Imports DevExpress.Data.Utils.ServiceModel
Imports DevExpress.XtraReports.UI
' ...

Namespace E2876.Web
	' NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "ReportService1" in code, svc and config file together.
	<SilverlightFaultBehavior> _
	Public Class ReportService1
		Inherits DevExpress.XtraReports.Service.ReportService
		Protected Overrides Sub FillDataSources(ByVal report As XtraReport, ByVal reportName As String, ByVal isDesignActive As Boolean)
		End Sub

		Protected Overrides Sub SaveReportLayout(ByVal reportName As String, ByVal layoutData() As Byte)
			Throw New FaultException("This method is not implemented.")
		End Sub
	End Class
End Namespace
