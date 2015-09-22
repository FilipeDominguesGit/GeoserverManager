using Newtonsoft.Json;

namespace GeoserverManager.Geoserver.Rest.Client.Request.Layer
{
    public interface ILayerRoot
    {
        [JsonProperty("featureType")]
        IRequestFeatureType FeatureType { get; set; }
    }
}