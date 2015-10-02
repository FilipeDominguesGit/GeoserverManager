using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GeoserverManager.UseCases.Base.Interface.ResponseBoundary;

namespace GeoserverManager.UseCases.Interface.UseCases.Server.Response
{
    public interface IGetServerStatusResponse : IUseCaseResponse
    {
        bool IsOnline { get;  }
    }
}
