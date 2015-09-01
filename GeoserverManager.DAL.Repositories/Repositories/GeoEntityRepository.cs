using System;
using System.Collections.Generic;
using System.Linq;
using GeoserverManager.DAL.Interface.Datamodel.Layer;
using GeoserverManager.DAL.Interface.Gateways;

namespace GeoserverManager.DAL.Repositories.Repositories
{
    public class GeoEntityRepository : IGeoEntityRepository
    {
        private readonly IGeoGateway gateway;

        public GeoEntityRepository(IGeoGateway gateway)
        {
            if (gateway == null)
                throw new ArgumentNullException("gateway", "gateway cannot be null");

            this.gateway = gateway;
        }

        public IEnumerable<ILayerEntityRoot> GetAllLayers()
        {
            var output = gateway.GetAllLayers();

            if (output == null || !output.Any())
                throw new ArgumentNullException("output", "Repository returned null value");

            return output;
        }
    }
}