using GeoserverManager.UseCases.Base.Interface.RequestBoundary;
using GeoserverManager.UseCases.Base.Interface.ResponseBoundary;

namespace GeoserverManager.UseCases.Interface.UseCases.Layers
{
    public interface IGetAllLayersUseCase : IUseCaseRequestBoundary<IUseCaseRequest, IUseCaseResponse>
    {
    }
}