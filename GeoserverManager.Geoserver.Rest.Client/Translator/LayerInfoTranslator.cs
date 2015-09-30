using GeoserverManager.Entities.Interface.BussinessModel;
using GeoserverManager.Geoserver.Rest.Client.Request.FeatureType;
using GeoserverManager.Geoserver.Rest.Client.Request.Layer;

namespace GeoserverManager.Geoserver.Rest.Client.Translator
{
    public static class LayerInfoTranslator
    {

        public static IRequestFeatureTypeRoot TranslateToRequestFeatureTypeRoot(ILayerInfo layerInfo)
        {
            var layerRoot = new RequestFeatureTypeRoot
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

        public static IRequestLayerRoot TranslateToRequestLayerRoot(ILayerInfo layerInfo)
        {
            return  new RequestLayerRoot()
            {
                Layer = new RequestLayer()
                {
                    DefaultStyle = new RequestDefaultStyle()
                    {
                        Name =layerInfo.Geometry
                    }
                }
            };
        }
    }
}
