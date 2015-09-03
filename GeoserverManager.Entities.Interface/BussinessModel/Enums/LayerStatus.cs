namespace GeoserverManager.Entities.Interface.BussinessModel.Enums
{
    public enum LayerStatus
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
