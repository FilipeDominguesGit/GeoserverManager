using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GeoserverManager.Entities.Interface.BussinessModel;

namespace GeoserverManager.UseCases.Interface.Repositories
{
    public interface ILayerInfoRepository
    {
        IEnumerable<ILayerInfo> GetAllLayersInfos();
    }
}
