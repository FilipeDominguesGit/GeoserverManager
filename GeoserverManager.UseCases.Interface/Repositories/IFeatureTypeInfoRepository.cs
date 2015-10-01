using System.Collections.Generic;
using GeoserverManager.Entities.Interface.BussinessModel;

namespace GeoserverManager.UseCases.Interface.Repositories
{
    public interface IFeatureTypeInfoRepository
    {
        IEnumerable<IFeatureTypeInfo> GetAllLayersInfos();
    }
}