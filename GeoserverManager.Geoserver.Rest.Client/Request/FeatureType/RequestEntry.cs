using GeoserverManager.Geoserver.Rest.Client.Converter;
using Newtonsoft.Json;

namespace GeoserverManager.Geoserver.Rest.Client.Request.FeatureType
{
    public class RequestEntry: IRequestEntry
    {
        public string Key { get; set; }

        [JsonConverter(typeof(ComplexJsonConverter<RequestVirtualTable>))]
        public IRequestVirtualTable VirtualTable { get; set; }
    }
}
