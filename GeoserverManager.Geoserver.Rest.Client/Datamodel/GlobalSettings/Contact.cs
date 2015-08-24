namespace GeoserverManager.Geoserver.Rest.Client.Datamodel.GlobalSettings
{
    public class Contact : IContact
    {
        public string AddressCity { get; set; }
        public string AddressCountry { get; set; }
        public string AddressType { get; set; }
        public string ContactEmail { get; set; }
        public string ContactOrganization { get; set; }
        public string ContactPerson { get; set; }
        public string ContactPosition { get; set; }
    }
}