using System.ServiceModel;
using DevExpress.Data.Utils.ServiceModel;
using DevExpress.XtraReports.UI;
// ...

namespace E2876.Web {
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "ReportService1" in code, svc and config file together.
    [SilverlightFaultBehavior]
    public class ReportService1 : DevExpress.XtraReports.Service.ReportService {
        protected override void FillDataSources(XtraReport report, string reportName, bool isDesignActive) {
        }

        protected override void SaveReportLayout(string reportName, byte[] layoutData) {
            throw new FaultException("This method is not implemented.");
        }
    }
}
