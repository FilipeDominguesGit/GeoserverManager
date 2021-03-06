﻿using System;
using System.Collections.Generic;
using GeoserverManager.DAL.Interface.Datamodel.Layer;
using GeoserverManager.DAL.Interface.Gateways;
using GeoserverManager.DAL.Repositories.Repositories;
using NUnit.Framework;
using Telerik.JustMock;

namespace GeoserverManager.DAL.Repositories.Tests
{
    [TestFixture]
    public class GeoEntityRepositoryTests
    {
        [TestFixture]
        public class ConstructorTests
        {
            [Test]
            public void Should_build_repository_When_gateway_is_valid()
            {
                var gateway = Mock.Create<IGeoGateway>();

                var repo = new GeoEntityRepository(gateway);

                Assert.IsNotNull(repo);
            }

            [Test]
            public void Should_throw_exception_When_gateway_is_null()
            {
                Assert.Throws<ArgumentNullException>(() => new GeoEntityRepository(null));
            }
        }

        [TestFixture]
        public class ExecuteTests
        {
            [SetUp]
            public void Setup()
            {
                gateway = Mock.Create<IGeoGateway>();
                repository = new GeoEntityRepository(gateway);
            }

            [TearDown]
            public void TearDown()
            {
                gateway = null;
                repository = null;
            }

            private IGeoGateway gateway;
            private IGeoEntityRepository repository;

            [Test]
            public void Should_return_list_with_geoentities_When_db_has_records()
            {
                //arrange
                var output = new List<ILayerEntityRoot>();
                var elem = Mock.Create<ILayerEntityRoot>();
                output.Add(elem);
                Mock.Arrange(() => gateway.GetAllLayers()).Returns(output);

                //act
                var list = repository.GetAllLayers();

                //assert
                Assert.IsNotEmpty(list);
            }
        }
    }
}