using GeoserverManager.UseCases.Base.Interface.RequestBoundary;
using GeoserverManager.UseCases.Interface.UseCases.FeatureTypes.Requests;
using GeoserverManager.UseCases.Interface.UseCases.FeatureTypes.Responses;

namespace GeoserverManager.UseCases.Interface.UseCases.FeatureTypes
{
    public interface IUploadFeatureTypeInfoToGeoserverUseCase : IUseCaseRequestBoundary<IUploadFeatureTypeInfoToGeoserverRequest, IUploadFeatureTypeInfoToGeoserverResponse>
    {
    }
}
