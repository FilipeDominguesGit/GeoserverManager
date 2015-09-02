using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GeoserverManager.Entities.Interface.BussinessModel;
using GeoserverManager.UseCases.Base.Interface.RequestBoundary;

namespace GeoserverManager.UseCases.Interface.UseCases.Layers.Requests
{
    public interface IGetLayerStatusRequest : IUseCaseRequest
    {
        ILayerInfo Layer { get; set; }
    }
}