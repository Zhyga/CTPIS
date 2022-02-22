using KursachServer.Connections;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KursachServer.Controller
{
    class DeliveryController
    {
        public List<Delivery> ReadInfo()
        {

            using (DeliveryContext db = new DeliveryContext())
            {
                // получаем объекты из бд и выводим на консоль
                /*var tewstList = db.DeliveryDB.SqlQuery("SELECT deliveries.id,delivery_date,order_date,region_name,status.status, login, warehouse_id FROM deliveries"+ 
                    "JOIN status ON deliveries.status_id = status.id JOIN region ON deliveries.region_id = region.id JOIN "+
                    "clients ON deliveries.client_id = clients.id");*/
                List<Delivery> deliverys = db.DeliveryDB.ToList<Delivery>();
                return deliverys;
            }
        }
    }
}
