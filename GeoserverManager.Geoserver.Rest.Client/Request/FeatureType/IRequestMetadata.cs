using Newtonsoft.Json;

namespace GeoserverManager.Geoserver.Rest.Client.Request.FeatureType
{
    public interface IRequestMetadata
    {

        [JsonProperty("entry")]
        IRequestEntry Entry { get; set; }
    }
}
