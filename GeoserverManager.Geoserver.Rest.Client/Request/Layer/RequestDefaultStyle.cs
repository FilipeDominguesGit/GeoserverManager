using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeoserverManager.Geoserver.Rest.Client.Request.Layer
{
    public class RequestDefaultStyle: IRequestDefaultStyle
    {
        public string Name { get; set; }
    }
}
