namespace GeoserverManager.Geoserver.Rest.Client.Datamodel.FeatureTypes
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