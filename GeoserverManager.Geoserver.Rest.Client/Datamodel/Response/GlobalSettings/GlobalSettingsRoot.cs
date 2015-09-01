using GeoserverManager.Geoserver.Rest.Client.Converter;
using Newtonsoft.Json;

namespace GeoserverManager.Geoserver.Rest.Client.Datamodel.Response.GlobalSettings
{
    public class GlobalSettingsRoot : IGlobalSettingsRoot
    {
        [JsonConverter(typeof (ComplexJsonConverter<Global>))]
        public IGlobal global { get; set; }
    }
}