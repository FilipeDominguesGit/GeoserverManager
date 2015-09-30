using GeoserverManager.DAL.Interface.Datamodel.Layer;
using GeoserverManager.Entities.Interface.BussinessModel;
using GeoserverManager.Entities.Interface.BussinessModel.Enums;
using GeoserverManager.Entities.Interface.BussinessModelFactories;

namespace GeoserverManager.DAL.UI.Repositories.Factories
{
    public static class CreateLayerInfoFromEntities
    {
        public static ILayerInfo CreateLayerInfo(ILayerEntityRoot entity, ILayerInfoBuilder builder)
        {
            if (entity == null)
                return builder.BuildNullObject();

            return Create(entity, builder);
        }

        private static ILayerInfo Create(ILayerEntityRoot entity, ILayerInfoBuilder builder)
        {
            builder = builder.WithName(entity.Layer.Name)
                .WithSrs(entity.Layer.Srs)
                .WithSql(entity.Layer.Sql)
                .WithDatastore(entity.Layer.Datastore)
                .WithWorkspace(entity.Layer.Workspace)
                .WithGeometry(entity.Layer.Geometry)
                .WithLayerStatus(LayerStatus.Unknown);

            return builder.Build();
        }
    }
}