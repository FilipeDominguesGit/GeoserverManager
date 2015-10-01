namespace GeoserverManager.Entities.Interface.BussinessModel.Enums
{
    public enum FeatureTypeInfoStatus
    {
        Unknown,
        Ok,
        Missing,
        WorkspaceNotFound,
        DatastoreNotFound,
        WithChanges,
        Error,
        ConnectionError
    }
}