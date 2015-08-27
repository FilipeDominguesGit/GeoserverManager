using GeoserverManager.Entities.Base.Interface.BusinessModel;

namespace GeoserverManager.Entities.Interface.BussinessModel
{
    public interface ILayerInfo : IBusinessModel
    {
        string Name { get; }
        string Srs { get; }
        string Sql { get; }
    }
}