using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GeoserverManager.Geoserver.Rest.Client.Converter;
using Newtonsoft.Json;

namespace GeoserverManager.Geoserver.Rest.Client.Request.Layer
{
    public class RequestLayer : IRequestLayer
    {
       
        [JsonConverter(typeof(ComplexJsonConverter<RequestDefaultStyle>))]
        public IRequestDefaultStyle DefaultStyle { get; set; }
    }
}
