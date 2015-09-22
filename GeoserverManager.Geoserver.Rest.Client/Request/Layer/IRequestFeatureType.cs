using Newtonsoft.Json;

namespace GeoserverManager.Geoserver.Rest.Client.Request.Layer
{
    public interface IRequestFeatureType
    {

        [JsonProperty("name")]
        string Name { get; set; }

        [JsonProperty("title")]
        string Title { get; set; }

        [JsonProperty("srs")]
        string Srs { get; set; }

        [JsonProperty("projectionPolicy")]
        string ProjectionPolicy { get; set; }

        [JsonProperty("enabled")]
        string Enabled { get; set; }

        
        [JsonProperty("metadata")]
        IRequestMetadata Metadata { get; set; }

    }
}