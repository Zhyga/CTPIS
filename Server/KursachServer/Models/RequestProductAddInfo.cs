using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KursachServer.Models
{
    class RequestProductAddInfo
    {
        //        public String Provider { get; set; }
        //public static List<int> Warehouse_Id { get; set; }
        public int ProductId { get; set; }
        public String Product { get; set; }
        public int Amount { get; set; }
        public float Price { get; set; }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(ProductId + "|");
            sb.Append(Product + "|");
            sb.Append(Amount + "|");
            sb.Append(Price + "|");
            return sb.ToString();
        }
    }
}
