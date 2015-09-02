using System;
using System.Net;
using GeoserverManager.Entities.Interface.BussinessModel.Enums;
using GeoserverManager.Geoserver.Rest.Client;
using GeoserverManager.UseCases.Base.Interface.Exceptions;
using GeoserverManager.UseCases.Interface.UseCases.Layers;
using GeoserverManager.UseCases.Interface.UseCases.Layers.Requests;
using GeoserverManager.UseCases.Interface.UseCases.Layers.Responses;
using GeoserverManager.UseCases.UseCases.Layers.Responses;

namespace GeoserverManager.UseCases.UseCases.Layers
{
    public class GetLayerStatusUseCase: IGetLayerStatusUseCase
    {
        private readonly IGeoserverRestClient restClient;

        public GetLayerStatusUseCase(IGeoserverRestClient restClient)
        {
            this.restClient = restClient;
        }

        public void Execute(IGetLayerStatusRequest request, Action<IGetLayerStatusResponse> responseBoundary)
        {
            if (request == null)
                throw new ArgumentNullException("request", "Use case request cannot be null!");
            if (responseBoundary == null)
                throw new ArgumentNullException("responseBoundary", "Response handler cannot be null!");

            try
            {
                
                var response = restClient.GetLayerInfoBy(request.Layer.Datastore,request.Layer.Workspace,request.Layer.Name);

                var status=LayerStatus.Unknown;

                if(response.Code==HttpStatusCode.OK)
                    status=LayerStatus.Ok;

                if (response.Code==HttpStatusCode.NotFound)
                    status = response.IsMissingFeatureType ? LayerStatus.Missing : LayerStatus.Error;
                if(response.Code==0)
                    status=LayerStatus.ConnectionError;
                
                responseBoundary(new GetLayerStatusResponse(status));
            }
            catch (Exception ex)
            {
                throw new UseCaseExecutionException("An error occurred while trying to get Layer Status!", ex);
            }
        }
    }
}
