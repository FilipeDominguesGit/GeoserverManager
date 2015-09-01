namespace GeoserverManager.Geoserver.Rest.Client.Datamodel.Response.FeatureTypes
{
    public interface IGeometry
    {
        string Name { get; set; }
        string Type { get; set; }
        int Srid { get; set; }
    }
}