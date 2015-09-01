namespace GeoserverManager.Geoserver.Rest.Client.Datamodel.Response.Workspaces
{
    public class Workspace : IWorkspace
    {
        public string Name { get; set; }
        public string Href { get; set; }
    }
}