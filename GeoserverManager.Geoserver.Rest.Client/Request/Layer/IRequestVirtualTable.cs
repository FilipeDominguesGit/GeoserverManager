using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace GeoserverManager.Geoserver.Rest.Client.Request.Layer
{
    public interface IRequestVirtualTable
    {
        [JsonProperty("name")]
        string Name { get; set; }

        [JsonProperty("sql")]
        string Sql { get; set; }

        [JsonProperty("escapeSql")]
        string EscapeSql { get; set; }
    }
}
