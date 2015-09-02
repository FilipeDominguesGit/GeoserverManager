using GeoserverManager.Entities.BussinessModel;
using GeoserverManager.Entities.Interface.BussinessModel;
using GeoserverManager.Entities.Interface.BussinessModel.Enums;
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

        public ILayerInfoBuilder WithSrs(string value)
        {
            layerInfo.Srs = value;
            return this;
        }

        public ILayerInfoBuilder WithSql(string value)
        {
            layerInfo.Sql = value;
            return this;
        }

        public ILayerInfoBuilder WithWorkspace(string value)
        {
            layerInfo.Workspace = value;
            return this;
        }

        public ILayerInfoBuilder WithDatastore(string value)
        {
            layerInfo.Datastore = value;
            return this;
        }


        public ILayerInfoBuilder WithLayerStatus(LayerStatus value)
        {
            layerInfo.LayerStatus = value;
            return this;
        }

        public ILayerInfoBuilder Clone()
        {
            return new LayerInfoBuilder();
        }
    }
}