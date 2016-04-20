using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceBuilderTest.Model
{
    public class Privilege
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int ApplicationId { get; set; }
        public Application Application { get; set; }
        public ICollection<UserPrivilege> UserPrivileges { get; set; }
        public ICollection<OrganizationPrivilege> OrganizationPrivileges { get; set; }
        public ICollection<GroupPrivilege> GroupPrivileges { get; set; }
    }
}
