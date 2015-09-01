using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeoserverManager.Geoserver.Rest.Client.Datamodel.Request
{
    public class Layer:ILayer
    {
        public string Workspace { get; set; }
        public string Name { get; set; }
        public string Srs { get; set; }
        public string Enabled { get; set; }
        public string ProjectionPolicy { get; set; }
        public string Sql { get; set; }
        public string Geometry { get; set; }
    }
}
