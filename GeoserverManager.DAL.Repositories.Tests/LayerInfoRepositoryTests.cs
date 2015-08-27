using System;
using System.Collections.Generic;
using System.Linq;
using GeoserverManager.DAL.Interface.Datamodel;
using GeoserverManager.DAL.Interface.Datamodel.FeatureType;
using GeoserverManager.DAL.Interface.Gateways;
using GeoserverManager.DAL.Repositories.Repositories;
using GeoserverManager.Entities.BussinessModelFactories;
using GeoserverManager.Entities.Interface.BussinessModel;
using GeoserverManager.Entities.Interface.BussinessModelFactories;
using GeoserverManager.UseCases.Interface.Repositories;
using NUnit.Framework;
using Telerik.JustMock;

namespace GeoserverManager.DAL.Repositories.Tests
{
    [TestFixture]
    public class LayerInfoRepositoryTests
    {
        [TestFixture]
        public class ConstructorTests
        {
            [Test]
            public void Should_throw_exception_When_gateway_is_null()
            {
                Assert.Throws<ArgumentNullException>(() => new LayerInfoRepository(null, null));
            }

            [Test]
            public void Should_build_repository_When_gateway_is_valid()
            {
                var gateway = Mock.Create<IGeoGateway>();
                var prototype = Mock.Create<ILayerInfoBuilderPrototype>();

                var repo = new LayerInfoRepository(gateway, prototype);

                Assert.IsNotNull(repo);
            }
        }

        [TestFixture]
        public class ExecuteTests
        {
            private ILayerInfoBuilderPrototype builderPrototype;
            private IGeoGateway gateway;
            private ILayerInfoRepository repository;

            [SetUp]
            public void Setup()
            {
                gateway = Mock.Create<IGeoGateway>();
                builderPrototype = new LayerInfoBuilder();
                repository = new LayerInfoRepository(gateway, builderPrototype);
            }

            [TearDown]
            public void TearDown()
            {
                gateway = null;
                repository = null;
                builderPrototype = null;
            }

            [Test]
            public void Should_return_list_with_layerinfo_When_db_has_records()
            {
                //arrange
                var output = new List<IFeatureTypeRoot>();
                var elem = Mock.Create<IFeatureTypeRoot>();

                elem.FeatureType.Metadata = Mock.Create<IMetadata>();
                elem.FeatureType.Metadata.Entry = new List<IEntry>();
                (elem.FeatureType.Metadata.Entry as List<IEntry>).Add(Mock.Create<IEntry>());

                var entry = Mock.Create<IEntry>();
                var virtualTable = Mock.Create<IVirtualTable>();
                virtualTable.Sql = "sql";
                entry.VirtualTable = virtualTable;

                (elem.FeatureType.Metadata.Entry as List<IEntry>).Add(entry);
                output.Add(elem);
                Mock.Arrange(() => gateway.GetAllLayers()).Returns(output);

                //act
                var list = repository.GetAllLayersInfos().ToList();
                var layerInfo = list.First();

                //assert
                Assert.IsNotEmpty(list);
                Assert.IsInstanceOf<ILayerInfo>(layerInfo);
            }
        }
    }
}