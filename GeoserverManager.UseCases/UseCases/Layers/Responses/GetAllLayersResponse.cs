using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GeoserverManager.Entities.Interface.BussinessModel;
using GeoserverManager.UseCases.Interface.UseCases.Layers.Responses;

namespace GeoserverManager.UseCases.UseCases.Layers.Responses
{
    public class GetAllLayersResponse : IGetAllLayersResponse
    {
        private class NullGetAllLayersResponse : IGetAllLayersResponse
        {
            public bool IsNull()
            {
                return true;
            }

            public IEnumerable<ILayerInfo> Layers
            {
                get
                {
                    throw new InvalidOperationException("Unable to get data from NULL object!");
                }
            }
        }
        public static IGetAllLayersResponse NULL = new NullGetAllLayersResponse();

		private static bool IsNull(IGetAllLayersResponse response)
		{
			return response == NULL;
		}

        public GetAllLayersResponse(IEnumerable<ILayerInfo> layers)
		{
            if (layers == null)
                throw new ArgumentNullException("layers", "layers can not be null");

            Layers = layers;
		}

		public IEnumerable<ILayerInfo> Layers { get; private set; }

		public bool IsNull()
		{
			return IsNull(this);
		}
    }
}
