using GeoserverManager.Entities.Interface.BussinessModel;
using GeoserverManager.UseCases.Interface.UseCases.Layers.Requests;

namespace GeoserverManager.UseCases.UseCases.Layers.Requests
{
    public class GetLayerStatusRequest : IGetLayerStatusRequest
    {
        public ILayerInfo Layer { get; set; }
    }
}