using Newtonsoft.Json;

namespace GeoserverManager.Geoserver.Rest.Client.Request.Layer
{
    public interface IRequestLayerRoot
    {
        [JsonProperty("layer")]
        IRequestLayer Layer { get; set; }
    }
}