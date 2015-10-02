using Castle.MicroKernel.Registration;
using Castle.MicroKernel.SubSystems.Configuration;
using Castle.Windsor;
using GeoserverManager.Geoserver.Rest.Client;
using GeoserverManager.UseCases.Interface.Repositories;
using GeoserverManager.UseCases.Interface.UseCases.FeatureTypes;
using GeoserverManager.UseCases.Interface.UseCases.Server;
using GeoserverManager.UseCases.UseCases.FeatureTypes;
using GeoserverManager.UseCases.UseCases.Server;

namespace GeoserverManager.IoC.Installers
{
    public class UseCasesInstaller : IWindsorInstaller
    {
        public void Install(IWindsorContainer container, IConfigurationStore store)
        {
            container.Register(Component
                .For<IGetAllFeatureTypesInfosUseCase>()
                .ImplementedBy<GetAllFeatureTypesInfosUseCase>()
               // .DependsOn(new
                //{
                //    repository = container.Resolve<ILayerInfoRepository>()
                //})
                 .DynamicParameters((p, k) =>
                 {
                     var repository = container.Resolve<IFeatureTypeInfoRepository>();

                     k["repository"] = repository;
                   
                 })
                .LifestyleTransient());


            container.Register(Component
                .For<IGetFeatureTypeInfoStatusUseCase>()
                .ImplementedBy<GetFeatureTypeInfoStatusUseCase>()
                //.DependsOn(new
                //{
                //    restClient = container.Resolve<IGeoserverRestClient>()
                //})
                  .DynamicParameters((p, k) =>
                  {
                      var restClient = container.Resolve<IGeoserverRestClient>();

                      k["restClient"] = restClient;

                  })
                .LifestyleTransient());

            container.Register(Component
             .For<IUploadFeatureTypeInfoToGeoserverUseCase>()
             .ImplementedBy<UploadFeatureTypeInfoToGeoserverUseCase>()
             //.DependsOn(new
             //{
             //    restClient = container.Resolve<IGeoserverRestClient>()
             //})
             .DynamicParameters((p, k) =>
             {
                 var restClient = container.Resolve<IGeoserverRestClient>();

                 k["restClient"] = restClient;

             })
             .LifestyleTransient());

            container.Register(Component
            .For<IGetServerStatusUseCase>()
            .ImplementedBy<GetServerStatusUseCase>()
            .DynamicParameters((p, k) =>
            {
                var restClient = container.Resolve<IGeoserverRestClient>();

                k["restClient"] = restClient;

            })
            .LifestyleTransient());
        }
    }
}