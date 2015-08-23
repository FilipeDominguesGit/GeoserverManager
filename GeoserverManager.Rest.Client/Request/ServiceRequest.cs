using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeoserverManager.Rest.Client.Request
{
    public class ServiceRequest : IServiceRequest
    {
        public  string Uri { get; set; }

        public ServiceRequest(string uri)
        {
            Uri = uri;

        }


    }
}
