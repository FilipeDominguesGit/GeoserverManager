﻿using GeoserverManager.Entities.Interface.BussinessModel;
using GeoserverManager.Geoserver.Rest.Client.Datamodel.GlobalSettings;
using GeoserverManager.Geoserver.Rest.Client.Datamodel.Workspaces;
using GeoserverManager.Geoserver.Rest.Client.Response;

namespace GeoserverManager.Geoserver.Rest.Client
{
    public interface IGeoserverRestClient
    {
        IGlobalSettingsRoot GetGlobalSettings();
        IWorkspacesRoot GetAllWorkSpaces();
        IGeoserverRestResponse GetLayerInfoBy(string datastore, string workspace, string layername);
        IGeoserverRestResponse PostLayer(IFeatureTypeInfo layer);
        IGeoserverRestResponse PutLayer(IFeatureTypeInfo layer);
        IGeoserverRestResponse GetServerStatus();

    }
}