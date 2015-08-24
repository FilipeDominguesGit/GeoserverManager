namespace GeoserverManager.Rest.Client.Interface.Request
{
    public interface IServiceRequest
    {
        string Uri { get; set; }
        string Body { get; set; }
    }
}