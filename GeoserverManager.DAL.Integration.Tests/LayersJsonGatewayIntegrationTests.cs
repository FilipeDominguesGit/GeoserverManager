using System.Linq;
using GeoserverManager.DAL.Gateways;
using GeoserverManager.DAL.Integration.Tests.Helpers;
using NUnit.Framework;

namespace GeoserverManager.DAL.Integration.Tests
{
    [TestFixture]
    public class LayersJsonGatewayIntegrationTests
    {
        [TestFixture]
        public class ExecuteTests
        {
            private GeoEntityJsonGateway gateway;

            [SetUp]
            public void Setup()
            {
                gateway = new GeoEntityJsonGateway(@"..\..\input\layer.json");
            }

            [TearDown]
            public void TearDown()
            {
                gateway = null;
            }

            [Test]
            public void Should_return_entities_When_valid_json_is_foun()
            {
                //arrange

                //act
                var list = gateway.GetAllLayers();

                //assert
                Assert.IsNotNull(list);
                Assert.AreEqual(2, list.Count());
            }

            [Test]
            public void Should_return_entity_by_name_and_workspace_When_valid_json_is_found()
            {
                //arrange
                var expected = EntityHelper.CreateLayerEntity();
                //act
                var list = gateway.GetLayerByName("Layer_teste_1");
                var elem = list.ElementAt(0);
                //assert
                Assert.IsNotNull(list);
                Assert.AreEqual(1, list.Count());
                Assert.AreEqual(expected.Layer.Name, elem.Layer.Name);
            }
        }
    }
}