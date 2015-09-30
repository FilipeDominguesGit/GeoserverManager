using GeoserverManager.Entities.Interface.BussinessModel;
using GeoserverManager.Entities.Interface.BussinessModel.Enums;

namespace GeoserverManager.Entities.Interface.BussinessModelFactories
{
    public interface ILayerInfoBuilder
    {
        ILayerInfo Build();
        ILayerInfo BuildNullObject();
        ILayerInfoBuilder WithName(string value);
        ILayerInfoBuilder WithSrs(string value);
        ILayerInfoBuilder WithSql(string value);
        ILayerInfoBuilder WithWorkspace(string value);
        ILayerInfoBuilder WithDatastore(string value);
        ILayerInfoBuilder WithGeometry(string value);
        ILayerInfoBuilder WithLayerStatus(LayerStatus value);
    }
}