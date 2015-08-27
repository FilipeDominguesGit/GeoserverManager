namespace GeoserverManager.Geoserver.Rest.Client.Datamodel.FeatureTypes
{
    public interface INativeBoundingBox
    {
        double Minx { get; set; }
        double Maxx { get; set; }
        double Miny { get; set; }
        double Maxy { get; set; }
    }
}