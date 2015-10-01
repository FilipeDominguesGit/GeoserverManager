using System.Collections.Generic;
using GeoserverManager.Entities.Interface.BussinessModel;
using GeoserverManager.UseCases.Base.Interface.ResponseBoundary;

namespace GeoserverManager.UseCases.Interface.UseCases.Layers.Responses
{
    public interface IGetAllFeatureTypesInfosResponse : IUseCaseResponse
    {
        IEnumerable<IFeatureTypeInfo> Layers { get; }
    }
}