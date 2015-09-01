namespace GeoserverManager.Geoserver.Rest.Client.Datamodel.Response.FeatureTypes
{
    public class LatLonBoundingBox : ILatLonBoundingBox
    {
        public double Minx { get; set; }
        public double Maxx { get; set; }
        public double Miny { get; set; }
        public double Maxy { get; set; }
        public string Crs { get; set; }
    }
}