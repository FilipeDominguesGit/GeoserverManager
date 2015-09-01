namespace GeoserverManager.Geoserver.Rest.Client.Datamodel.Response.GlobalSettings
{
    public interface ISettings
    {
        string Id { get; set; }
        IContact Contact { get; set; }
        string Charset { get; set; }
        int NumDecimals { get; set; }
        string OnlineResource { get; set; }
        bool Verbose { get; set; }
        bool VerboseExceptions { get; set; }
        IMetadata Metadata { get; set; }
        bool LocalWorkspaceIncludesPrefix { get; set; }
    }
}