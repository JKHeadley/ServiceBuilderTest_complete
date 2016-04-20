using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceBuilderTest.Model
{
    public class GroupPrivilege
    {
        public int Id { get; set; }
        public int GroupId { get; set; }
        public int PrivilegeId { get; set; }

    }
}
