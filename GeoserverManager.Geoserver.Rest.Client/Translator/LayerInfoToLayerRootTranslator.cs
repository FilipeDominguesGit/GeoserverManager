using GeoserverManager.Entities.Interface.BussinessModel;
using GeoserverManager.Geoserver.Rest.Client.Request.Layer;

namespace GeoserverManager.Geoserver.Rest.Client.Translator
{
    public static class LayerInfoToLayerRootTranslator
    {

        public static ILayerRoot TranslateFrom(ILayerInfo layerInfo)
        {
            var layerRoot = new LayerRoot
            {
                FeatureType = new RequestFeatureType
                {
                    Name = layerInfo.Name,
                    Srs = layerInfo.Srs,
                    ProjectionPolicy = "FORCE_DECLARED",
                    Enabled = "true",
                    Title = layerInfo.Name,
                    Metadata = new RequestMetadata()
                    {
                        Entry = new RequestEntry()
                        {
                            Key = "JDBC_VIRTUAL_TABLE",
                            VirtualTable = new RequestVirtualTable()
                            {
                                Name = layerInfo.Name,
                                Sql = layerInfo.Sql,
                                EscapeSql = "true"
                            }
                        }
                    }
                }
            };



            return layerRoot;
        }
    }
}
