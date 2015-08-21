using System.Collections.Generic;
using GeoserverManager.DAL.Interface.Datamodel;

namespace GeoserverManager.DAL.Repositories.Repositories
{
    public interface IGeoEntityRepository
    {
        IEnumerable<IGeoEntity> GetAllLayers();
    }
}
