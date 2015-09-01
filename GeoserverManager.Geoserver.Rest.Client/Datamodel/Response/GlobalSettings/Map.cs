using GeoserverManager.Geoserver.Rest.Client.Converter;
using Newtonsoft.Json;

namespace GeoserverManager.Geoserver.Rest.Client.Datamodel.Response.GlobalSettings
{
    public class Map : IMap
    {
        [JsonConverter(typeof (ComplexJsonConverter<Entry>))]
        public IEntry Entry { get; set; }
    }
}