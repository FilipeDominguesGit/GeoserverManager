﻿using GeoserverManager.Entities.Interface.BussinessModel;

namespace GeoserverManager.Entities.Interface.BussinessModelFactories
{
    public interface ILayerInfoBuilder
    {
        ILayerInfo Build();
        ILayerInfo BuildNullObject();
        ILayerInfoBuilder WithName(string value);
        ILayerInfoBuilder WithWorkspace(string value);
        ILayerInfoBuilder WithSql(string value);
    }
}