using GeoserverManager.Geoserver.Rest.Client.Converter;
using Newtonsoft.Json;

namespace GeoserverManager.Geoserver.Rest.Client.Request.Layer
{
    public class LayerRoot : ILayerRoot
    {
        [JsonConverter(typeof (ComplexJsonConverter<RequestFeatureType>))]
        public IRequestFeatureType FeatureType { get; set; }
    }
}