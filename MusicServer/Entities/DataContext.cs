using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class DataContext:DbContext
    {
        public DbSet<Album> Albums { get; set; }
        public DbSet<Advertisement> Advertisements { get; set; }
    }
}
