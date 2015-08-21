using System.Collections.Generic;
using Newtonsoft.Json;

namespace GeoserverManager.DAL.Interface.Datamodel
{
    public interface IKeywords
    {
        [JsonProperty("string")]
        IEnumerable<string> KeywordString { get; set; }
    }
}