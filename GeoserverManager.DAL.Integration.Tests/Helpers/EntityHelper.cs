using GeoserverManager.DAL.Datamodel;
using GeoserverManager.DAL.Datamodel.Layer;
using GeoserverManager.DAL.Interface.Datamodel.Layer;

namespace GeoserverManager.DAL.Integration.Tests.Helpers
{
    public static class EntityHelper
    {
        public static ILayerEntityRoot CreateLayerEntity()
        {
            return new LayerEntityRoot
            {
                Layer = new LayerEntity
                {
                    Name = "Layer_teste_1"
                }
            };
        }
    }
}