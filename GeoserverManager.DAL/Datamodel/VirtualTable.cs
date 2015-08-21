using GeoserverManager.DAL.Converter;
using GeoserverManager.DAL.Interface.Datamodel;
using Newtonsoft.Json;

namespace GeoserverManager.DAL.Datamodel
{
    public class VirtualTable : IVirtualTable
    {
        public string Name { get; set; }
        public string Sql { get; set; }
        public string EscapeSql { get; set; }

        [JsonConverter(typeof (JsonLayerConverter<Geometry>))]
        public IGeometry Geometry { get; set; }
    }
}