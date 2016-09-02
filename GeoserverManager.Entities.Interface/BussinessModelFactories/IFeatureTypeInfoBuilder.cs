using GeoserverManager.Entities.Interface.BussinessModel;
using GeoserverManager.Entities.Interface.BussinessModel.Enums;

namespace GeoserverManager.Entities.Interface.BussinessModelFactories
{
    public interface IFeatureTypeInfoBuilder
    {
        IFeatureTypeInfo Build();
        IFeatureTypeInfo BuildNullObject();
        IFeatureTypeInfoBuilder WithName(string value);
        IFeatureTypeInfoBuilder WithSrs(string value);
        IFeatureTypeInfoBuilder WithSql(string value);
        IFeatureTypeInfoBuilder WithWorkspace(string value);
        IFeatureTypeInfoBuilder WithDatastore(string value);
        IFeatureTypeInfoBuilder WithGeometry(string value);
        IFeatureTypeInfoBuilder WithLayerStatus(FeatureTypeInfoStatus value);
    }
}