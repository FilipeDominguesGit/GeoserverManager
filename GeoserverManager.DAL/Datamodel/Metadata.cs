using System.Collections.Generic;
using GeoserverManager.DAL.Converter;
using GeoserverManager.DAL.Interface.Datamodel.FeatureType;
using Newtonsoft.Json;

namespace GeoserverManager.DAL.Datamodel
{
    public class Metadata : IMetadata
    {
        [JsonConverter(typeof (ComplexJsonConverter<IEnumerable<Entry>>))]
        public IEnumerable<IEntry> Entry { get; set; }
    }
}