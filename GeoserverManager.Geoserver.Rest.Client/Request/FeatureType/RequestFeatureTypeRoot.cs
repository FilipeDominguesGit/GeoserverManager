using GeoserverManager.Geoserver.Rest.Client.Converter;
using Newtonsoft.Json;

namespace GeoserverManager.Geoserver.Rest.Client.Request.FeatureType
{
    public class RequestFeatureTypeRoot : IRequestFeatureTypeRoot
    {
        [JsonConverter(typeof (ComplexJsonConverter<RequestFeatureType>))]
        public IRequestFeatureType FeatureType { get; set; }
    }
}