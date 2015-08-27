﻿using GeoserverManager.DAL.Converter;
using GeoserverManager.DAL.Interface.Datamodel.FeatureType;
using Newtonsoft.Json;

namespace GeoserverManager.DAL.Datamodel.FeatureType
{
    public class Entry : IEntry
    {
        [JsonProperty("@key")]
        public string Key { get; set; }

        [JsonProperty("$")]
        public string Dolar { get; set; }

        [JsonConverter(typeof (ComplexJsonConverter<VirtualTable>))]
        public IVirtualTable VirtualTable { get; set; }
    }
}