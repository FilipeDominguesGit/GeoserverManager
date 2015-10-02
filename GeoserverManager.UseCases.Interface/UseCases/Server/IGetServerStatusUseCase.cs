using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GeoserverManager.UseCases.Base.Interface.RequestBoundary;
using GeoserverManager.UseCases.Interface.UseCases.Server.Request;
using GeoserverManager.UseCases.Interface.UseCases.Server.Response;

namespace GeoserverManager.UseCases.Interface.UseCases.Server
{
    public interface IGetServerStatusUseCase : IUseCaseRequestBoundary<IGetServerStatusRequest, IGetServerStatusResponse>
    {
    }
}
