using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GeoserverManager.DAL.Interface.Datamodel;
using GeoserverManager.Entities.Interface.BussinessModel;
using GeoserverManager.Entities.Interface.BussinessModelFactories;

namespace GeoserverManager.DAL.Repositories.Factories
{
    public static class CreateLayerInfoFromEntities
    {
        public static ILayerInfo CreateLayerInfo(IGeoEntity entity, ILayerInfoBuilder builder)
        {
            if (entity == null)
                return builder.BuildNullObject();

            return Create(entity, builder);
        }

        private static ILayerInfo Create(IGeoEntity entity, ILayerInfoBuilder builder)
        {
            builder = builder.WithName(entity.FeatureType.Name)
                .WithSql(entity.FeatureType.Metadata.Entry.ElementAt(1).VirtualTable.Sql)
                .WithWorkspace(entity.FeatureType.Namespace.Name);

            return builder.Build();
        }

    }
}
