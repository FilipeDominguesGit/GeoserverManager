using System.Collections.Generic;

namespace GeoserverManager.Geoserver.Rest.Client.Datamodel.Response.Workspaces
{
    public interface IWorkspaces
    {
        IEnumerable<IWorkspace> workspace { get; set; }
    }
}