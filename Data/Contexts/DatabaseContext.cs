using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Contexts
{
    public abstract class DatabaseContext : DbContext
    {
        public DatabaseContext(string connectionString)
            : base(connectionString) { }

        public abstract DatabaseContext Get();
    }
}
