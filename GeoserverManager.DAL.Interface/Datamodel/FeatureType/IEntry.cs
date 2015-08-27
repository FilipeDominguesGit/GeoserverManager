using Newtonsoft.Json;

namespace GeoserverManager.DAL.Interface.Datamodel.FeatureType
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