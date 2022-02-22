using StpisKursachZhyhadlo.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StpisKursachZhyhadlo
{
    public partial class ClientForm : Form
    {
        MainForm parentForm = null;
        public ClientForm()
        {
            InitializeComponent();
        }

        public ClientForm(List<Client> clients, MainForm form)
        {
            InitializeComponent();
            dataGridView1.DataSource = clients;
            parentForm = form;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            parentForm.Show();
            parentForm.products.Clear();
            this.Dispose();
        }

        private void ClientForm_Load(object sender, EventArgs e)
        {

        }

        private void ClientForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            parentForm.Show();
            parentForm.products.Clear();
        }
    }
}
