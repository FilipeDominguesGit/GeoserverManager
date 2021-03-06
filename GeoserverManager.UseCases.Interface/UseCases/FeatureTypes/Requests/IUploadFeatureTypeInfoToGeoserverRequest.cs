﻿using GeoserverManager.Entities.Interface.BussinessModel;
using GeoserverManager.UseCases.Base.Interface.RequestBoundary;

namespace GeoserverManager.UseCases.Interface.UseCases.FeatureTypes.Requests
{
    public interface IUploadFeatureTypeInfoToGeoserverRequest : IUseCaseRequest
    {
        IFeatureTypeInfo Layer { get; set; }
    }
}
