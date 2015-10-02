using System;
using GeoserverManager.Entities.Interface.BussinessModel.Enums;
using GeoserverManager.UseCases.Interface.UseCases.FeatureTypes.Responses;

namespace GeoserverManager.UseCases.UseCases.FeatureTypes.Responses
{
    public class UploadFeatureTypeInfoToGeoserverResponse: IUploadFeatureTypeInfoToGeoserverResponse
    {
        public static IUploadFeatureTypeInfoToGeoserverResponse NULL = new NullUploadLayerToGeoserverResponse();

        public UploadFeatureTypeInfoToGeoserverResponse(FeatureTypeInfoStatus status)
        {
        
            Status = status;
        }

        public FeatureTypeInfoStatus Status { get; }

        public bool IsNull()
        {
            return IsNull(this);
        }

        private static bool IsNull(IUploadFeatureTypeInfoToGeoserverResponse response)
        {
            return response == NULL;
        }

        private class NullUploadLayerToGeoserverResponse : IUploadFeatureTypeInfoToGeoserverResponse
        {
            public bool IsNull()
            {
                return true;
            }

            public FeatureTypeInfoStatus Status
            {
                get { throw new InvalidOperationException("Unable to get data from NULL object!"); }
            }
        }
    }
}