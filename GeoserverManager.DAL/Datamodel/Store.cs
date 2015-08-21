using GeoserverManager.DAL.Interface.Datamodel;

namespace GeoserverManager.DAL.Datamodel
{
    public class Store : IStore
    {
        public string StoreClass { get; set; }
        public string Name { get; set; }
        public string Href { get; set; }
    }
}