using Domain;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Contexts
{
    public class DataDbContext : DatabaseContext
    {
        public DataDbContext() : base("DataDb") { }

        public DbSet<Book> Books { get; set; }

        public override DatabaseContext Get()
        {
            return new DataDbContext();
        }
    }
}
