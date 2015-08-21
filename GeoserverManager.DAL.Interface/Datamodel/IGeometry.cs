namespace GeoserverManager.DAL.Interface.Datamodel
{
    public interface IGeometry
    {
        string Name { get; set; }
        string Type { get; set; }
        int Srid { get; set; }
    }
}