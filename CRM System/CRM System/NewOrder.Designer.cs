namespace CRM_System
{
    partial class NewOrder
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
            this.NamOrd = new System.Windows.Forms.TextBox();
            this.AddNwOrd = new System.Windows.Forms.Button();
            this.Description = new System.Windows.Forms.TextBox();
            this.DeadLn = new System.Windows.Forms.TextBox();
            this.DateSt = new System.Windows.Forms.TextBox();
            this.ClientsBx = new System.Windows.Forms.ComboBox();
            this.ManagerBx = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.AddNwClnt = new System.Windows.Forms.Button();
            this.Price = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // NamOrd
            // 
            this.NamOrd.Location = new System.Drawing.Point(24, 28);
            this.NamOrd.Name = "NamOrd";
            this.NamOrd.Size = new System.Drawing.Size(100, 20);
            this.NamOrd.TabIndex = 1;
            // 
            // AddNwOrd
            // 
            this.AddNwOrd.Location = new System.Drawing.Point(80, 98);
            this.AddNwOrd.Name = "AddNwOrd";
            this.AddNwOrd.Size = new System.Drawing.Size(153, 23);
            this.AddNwOrd.TabIndex = 2;
            this.AddNwOrd.Text = "Добавить новый заказ";
            this.AddNwOrd.UseVisualStyleBackColor = true;
            this.AddNwOrd.Click += new System.EventHandler(this.AddNwOrd_Click);
            // 
            // Description
            // 
            this.Description.Location = new System.Drawing.Point(24, 72);
            this.Description.Name = "Description";
            this.Description.Size = new System.Drawing.Size(209, 20);
            this.Description.TabIndex = 3;
            // 
            // DeadLn
            // 
            this.DeadLn.Location = new System.Drawing.Point(130, 28);
            this.DeadLn.Name = "DeadLn";
            this.DeadLn.Size = new System.Drawing.Size(100, 20);
            this.DeadLn.TabIndex = 4;
            // 
            // DateSt
            // 
            this.DateSt.Location = new System.Drawing.Point(236, 28);
            this.DateSt.Name = "DateSt";
            this.DateSt.Size = new System.Drawing.Size(100, 20);
            this.DateSt.TabIndex = 5;
            // 
            // ClientsBx
            // 
            this.ClientsBx.FormattingEnabled = true;
            this.ClientsBx.Location = new System.Drawing.Point(342, 27);
            this.ClientsBx.Name = "ClientsBx";
            this.ClientsBx.Size = new System.Drawing.Size(121, 21);
            this.ClientsBx.TabIndex = 6;
            // 
            // ManagerBx
            // 
            this.ManagerBx.FormattingEnabled = true;
            this.ManagerBx.Location = new System.Drawing.Point(342, 71);
            this.ManagerBx.Name = "ManagerBx";
            this.ManagerBx.Size = new System.Drawing.Size(121, 21);
            this.ManagerBx.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(43, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Название";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(129, 12);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(101, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Дата завершения:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(245, 12);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(91, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Дата получения:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(95, 56);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Описание:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(380, 12);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(46, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "Клиент:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(380, 56);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(63, 13);
            this.label7.TabIndex = 13;
            this.label7.Text = "Менеджер:";
            // 
            // AddNwClnt
            // 
            this.AddNwClnt.Location = new System.Drawing.Point(248, 98);
            this.AddNwClnt.Name = "AddNwClnt";
            this.AddNwClnt.Size = new System.Drawing.Size(153, 23);
            this.AddNwClnt.TabIndex = 14;
            this.AddNwClnt.Text = "Добавить нового клиента";
            this.AddNwClnt.UseVisualStyleBackColor = true;
            this.AddNwClnt.Click += new System.EventHandler(this.AddNwClnt_Click);
            // 
            // Price
            // 
            this.Price.Location = new System.Drawing.Point(236, 72);
            this.Price.Name = "Price";
            this.Price.Size = new System.Drawing.Size(100, 20);
            this.Price.TabIndex = 15;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(257, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 13);
            this.label1.TabIndex = 16;
            this.label1.Text = "Стоимость:";
            // 
            // NewOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 139);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Price);
            this.Controls.Add(this.AddNwClnt);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ManagerBx);
            this.Controls.Add(this.ClientsBx);
            this.Controls.Add(this.DateSt);
            this.Controls.Add(this.DeadLn);
            this.Controls.Add(this.Description);
            this.Controls.Add(this.AddNwOrd);
            this.Controls.Add(this.NamOrd);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "NewOrder";
            this.Text = "Новый заказ";
            this.Activated += new System.EventHandler(this.NewOrder_Activate);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox NamOrd;
        private System.Windows.Forms.Button AddNwOrd;
        private System.Windows.Forms.TextBox Description;
        private System.Windows.Forms.TextBox DeadLn;
        private System.Windows.Forms.TextBox DateSt;
        private System.Windows.Forms.ComboBox ClientsBx;
        private System.Windows.Forms.ComboBox ManagerBx;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button AddNwClnt;
        private System.Windows.Forms.TextBox Price;
        private System.Windows.Forms.Label label1;
    }
}