using GeoserverManager.Entities.Base.Interface.BusinessModel;

namespace GeoserverManager.Entities.Interface.BussinessModel
{
    public interface ILayerInfo : IBusinessModel
    {
        string Name { get; }
        string Workspace { get; }
        string Sql { get; }
    }
}