namespace CRM_System
{
    partial class Clients
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
            this.dGV1 = new System.Windows.Forms.DataGridView();
            this.Srnam = new System.Windows.Forms.TextBox();
            this.Nam = new System.Windows.Forms.TextBox();
            this.Patrn = new System.Windows.Forms.TextBox();
            this.PhoneN = new System.Windows.Forms.TextBox();
            this.Adress = new System.Windows.Forms.TextBox();
            this.Add = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.Discount = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.IDClient = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.DiscChng = new System.Windows.Forms.TextBox();
            this.DiscountChngB = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dGV1)).BeginInit();
            this.SuspendLayout();
            // 
            // dGV1
            // 
            this.dGV1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGV1.Location = new System.Drawing.Point(12, 114);
            this.dGV1.Name = "dGV1";
            this.dGV1.Size = new System.Drawing.Size(743, 250);
            this.dGV1.TabIndex = 0;
            this.dGV1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dGV1_CellContentClick);
            // 
            // Srnam
            // 
            this.Srnam.Location = new System.Drawing.Point(29, 27);
            this.Srnam.Name = "Srnam";
            this.Srnam.Size = new System.Drawing.Size(100, 20);
            this.Srnam.TabIndex = 1;
            // 
            // Nam
            // 
            this.Nam.Location = new System.Drawing.Point(135, 27);
            this.Nam.Name = "Nam";
            this.Nam.Size = new System.Drawing.Size(100, 20);
            this.Nam.TabIndex = 2;
            // 
            // Patrn
            // 
            this.Patrn.Location = new System.Drawing.Point(241, 27);
            this.Patrn.Name = "Patrn";
            this.Patrn.Size = new System.Drawing.Size(100, 20);
            this.Patrn.TabIndex = 3;
            // 
            // PhoneN
            // 
            this.PhoneN.Location = new System.Drawing.Point(347, 27);
            this.PhoneN.Name = "PhoneN";
            this.PhoneN.Size = new System.Drawing.Size(100, 20);
            this.PhoneN.TabIndex = 4;
            // 
            // Adress
            // 
            this.Adress.Location = new System.Drawing.Point(453, 27);
            this.Adress.Name = "Adress";
            this.Adress.Size = new System.Drawing.Size(100, 20);
            this.Adress.TabIndex = 5;
            // 
            // Add
            // 
            this.Add.Location = new System.Drawing.Point(665, 25);
            this.Add.Name = "Add";
            this.Add.Size = new System.Drawing.Size(75, 23);
            this.Add.TabIndex = 7;
            this.Add.Text = "Добавить";
            this.Add.UseVisualStyleBackColor = true;
            this.Add.Click += new System.EventHandler(this.Add_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(46, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Фамилия:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(166, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Имя:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(263, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Отчество:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(351, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(96, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Номер телефона:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(484, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "Адрес:";
            // 
            // Discount
            // 
            this.Discount.Location = new System.Drawing.Point(559, 27);
            this.Discount.Name = "Discount";
            this.Discount.Size = new System.Drawing.Size(100, 20);
            this.Discount.TabIndex = 6;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(588, 9);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(47, 13);
            this.label6.TabIndex = 13;
            this.label6.Text = "Скидка:";
            // 
            // IDClient
            // 
            this.IDClient.Location = new System.Drawing.Point(29, 71);
            this.IDClient.Name = "IDClient";
            this.IDClient.Size = new System.Drawing.Size(100, 20);
            this.IDClient.TabIndex = 14;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(46, 53);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(66, 13);
            this.label7.TabIndex = 15;
            this.label7.Text = "ID Клиента:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(164, 53);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(47, 13);
            this.label8.TabIndex = 17;
            this.label8.Text = "Скидка:";
            // 
            // DiscChng
            // 
            this.DiscChng.Location = new System.Drawing.Point(135, 71);
            this.DiscChng.Name = "DiscChng";
            this.DiscChng.Size = new System.Drawing.Size(100, 20);
            this.DiscChng.TabIndex = 16;
            // 
            // DiscountChngB
            // 
            this.DiscountChngB.Location = new System.Drawing.Point(241, 69);
            this.DiscountChngB.Name = "DiscountChngB";
            this.DiscountChngB.Size = new System.Drawing.Size(75, 23);
            this.DiscountChngB.TabIndex = 18;
            this.DiscountChngB.Text = "Изменить";
            this.DiscountChngB.UseVisualStyleBackColor = true;
            this.DiscountChngB.Click += new System.EventHandler(this.DiscountChngB_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(324, 98);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(97, 13);
            this.label9.TabIndex = 19;
            this.label9.Text = "Список клиентов:";
            // 
            // Clients
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(767, 376);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.DiscountChngB);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.DiscChng);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.IDClient);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Add);
            this.Controls.Add(this.Discount);
            this.Controls.Add(this.Adress);
            this.Controls.Add(this.PhoneN);
            this.Controls.Add(this.Patrn);
            this.Controls.Add(this.Nam);
            this.Controls.Add(this.Srnam);
            this.Controls.Add(this.dGV1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Clients";
            this.Text = "Клиенты";
            ((System.ComponentModel.ISupportInitialize)(this.dGV1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dGV1;
        private System.Windows.Forms.TextBox Srnam;
        private System.Windows.Forms.TextBox Nam;
        private System.Windows.Forms.TextBox Patrn;
        private System.Windows.Forms.TextBox PhoneN;
        private System.Windows.Forms.TextBox Adress;
        private System.Windows.Forms.Button Add;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox Discount;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox IDClient;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox DiscChng;
        private System.Windows.Forms.Button DiscountChngB;
        private System.Windows.Forms.Label label9;
    }
}