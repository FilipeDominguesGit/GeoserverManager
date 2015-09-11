using System;
using GeoserverManager.Entities.Interface.BussinessModel.Enums;
using GeoserverManager.UseCases.Interface.UseCases.Layers.Responses;

namespace GeoserverManager.UseCases.UseCases.Layers.Responses
{
    public class GetLayerStatusResponse : IGetLayerStatusResponse
    {
        public static IGetLayerStatusResponse NULL = new NullGetLayerStatusResponse();

        public GetLayerStatusResponse(LayerStatus status)
        {
            if (status == null)
                throw new ArgumentNullException("status", "status can not be null");

            Status = status;
        }

        public LayerStatus Status { get; }

        public bool IsNull()
        {
            return IsNull(this);
        }

        private static bool IsNull(IGetLayerStatusResponse response)
        {
            return response == NULL;
        }

        private class NullGetLayerStatusResponse : IGetLayerStatusResponse
        {
            public bool IsNull()
            {
                return true;
            }

            public LayerStatus Status
            {
                get { throw new InvalidOperationException("Unable to get data from NULL object!"); }
            }
        }
    }
}