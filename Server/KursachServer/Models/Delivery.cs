using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KursachServer
{
    class Delivery
    {
        public int Id { get; set; }
        public String Delivery_Date { get; set; }
        public String Order_Date { get; set; }
        public int Warehouse_Id { get; set; }
        public int Region_Id { get; set; }
        public int Status_Id { get; set; }
        public int Client_Id { get; set; }
        public int Order_Id { get; set; }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(Id + "|");
            sb.Append(Delivery_Date + "|");
            sb.Append(Order_Date + "|");
            sb.Append(Warehouse_Id + "|");
            sb.Append(Region_Id + "|");
            sb.Append(Status_Id + "|");
            sb.Append(Client_Id + "|");
            sb.Append(Order_Id + "|");
            return sb.ToString();
        }
    }
}
