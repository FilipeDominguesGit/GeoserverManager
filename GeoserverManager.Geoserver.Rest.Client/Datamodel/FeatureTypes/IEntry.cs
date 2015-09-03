using Newtonsoft.Json;

namespace GeoserverManager.Geoserver.Rest.Client.Datamodel.FeatureTypes
{
    public interface IEntry
    {
        [JsonProperty("@key")]
        string Key { get; set; }

        [JsonProperty("$")]
        string Dolar { get; set; }

        IVirtualTable VirtualTable { get; set; }
    }
}