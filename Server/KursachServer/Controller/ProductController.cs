using KursachServer.Connections;
using KursachServer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KursachServer.Controller
{
    class ProductController
    {
        public List<Product> ReadInfo()
        {
                    using (ProductContext db = new ProductContext())
                    {
                        // получаем объекты из бд и выводим на консоль
                        List<Product> products = db.ProductDB.ToList<Product>();
                        return products;
                    }
        }

        public void AddProduct(String info)
        {
            using (ProductContext db = new ProductContext())
            {
                Product product = new Product(info);
                db.ProductDB.Add(product);
                db.SaveChanges();
            }
        }
    }
}
