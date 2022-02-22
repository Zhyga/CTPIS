using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KursachServer
{
    class Client
    {
        public int Id { get; set; }
        public String Login { get; set; }
        public String Password { get; set; }
        public String Adress { get; set; }
        public String Phone_Number { get; set; }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(Id + "|");
            sb.Append(Login + "|");
            sb.Append(Password + "|");
            sb.Append(Adress + "|");
            sb.Append(Phone_Number + "|");
            return sb.ToString();
        }

    }
}
