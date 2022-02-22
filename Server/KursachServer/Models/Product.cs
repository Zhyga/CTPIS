using ProtoBuf;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KursachServer.Models
{
    class Product
    {
        public Product()
        {

        }
        public Product(String info)
        {
            string[] variables = info.Split('|');
            this.Id = Int32.Parse(variables[0]);
            this.Name = variables[1];
            this.Price = float.Parse(variables[2]);
            this.Size = Int32.Parse(variables[3]);
            this.Amount = Int32.Parse(variables[4]);
        }

        public int Id { get; set; }

        public String Name { get; set; }

        public float Price { get; set; }

        public int Size { get; set; }

        public int Amount { get; set; }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(Id + "|");
            sb.Append(Name + "|");
            sb.Append(Price + "|");
            sb.Append(Size + "|");
            sb.Append(Amount + "|");
            return sb.ToString();
        }
    }
}
