using GeoserverManager.Geoserver.Rest.Client.Converter;
using Newtonsoft.Json;

namespace GeoserverManager.Geoserver.Rest.Client.Datamodel.FeatureTypes
{
    public class Metadata : IMetadata
    {
        [JsonConverter(typeof (ComplexJsonConverter<Entry>))]
        public IEntry Entry { get; set; }
    }
}