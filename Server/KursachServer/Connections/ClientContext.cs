using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace KursachServer
{
    class ClientContext : DbContext
    {
        public ClientContext() : base("DbConnection") { }

        public DbSet<Client> ClientDB { get; set; }
    }
}
