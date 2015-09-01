using GeoserverManager.DAL.Converter;
using GeoserverManager.DAL.Interface.Datamodel.FeatureType;
using Newtonsoft.Json;

namespace GeoserverManager.DAL.Datamodel
{
    public class FeatureType : IFeatureType
    {
        public string Name { get; set; }

        public string Title { get; set; }

        public string srs { get; set; }


        public string ProjectionPolicy { get; set; }
        public bool Enabled { get; set; }

        [JsonConverter(typeof (ComplexJsonConverter<Metadata>))]
        public IMetadata Metadata { get; set; }

        public bool OverridingServiceSRS { get; set; }
        public bool CircularArcPresent { get; set; }
    }
} 