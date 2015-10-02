using System;
using System.Net;
using GeoserverManager.Entities.Interface.BussinessModel.Enums;
using GeoserverManager.Geoserver.Rest.Client;
using GeoserverManager.Geoserver.Rest.Client.Response;
using GeoserverManager.UseCases.Base.Interface.Exceptions;
using GeoserverManager.UseCases.Interface.UseCases.FeatureTypes;
using GeoserverManager.UseCases.Interface.UseCases.FeatureTypes.Requests;
using GeoserverManager.UseCases.Interface.UseCases.FeatureTypes.Responses;
using GeoserverManager.UseCases.UseCases.FeatureTypes.Responses;

namespace GeoserverManager.UseCases.UseCases.FeatureTypes
{
    public class GetFeatureTypeInfoStatusUseCase : IGetFeatureTypeInfoStatusUseCase
    {
        private readonly IGeoserverRestClient restClient;

        public GetFeatureTypeInfoStatusUseCase(IGeoserverRestClient restClient)
        {
            this.restClient = restClient;
        }

        public void Execute(IGetFeatureTypeInfoStatusRequest request, Action<IGetFeatureTypeInfoStatusResponse> responseBoundary)
        {
            if (request == null)
                throw new ArgumentNullException("request", "Use case request cannot be null!");
            if (responseBoundary == null)
                throw new ArgumentNullException("responseBoundary", "Response handler cannot be null!");

            try
            {
                var response = restClient.GetLayerInfoBy(request.Layer.Datastore, request.Layer.Workspace,
                    request.Layer.Name);

                var status = GetStatusFromResponse(response);

                responseBoundary(new GetFeatureTypeInfoStatusResponse(status));
            }
            catch (Exception ex)
            {
                throw new UseCaseExecutionException("An error occurred while trying to get Layer Status!", ex);
            }
        }

        private FeatureTypeInfoStatus GetStatusFromResponse(IGeoserverRestResponse response)
        {
            var status = FeatureTypeInfoStatus.Unknown;

            if (response.Code == HttpStatusCode.OK)
                status = FeatureTypeInfoStatus.Ok;

            if (response.Code == HttpStatusCode.NotFound)
            {
                if (response.IsMissingDataStore)
                    status = FeatureTypeInfoStatus.DatastoreNotFound;

                if (response.IsMissingWorkSpace)
                    status = FeatureTypeInfoStatus.WorkspaceNotFound;

                if (response.IsMissingFeatureType)
                    status = FeatureTypeInfoStatus.Missing;
            }
            if (response.Code == 0)
                status = FeatureTypeInfoStatus.ConnectionError;

            return status;
        }
    }
}