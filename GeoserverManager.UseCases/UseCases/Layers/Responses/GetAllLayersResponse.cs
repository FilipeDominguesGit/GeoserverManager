using System;
using System.Collections.Generic;
using GeoserverManager.Entities.Interface.BussinessModel;
using GeoserverManager.UseCases.Interface.UseCases.Layers.Responses;

namespace GeoserverManager.UseCases.UseCases.Layers.Responses
{
    public class GetAllLayersResponse : IGetAllLayersResponse
    {
        public static IGetAllLayersResponse NULL = new NullGetAllLayersResponse();

        public GetAllLayersResponse(IEnumerable<ILayerInfo> layers)
        {
            if (layers == null)
                throw new ArgumentNullException("layers", "layers can not be null");

            Layers = layers;
        }

        public IEnumerable<ILayerInfo> Layers { get; }

        public bool IsNull()
        {
            return IsNull(this);
        }

        private static bool IsNull(IGetAllLayersResponse response)
        {
            return response == NULL;
        }

        private class NullGetAllLayersResponse : IGetAllLayersResponse
        {
            public bool IsNull()
            {
                return true;
            }

            public IEnumerable<ILayerInfo> Layers
            {
                get { throw new InvalidOperationException("Unable to get data from NULL object!"); }
            }
        }
    }
}