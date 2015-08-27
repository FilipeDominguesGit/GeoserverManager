using System.Collections.Generic;
using Newtonsoft.Json;

namespace GeoserverManager.Geoserver.Rest.Client.Datamodel.FeatureTypes
{
    public interface IKeywords
    {
        [JsonProperty("string")]
        IEnumerable<string> KeywordString { get; set; }
    }
}