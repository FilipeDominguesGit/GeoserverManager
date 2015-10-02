using GeoserverManager.Entities.Interface.BussinessModel;
using GeoserverManager.UseCases.Interface.UseCases.FeatureTypes.Requests;

namespace GeoserverManager.UseCases.UseCases.FeatureTypes.Requests
{
    public class UploadFeatureTypeInfoToGeoserverRequest: IUploadFeatureTypeInfoToGeoserverRequest
    {
        public UploadFeatureTypeInfoToGeoserverRequest(IFeatureTypeInfo layerInfo)
        {
            this.Layer = layerInfo;

        }
        public IFeatureTypeInfo Layer { get; set; }
    }
}
