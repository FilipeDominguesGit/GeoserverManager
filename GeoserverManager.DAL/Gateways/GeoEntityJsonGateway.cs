using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using GeoserverManager.DAL.Datamodel;
using GeoserverManager.DAL.Interface.Datamodel;
using GeoserverManager.DAL.Interface.Gateways;
using Newtonsoft.Json;

namespace GeoserverManager.DAL.Gateways
{
    public class GeoEntityJsonGateway : IGeoGateway
    {
        public GeoEntityJsonGateway(string path)
        {
            if (string.IsNullOrWhiteSpace(path))
                throw new ArgumentNullException("path", "path cannot be null or empty");

            FilePath = path;
        }

        private string FilePath { get; set; }

        public IEnumerable<IGeoEntity> GetAllLayers()
        {
            var entities = JsonConvert.DeserializeObject<IEnumerable<GeoEntity>>(File.ReadAllText(@FilePath));

            return entities;
        }

        public IEnumerable<IGeoEntity> GetLayerByNameAndNamespace(string name, string @namespace)
        {
            var entities = JsonConvert.DeserializeObject<IEnumerable<GeoEntity>>(File.ReadAllText(@FilePath));

            entities =
                entities.Where(x => x.FeatureType.Name.Equals(name) && x.FeatureType.Namespace.Name == @namespace)
                    .ToList();

            return entities;
        }
    }
}