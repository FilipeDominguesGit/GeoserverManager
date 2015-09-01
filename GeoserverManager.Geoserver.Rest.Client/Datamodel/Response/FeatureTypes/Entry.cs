using GeoserverManager.Geoserver.Rest.Client.Converter;
using Newtonsoft.Json;

namespace GeoserverManager.Geoserver.Rest.Client.Datamodel.Response.FeatureTypes
{
    public class Entry : IEntry
    {
        [JsonProperty("@key")]
        public string Key { get; set; }

        [JsonProperty("$")]
        public string Dolar { get; set; }

        [JsonConverter(typeof (ComplexJsonConverter<VirtualTable>))]
        public IVirtualTable VirtualTable { get; set; }
    }
}