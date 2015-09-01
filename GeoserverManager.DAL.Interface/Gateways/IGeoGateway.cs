using System.Collections.Generic;
using GeoserverManager.DAL.Interface.Datamodel.Layer;

namespace GeoserverManager.DAL.Interface.Gateways
{
    public interface IGeoGateway
    {
        IEnumerable<ILayerEntityRoot> GetAllLayers();
        IEnumerable<ILayerEntityRoot> GetLayerByName(string name);
    }
}