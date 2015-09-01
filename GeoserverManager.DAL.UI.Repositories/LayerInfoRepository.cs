using System;
using System.Collections.Generic;
using System.Linq;
using GeoserverManager.DAL.Interface.Datamodel.Layer;
using GeoserverManager.DAL.Interface.Gateways;
using GeoserverManager.DAL.UI.Repositories.Factories;
using GeoserverManager.Entities.Interface.BussinessModel;
using GeoserverManager.Entities.Interface.BussinessModelFactories;
using GeoserverManager.UseCases.Interface.Repositories;

namespace GeoserverManager.DAL.UI.Repositories
{
    public class LayerInfoRepository : ILayerInfoRepository
    {
        private readonly ILayerInfoBuilderPrototype builderPrototype;
        private readonly IGeoGateway gateway;

        public LayerInfoRepository(IGeoGateway gateway, ILayerInfoBuilderPrototype builderPrototype)
        {
            if (gateway == null)
                throw new ArgumentNullException("gateway", "gateway cannot be null");
            if (builderPrototype == null)
                throw new ArgumentNullException("builderPrototype", "builderPrototype cannot be null");

            this.gateway = gateway;
            this.builderPrototype = builderPrototype;
        }

        public IEnumerable<ILayerInfo> GetAllLayersInfos()
        {
            var output = gateway.GetAllLayers();

            if (output == null || !output.Any())
                throw new ArgumentNullException("output", "Repository returned null value");

            return output.Select(CreateLayerInfoFromEntity);
        }

        private ILayerInfo CreateLayerInfoFromEntity(ILayerEntityRoot entity)
        {
            var builder = builderPrototype.Clone();

            return CreateLayerInfoFromEntities.CreateLayerInfo(entity, builder);
        }
    }
}