using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KursachServer.Models
{
    [Table("request_product")]
    class RequestProduct
    {
        public RequestProduct()
        {

        }
        public RequestProduct(String info)
        {
            string[] variables = info.Split('|');
            this.Id = Int32.Parse(variables[0]);
            this.Provider = variables[1];
            this.Warehouse_Id = Int32.Parse(variables[2]);
            this.Product_Id = Int32.Parse(variables[3]);
            this.Amount = Int32.Parse(variables[4]);
            this.Price = float.Parse(variables[5]);
        }

        public int Id { get; set; }
        public String Provider { get; set; }
        public int Warehouse_Id { get; set; }
        public int Product_Id { get; set; }
        public int Amount { get; set; }
        public float Price { get; set; }    

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(Id + "|");
            sb.Append(Provider + "|");
            sb.Append(Warehouse_Id + "|");
            sb.Append(Product_Id + "|");
            sb.Append(Amount + "|");
            sb.Append(Price + "|");
            return sb.ToString();
        }

    }
}
