using System.Collections.Generic;
using GeoserverManager.DAL.Interface.Datamodel.FeatureType;

namespace GeoserverManager.DAL.Interface.Gateways
{
    public interface IGeoGateway
    {
        IEnumerable<IFeatureTypeRoot> GetAllLayers();
        IEnumerable<IFeatureTypeRoot> GetLayerByName(string name);
    }
}