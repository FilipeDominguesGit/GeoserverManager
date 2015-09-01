namespace GeoserverManager.DAL.Interface.Datamodel.Layer
{
    public interface ILayerEntity
    {
        string Datastore { get; set; }
        string Workspace { get; set; }
        string Name { get; set; }
        string Srs { get; set; }
        string Enabled { get; set; }
        string ProjectionPolicy { get; set; }
        string Sql { get; set; }
        string Geometry { get; set; }
    }
}