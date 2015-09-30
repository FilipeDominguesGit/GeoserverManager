using GeoserverManager.Entities.Base.Interface.BusinessModel;
using GeoserverManager.Entities.Interface.BussinessModel.Enums;

namespace GeoserverManager.Entities.Interface.BussinessModel
{
    public interface ILayerInfo : IBusinessModel
    {
        string Datastore { get; }
        string Name { get; }
        string Srs { get; }
        string Sql { get; }
        string Workspace { get; }
        string Geometry { get; }
        LayerStatus LayerStatus { get; }


        void ChangeLayerStatus(LayerStatus layerStatus);
    }
}