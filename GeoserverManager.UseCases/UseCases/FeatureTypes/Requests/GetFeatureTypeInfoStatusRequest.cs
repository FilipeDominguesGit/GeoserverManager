using GeoserverManager.Entities.Interface.BussinessModel;
using GeoserverManager.UseCases.Interface.UseCases.Layers.Requests;

namespace GeoserverManager.UseCases.UseCases.FeatureTypes.Requests
{
    public class GetFeatureTypeInfoStatusRequest : IGetFeatureTypeInfoStatusRequest
    {
        public IFeatureTypeInfo Layer { get; set; }
    }
}