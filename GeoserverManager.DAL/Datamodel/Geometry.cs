using GeoserverManager.DAL.Interface.Datamodel;

namespace GeoserverManager.DAL.Datamodel
{
    public class Geometry : IGeometry
    {
        public string Name { get; set; }
        public string Type { get; set; }
        public int Srid { get; set; }
    }
}