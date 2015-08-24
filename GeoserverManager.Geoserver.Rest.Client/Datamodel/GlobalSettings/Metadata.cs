using System.Collections.Generic;
using GeoserverManager.Geoserver.Rest.Client.Converter;
using Newtonsoft.Json;

namespace GeoserverManager.Geoserver.Rest.Client.Datamodel.GlobalSettings
{
    public class Metadata : IMetadata
    {
        [JsonConverter(typeof (ComplexJsonConverter<IEnumerable<Map>>))]
        public IEnumerable<IMap> Map { get; set; }
    }
}