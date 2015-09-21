using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GeoserverManager.Entities.Interface.BussinessModel;
using GeoserverManager.Geoserver.Rest.Client.Request.Layer;

namespace GeoserverManager.Geoserver.Rest.Client
{
    public static class LayerInfoToLayerRootTranslator
    {

        public static ILayerRoot TranslateFrom(ILayerInfo layerInfo)
        {
            var layerRoot = new LayerRoot
            {
                Layer = new Layer
                {
                    Name = layerInfo.Name,
                    Enabled = "True",
                    Geometry = "Polygon",
                    ProjectionPolicy = "FORCE_DECLARED",
                    Sql = layerInfo.Sql,
                    Srs = layerInfo.Srs,
                    Workspace = layerInfo.Workspace
                }
            };



            return layerRoot;
        }
    }
}
