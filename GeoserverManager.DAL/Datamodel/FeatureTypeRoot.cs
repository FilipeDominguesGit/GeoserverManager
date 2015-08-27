using GeoserverManager.DAL.Converter;
using GeoserverManager.DAL.Interface.Datamodel.FeatureType;
using Newtonsoft.Json;

namespace GeoserverManager.DAL.Datamodel.FeatureType
{
    public class FeatureTypeRoot : IFeatureTypeRoot
    {
        [JsonConverter(typeof (ComplexJsonConverter<FeatureType>))]
        public IFeatureType FeatureType { get; set; }
    }
}