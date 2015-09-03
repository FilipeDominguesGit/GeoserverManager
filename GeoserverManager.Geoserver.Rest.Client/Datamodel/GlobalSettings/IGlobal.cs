namespace GeoserverManager.Geoserver.Rest.Client.Datamodel.GlobalSettings
{
    public interface IGlobal
    {
        ISettings Settings { get; set; }
        IJai Jai { get; set; }
        ICoverageAccess CoverageAccess { get; set; }
        int UpdateSequence { get; set; }
        int FeatureTypeCacheSize { get; set; }
        bool GlobalServices { get; set; }
        int XmlPostRequestLogBufferSize { get; set; }
        bool XmlExternalEntitiesEnabled { get; set; }
    }
}