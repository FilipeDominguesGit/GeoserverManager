using System.Collections.Generic;
using GeoserverManager.Geoserver.Rest.Client.Converter;
using Newtonsoft.Json;

namespace GeoserverManager.Geoserver.Rest.Client.Datamodel.Workspaces
{
    public class Workspaces : IWorkspaces
    {
        [JsonConverter(typeof (ComplexJsonConverter<IEnumerable<Workspace>>))]
        public IEnumerable<IWorkspace> workspace { get; set; }
    }
}