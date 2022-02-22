using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StpisKursachZhyhadlo.Models
{
    public class Delivery
    {

        public Delivery()
        {

        }
        public Delivery(String info)
        {
            string[] variables = info.Split('|');
            this.Id = Int32.Parse(variables[0]);
            this.Delivery_Date = variables[1];
            this.Order_Date = variables[2];
            this.Warehouse_Id = Int32.Parse(variables[3]);
            this.Region_Id = Int32.Parse(variables[4]);
            this.Status_Id = Int32.Parse(variables[5]);
            this.Client_Id = Int32.Parse(variables[6]);
            this.Order_Id = Int32.Parse(variables[7]);
        }
        public int Id { get; set; }
        public String Delivery_Date { get; set; }
        public String Order_Date { get; set; }
        public int Warehouse_Id { get; set; }
        public int Region_Id { get; set; }
        public int Status_Id { get; set; }
        public int Client_Id { get; set; }
        public int Order_Id { get; set; }
    }
}
