using GeoserverManager.Entities.Interface.BussinessModel;
using GeoserverManager.UseCases.Base.Interface.RequestBoundary;

namespace GeoserverManager.UseCases.Interface.UseCases.Layers.Requests
{
    public interface IGetFeatureTypeInfoStatusRequest : IUseCaseRequest
    {
        IFeatureTypeInfo Layer { get; set; }
    }
}