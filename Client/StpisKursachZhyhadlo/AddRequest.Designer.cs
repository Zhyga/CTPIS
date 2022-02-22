
namespace StpisKursachZhyhadlo
{
    partial class AddRequest
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.addProduct_Button = new System.Windows.Forms.Button();
            this.addRequest_Button = new System.Windows.Forms.Button();
            this.comboBox_provider = new System.Windows.Forms.ComboBox();
            this.comboBox_warehouse = new System.Windows.Forms.ComboBox();
            this.comboBox_product = new System.Windows.Forms.ComboBox();
            this.textBox_amount = new System.Windows.Forms.TextBox();
            this.textBox_totalSum = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(184, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(302, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "Оформление поставки";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(12, 105);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Поставщик";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(12, 148);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(118, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Номер склада";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(12, 189);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Товар";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(12, 227);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(100, 20);
            this.label5.TabIndex = 4;
            this.label5.Text = "Количество";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(12, 272);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(113, 20);
            this.label6.TabIndex = 5;
            this.label6.Text = "Сумма заказа";
            // 
            // addProduct_Button
            // 
            this.addProduct_Button.Location = new System.Drawing.Point(96, 362);
            this.addProduct_Button.Name = "addProduct_Button";
            this.addProduct_Button.Size = new System.Drawing.Size(136, 62);
            this.addProduct_Button.TabIndex = 6;
            this.addProduct_Button.Text = "Добавить товар";
            this.addProduct_Button.UseVisualStyleBackColor = true;
            this.addProduct_Button.Click += new System.EventHandler(this.addProduct_Button_Click);
            // 
            // addRequest_Button
            // 
            this.addRequest_Button.Location = new System.Drawing.Point(393, 362);
            this.addRequest_Button.Name = "addRequest_Button";
            this.addRequest_Button.Size = new System.Drawing.Size(136, 62);
            this.addRequest_Button.TabIndex = 7;
            this.addRequest_Button.Text = "Оформить поставку";
            this.addRequest_Button.UseVisualStyleBackColor = true;
            this.addRequest_Button.Click += new System.EventHandler(this.addRequest_Button_Click);
            // 
            // comboBox_provider
            // 
            this.comboBox_provider.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_provider.FormattingEnabled = true;
            this.comboBox_provider.Items.AddRange(new object[] {
            "FurnitureStore",
            "BelFur",
            "ГомельДрев",
            "РечицаДрев"});
            this.comboBox_provider.Location = new System.Drawing.Point(204, 103);
            this.comboBox_provider.Name = "comboBox_provider";
            this.comboBox_provider.Size = new System.Drawing.Size(121, 21);
            this.comboBox_provider.TabIndex = 8;
            // 
            // comboBox_warehouse
            // 
            this.comboBox_warehouse.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_warehouse.FormattingEnabled = true;
            this.comboBox_warehouse.Items.AddRange(new object[] {
            "1",
            "2",
            "3"});
            this.comboBox_warehouse.Location = new System.Drawing.Point(204, 146);
            this.comboBox_warehouse.Name = "comboBox_warehouse";
            this.comboBox_warehouse.Size = new System.Drawing.Size(121, 21);
            this.comboBox_warehouse.TabIndex = 9;
            // 
            // comboBox_product
            // 
            this.comboBox_product.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_product.FormattingEnabled = true;
            this.comboBox_product.Location = new System.Drawing.Point(204, 187);
            this.comboBox_product.Name = "comboBox_product";
            this.comboBox_product.Size = new System.Drawing.Size(121, 21);
            this.comboBox_product.TabIndex = 10;
            // 
            // textBox_amount
            // 
            this.textBox_amount.Location = new System.Drawing.Point(204, 226);
            this.textBox_amount.Name = "textBox_amount";
            this.textBox_amount.Size = new System.Drawing.Size(121, 20);
            this.textBox_amount.TabIndex = 11;
            // 
            // textBox_totalSum
            // 
            this.textBox_totalSum.Location = new System.Drawing.Point(204, 271);
            this.textBox_totalSum.Name = "textBox_totalSum";
            this.textBox_totalSum.ReadOnly = true;
            this.textBox_totalSum.Size = new System.Drawing.Size(121, 20);
            this.textBox_totalSum.TabIndex = 12;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2});
            this.dataGridView1.Location = new System.Drawing.Point(393, 103);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(243, 189);
            this.dataGridView1.TabIndex = 13;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Товар";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Количество";
            this.Column2.Name = "Column2";
            // 
            // AddRequest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(709, 479);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.textBox_totalSum);
            this.Controls.Add(this.textBox_amount);
            this.Controls.Add(this.comboBox_product);
            this.Controls.Add(this.comboBox_warehouse);
            this.Controls.Add(this.comboBox_provider);
            this.Controls.Add(this.addRequest_Button);
            this.Controls.Add(this.addProduct_Button);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "AddRequest";
            this.Text = "AddRequest";
            this.Load += new System.EventHandler(this.AddRequest_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button addProduct_Button;
        private System.Windows.Forms.Button addRequest_Button;
        private System.Windows.Forms.ComboBox comboBox_provider;
        private System.Windows.Forms.ComboBox comboBox_warehouse;
        private System.Windows.Forms.ComboBox comboBox_product;
        private System.Windows.Forms.TextBox textBox_amount;
        private System.Windows.Forms.TextBox textBox_totalSum;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
    }
}