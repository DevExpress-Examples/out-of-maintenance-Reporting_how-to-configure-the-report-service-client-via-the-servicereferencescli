using System.ServiceModel;
using DevExpress.Xpf.Printing.ServiceModel;
// ...

namespace E2876 {
    public class CustomServiceClientFactory : ReportServiceClientFactory {
        public string EndpointConfigurationName { get; set; }

        public override IReportServiceClient Create(EndpointAddress serviceAddress) {
            var channelFactory = new ChannelFactory<IAsyncReportService>(EndpointConfigurationName);
            var channel = channelFactory.CreateChannel();
            return CreateClient(channel);
        }
    }
}
