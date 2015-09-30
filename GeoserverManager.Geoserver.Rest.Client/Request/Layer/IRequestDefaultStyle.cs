using Newtonsoft.Json;

namespace GeoserverManager.Geoserver.Rest.Client.Request.Layer
{
    public interface IRequestDefaultStyle
    {
        [JsonProperty("name")]
        string Name { get; set; }
    }
}