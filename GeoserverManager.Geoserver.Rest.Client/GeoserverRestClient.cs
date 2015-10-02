using System;
using System.Net;
using GeoserverManager.Entities.Interface.BussinessModel;
using GeoserverManager.Geoserver.Rest.Client.Datamodel.FeatureTypes;
using GeoserverManager.Geoserver.Rest.Client.Datamodel.GlobalSettings;
using GeoserverManager.Geoserver.Rest.Client.Datamodel.Workspaces;
using GeoserverManager.Geoserver.Rest.Client.Request.Layer;
using GeoserverManager.Geoserver.Rest.Client.Response;
using GeoserverManager.Geoserver.Rest.Client.Translator;
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

        public IGeoserverRestResponse GetLayerInfoBy(string datastore, string workspace, string layername)
        {
            var uri = $@"workspaces/{workspace}/datastores/{datastore}/featuretypes/{layername}";
            var request = new ServiceRequest(uri);
            var response = restService.Get(request);

            var output = new GeoserverRestResponse
            {
                Data = response.Data,
                Code = response.StatusCode
            };

            if (response.StatusCode == HttpStatusCode.OK)
            {
                output.FeatureTypeRoot = JsonConvert.DeserializeObject<FeatureTypeRoot>(response.Data);
            }
            if (response.StatusCode == HttpStatusCode.NotFound)
            {
                output.IsMissingDataStore = response.Data.StartsWith("No such datastore");
                output.IsMissingWorkSpace = response.Data.StartsWith("No such workspace");
                output.IsMissingFeatureType = response.Data.StartsWith("No such feature type");
            }


            return output;
        }

        public IGeoserverRestResponse PostLayer(IFeatureTypeInfo layer)
        {
            var uri = $@"workspaces/{layer.Workspace}/datastores/{layer.Datastore}/featuretypes";
            var request = new ServiceRequest(uri);

            var featureTypeRoot = LayerInfoTranslator.TranslateToRequestFeatureTypeRoot(layer);

            request.Body = JsonConvert.SerializeObject(featureTypeRoot);

            var response = restService.Post(request);


            var output = new GeoserverRestResponse
            {
                Data = response.Data,
                Code = response.StatusCode
            };

            return output;
        }

        public IGeoserverRestResponse PutLayer(IFeatureTypeInfo layer)
        {
            var uri = $@"layers/{layer.Name}";
            var request = new ServiceRequest(uri);

            var layerRoot = LayerInfoTranslator.TranslateToRequestLayerRoot(layer);

            request.Body = JsonConvert.SerializeObject(layerRoot);

            var response = restService.Put(request);


            var output = new GeoserverRestResponse
            {
                Data = response.Data,
                Code = response.StatusCode
            };

            return output;
        }

        public IGeoserverRestResponse GetServerStatus()
        {
            var request =new ServiceRequest("");

            var response = restService.Get(request);

            var output = new GeoserverRestResponse
            {
                Data = response.Data,
                Code = response.StatusCode
            };
            return output;
        }
    }
}