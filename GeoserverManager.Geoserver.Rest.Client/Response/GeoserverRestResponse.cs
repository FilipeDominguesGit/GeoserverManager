﻿using System.Net;
using GeoserverManager.Geoserver.Rest.Client.Datamodel.FeatureTypes;
using GeoserverManager.Geoserver.Rest.Client.Datamodel.GlobalSettings;
using GeoserverManager.Geoserver.Rest.Client.Datamodel.Workspaces;

namespace GeoserverManager.Geoserver.Rest.Client.Response
{
    public class GeoserverRestResponse : IGeoserverRestResponse
    {
        public HttpStatusCode Code { get; set; }
        public string Data { get; set; }
        public IFeatureTypeRoot FeatureTypeRoot { get; set; }
        public IGlobalSettingsRoot GlobalSettingsRoot { get; set; }
        public IWorkspacesRoot WorkspacesRoot { get; set; }
        public bool IsMissingWorkSpace { get; set; }
        public bool IsMissingDataStore { get; set; }
        public bool IsMissingFeatureType { get; set; }
    }
}