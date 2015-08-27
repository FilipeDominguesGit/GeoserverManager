using System.Collections.Generic;
using GeoserverManager.Geoserver.Rest.Client.Converter;
using Newtonsoft.Json;

namespace GeoserverManager.Geoserver.Rest.Client.Datamodel.FeatureTypes
{
    public class Metadata : IMetadata
    {
        [JsonConverter(typeof (ComplexJsonConverter<IEnumerable<Entry>>))]
        public IEnumerable<IEntry> Entry { get; set; }
    }
}