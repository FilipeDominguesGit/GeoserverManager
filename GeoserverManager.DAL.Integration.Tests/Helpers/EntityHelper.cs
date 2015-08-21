using GeoserverManager.DAL.Datamodel;
using GeoserverManager.DAL.Interface.Datamodel;

namespace GeoserverManager.DAL.Integration.Tests.Helpers
{
    public static class EntityHelper
    {
        public static IGeoEntity CreateLayerEntity()
        {
            return new GeoEntity
            {
                FeatureType = new FeatureType
                {
                    Name = "live_cell_size_geom_big",
                    Namespace = new Namespace() { Name = "webgis-dev" }
                }
                
            };
        }
    }
}