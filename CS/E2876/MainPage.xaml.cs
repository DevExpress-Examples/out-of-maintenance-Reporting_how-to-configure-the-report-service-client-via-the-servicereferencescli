using System.Windows.Controls;
using DevExpress.Xpf.Printing;
using DevExpress.Xpf.Printing.ServiceModel;

namespace E2876 {
    public partial class MainPage : UserControl {
        public MainPage() {
            InitializeComponent();

            preview.Model = new ReportPreviewModel() {
                ReportName = "E2876.Web.SampleReport, E2876.Web",
                ServiceClientFactory = 
                    new ReportServiceClientFactory("endpointConfiguration")
            };
        }
    }
}
