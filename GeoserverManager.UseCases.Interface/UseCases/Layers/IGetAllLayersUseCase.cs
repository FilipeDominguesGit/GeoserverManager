﻿using GeoserverManager.UseCases.Base.Interface.RequestBoundary;
using GeoserverManager.UseCases.Base.Interface.ResponseBoundary;
using GeoserverManager.UseCases.Interface.UseCases.Layers.Requests;
using GeoserverManager.UseCases.Interface.UseCases.Layers.Responses;

namespace GeoserverManager.UseCases.Interface.UseCases.Layers
{
    public interface IGetAllLayersUseCase : IUseCaseRequestBoundary<IGetAllLayersRequests, IGetAllLayersResponse>
    {
    }
}