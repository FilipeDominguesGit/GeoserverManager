using GeoserverManager.DAL.Converter;
using GeoserverManager.DAL.Interface.Datamodel.Layer;
using Newtonsoft.Json;

namespace GeoserverManager.DAL.Datamodel.Layer
{
    public class LayerEntityRoot : ILayerEntityRoot
    {
        [JsonConverter(typeof (ComplexJsonConverter<LayerEntity>))]
        public ILayerEntity Layer { get; set; }
    }
}