using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceBuilderTest.Model
{
    public class Organization
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public virtual ICollection<Group> Groups { get; set; }
        public virtual ICollection<OrganizationPrivilege> OrganizationPrivileges { get; set; }
        public virtual ICollection<UserOrganization> UserOrganizations { get; set; }
    }
}
