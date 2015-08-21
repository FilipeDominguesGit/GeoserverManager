using System;
using GeoserverManager.DAL.Gateways;
using NUnit.Framework;

namespace GeoserverManager.DAL.Tests
{
    [TestFixture]
    public class LayersJsonGatewayTests
    {
        [TestFixture]
        public class ConstructorTests
        {
            [TestCase(" ")]
            [TestCase("")]
            [TestCase("   ")]
            [TestCase(null)]
            public void Should_throw_exception_When_path_is_null_or_spaces(string path)
            {
                Assert.Throws<ArgumentNullException>(() => new GeoEntityJsonGateway(path));
            }
        }
    }
}