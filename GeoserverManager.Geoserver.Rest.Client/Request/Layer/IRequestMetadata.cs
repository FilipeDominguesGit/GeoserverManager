using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace GeoserverManager.Geoserver.Rest.Client.Request.Layer
{
    public interface IRequestMetadata
    {

        [JsonProperty("entry")]
        IRequestEntry Entry { get; set; }
    }
}
