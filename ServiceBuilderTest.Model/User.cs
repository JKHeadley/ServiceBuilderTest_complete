using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceBuilderTest.Model
{
    [Description("User")]
    public class User
    {
        public Guid Id { get; set; }
        [Description("UserName")]
        public string Username { get; set; }
        public string Password { get; set; }
        public virtual ICollection<UserOrganization> UserOrganizations { get; set; }
        public virtual ICollection<UserGroup> UserGroups { get; set; }
        public virtual ICollection<UserPrivilege> UserPrivileges { get; set; }
    }
}
