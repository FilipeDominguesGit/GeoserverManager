using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeoserverManager.Geoserver.Rest.Client.Request.Layer
{
    public class RequestVirtualTable: IRequestVirtualTable
    {
        public string Name { get; set; }
        public string Sql { get; set; }
        public string EscapeSql { get; set; }
    }
}
