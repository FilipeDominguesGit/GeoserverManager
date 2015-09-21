using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GeoserverManager.Entities.Interface.BussinessModel.Enums;
using GeoserverManager.UseCases.Interface.UseCases.Layers.Responses;

namespace GeoserverManager.UseCases.UseCases.Layers.Responses
{
    public class UploadLayerToGeoserverResponse: IUploadLayerToGeoserverResponse
    {
        public static IUploadLayerToGeoserverResponse NULL = new NullUploadLayerToGeoserverResponse();

        public UploadLayerToGeoserverResponse(LayerStatus status)
        {
        
            Status = status;
        }

        public LayerStatus Status { get; }

        public bool IsNull()
        {
            return IsNull(this);
        }

        private static bool IsNull(IUploadLayerToGeoserverResponse response)
        {
            return response == NULL;
        }

        private class NullUploadLayerToGeoserverResponse : IUploadLayerToGeoserverResponse
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