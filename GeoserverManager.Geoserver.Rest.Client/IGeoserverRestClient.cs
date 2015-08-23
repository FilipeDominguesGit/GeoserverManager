using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GeoserverManager.Entities.Interface.BussinessModel;

namespace GeoserverManager.Geoserver.Rest.Client
{
    public interface IGeoserverRestClient
    {

        ILayerInfo GetLayerInfoByNameAndNamespace(string layername, string workspace);

    }
}
