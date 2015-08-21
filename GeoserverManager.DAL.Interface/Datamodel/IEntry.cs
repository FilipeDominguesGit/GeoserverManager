using Newtonsoft.Json;

namespace GeoserverManager.DAL.Interface.Datamodel
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