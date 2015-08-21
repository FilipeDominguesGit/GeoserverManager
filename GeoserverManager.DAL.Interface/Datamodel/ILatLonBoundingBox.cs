namespace GeoserverManager.DAL.Interface.Datamodel
{
    public interface ILatLonBoundingBox
    {
        double Minx { get; set; }
        double Maxx { get; set; }
        double Miny { get; set; }
        double Maxy { get; set; }
        string Crs { get; set; }
    }
}