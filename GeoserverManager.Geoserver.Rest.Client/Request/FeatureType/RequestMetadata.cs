using GeoserverManager.Geoserver.Rest.Client.Converter;
using Newtonsoft.Json;

namespace GeoserverManager.Geoserver.Rest.Client.Request.FeatureType
{
    public class RequestMetadata: IRequestMetadata
    {
        [JsonConverter(typeof(ComplexJsonConverter<RequestEntry>))]
        public IRequestEntry Entry { get; set; }
    }
}
