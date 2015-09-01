namespace GeoserverManager.Geoserver.Rest.Client.Datamodel.Response.GlobalSettings
{
    public interface ICoverageAccess
    {
        int MaxPoolSize { get; set; }
        int CorePoolSize { get; set; }
        int KeepAliveTime { get; set; }
        string QueueType { get; set; }
        int ImageIOCacheThreshold { get; set; }
    }
}