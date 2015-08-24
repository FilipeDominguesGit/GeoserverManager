using GeoserverManager.Geoserver.Rest.Client.Converter;
using Newtonsoft.Json;

namespace GeoserverManager.Geoserver.Rest.Client.Datamodel.Workspaces
{
    public class WorkspacesRoot : IWorkspacesRoot
    {
        [JsonConverter(typeof (ComplexJsonConverter<Workspaces>))]
        public IWorkspaces Workspaces { get; set; }
    }
}