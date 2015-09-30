using Newtonsoft.Json;

namespace GeoserverManager.Geoserver.Rest.Client.Request.FeatureType
{
    public interface IRequestVirtualTable
    {
        [JsonProperty("name")]
        string Name { get; set; }

        [JsonProperty("sql")]
        string Sql { get; set; }

        [JsonProperty("escapeSql")]
        string EscapeSql { get; set; }
    }
}
