using System.Windows.Controls;
using DevExpress.DocumentServices.ServiceModel.Client;
using DevExpress.Xpf.Printing;
// ...

namespace E2876 {
    public partial class MainPage : UserControl {
        public MainPage() {
            InitializeComponent();

            preview.Model = new ReportServicePreviewModel() {
                ReportName = "E2876.Web.SampleReport, E2876.Web",
                ServiceClientFactory = 
                    new ReportServiceClientFactory("endpointConfiguration")
            };
        }
    }
}
