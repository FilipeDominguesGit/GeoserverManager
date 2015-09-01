using Newtonsoft.Json;

namespace GeoserverManager.Geoserver.Rest.Client.Datamodel.Response.GlobalSettings
{
    public class Entry : IEntry
    {
        [JsonProperty("string")]
        public string EntryString { get; set; }

        [JsonProperty("boolean")]
        public bool EntryBoolean { get; set; }
    }
}