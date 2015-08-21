using GeoserverManager.DAL.Converter;
using GeoserverManager.DAL.Interface.Datamodel;
using Newtonsoft.Json;

namespace GeoserverManager.DAL.Datamodel
{
    public class GeoEntity : IGeoEntity
    {
        [JsonConverter(typeof (JsonLayerConverter<FeatureType>))]
        public IFeatureType FeatureType { get; set; }
    }
}