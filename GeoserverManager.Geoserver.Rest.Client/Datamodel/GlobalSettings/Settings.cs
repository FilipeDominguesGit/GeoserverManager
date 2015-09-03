using GeoserverManager.Geoserver.Rest.Client.Converter;
using Newtonsoft.Json;

namespace GeoserverManager.Geoserver.Rest.Client.Datamodel.GlobalSettings
{
    public class Settings : ISettings
    {
        public string Id { get; set; }

        [JsonConverter(typeof (ComplexJsonConverter<Contact>))]
        public IContact Contact { get; set; }

        public string Charset { get; set; }
        public int NumDecimals { get; set; }
        public string OnlineResource { get; set; }
        public bool Verbose { get; set; }
        public bool VerboseExceptions { get; set; }

        [JsonConverter(typeof (ComplexJsonConverter<Metadata>))]
        public IMetadata Metadata { get; set; }

        public bool LocalWorkspaceIncludesPrefix { get; set; }
    }
}