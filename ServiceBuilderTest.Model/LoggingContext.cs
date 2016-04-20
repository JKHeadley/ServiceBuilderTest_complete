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
        public DbSet<LogEvent> LogEvents { get; set; }
    }
}
