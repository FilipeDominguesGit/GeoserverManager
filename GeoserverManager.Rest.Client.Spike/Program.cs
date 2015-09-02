using System;
using GeoserverManager.DAL.Gateways;
using GeoserverManager.Geoserver.Rest.Client;
using GeoserverManager.Rest.Client.Request;

namespace GeoserverManager.Rest.Client.Spike
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            var restService = new RestService("", "",
                "");
            // var restService = new RestService("http://jsonplaceholder.typicode.com");

            var gate = new GeoEntityJsonGateway(@"c:\tmp\layer.json");

            var geoserverClient = new GeoserverRestClient(restService);

            //  var testLayer = "{'featureType': {'name': 'new_test_layer','title': 'new_test_layer','srs': 'EPSG:4326','projectionPolicy': 'FORCE_DECLARED','enabled': 'true','metadata': {'entry': {'@key': 'JDBC_VIRTUAL_TABLE','virtualTable': {'name': 'new_test_layer','sql': 'SELECT uuid, cellid, cellname, cellname as sigga_external_id, cellstate, operator, latitude, longitude, azimuth, sectorid, siteenvironment, siteid, vendor, tech, band, sector, oss, mcc, mnc, controllerid, controllername, lac, rac, tac, carrier, frequency, code, dldataspeed,cellgeomsmall as geom,cellgeommicrotiny as microtiny, cellgeomtiny as tiny, cellgeomsmall as small, cellgeommedium as medium, cellgeombig as big, cellgeombigger as bigger,cellgeomhuge as huge, errors FROM view_livefulldata_cell','escapeSql': 'false'}}},'overridingServiceSRS': 'false','circularArcPresent': 'false'}}";
            //var response = restService.Post(new ServiceRequest("workspaces/webgis-dev/datastores/networkTopologyDev/featuretypes") { Body = testLayer });

            //restService.Post(new ServiceRequest("workspaces/webgis-dev/datastores/networkTopologyDev/featuretypes") {Body = testLayer});
            var response =
                restService.Get(
                    new ServiceRequest("workspaces/webgis-dev/datastores/networkTopologyDev/featuretypes/new_test_layer"));
            //var layerInfo = JsonConvert.DeserializeObject<GeoEntity>(response.Data);

            // var response = restService.Get(new ServiceRequest("layers/uk_postcode"));
            //geoserverClient.GetAllWorkSpaces();

            var output=geoserverClient.GetLayerInfoBy("networkTopologyDev", "webgis-dev", "new_test_layer");


            Console.WriteLine(response.StatusCode.ToString());
            Console.WriteLine(response.Data);

            Console.ReadKey();
        }
    }
}