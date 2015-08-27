using GeoserverManager.DAL.Interface.Datamodel.FeatureType;

namespace GeoserverManager.DAL.Datamodel.FeatureType
{
    public class VirtualTable : IVirtualTable
    {
        public string Name { get; set; }
        public string Sql { get; set; }
        public string EscapeSql { get; set; }

  
    }
}