using System;
using System.ServiceModel;
using System.ServiceModel.Channels;
using DevExpress.Xpf.Printing;
using DevExpress.Xpf.Printing.ServiceReference;
// ...

namespace SilverlightApplication1 {
    public class MyServiceClientFactory : IServiceClientFactory {

        public string EndpointConfigurationName { get; set; }

        #region IServiceClientFactory Members
        public Binding Binding {
            get { throw new NotSupportedException(); }
            set { throw new NotSupportedException(); }
        }

        public ServiceClient Create(EndpointAddress serviceAddress) {
            return new ServiceClient(EndpointConfigurationName);
        }
        #endregion
    }
}
