using System.Collections.Generic;
using GeoserverManager.Geoserver.Rest.Client.Converter;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace GeoserverManager.Geoserver.Rest.Client.Datamodel.FeatureTypes
{
    public class Metadata : IMetadata
    {
        [JsonConverter(typeof (EntryJsonConverter))]
        public  IEnumerable<IEntry> Entry { get; set; }
    }
}