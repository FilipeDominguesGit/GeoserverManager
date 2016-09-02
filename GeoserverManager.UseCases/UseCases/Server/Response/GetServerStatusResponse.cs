using GeoserverManager.UseCases.Interface.UseCases.Server.Response;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeoserverManager.UseCases.UseCases.Server.Response
{
    public class GetServerStatusResponse: IGetServerStatusResponse
    {
        public static IGetServerStatusResponse NULL = new NullGetServerStatusResponse();

        public bool IsOnline { get; }

        public GetServerStatusResponse(bool IsOnline)
        {
            this.IsOnline = IsOnline;
        }

        public bool IsNull()
        {
            return IsNull(this);
        }
        private static bool IsNull(IGetServerStatusResponse response)
        {
            return response == NULL;
        }

       

        private class NullGetServerStatusResponse : IGetServerStatusResponse
        {
            public bool IsNull()
            {
                return true;
            }

            public bool IsOnline
            {
                get { throw new InvalidOperationException("Unable to get data from NULL object!"); }
            }
        }
    }
}
