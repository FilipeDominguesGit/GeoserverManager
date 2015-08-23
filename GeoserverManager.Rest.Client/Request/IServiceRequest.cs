using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeoserverManager.Rest.Client.Request
{
    public interface IServiceRequest
    {
        string Uri { get; set; }
    }
}
