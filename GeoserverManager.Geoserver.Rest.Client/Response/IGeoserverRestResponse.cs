using System.Net;
using GeoserverManager.Geoserver.Rest.Client.Datamodel.FeatureTypes;
using GeoserverManager.Geoserver.Rest.Client.Datamodel.GlobalSettings;
using GeoserverManager.Geoserver.Rest.Client.Datamodel.Workspaces;

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