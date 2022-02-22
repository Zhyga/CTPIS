using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KursachServer.Controller
{
    class ClientController
    {
        public List<Client> ReadInfo()
        {
            using (ClientContext db = new ClientContext())
            {
                // получаем объекты из бд и выводим на консоль
                List<Client> clients = db.ClientDB.ToList<Client>();
                return clients;
            }
        }
    }
}
