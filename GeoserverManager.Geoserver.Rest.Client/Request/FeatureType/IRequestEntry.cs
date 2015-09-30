using Newtonsoft.Json;

namespace GeoserverManager.Geoserver.Rest.Client.Request.FeatureType
{
    public interface IRequestEntry
    {
        [JsonProperty("@key")]
        string Key { get; set; }

        [JsonProperty("virtualTable")]
        IRequestVirtualTable VirtualTable { get; set; }
    }
}
