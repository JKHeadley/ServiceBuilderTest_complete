using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceBuilderTest.Model
{
    public partial class ServiceBuilderTestContext : DbContext
    {
        public ServiceBuilderTestContext()
            : base("ServiceBuilderTest")
        {
        }
        public DbSet<Application> Applications { get; set; }
        public DbSet<GroupPrivilege> GroupPrivileges { get; set; }
        public DbSet<Group> Groups { get; set; }
        public DbSet<OrganizationPrivilege> OrganizationPrivileges { get; set; }
        public DbSet<Organization> Organizations { get; set; }
        public DbSet<Privilege> Privileges { get; set; }
        public DbSet<UserOrganization> UserOrganizations { get; set; }
        public DbSet<UserPrivilege> UserPrivileges { get; set; }
        public DbSet<UserGroup> UserGroups { get; set; }
        public DbSet<User> Users { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }
    }
}
