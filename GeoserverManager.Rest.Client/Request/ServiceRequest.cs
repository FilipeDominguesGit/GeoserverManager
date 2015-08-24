using GeoserverManager.Rest.Client.Interface.Request;

namespace GeoserverManager.Rest.Client.Request
{
    public class ServiceRequest : IServiceRequest
    {
        public ServiceRequest(string uri)
        {
            Uri = uri;
        }

        public string Uri { get; set; }

        public string Body { get; set; }
    }
}