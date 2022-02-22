using KursachServer.Controller;
using KursachServer.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KursachServer
{
    public partial class ServerForm : Form
    {

        public TcpListener listener = null;
        public Socket socket = null;
        public NetworkStream ns = null;
        public ASCIIEncoding ae = null;
        ServerForm form1 = null;
        ProductController productController = new ProductController();
        ClientController clientController = new ClientController();
        DeliveryController deliveryController = new DeliveryController();
        RequestProductController requestProductController = new RequestProductController();

        public ServerForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
             listener = new TcpListener(IPAddress.Any, 5555);
             listener.Start();
             socket = listener.AcceptSocket();
             if (socket.Connected)
             {
                 ns = new NetworkStream(socket);
                 ae = new ASCIIEncoding();
                 Thread thread = Start(ns, this);
             }
        }

        public Thread Start(NetworkStream ns, ServerForm form)
        {
            this.ns = ns;
            this.form1 = form;
            Thread thread = new Thread(new ThreadStart(ThreadOperations));
            thread.Start();
            return thread;
        }

        public void ThreadOperations()
        {
            while (true)
            {
                byte[] receivedCommand = new byte[10];
                ns.Read(receivedCommand, 0, receivedCommand.Length);
                String command = ae.GetString(receivedCommand);
                command = command.Replace("\0", String.Empty);

                byte[] receivedTableName = new byte[20];
                ns.Read(receivedTableName, 0, receivedTableName.Length);
                String tableName = ae.GetString(receivedTableName);
                tableName = tableName.Replace("\0", String.Empty);
                ns.Flush();
                switch(command){
                    case "read":
                        {
                            switch (tableName)
                            {
                                case "product":
                                    {
                                        List<Product> productList = productController.ReadInfo();
                                        SendInfo.SendUserData<Product>(productList, ns);
                                        break;
                                    }
                                case "client":
                                    {
                                        List<Client> clientList = clientController.ReadInfo();
                                        SendInfo.SendUserData<Client>(clientList, ns);
                                        break;
                                    }
                                case "delivery":
                                    {
                                        List<Delivery> deliveryList = deliveryController.ReadInfo();
                                        SendInfo.SendUserData<Delivery>(deliveryList, ns);
                                        break;
                                    }
                                case "request":
                                    {
                                        List<RequestProduct> requestProductList = requestProductController.ReadInfo();
                                        SendInfo.SendUserData<RequestProduct>(requestProductList, ns);
                                        break;
                                    }
                            }
                            break;
                        }
                    case "create":
                        {
                            switch (tableName)
                            {
                                case "product":
                                    {
                                        byte[] info = new byte[256];
                                        ns.Read(info, 0, info.Length);
                                        String productInfo = ae.GetString(info);
                                        productInfo = productInfo.Replace("\0", String.Empty);
                                        productController.AddProduct(productInfo);
                                        break;
                                    }
                                case "requestInfo":
                                    {
                                        byte[] info = new byte[256];
                                        List<RequestProductAddInfo> requestProducts = requestProductController.ReadInfoToAdd();
                                        SendInfo.SendUserData<RequestProductAddInfo>(requestProducts, ns);
                                        break;
                                    }
                                case "request":
                                    {
                                        List<RequestProduct> requestProducts1 = new List<RequestProduct>();
                                        byte[] size = new byte[4];
                                        ns.Read(size, 0, size.Length);
                                        int sizeInt = BitConverter.ToInt32(size, 0);
                                        for (int i = 0; i < sizeInt; i++)
                                        {
                                            byte[] request = new byte[256];
                                            ns.Read(request, 0, request.Length);
                                            String strProduct = ae.GetString(request);
                                            strProduct = strProduct.Replace("\0", String.Empty);
                                            RequestProduct product = new RequestProduct(strProduct);
                                            requestProducts1.Add(product);
                                        }
                                        requestProductController.AddRequests(requestProducts1);
                                        break;
                                    }
                            }
                            break;
                        }
                    default:
                        break;
            }
            }
        }
    }
}


