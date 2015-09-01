namespace GeoserverManager.DAL.Interface.Datamodel.FeatureType
{
    public interface IVirtualTable
    {
        string Name { get; set; }
        string Sql { get; set; }
        string EscapeSql { get; set; }
    }
}