using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace KursachServer
{
    class SendInfo
    {
        public static void SendUserData<T>(List<T> info, NetworkStream ns)
        {
            ASCIIEncoding ae = new ASCIIEncoding();
            byte[] listLenght = new byte[4];
            listLenght = BitConverter.GetBytes(info.Count);
            ns.Write(listLenght, 0, listLenght.Length);
            foreach (var product in info)
            {
                byte[] userDataBytes = ae.GetBytes(product.ToString());
                String a = product.ToString();
                ns.Write(userDataBytes, 0, userDataBytes.Length);
                System.Threading.Thread.Sleep(10);
            }
        }
    }
}
