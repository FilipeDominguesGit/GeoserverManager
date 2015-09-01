using System.Collections.Generic;
using GeoserverManager.DAL.Interface.Datamodel.Layer;

namespace GeoserverManager.DAL.Repositories.Repositories
{
    public interface IGeoEntityRepository
    {
        IEnumerable<ILayerEntityRoot> GetAllLayers();
    }
}