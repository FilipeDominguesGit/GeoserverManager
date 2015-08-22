using System.Collections.Generic;
using GeoserverManager.Entities.Interface.BussinessModel;

namespace GeoserverManager.UseCases.Interface.Repositories
{
    public interface ILayerInfoRepository
    {
        IEnumerable<ILayerInfo> GetAllLayersInfos();
    }
}