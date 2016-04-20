using Castle.MicroKernel.Registration;
using Castle.MicroKernel.SubSystems.Configuration;
using Castle.Facilities.WcfIntegration;
using Castle.Windsor;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace ServiceBuilderTest.Service.Installers
{
    public class ServiceInstaller : IWindsorInstaller
    {
        public void Install(IWindsorContainer container, IConfigurationStore store)
        {
            container.AddFacility<WcfFacility>();

            // .Hosted() tells IoC that someone else (IIS) will host the service
            // Otherwise, Castle Windsor will try to setup hosting for the service
            container.Register(
                Component.For<IService>()
                         .ImplementedBy<Service>()
                         .AsWcfService(new DefaultServiceModel().Hosted())
                         .IsDefault()
                         .LifestylePerWcfOperation());
	    container.Register(
                Component.For<IDTOMapper>()
                         .ImplementedBy<DTOMapper>()
                         .LifestyleSingleton());
        }
    }
}



