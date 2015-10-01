using GeoserverManager.Entities.Interface.BussinessModel.Enums;
using GeoserverManager.UseCases.Base.Interface.ResponseBoundary;

namespace GeoserverManager.UseCases.Interface.UseCases.Layers.Responses
{
    public interface IGetFeatureTypeInfoStatusResponse : IUseCaseResponse
    {
        FeatureTypeInfoStatus Status { get; }
    }
}