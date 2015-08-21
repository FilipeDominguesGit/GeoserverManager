using Newtonsoft.Json;

namespace GeoserverManager.DAL.Interface.Datamodel
{
    public interface IStore
    {
        [JsonProperty("@class")]
        string StoreClass { get; set; }

        string Name { get; set; }
        string Href { get; set; }
    }
}