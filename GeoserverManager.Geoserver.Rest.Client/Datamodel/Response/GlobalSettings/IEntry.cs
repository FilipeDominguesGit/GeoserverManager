using Newtonsoft.Json;

namespace GeoserverManager.Geoserver.Rest.Client.Datamodel.Response.GlobalSettings
{
    public interface IEntry
    {
        [JsonProperty("string")]
        string EntryString { get; set; }

        [JsonProperty("boolean")]
        bool EntryBoolean { get; set; }
    }
}