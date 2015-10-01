using GeoserverManager.Entities.BussinessModel;
using GeoserverManager.Entities.Interface.BussinessModel;
using GeoserverManager.Entities.Interface.BussinessModel.Enums;
using GeoserverManager.Entities.Interface.BussinessModelFactories;

namespace GeoserverManager.Entities.BussinessModelFactories
{
    public class FeatureTypeInfoBuilder : IFeatureTypeInfoBuilder, IFeatureTypeInfoBuilderPrototype
    {
        private readonly FeatureTypeInfo layerInfo = new FeatureTypeInfo();

        public IFeatureTypeInfo Build()
        {
            return layerInfo;
        }

        public IFeatureTypeInfo BuildNullObject()
        {
            return FeatureTypeInfo.NULL;
        }

        public IFeatureTypeInfoBuilder WithName(string value)
        {
            layerInfo.Name = value;
            return this;
        }

        public IFeatureTypeInfoBuilder WithSrs(string value)
        {
            layerInfo.Srs = value;
            return this;
        }

        public IFeatureTypeInfoBuilder WithSql(string value)
        {
            layerInfo.Sql = value;
            return this;
        }

        public IFeatureTypeInfoBuilder WithWorkspace(string value)
        {
            layerInfo.Workspace = value;
            return this;
        }

        public IFeatureTypeInfoBuilder WithDatastore(string value)
        {
            layerInfo.Datastore = value;
            return this;
        }

        public IFeatureTypeInfoBuilder WithGeometry(string value)
        {
            layerInfo.Geometry = value;
            return this;
        }

        public IFeatureTypeInfoBuilder WithLayerStatus(FeatureTypeInfoStatus value)
        {
            layerInfo.LayerStatus = value;
            return this;
        }

        public IFeatureTypeInfoBuilder Clone()
        {
            return new FeatureTypeInfoBuilder();
        }
    }
}