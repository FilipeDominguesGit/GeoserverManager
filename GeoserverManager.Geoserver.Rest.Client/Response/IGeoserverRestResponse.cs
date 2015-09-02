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
    public interface IGeoserverRestResponse
    {
        HttpStatusCode Code { get; }
        string Data { get; }
        IFeatureTypeRoot FeatureTypeRoot { get; }
        IGlobalSettingsRoot GlobalSettingsRoot { get; }
        IWorkspacesRoot WorkspacesRoot { get; }
        bool IsMissingWorkSpace { get; }
        bool IsMissingDataStore { get; }
        bool IsMissingFeatureType { get; }
    }
}
