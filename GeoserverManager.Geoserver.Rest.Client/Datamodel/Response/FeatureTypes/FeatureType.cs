using GeoserverManager.Geoserver.Rest.Client.Converter;
using Newtonsoft.Json;

namespace GeoserverManager.Geoserver.Rest.Client.Datamodel.Response.FeatureTypes
{
    public class FeatureType : IFeatureType
    {
        //[JsonConverter(typeof (ComplexJsonConverter<LayerMetadata>))]
        //public IMetadata Metadata { get; set; }

        public string Name { get; set; }
        public string NativeName { get; set; }

        [JsonConverter(typeof (ComplexJsonConverter<Namespace>))]
        public INamespace Namespace { get; set; }

        public string Title { get; set; }

        [JsonConverter(typeof (ComplexJsonConverter<Keywords>))]
        public IKeywords Keywords { get; set; }

        public string srs { get; set; }

        [JsonConverter(typeof (ComplexJsonConverter<NativeBoundingBox>))]
        public INativeBoundingBox NativeBoundingBox { get; set; }

        [JsonConverter(typeof (ComplexJsonConverter<LatLonBoundingBox>))]
        public ILatLonBoundingBox LatLonBoundingBox { get; set; }

        public string ProjectionPolicy { get; set; }
        public bool Enabled { get; set; }

        [JsonConverter(typeof (ComplexJsonConverter<Metadata>))]
        public IMetadata Metadata { get; set; }

        [JsonConverter(typeof (ComplexJsonConverter<Store>))]
        public IStore Store { get; set; }

        public int MaxFeatures { get; set; }
        public int NumDecimals { get; set; }
        public bool OverridingServiceSRS { get; set; }
        public bool CircularArcPresent { get; set; }

        [JsonConverter(typeof (ComplexJsonConverter<Attributes>))]
        public IAttributes Attributes { get; set; }
    }
}