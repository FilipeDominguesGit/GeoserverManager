using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using GeoserverManager.DAL.Datamodel.Layer;
using GeoserverManager.DAL.Interface.Datamodel.Layer;
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

        private string FilePath { get; }

        public IEnumerable<ILayerEntityRoot> GetAllLayers()
        {
            var entities = JsonConvert.DeserializeObject<IEnumerable<LayerEntityRoot>>(File.ReadAllText(@FilePath));

            return entities;
        }

        public IEnumerable<ILayerEntityRoot> GetLayerByName(string name)
        {
            var entities = JsonConvert.DeserializeObject<IEnumerable<LayerEntityRoot>>(File.ReadAllText(@FilePath));

            entities =
                entities.Where(x => x.Layer.Name.Equals(name))
                    .ToList();

            return entities;
        }
    }
}