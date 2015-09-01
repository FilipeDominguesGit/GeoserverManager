﻿using System;
using System.Linq;
using GeoserverManager.UseCases.Base.Interface.Exceptions;
using GeoserverManager.UseCases.Interface.Repositories;
using GeoserverManager.UseCases.Interface.UseCases.Layers;
using GeoserverManager.UseCases.Interface.UseCases.Layers.Requests;
using GeoserverManager.UseCases.Interface.UseCases.Layers.Responses;
using GeoserverManager.UseCases.UseCases.Layers.Responses;

namespace GeoserverManager.UseCases.UseCases.Layers
{
    public class GetAllLayersUseCase : IGetAllLayersUseCase
    {
        private readonly ILayerInfoRepository repository;

        public GetAllLayersUseCase(ILayerInfoRepository repository)
        {
            this.repository = repository;
        }

        public void Execute(IGetAllLayersRequests request, Action<IGetAllLayersResponse> responseBoundary)
        {
            if (request == null)
                throw new ArgumentNullException("request", "Use case request cannot be null!");
            if (responseBoundary == null)
                throw new ArgumentNullException("responseBoundary", "Response handler cannot be null!");

            try
            {
                var layers = repository.GetAllLayersInfos();
                responseBoundary(layers.Any() ? new GetAllLayersResponse(layers) : GetAllLayersResponse.NULL);
            }
            catch (Exception ex)
            {
                throw new UseCaseExecutionException("An error occurred while trying to get Layer info!", ex);
            }
        }
    }
}