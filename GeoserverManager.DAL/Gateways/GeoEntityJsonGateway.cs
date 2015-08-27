using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using GeoserverManager.DAL.Datamodel;
using GeoserverManager.DAL.Datamodel.FeatureType;
using GeoserverManager.DAL.Interface.Datamodel;
using GeoserverManager.DAL.Interface.Datamodel.FeatureType;
using GeoserverManager.DAL.Interface.Gateways;
using Newtonsoft.Json;

namespace GeoserverManager.DAL.Gateways
{
    public class GeoEntityJsonGateway : IGeoEntityJsonGateway
    {
        public GeoEntityJsonGateway(string connectionString)
        {
            if (string.IsNullOrWhiteSpace(connectionString))
                throw new ArgumentNullException("connectionString", "connectionString cannot be null or empty");

            FilePath = connectionString;
        }

        private string FilePath { get; set; }

        public IEnumerable<IFeatureTypeRoot> GetAllLayers()
        {
            var entities = JsonConvert.DeserializeObject<IEnumerable<FeatureTypeRoot>>(File.ReadAllText(@FilePath));

            return entities;
        }

        public IEnumerable<IFeatureTypeRoot> GetLayerByName(string name)
        {
            var entities = JsonConvert.DeserializeObject<IEnumerable<FeatureTypeRoot>>(File.ReadAllText(@FilePath));

            entities =
                entities.Where(x => x.FeatureType.Name.Equals(name))
                    .ToList();

            return entities;
        }
    }
}