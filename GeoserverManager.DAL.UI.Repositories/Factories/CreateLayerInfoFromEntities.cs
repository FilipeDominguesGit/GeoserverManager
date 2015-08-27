using System.Linq;
using GeoserverManager.DAL.Interface.Datamodel.FeatureType;
using GeoserverManager.Entities.Interface.BussinessModel;
using GeoserverManager.Entities.Interface.BussinessModelFactories;

namespace GeoserverManager.DAL.UI.Repositories.Factories
{
    public static class CreateLayerInfoFromEntities
    {
        public static ILayerInfo CreateLayerInfo(IFeatureTypeRoot entity, ILayerInfoBuilder builder)
        {
            if (entity == null)
                return builder.BuildNullObject();

            return Create(entity, builder);
        }

        private static ILayerInfo Create(IFeatureTypeRoot entity, ILayerInfoBuilder builder)
        {
            builder = builder.WithName(entity.FeatureType.Name)
                .WithSrs(entity.FeatureType.srs)
                .WithSql(entity.FeatureType.Metadata.Entry.ElementAt(0).VirtualTable.Sql);

            return builder.Build();
        }
    }
}