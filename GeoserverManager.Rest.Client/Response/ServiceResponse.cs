using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using GeoserverManager.Rest.Client.Interface.Response;

namespace GeoserverManager.Rest.Client.Response
{
    public class ServiceResponse : IServiceResponse
    {
        public HttpStatusCode StatusCode { get; set; }
        public string Data { get; set; }
    }
}
