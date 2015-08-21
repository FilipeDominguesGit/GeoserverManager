using GeoserverManager.DAL.Converter;
using GeoserverManager.DAL.Interface.Datamodel;
using Newtonsoft.Json;

namespace GeoserverManager.DAL.Datamodel
{
    public class FeatureType : IFeatureType
    {
        //[JsonConverter(typeof (JsonLayerConverter<LayerMetadata>))]
        //public IMetadata Metadata { get; set; }

        public string Name { get; set; }
        public string NativeName { get; set; }

        [JsonConverter(typeof (JsonLayerConverter<Namespace>))]
        public INamespace Namespace { get; set; }

        public string Title { get; set; }

        [JsonConverter(typeof (JsonLayerConverter<Keywords>))]
        public IKeywords Keywords { get; set; }

        public string srs { get; set; }

        [JsonConverter(typeof (JsonLayerConverter<NativeBoundingBox>))]
        public INativeBoundingBox NativeBoundingBox { get; set; }

        [JsonConverter(typeof (JsonLayerConverter<LatLonBoundingBox>))]
        public ILatLonBoundingBox LatLonBoundingBox { get; set; }

        public string ProjectionPolicy { get; set; }
        public bool Enabled { get; set; }

        [JsonConverter(typeof (JsonLayerConverter<Metadata>))]
        public IMetadata Metadata { get; set; }

        [JsonConverter(typeof (JsonLayerConverter<Store>))]
        public IStore Store { get; set; }

        public int MaxFeatures { get; set; }
        public int NumDecimals { get; set; }
        public bool OverridingServiceSRS { get; set; }
        public bool CircularArcPresent { get; set; }

        [JsonConverter(typeof (JsonLayerConverter<Attributes>))]
        public IAttributes Attributes { get; set; }
    }
}