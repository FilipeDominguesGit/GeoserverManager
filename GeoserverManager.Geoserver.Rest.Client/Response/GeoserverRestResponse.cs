using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using GeoserverManager.Geoserver.Rest.Client.Datamodel.Response.FeatureTypes;
using GeoserverManager.Geoserver.Rest.Client.Datamodel.Response.GlobalSettings;
using GeoserverManager.Geoserver.Rest.Client.Datamodel.Response.Workspaces;

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
