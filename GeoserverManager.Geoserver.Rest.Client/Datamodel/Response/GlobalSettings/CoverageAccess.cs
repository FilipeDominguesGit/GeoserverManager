namespace GeoserverManager.Geoserver.Rest.Client.Datamodel.Response.GlobalSettings
{
    public class CoverageAccess : ICoverageAccess
    {
        public int MaxPoolSize { get; set; }
        public int CorePoolSize { get; set; }
        public int KeepAliveTime { get; set; }
        public string QueueType { get; set; }
        public int ImageIOCacheThreshold { get; set; }
    }
}