using GeoserverManager.DAL.Interface.Datamodel;

namespace GeoserverManager.DAL.Datamodel
{
    public class NativeBoundingBox : INativeBoundingBox
    {
        public double Minx { get; set; }
        public double Maxx { get; set; }
        public double Miny { get; set; }
        public double Maxy { get; set; }
    }
}