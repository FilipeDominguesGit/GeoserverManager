using Castle.Windsor;
using GeoserverManager.IoC.Spike.Installers;

namespace GeoserverManager.IoC.Spike
{
    public static class IocContainer
    {
        private static readonly IWindsorContainer _container = Bootstrap();

        public static T Resolve<T>()
        {
            return _container.Resolve<T>();
        }

        private static IWindsorContainer Bootstrap()
        {
            var container = new WindsorContainer();
            container.Install(new ConfigurationDataInstaller(),
                new GatewaysInstaller());


            return container;
        }
    }
}