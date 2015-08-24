using GeoserverManager.Rest.Client.Interface.Request;
using GeoserverManager.Rest.Client.Interface.Response;

namespace GeoserverManager.Rest.Client.Interface
{
    public interface IRestService
    {
        IServiceResponse Get(IServiceRequest request, IRequestSettings restSettings);
        IServiceResponse Get(IServiceRequest request);
        void Post(IServiceRequest request, IRequestSettings restSettings);
        IServiceResponse Post(IServiceRequest request);
        void Put(IServiceRequest request, IRequestSettings restSettings);
        void Put(IServiceRequest request);
    }
}