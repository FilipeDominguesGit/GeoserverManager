namespace GeoserverManager.Geoserver.Rest.Client.Datamodel.Response.FeatureTypes
{
    public class Store : IStore
    {
        public string StoreClass { get; set; }
        public string Name { get; set; }
        public string Href { get; set; }
    }
}