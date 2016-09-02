namespace GeoserverManager.Geoserver.Rest.Client.Request.FeatureType
{
    public class RequestVirtualTable: IRequestVirtualTable
    {
        public string Name { get; set; }
        public string Sql { get; set; }
        public string EscapeSql { get; set; }
    }
}
