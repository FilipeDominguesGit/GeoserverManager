using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using GeoserverManager.Rest.Client.Request;
using GeoserverManager.Rest.Client.Response;

namespace GeoserverManager.Rest.Client
{
    public interface IRestService
    {
        IServiceResponse Get(IServiceRequest request,IRequestSettings restSettings);
        IServiceResponse Get(IServiceRequest request);

        void Post(IServiceRequest request, IRequestSettings restSettings);
        void Post(IServiceRequest request);

        void Put(IServiceRequest request, IRequestSettings restSettings);
        void Put(IServiceRequest request);

    }
}
