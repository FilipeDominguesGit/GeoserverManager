using GeoserverManager.DAL.Converter;
using GeoserverManager.DAL.Interface.Datamodel;
using Newtonsoft.Json;

namespace GeoserverManager.DAL.Datamodel
{
    public class Entry : IEntry
    {
        [JsonProperty("@key")]
        public string Key { get; set; }

        [JsonProperty("$")]
        public string Dolar { get; set; }

        [JsonConverter(typeof (JsonLayerConverter<VirtualTable>))]
        public IVirtualTable VirtualTable { get; set; }
    }
}