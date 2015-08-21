namespace GeoserverManager.DAL.Interface.Datamodel
{
    public interface IVirtualTable
    {
        string Name { get; set; }
        string Sql { get; set; }
        string EscapeSql { get; set; }
        IGeometry Geometry { get; set; }
    }
}