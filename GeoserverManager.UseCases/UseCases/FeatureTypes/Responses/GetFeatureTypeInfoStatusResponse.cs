using System;
using GeoserverManager.Entities.Interface.BussinessModel.Enums;
using GeoserverManager.UseCases.Interface.UseCases.Layers.Responses;

namespace GeoserverManager.UseCases.UseCases.FeatureTypes.Responses
{
    public class GetFeatureTypeInfoStatusResponse : IGetFeatureTypeInfoStatusResponse
    {
        public static IGetFeatureTypeInfoStatusResponse NULL = new NullGetLayerStatusResponse();

        public GetFeatureTypeInfoStatusResponse(FeatureTypeInfoStatus status)
        {
         
            Status = status;
        }

        public FeatureTypeInfoStatus Status { get; }

        public bool IsNull()
        {
            return IsNull(this);
        }

        private static bool IsNull(IGetFeatureTypeInfoStatusResponse response)
        {
            return response == NULL;
        }

        private class NullGetLayerStatusResponse : IGetFeatureTypeInfoStatusResponse
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