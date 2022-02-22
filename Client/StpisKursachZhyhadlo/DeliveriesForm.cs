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
    public partial class DeliveriesForm : Form
    {
        MainForm parentForm = null;
        public DeliveriesForm()
        {
            InitializeComponent();
        }

        public DeliveriesForm(List<Delivery> deliveries, MainForm form)
        {
            InitializeComponent();
            dataGridView1.DataSource = deliveries;
            parentForm = form;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }



        private void button3_Click(object sender, EventArgs e)
        {
            parentForm.Show();
            parentForm.products.Clear();
            this.Dispose();
        }

        private void DeliveriesForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            parentForm.Show();
            parentForm.products.Clear();
        }
    }
}
