using System.Collections.Generic;
using GeoserverManager.DAL.Interface.Datamodel;

namespace GeoserverManager.DAL.Interface.Gateways
{
    public interface IGeoGateway
    {
        IEnumerable<IGeoEntity> GetAllLayers();
        IEnumerable<IGeoEntity> GetLayerByNameAndNamespace(string name, string @namespace);
    }
}