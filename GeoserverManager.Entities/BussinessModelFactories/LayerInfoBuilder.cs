using GeoserverManager.Entities.BussinessModel;
using GeoserverManager.Entities.Interface.BussinessModel;
using GeoserverManager.Entities.Interface.BussinessModelFactories;

namespace GeoserverManager.Entities.BussinessModelFactories
{
    public class LayerInfoBuilder : ILayerInfoBuilder, ILayerInfoBuilderPrototype
    {
        private readonly LayerInfo layerInfo = new LayerInfo();

        public ILayerInfo Build()
        {
            return layerInfo;
        }

        public ILayerInfo BuildNullObject()
        {
            return LayerInfo.NULL;
        }

        public ILayerInfoBuilder WithName(string value)
        {
            layerInfo.Name = value;
            return this;
        }

        public ILayerInfoBuilder WithWorkspace(string value)
        {
            layerInfo.Workspace = value;
            return this;
        }

        public ILayerInfoBuilder WithSql(string value)
        {
            layerInfo.Sql = value;
            return this;
        }

        public ILayerInfoBuilder Clone()
        {
            return new LayerInfoBuilder();
        }
    }
}