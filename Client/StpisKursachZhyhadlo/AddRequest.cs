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
    public partial class AddRequest : Form
    {
        MainForm parentForm = null;
        List<RequestProductAddInfo> deliveries = null;
        List<RequestProduct> requestProducts = new List<RequestProduct>();
        float totalSum = 0;
        public AddRequest()
        {
            InitializeComponent();
        }

        public AddRequest(List<RequestProductAddInfo> deliveries, MainForm form)
        {
            InitializeComponent();
            this.deliveries = deliveries;
            parentForm = form;
        }

        private void AddRequest_Load(object sender, EventArgs e)
        {
            foreach(var delivery in deliveries)
            {
                comboBox_product.Items.Add(delivery.Product);
            }
        }

        private void addProduct_Button_Click(object sender, EventArgs e)
        {
            int productIndex = comboBox_product.SelectedIndex;
            totalSum += deliveries[productIndex].Price * Int32.Parse(textBox_amount.Text);
            textBox_totalSum.Text = totalSum.ToString();
            RequestProduct requestProduct = new RequestProduct();
            requestProduct.Product_Id = deliveries[productIndex].ProductId;
            requestProduct.Provider = comboBox_provider.SelectedItem.ToString();
            requestProduct.Warehouse_Id = Int32.Parse(comboBox_warehouse.SelectedItem.ToString());
            requestProduct.Amount = Int32.Parse(textBox_amount.Text);
            requestProduct.Price = deliveries[productIndex].Price;
            requestProducts.Add(requestProduct);
        }

        private void addRequest_Button_Click(object sender, EventArgs e)
        {
            NetworkStream ns = TCPConnector.tcp_client.GetStream();
            ASCIIEncoding ae = new ASCIIEncoding();
            String command = "create";
            byte[] sentCommand = ae.GetBytes(command);
            String tableName = "request";
            byte[] sentTableName = ae.GetBytes(tableName);
            ns.Write(sentCommand, 0, sentCommand.Length);
            System.Threading.Thread.Sleep(10);
            ns.Write(sentTableName, 0, sentTableName.Length);
            System.Threading.Thread.Sleep(20);
            ns.Flush();
            byte[] size = BitConverter.GetBytes(requestProducts.Count);
            ns.Write(size, 0, size.Length);
            for(int i = 0; i < requestProducts.Count; i++)
            {
                String info = requestProducts[i].ToString();
                byte[] byteInfo = ae.GetBytes(info);
                ns.Write(byteInfo, 0, byteInfo.Length);
                //System.Threading.Thread.Sleep(20);
            }
        }
    }
}
