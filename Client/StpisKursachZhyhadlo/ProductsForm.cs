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
    public partial class ProductsForm : Form
    {
        MainForm parentForm = null;
        AddProduct addProductForm = null;

        public ProductsForm()
        {
            InitializeComponent();
        }
        public ProductsForm(List<Product> products, MainForm formRef)
        {
            InitializeComponent();
            dataGridView1.DataSource = products;
            parentForm = formRef;
        }

        private void ProductsForm_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            parentForm.Show();
            parentForm.products.Clear();
            this.Dispose();
        }

        private void ProductsForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            parentForm.Show();
            parentForm.products.Clear();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(addProductForm == null || addProductForm.IsDisposed)
            {
                addProductForm = new AddProduct();
                addProductForm.Show();
            }
            else
            {
                addProductForm.Show();
            }
        }
    }
}
