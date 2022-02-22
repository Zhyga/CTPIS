using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StpisKursachZhyhadlo
{
    public partial class AddProduct : Form
    {
        public AddProduct()
        {
            InitializeComponent();
        }

        private void add_button_Click(object sender, EventArgs e)
        { 
            NetworkStream ns = TCPConnector.tcp_client.GetStream();
            ASCIIEncoding ae = new ASCIIEncoding();
            String command = "create";
            byte[] sentCommand = ae.GetBytes(command);
            String tableName = "product";
            byte[] sentTableName = ae.GetBytes(tableName);
            ns.Write(sentCommand, 0, sentCommand.Length);
            System.Threading.Thread.Sleep(10);
            ns.Write(sentTableName, 0, sentTableName.Length);
            Product product = new Product();
            product.Name = productName_Text.Text;
            product.Price = float.Parse(price_Text.Text, CultureInfo.InvariantCulture.NumberFormat);
            product.Amount = Int32.Parse(amount_Text.Text);
            product.Size = Int32.Parse(Size_Text.Text);
            System.Threading.Thread.Sleep(20);
            ns.Flush();
            byte[] userDataBytes = ae.GetBytes(product.ToString());
            ns.Write(userDataBytes, 0, userDataBytes.Length);
        }

        private void price_Text_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
                (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void Size_Text_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void amount_Text_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
