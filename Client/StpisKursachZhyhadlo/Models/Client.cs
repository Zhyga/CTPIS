using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StpisKursachZhyhadlo.Models
{
    public class Client
    {
        public Client()
        {

        }
        public Client(String info)
        {
            string[] variables = info.Split('|');
            this.Id = Int32.Parse(variables[0]);
            this.Login = variables[1];
            this.Password = variables[2];
            this.Adress = variables[3];
            this.Phone_Number = variables[4];
        }
        public int Id { get; set; }
        public String Login { get; set; }
        public String Password { get; set; }
        public String Adress { get; set; }
        public String Phone_Number { get; set; }
    }
}
