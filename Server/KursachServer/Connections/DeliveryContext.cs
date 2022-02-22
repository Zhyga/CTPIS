using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KursachServer.Connections
{
    class DeliveryContext : DbContext
    {
        public DeliveryContext() : base("DbConnection") { }

        public DbSet<Delivery> DeliveryDB { get; set; }
    }
}
