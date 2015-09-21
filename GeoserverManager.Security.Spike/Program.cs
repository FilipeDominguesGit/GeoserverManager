using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GeoserverManager.DAL.UI.Repositories.Security;

namespace GeoserverManager.Security.Spike
{
    class Program
    {
        static void Main(string[] args)
        {
           var hash= HashUtils.Encrypt(@"geoserver", "GeoserverManager");

           var plain= HashUtils.Decrypt(hash, "GeoserverManager");
        }
    }
}
