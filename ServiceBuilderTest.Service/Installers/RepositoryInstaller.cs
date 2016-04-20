using ServiceBuilderTest.Model;
using ServiceBuilderTest.Repository;
using Castle.MicroKernel.Registration;
using Castle.MicroKernel.SubSystems.Configuration;
using Castle.Windsor;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace ServiceBuilderTest.Service.Installers
{
    public class RepositoryInstaller : IWindsorInstaller
    {
        public void Install(IWindsorContainer container, IConfigurationStore store)
        {
            container.Register(Component.For<DbContext>()
                .ImplementedBy<ServiceBuilderTestContext>()
                .LifestyleSingleton());

            container.Register(Component.For<IServiceBuilderTestRepository>()
                    .ImplementedBy<LoggingDecorator>()
                    .LifestyleSingleton());

            container.Register(Component.For<IServiceBuilderTestRepository>()
                .ImplementedBy<ServiceBuilderTestRepository>()
                .LifestyleSingleton());
        }
    }
}
