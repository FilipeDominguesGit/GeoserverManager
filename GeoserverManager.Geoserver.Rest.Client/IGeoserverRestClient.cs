using GeoserverManager.Entities.Interface.BussinessModel;
using GeoserverManager.Geoserver.Rest.Client.Datamodel.GlobalSettings;
using GeoserverManager.Geoserver.Rest.Client.Datamodel.Workspaces;

namespace GeoserverManager.Geoserver.Rest.Client
{
    public interface IGeoserverRestClient
    {
        IGlobalSettingsRoot GetGlobalSettings();
        IWorkspacesRoot GetAllWorkSpaces();
        ILayerInfo GetLayerInfoByWorkspaceLayerNameAndNamespace(string workspace, string datastore, string layername);
    }
}