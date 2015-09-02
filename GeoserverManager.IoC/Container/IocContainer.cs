using Castle.Windsor;
using GeoserverManager.IoC.Installers;

namespace GeoserverManager.IoC.Container
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
                new BuilderPrototypeInstaller(),
                new RestClientInstaller(),
                new GatewaysInstaller(),
                new RepositoriesInstaller(),
                new GeoserverRestClientInstaller(),
                new UseCasesInstaller());


            return container;
        }
    }
}