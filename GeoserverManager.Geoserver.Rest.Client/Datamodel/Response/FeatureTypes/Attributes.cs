namespace GeoserverManager.Geoserver.Rest.Client.Datamodel.Response.FeatureTypes
{
    public class Attributes : IAttributes
    {
        public string Name { get; set; }
        public int MinOccurs { get; set; }
        public int MaxOccurs { get; set; }
        public bool Nillable { get; set; }
        public string Binding { get; set; }
    }
}