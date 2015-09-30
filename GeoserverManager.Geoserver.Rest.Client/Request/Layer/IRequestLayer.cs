using Newtonsoft.Json;

namespace GeoserverManager.Geoserver.Rest.Client.Request.Layer
{
    public interface IRequestLayer
    {
        [JsonProperty("defaultStyle")]
        IRequestDefaultStyle DefaultStyle { get; set; }
    }
}