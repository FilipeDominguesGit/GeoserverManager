using System;
using GeoserverManager.Entities.Interface.BussinessModel;
using GeoserverManager.Geoserver.Rest.Client.Datamodel.Response.GlobalSettings;
using GeoserverManager.Geoserver.Rest.Client.Datamodel.Response.Workspaces;
using GeoserverManager.Rest.Client.Interface;
using GeoserverManager.Rest.Client.Request;
using Newtonsoft.Json;

namespace GeoserverManager.Geoserver.Rest.Client
{
    public class GeoserverRestClient : IGeoserverRestClient
    {
        private readonly IRestService restService;

        public GeoserverRestClient(IRestService restService)
        {
            if (restService == null)
                throw new ArgumentNullException("restService", "restService cannot be null!");

            this.restService = restService;
        }

        public IGlobalSettingsRoot GetGlobalSettings()
        {
            const string uri = @"settings";

            var request = new ServiceRequest(uri);

            var response = restService.Get(request);

            var globalSettings = JsonConvert.DeserializeObject<GlobalSettingsRoot>(response.Data);

            return globalSettings;
        }

        public IWorkspacesRoot GetAllWorkSpaces()
        {
            const string uri = @"workspaces";

            var request = new ServiceRequest(uri);

            var response = restService.Get(request);

            var workspacesRoot = JsonConvert.DeserializeObject<WorkspacesRoot>(response.Data);

            return workspacesRoot;
        }

        public ILayerInfo GetLayerInfoByWorkspaceLayerNameAndNamespace(string workspace, string datastore,
            string layername)
        {
            var uri = string.Format(@"workspaces/{0}/datastores/{1}/featuretypes/{2}", workspace, datastore, layername);

            var request = new ServiceRequest(uri);

            var response = restService.Get(request);


            throw new NotImplementedException();
        }
    }
}