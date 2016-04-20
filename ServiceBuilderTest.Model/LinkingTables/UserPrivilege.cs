using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceBuilderTest.Model
{
    public class UserPrivilege
    {
        public int Id { get; set; }
        public Guid UserId { get; set; }
        public int PrivilegeId { get; set; }

    }
}
