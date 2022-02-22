using KursachServer.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KursachServer.Connections
{
    class RequestContext : DbContext
    {
        public RequestContext() : base("DbConnection") { }

        public DbSet<RequestProduct> RequestDb { get; set; }
    }
}
