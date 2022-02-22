using KursachServer.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KursachServer.Connections
{
    class ProductContext : DbContext
    {
        public ProductContext() : base("DbConnection") { }

        public DbSet<Product> ProductDB { get; set; }
    }
}
