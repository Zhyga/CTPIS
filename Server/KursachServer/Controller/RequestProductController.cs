using KursachServer.Connections;
using KursachServer.Models;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KursachServer.Controller
{
    class RequestProductController
    {
        public List<RequestProduct> ReadInfo()
        {

            using (RequestContext db = new RequestContext())
            {
                // получаем объекты из бд и выводим на консоль
                List<RequestProduct> requestProducts = db.RequestDb.ToList<RequestProduct>();
                return requestProducts;
            }
        }

        public List<RequestProductAddInfo> ReadInfoToAdd()
        {
            List<RequestProductAddInfo> requestedInfo = new List<RequestProductAddInfo>();
            MySqlConnection conn = new MySqlConnection("Server=localhost;Database=stpis;Uid=root;Pwd=root;");
            conn.Open();
            MySqlCommand command = new MySqlCommand("SELECT products.id,products.name,products.amount,products.price FROM products", conn);
            DbDataReader dataReader = command.ExecuteReader();
            while (dataReader.Read())
            {
                RequestProductAddInfo requestProduct = new RequestProductAddInfo();
                requestProduct.ProductId = Int32.Parse(dataReader.GetString(0));
                requestProduct.Product = dataReader.GetString(1);
                requestProduct.Amount = Int32.Parse(dataReader.GetString(2));
                requestProduct.Price = float.Parse(dataReader.GetString(3));
                requestedInfo.Add(requestProduct);
            }
            conn.Close();
            conn.Dispose();
            return requestedInfo;
        }

        public void AddRequests(List<RequestProduct> requestProducts)
        {
            using (RequestContext db = new RequestContext())
            {
                // получаем объекты из бд и выводим на консоль
                foreach (var product in requestProducts) {
                    db.RequestDb.Add(product);
                }
                db.SaveChanges();
            }
        }
    }

    public class Class1
    {
    }
}
