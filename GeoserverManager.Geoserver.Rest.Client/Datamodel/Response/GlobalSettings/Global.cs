using GeoserverManager.Geoserver.Rest.Client.Converter;
using Newtonsoft.Json;

namespace GeoserverManager.Geoserver.Rest.Client.Datamodel.Response.GlobalSettings
{
    public class Global : IGlobal
    {
        [JsonConverter(typeof (ComplexJsonConverter<Settings>))]
        public ISettings Settings { get; set; }

        [JsonConverter(typeof (ComplexJsonConverter<Jai>))]
        public IJai Jai { get; set; }

        [JsonConverter(typeof (ComplexJsonConverter<CoverageAccess>))]
        public ICoverageAccess CoverageAccess { get; set; }

        public int UpdateSequence { get; set; }
        public int FeatureTypeCacheSize { get; set; }
        public bool GlobalServices { get; set; }
        public int XmlPostRequestLogBufferSize { get; set; }
        public bool XmlExternalEntitiesEnabled { get; set; }
    }
}