using System.Collections.Generic;
using GeoserverManager.DAL.Interface.Datamodel;
using GeoserverManager.DAL.Interface.Datamodel.FeatureType;

namespace GeoserverManager.DAL.Repositories.Repositories
{
    public interface IGeoEntityRepository
    {
        IEnumerable<IFeatureTypeRoot> GetAllLayers();
    }
}