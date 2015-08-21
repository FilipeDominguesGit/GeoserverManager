using System;

namespace GeoserverManager.UseCases.Base.Interface.RequestBoundary
{
    public interface IUseCaseRequestBoundary
    {
    }

    public interface IUseCaseRequestBoundary<in TRequestModel, out TResponseModel> : IUseCaseRequestBoundary
        where TRequestModel : IUseCaseRequest
    {
        void Execute(TRequestModel request, Action<TResponseModel> responseBoundary);
    }
}