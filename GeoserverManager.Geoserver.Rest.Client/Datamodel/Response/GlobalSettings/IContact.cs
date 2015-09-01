namespace GeoserverManager.Geoserver.Rest.Client.Datamodel.Response.GlobalSettings
{
    public interface IContact
    {
        string AddressCity { get; set; }
        string AddressCountry { get; set; }
        string AddressType { get; set; }
        string ContactEmail { get; set; }
        string ContactOrganization { get; set; }
        string ContactPerson { get; set; }
        string ContactPosition { get; set; }
    }
}