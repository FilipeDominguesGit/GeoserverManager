using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GeoserverManager.Geoserver.Rest.Client.Converter;
using Newtonsoft.Json;

namespace GeoserverManager.Geoserver.Rest.Client.Datamodel.Request
{
    public class LayerRoot : ILayerRoot
    {
        [JsonConverter(typeof(ComplexJsonConverter<Layer>))]
        public ILayer Layer { get; set; }
    }
}
