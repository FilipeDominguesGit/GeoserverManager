namespace GeoserverManager.Geoserver.Rest.Client.Datamodel.Response.FeatureTypes
{
    public class Geometry : IGeometry
    {
        public string Name { get; set; }
        public string Type { get; set; }
        public int Srid { get; set; }
    }
}