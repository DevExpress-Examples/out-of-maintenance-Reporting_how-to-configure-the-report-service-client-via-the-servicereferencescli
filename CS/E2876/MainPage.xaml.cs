using System.Windows.Controls;
using DevExpress.Xpf.Printing;

namespace E2876
{
    public partial class MainPage : UserControl
    {
        public MainPage()
        {
            InitializeComponent();
            // B187159 workaround
            ((ReportPreviewModel)preview.Model).ServiceUri = "../ReportService.svc";
        }
    }
}
