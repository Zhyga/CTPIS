
namespace StpisKursachZhyhadlo
{
    partial class AddProduct
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
            this.productName_Text = new System.Windows.Forms.TextBox();
            this.price_Text = new System.Windows.Forms.TextBox();
            this.Size_Text = new System.Windows.Forms.TextBox();
            this.amount_Text = new System.Windows.Forms.TextBox();
            this.add_button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(57, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(215, 26);
            this.label1.TabIndex = 0;
            this.label1.Text = "Добавление товара";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(13, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Название";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(16, 147);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Цена";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(16, 218);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Размер";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(16, 289);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(100, 20);
            this.label5.TabIndex = 4;
            this.label5.Text = "Количество";
            // 
            // productName_Text
            // 
            this.productName_Text.Location = new System.Drawing.Point(129, 81);
            this.productName_Text.Name = "productName_Text";
            this.productName_Text.Size = new System.Drawing.Size(100, 20);
            this.productName_Text.TabIndex = 5;
            // 
            // price_Text
            // 
            this.price_Text.Location = new System.Drawing.Point(129, 149);
            this.price_Text.Name = "price_Text";
            this.price_Text.Size = new System.Drawing.Size(100, 20);
            this.price_Text.TabIndex = 6;
            this.price_Text.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.price_Text_KeyPress);
            // 
            // Size_Text
            // 
            this.Size_Text.Location = new System.Drawing.Point(129, 217);
            this.Size_Text.Name = "Size_Text";
            this.Size_Text.Size = new System.Drawing.Size(100, 20);
            this.Size_Text.TabIndex = 7;
            this.Size_Text.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Size_Text_KeyPress);
            // 
            // amount_Text
            // 
            this.amount_Text.Location = new System.Drawing.Point(129, 289);
            this.amount_Text.Name = "amount_Text";
            this.amount_Text.Size = new System.Drawing.Size(100, 20);
            this.amount_Text.TabIndex = 8;
            this.amount_Text.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.amount_Text_KeyPress);
            // 
            // add_button
            // 
            this.add_button.Location = new System.Drawing.Point(129, 339);
            this.add_button.Name = "add_button";
            this.add_button.Size = new System.Drawing.Size(104, 40);
            this.add_button.TabIndex = 9;
            this.add_button.Text = "Добавить";
            this.add_button.UseVisualStyleBackColor = true;
            this.add_button.Click += new System.EventHandler(this.add_button_Click);
            // 
            // AddProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(344, 414);
            this.Controls.Add(this.add_button);
            this.Controls.Add(this.amount_Text);
            this.Controls.Add(this.Size_Text);
            this.Controls.Add(this.price_Text);
            this.Controls.Add(this.productName_Text);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.MinimumSize = new System.Drawing.Size(355, 375);
            this.Name = "AddProduct";
            this.Text = "AddProduct";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox productName_Text;
        private System.Windows.Forms.TextBox price_Text;
        private System.Windows.Forms.TextBox Size_Text;
        private System.Windows.Forms.TextBox amount_Text;
        private System.Windows.Forms.Button add_button;
    }
}