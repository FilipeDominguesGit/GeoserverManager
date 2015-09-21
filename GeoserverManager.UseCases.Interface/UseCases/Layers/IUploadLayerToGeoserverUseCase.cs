using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GeoserverManager.UseCases.Base.Interface.RequestBoundary;
using GeoserverManager.UseCases.Interface.UseCases.Layers.Requests;
using GeoserverManager.UseCases.Interface.UseCases.Layers.Responses;

namespace GeoserverManager.UseCases.Interface.UseCases.Layers
{
    public interface IUploadLayerToGeoserverUseCase : IUseCaseRequestBoundary<IUploadLayerToGeoserverRequest, IUploadLayerToGeoserverResponse>
    {
    }
}
