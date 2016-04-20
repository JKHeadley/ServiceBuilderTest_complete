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
using ServiceBuilderTest.Service.Helpers;

namespace ServiceBuilderTest.Service.Installers
{
    public class HelpersInstaller : IWindsorInstaller
    {
        public void Install(IWindsorContainer container, IConfigurationStore store)
        {
			container.Register(Component.For<IUserGroupHelper>()
                .ImplementedBy<UserGroupHelper>()
                .LifestyleSingleton());

			container.Register(Component.For<IOrganizationPrivilegeHelper>()
                .ImplementedBy<OrganizationPrivilegeHelper>()
                .LifestyleSingleton());

			container.Register(Component.For<IUserHelper>()
                .ImplementedBy<UserHelper>()
                .LifestyleSingleton());

			container.Register(Component.For<IOrganizationHelper>()
                .ImplementedBy<OrganizationHelper>()
                .LifestyleSingleton());

			container.Register(Component.For<IUserOrganizationHelper>()
                .ImplementedBy<UserOrganizationHelper>()
                .LifestyleSingleton());

			container.Register(Component.For<IApplicationHelper>()
                .ImplementedBy<ApplicationHelper>()
                .LifestyleSingleton());

			container.Register(Component.For<IGroupPrivilegeHelper>()
                .ImplementedBy<GroupPrivilegeHelper>()
                .LifestyleSingleton());

			container.Register(Component.For<IPrivilegeHelper>()
                .ImplementedBy<PrivilegeHelper>()
                .LifestyleSingleton());

			container.Register(Component.For<IUserPrivilegeHelper>()
                .ImplementedBy<UserPrivilegeHelper>()
                .LifestyleSingleton());

			container.Register(Component.For<IGroupHelper>()
                .ImplementedBy<GroupHelper>()
                .LifestyleSingleton());

			container.Register(Component.For<ILogEventHelper>()
                .ImplementedBy<LogEventHelper>()
                .LifestyleSingleton());

		}
      
    }
}



