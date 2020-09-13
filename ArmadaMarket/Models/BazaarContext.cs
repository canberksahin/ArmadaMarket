using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArmadaMarket.Models
{
    class BazaarContext : DbContext
    {
        public DbSet<Product> Products { get; set; }

        public DbSet<Category> Categories { get; set; }

        public BazaarContext() : base("name=BaglantiCumlem")
        {
            Database.SetInitializer(new MyInitDb());
        }
    }
}
