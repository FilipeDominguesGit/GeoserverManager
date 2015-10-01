using System;
using System.Linq;
using GeoserverManager.UseCases.Base.Interface.Exceptions;
using GeoserverManager.UseCases.Interface.Repositories;
using GeoserverManager.UseCases.Interface.UseCases.Layers;
using GeoserverManager.UseCases.Interface.UseCases.Layers.Requests;
using GeoserverManager.UseCases.Interface.UseCases.Layers.Responses;
using GeoserverManager.UseCases.UseCases.FeatureTypes.Responses;

namespace GeoserverManager.UseCases.UseCases.FeatureTypes
{
    public class GetAllFeatureTypesInfosUseCase : Interface.UseCases.Layers.IGetAllFeatureTypesInfosUseCase
    {
        private readonly IFeatureTypeInfoRepository repository;

        public GetAllFeatureTypesInfosUseCase(IFeatureTypeInfoRepository repository)
        {
            this.repository = repository;
        }

        public void Execute(IGetAllFeatureTypesInfosRequests request, Action<IGetAllFeatureTypesInfosResponse> responseBoundary)
        {
            if (request == null)
                throw new ArgumentNullException("request", "Use case request cannot be null!");
            if (responseBoundary == null)
                throw new ArgumentNullException("responseBoundary", "Response handler cannot be null!");

            try
            {
                var layers = repository.GetAllLayersInfos();
                responseBoundary(layers.Any() ? new GetAllFeatureTypesInfosResponse(layers) : GetAllFeatureTypesInfosResponse.NULL);
            }
            catch (Exception ex)
            {
                throw new UseCaseExecutionException("An error occurred while trying to get Layer info!", ex);
            }
        }
    }
}