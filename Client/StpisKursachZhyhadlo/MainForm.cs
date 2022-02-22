using StpisKursachZhyhadlo.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StpisKursachZhyhadlo
{
    public partial class MainForm : Form
    {
        //TcpClient tcp_client = new TcpClient("localhost", 5555);
        ASCIIEncoding ae = new ASCIIEncoding();
        ProductsForm productsForm = null;
        ClientForm clientForm = null;
        DeliveriesForm deliveriesForm = null;
        RequestForm requestForm = null;
        AddRequest addRequest = null;
        public List<Product> products = new List<Product>();
        public List<Client> clients = new List<Client>();
        public List<Delivery> deliveries = new List<Delivery>();
        public List<RequestProductAddInfo> requestProductAddInfos = new List<RequestProductAddInfo>();
        public List<Models.RequestProduct> requestProducts = new List<Models.RequestProduct>();

        public MainForm()
        {
            InitializeComponent();
        }

        private void button_product_Click(object sender, EventArgs e)
        {
            if (productsForm == null || productsForm.IsDisposed)
            {
                NetworkStream ns = TCPConnector.tcp_client.GetStream();
                String command = "read";
                byte[] sentCommand = ae.GetBytes(command);
                String tableName = "product";
                byte[] sentTableName = ae.GetBytes(tableName);
                ns.Write(sentCommand, 0, sentCommand.Length);
                System.Threading.Thread.Sleep(10);
                ns.Write(sentTableName, 0, sentTableName.Length);
                byte[] listSize = new byte[4];
                ns.Read(listSize, 0, listSize.Length);
                int size = BitConverter.ToInt32(listSize, 0);
                for (int i = 0; i < size; i++)
                {
                    byte[] readInfo = new byte[256];
                    ns.Read(readInfo, 0, readInfo.Length);
                    String info = ae.GetString(readInfo);
                    info = info.Replace("\0", String.Empty);
                    Product product = new Product(info);
                    products.Add(product);
                }
                productsForm = new ProductsForm(products, this);
                productsForm.Show();
            }
            else
            {
                productsForm.Show();
            }

        }

        private void button_clients_Click(object sender, EventArgs e)
        {
            if (clientForm == null || clientForm.IsDisposed)
            {
                NetworkStream ns = TCPConnector.tcp_client.GetStream();
                String command = "read";
                byte[] sentCommand = ae.GetBytes(command);
                String tableName = "client";
                byte[] sentTableName = ae.GetBytes(tableName);
                ns.Write(sentCommand, 0, sentCommand.Length);
                ns.Write(sentTableName, 0, sentTableName.Length);
                byte[] listSize = new byte[4];
                ns.Read(listSize, 0, listSize.Length);
                int size = BitConverter.ToInt32(listSize, 0);
                for (int i = 0; i < size; i++)
                {
                    byte[] readInfo = new byte[256];
                    ns.Read(readInfo, 0, readInfo.Length);
                    String info = ae.GetString(readInfo);
                    info = info.Replace("\0", String.Empty);
                    Client client = new Client(info);
                    clients.Add(client);
                }
                clientForm = new ClientForm(clients, this);
                clientForm.Show();
            }
            else
            {
                clientForm.Show();
            }
        }

        private void button_requests_Click(object sender, EventArgs e)
        {
            if (requestForm == null || requestForm.IsDisposed)
            {
                NetworkStream ns = TCPConnector.tcp_client.GetStream();
                String command = "read";
                byte[] sentCommand = ae.GetBytes(command);
                String tableName = "request";
                byte[] sentTableName = ae.GetBytes(tableName);
                ns.Write(sentCommand, 0, sentCommand.Length);
                ns.Write(sentTableName, 0, sentTableName.Length);
                byte[] listSize = new byte[4];
                ns.Read(listSize, 0, listSize.Length);
                int size = BitConverter.ToInt32(listSize, 0);
                for (int i = 0; i < size; i++)
                {
                    byte[] readInfo = new byte[256];
                    ns.Read(readInfo, 0, readInfo.Length);
                    String info = ae.GetString(readInfo);
                    info = info.Replace("\0", String.Empty);
                    Models.RequestProduct requestProduct = new Models.RequestProduct(info);
                    requestProducts.Add(requestProduct);
                }
                requestForm = new RequestForm(requestProducts, this);
                requestForm.Show();
            }
            else
            {
                requestForm.Show();
            }
        }

        private void button_deliverys_Click(object sender, EventArgs e)
        {
            if (deliveriesForm == null || deliveriesForm.IsDisposed)
            {
                NetworkStream ns = TCPConnector.tcp_client.GetStream();
                String command = "read";
                byte[] sentCommand = ae.GetBytes(command);
                String tableName = "delivery";
                byte[] sentTableName = ae.GetBytes(tableName);
                ns.Write(sentCommand, 0, sentCommand.Length);
                System.Threading.Thread.Sleep(5);
                ns.Write(sentTableName, 0, sentTableName.Length);
                byte[] listSize = new byte[4];
                ns.Read(listSize, 0, listSize.Length);
                int size = BitConverter.ToInt32(listSize, 0);
                for (int i = 0; i < size; i++)
                {
                    byte[] readInfo = new byte[256];
                    ns.Read(readInfo, 0, readInfo.Length);
                    String info = ae.GetString(readInfo);
                    info = info.Replace("\0", String.Empty);
                    Delivery delivery = new Delivery(info);
                    deliveries.Add(delivery);
                }
                deliveriesForm = new DeliveriesForm(deliveries, this);
                deliveriesForm.Show();
            }
            else
            {
                deliveriesForm.Show();
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (addRequest == null || addRequest.IsDisposed)
            {
                NetworkStream ns = TCPConnector.tcp_client.GetStream();
                String command = "create";
                byte[] sentCommand = ae.GetBytes(command);
                String tableName = "requestInfo";
                byte[] sentTableName = ae.GetBytes(tableName);
                ns.Write(sentCommand, 0, sentCommand.Length);
                System.Threading.Thread.Sleep(10);
                ns.Write(sentTableName, 0, sentTableName.Length);
                byte[] listSize = new byte[4];
                ns.Read(listSize, 0, listSize.Length);
                int size = BitConverter.ToInt32(listSize, 0);
                for (int i = 0; i < size; i++)
                {
                    byte[] readInfo = new byte[256];
                    ns.Read(readInfo, 0, readInfo.Length);
                    String info = ae.GetString(readInfo);
                    info = info.Replace("\0", String.Empty);
                    RequestProductAddInfo requestProduct = new RequestProductAddInfo(info);
                    requestProductAddInfos.Add(requestProduct);
                }
                addRequest = new AddRequest(requestProductAddInfos,this);
                addRequest.Show();
            }
            else
            {
                addRequest.Show();
            }
        }

    }
}
