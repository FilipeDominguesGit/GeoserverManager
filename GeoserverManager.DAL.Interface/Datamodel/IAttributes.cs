namespace GeoserverManager.DAL.Interface.Datamodel
{
    public interface IAttributes
    {
        string Name { get; set; }
        int MinOccurs { get; set; }
        int MaxOccurs { get; set; }
        bool Nillable { get; set; }
        string Binding { get; set; }
    }
}