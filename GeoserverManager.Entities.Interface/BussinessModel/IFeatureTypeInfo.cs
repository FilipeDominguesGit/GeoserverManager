using GeoserverManager.Entities.Base.Interface.BusinessModel;
using GeoserverManager.Entities.Interface.BussinessModel.Enums;

namespace GeoserverManager.Entities.Interface.BussinessModel
{
    public interface IFeatureTypeInfo : IBusinessModel
    {
        string Datastore { get; }
        string Name { get; }
        string Srs { get; }
        string Sql { get; }
        string Workspace { get; }
        string Geometry { get; }
        FeatureTypeInfoStatus LayerStatus { get; }


        void ChangeLayerStatus(FeatureTypeInfoStatus layerStatus);
    }
}