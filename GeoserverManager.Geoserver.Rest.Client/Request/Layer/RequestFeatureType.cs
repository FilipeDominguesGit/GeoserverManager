using GeoserverManager.Geoserver.Rest.Client.Converter;
using Newtonsoft.Json;

namespace GeoserverManager.Geoserver.Rest.Client.Request.Layer
{
    public class RequestFeatureType : IRequestFeatureType
    {
        public string Name { get; set; }
        public string Title { get; set; }
        public string Srs { get; set; }
        public string ProjectionPolicy { get; set; }
        public string Enabled { get; set; }
  
        

        [JsonConverter(typeof (ComplexJsonConverter<RequestMetadata>))]
        public IRequestMetadata Metadata { get; set; }
    }
}