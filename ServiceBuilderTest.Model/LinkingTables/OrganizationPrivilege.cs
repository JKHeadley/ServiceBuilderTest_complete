using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceBuilderTest.Model
{
    public class OrganizationPrivilege
    {
        public int Id { get; set; }
        public int OrganizationId { get; set; }
        public int PrivilegeId { get; set; }

    }
}
