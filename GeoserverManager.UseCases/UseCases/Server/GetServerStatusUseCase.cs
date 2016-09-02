using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using GeoserverManager.Geoserver.Rest.Client;
using GeoserverManager.UseCases.Base.Interface.Exceptions;
using GeoserverManager.UseCases.Interface.UseCases.Server;
using GeoserverManager.UseCases.Interface.UseCases.Server.Request;
using GeoserverManager.UseCases.Interface.UseCases.Server.Response;
using GeoserverManager.UseCases.UseCases.Server.Response;

namespace GeoserverManager.UseCases.UseCases.Server
{
    public class GetServerStatusUseCase: IGetServerStatusUseCase
    {
        private readonly IGeoserverRestClient restClient;

        public GetServerStatusUseCase(IGeoserverRestClient restClient)
        {
            this.restClient = restClient;
        }

        public void Execute(IGetServerStatusRequest request, Action<IGetServerStatusResponse> responseBoundary)
        {
             if (request == null)
                throw new ArgumentNullException("request", "Use case request cannot be null!");
            if (responseBoundary == null)
                throw new ArgumentNullException("responseBoundary", "Response handler cannot be null!");

            try
            {
                var response = restClient.GetServerStatus();

                var isOnline = response.Code == HttpStatusCode.OK;

                responseBoundary(new GetServerStatusResponse(isOnline));
            }
            catch (Exception ex)
            {
                throw new UseCaseExecutionException("An error occurred while trying to get Server Status!", ex);
            }
        }
    }
}
