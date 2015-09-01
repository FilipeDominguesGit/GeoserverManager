using Newtonsoft.Json;

namespace GeoserverManager.Geoserver.Rest.Client.Datamodel.Response.FeatureTypes
{
    public interface IStore
    {
        [JsonProperty("@class")]
        string StoreClass { get; set; }

        string Name { get; set; }
        string Href { get; set; }
    }
}