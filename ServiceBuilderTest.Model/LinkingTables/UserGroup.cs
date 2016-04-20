using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceBuilderTest.Model
{
    public class UserGroup
    {
        public int Id { get; set; }
        public Guid UserId { get; set; }
        public int GroupId { get; set; }

    }
}
