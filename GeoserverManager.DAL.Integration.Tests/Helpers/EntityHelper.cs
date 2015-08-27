using GeoserverManager.DAL.Datamodel;
using GeoserverManager.DAL.Interface.Datamodel.FeatureType;

namespace GeoserverManager.DAL.Integration.Tests.Helpers
{
    public static class EntityHelper
    {
        public static IFeatureTypeRoot CreateLayerEntity()
        {
            return new FeatureTypeRoot
            {
                FeatureType = new FeatureType
                {
                    Name = "new_test_layer"
                }
            };
        }
    }
}