using System;
using System.Collections.Generic;
using System.Linq;
using GeoserverManager.DAL.Interface.Datamodel.Layer;
using GeoserverManager.DAL.Interface.Gateways;
using GeoserverManager.DAL.UI.Repositories;
using GeoserverManager.Entities.BussinessModelFactories;
using GeoserverManager.Entities.Interface.BussinessModel;
using GeoserverManager.Entities.Interface.BussinessModelFactories;
using GeoserverManager.UseCases.Interface.Repositories;
using NUnit.Framework;
using Telerik.JustMock;

namespace GeoserverManager.DAL.Repositories.Tests
{
    [TestFixture]
    public class FeatureTypeInfoRepositoryTests
    {
        [TestFixture]
        public class ConstructorTests
        {
            [Test]
            public void Should_build_repository_When_gateway_is_valid()
            {
                var gateway = Mock.Create<IGeoGateway>();
                var prototype = Mock.Create<IFeatureTypeInfoBuilderPrototype>();

                var repo = new FeatureTypeInfoRepository(gateway, prototype);

                Assert.IsNotNull(repo);
            }

            [Test]
            public void Should_throw_exception_When_gateway_is_null()
            {
                Assert.Throws<ArgumentNullException>(() => new FeatureTypeInfoRepository(null, null));
            }
        }

        [TestFixture]
        public class ExecuteTests
        {
            [SetUp]
            public void Setup()
            {
                gateway = Mock.Create<IGeoGateway>();
                builderPrototype = new FeatureTypeInfoBuilder();
                repository = new FeatureTypeInfoRepository(gateway, builderPrototype);
            }

            [TearDown]
            public void TearDown()
            {
                gateway = null;
                repository = null;
                builderPrototype = null;
            }

            private IFeatureTypeInfoBuilderPrototype builderPrototype;
            private IGeoGateway gateway;
            private IFeatureTypeInfoRepository repository;

            [Test]
            public void Should_return_list_with_layerinfo_When_db_has_records()
            {
                //arrange
                var output = new List<ILayerEntityRoot>();
                var elem = Mock.Create<ILayerEntityRoot>();


                elem.Layer.Sql = "sql";

                output.Add(elem);
                Mock.Arrange(() => gateway.GetAllLayers()).Returns(output);

                //act
                var list = repository.GetAllLayersInfos().ToList();
                var layerInfo = list.First();

                //assert
                Assert.IsNotEmpty(list);
                Assert.IsInstanceOf<IFeatureTypeInfo>(layerInfo);
            }
        }
    }
}