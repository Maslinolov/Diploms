namespace CRM_System
{
    partial class PriceCalc
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
            this.Disp = new System.Windows.Forms.RichTextBox();
            this.NumbOrd = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.ResPrice = new System.Windows.Forms.TextBox();
            this.Clnt = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Ord = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.Discnt = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.PromPrice = new System.Windows.Forms.TextBox();
            this.Description = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Disp
            // 
            this.Disp.Location = new System.Drawing.Point(12, 148);
            this.Disp.Name = "Disp";
            this.Disp.ReadOnly = true;
            this.Disp.Size = new System.Drawing.Size(375, 193);
            this.Disp.TabIndex = 0;
            this.Disp.Text = "";
            // 
            // NumbOrd
            // 
            this.NumbOrd.Location = new System.Drawing.Point(139, 32);
            this.NumbOrd.Name = "NumbOrd";
            this.NumbOrd.ReadOnly = true;
            this.NumbOrd.Size = new System.Drawing.Size(121, 20);
            this.NumbOrd.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(47, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Клиент:";
            // 
            // ResPrice
            // 
            this.ResPrice.Location = new System.Drawing.Point(266, 75);
            this.ResPrice.Name = "ResPrice";
            this.ResPrice.ReadOnly = true;
            this.ResPrice.Size = new System.Drawing.Size(121, 20);
            this.ResPrice.TabIndex = 4;
            // 
            // Clnt
            // 
            this.Clnt.FormattingEnabled = true;
            this.Clnt.Location = new System.Drawing.Point(12, 31);
            this.Clnt.Name = "Clnt";
            this.Clnt.Size = new System.Drawing.Size(121, 21);
            this.Clnt.TabIndex = 5;
            this.Clnt.SelectedIndexChanged += new System.EventHandler(this.Clnt_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(136, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(114, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Количество заказов:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(263, 58);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(115, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Итоговая стоимость:";
            // 
            // Ord
            // 
            this.Ord.FormattingEnabled = true;
            this.Ord.Location = new System.Drawing.Point(139, 74);
            this.Ord.Name = "Ord";
            this.Ord.Size = new System.Drawing.Size(121, 21);
            this.Ord.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(158, 58);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Номер заказа:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(47, 59);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Скидка:";
            // 
            // Discnt
            // 
            this.Discnt.Location = new System.Drawing.Point(12, 75);
            this.Discnt.Name = "Discnt";
            this.Discnt.ReadOnly = true;
            this.Discnt.Size = new System.Drawing.Size(121, 20);
            this.Discnt.TabIndex = 10;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(144, 132);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(116, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "Подробности заказа:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(263, 15);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(110, 13);
            this.label7.TabIndex = 14;
            this.label7.Text = "Стоимость заказов:";
            // 
            // PromPrice
            // 
            this.PromPrice.Location = new System.Drawing.Point(266, 32);
            this.PromPrice.Name = "PromPrice";
            this.PromPrice.ReadOnly = true;
            this.PromPrice.Size = new System.Drawing.Size(121, 20);
            this.PromPrice.TabIndex = 13;
            // 
            // Description
            // 
            this.Description.Location = new System.Drawing.Point(12, 110);
            this.Description.Name = "Description";
            this.Description.Size = new System.Drawing.Size(121, 23);
            this.Description.TabIndex = 15;
            this.Description.Text = "Подробности";
            this.Description.UseVisualStyleBackColor = true;
            this.Description.Click += new System.EventHandler(this.Description_Click);
            // 
            // PriceCalc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(403, 353);
            this.Controls.Add(this.Description);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.PromPrice);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.Discnt);
            this.Controls.Add(this.Ord);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Clnt);
            this.Controls.Add(this.ResPrice);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.NumbOrd);
            this.Controls.Add(this.Disp);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "PriceCalc";
            this.Text = "Расчет стоимости";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox Disp;
        private System.Windows.Forms.TextBox NumbOrd;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Description;
        private System.Windows.Forms.TextBox ResPrice;
        private System.Windows.Forms.ComboBox Clnt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox Ord;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox Discnt;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox PromPrice;
    }
}