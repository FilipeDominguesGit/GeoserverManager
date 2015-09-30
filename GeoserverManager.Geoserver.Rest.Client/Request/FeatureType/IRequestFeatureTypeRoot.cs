using Newtonsoft.Json;

namespace GeoserverManager.Geoserver.Rest.Client.Request.FeatureType
{
    public interface IRequestFeatureTypeRoot
    {
        [JsonProperty("featureType")]
        IRequestFeatureType FeatureType { get; set; }
    }
}