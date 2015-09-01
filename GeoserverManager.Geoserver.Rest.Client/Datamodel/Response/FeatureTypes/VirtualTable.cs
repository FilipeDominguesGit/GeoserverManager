using GeoserverManager.Geoserver.Rest.Client.Converter;
using Newtonsoft.Json;

namespace GeoserverManager.Geoserver.Rest.Client.Datamodel.Response.FeatureTypes
{
    public class VirtualTable : IVirtualTable
    {
        public string Name { get; set; }
        public string Sql { get; set; }
        public string EscapeSql { get; set; }

        [JsonConverter(typeof (ComplexJsonConverter<Geometry>))]
        public IGeometry Geometry { get; set; }
    }
}