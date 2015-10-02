using System;
using System.Collections.Generic;
using GeoserverManager.Entities.Interface.BussinessModel;
using GeoserverManager.UseCases.Interface.UseCases.FeatureTypes.Responses;

namespace GeoserverManager.UseCases.UseCases.FeatureTypes.Responses
{
    public class GetAllFeatureTypesInfosResponse : IGetAllFeatureTypesInfosResponse
    {
        public static IGetAllFeatureTypesInfosResponse NULL = new NullGetAllLayersResponse();

        public GetAllFeatureTypesInfosResponse(IEnumerable<IFeatureTypeInfo> layers)
        {
            if (layers == null)
                throw new ArgumentNullException("layers", "layers can not be null");

            Layers = layers;
        }

        public IEnumerable<IFeatureTypeInfo> Layers { get; }

        public bool IsNull()
        {
            return IsNull(this);
        }

        private static bool IsNull(IGetAllFeatureTypesInfosResponse response)
        {
            return response == NULL;
        }

        private class NullGetAllLayersResponse : IGetAllFeatureTypesInfosResponse
        {
            public bool IsNull()
            {
                return true;
            }

            public IEnumerable<IFeatureTypeInfo> Layers
            {
                get { throw new InvalidOperationException("Unable to get data from NULL object!"); }
            }
        }
    }
}