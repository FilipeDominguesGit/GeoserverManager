using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GeoserverManager.Entities.Interface.BussinessModel;
using GeoserverManager.Rest.Client;
using GeoserverManager.Rest.Client.Request;

namespace GeoserverManager.Geoserver.Rest.Client
{
    public class GeoserverRestClient : IGeoserverRestClient
    {
        private IRestService restService;

        public GeoserverRestClient(IRestService restService)
        {
            if(restService ==null)
                throw  new ArgumentNullException("restService","restService cannot be null!");

            this.restService = restService;

        }

        public ILayerInfo GetLayerInfoByNameAndNamespace(string layername, string workspace)
        {
            var uri = string.Format(@"{0}/{1}", workspace, layername);

            var request= new ServiceRequest(uri);

            var response = restService.Get(request);


            throw new NotImplementedException();
        }
    }
}
