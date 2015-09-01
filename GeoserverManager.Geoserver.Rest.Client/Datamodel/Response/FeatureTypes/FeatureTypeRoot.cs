using GeoserverManager.Geoserver.Rest.Client.Converter;
using Newtonsoft.Json;

namespace GeoserverManager.Geoserver.Rest.Client.Datamodel.Response.FeatureTypes
{
    public class FeatureTypeRoot : IFeatureTypeRoot
    {
        [JsonConverter(typeof (ComplexJsonConverter<FeatureType>))]
        public IFeatureType FeatureType { get; set; }
    }
}