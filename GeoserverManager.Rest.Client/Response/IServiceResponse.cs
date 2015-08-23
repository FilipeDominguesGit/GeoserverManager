using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace GeoserverManager.Rest.Client.Response
{
    public interface IServiceResponse
    {
        HttpStatusCode StatusCode { get; set; }

        string Data { get; set; }
    }
}
