using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StpisKursachZhyhadlo.Models
{
    public class RequestProductAddInfo
    {
        public RequestProductAddInfo()
        {

        }
        public RequestProductAddInfo(String info)
        {
            string[] variables = info.Split('|');
            this.ProductId = Int32.Parse(variables[0]);
            this.Product = variables[1];
            this.Amount = Int32.Parse(variables[2]);
            this.Price = float.Parse(variables[3]);
        }

        public int ProductId { get; set; }
        public String Product { get; set; }
        public int Amount { get; set; }
        public float Price { get; set; }
    }
}
