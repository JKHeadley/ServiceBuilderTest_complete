using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceBuilderTest.Model
{
    public class Group
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int ParentOrganizationId { get; set; }
        public virtual Organization ParentOrganization { get; set; }
        public virtual ICollection<UserGroup> UserGroups { get; set; }
        public virtual ICollection<GroupPrivilege> GroupPrivileges { get; set; }

    }
}
