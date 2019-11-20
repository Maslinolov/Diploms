namespace CRM_System
{
    partial class Admin
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
            this.NewOrderB = new System.Windows.Forms.Button();
            this.AllOrdB = new System.Windows.Forms.Button();
            this.SrchB = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.SrchFltr = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SrchWrd = new System.Windows.Forms.TextBox();
            this.Displ = new System.Windows.Forms.RichTextBox();
            this.SrvcB = new System.Windows.Forms.Button();
            this.CalcPrice = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // NewOrderB
            // 
            this.NewOrderB.Location = new System.Drawing.Point(161, 54);
            this.NewOrderB.Name = "NewOrderB";
            this.NewOrderB.Size = new System.Drawing.Size(102, 23);
            this.NewOrderB.TabIndex = 30;
            this.NewOrderB.Text = "Новый заказ";
            this.NewOrderB.UseVisualStyleBackColor = true;
            this.NewOrderB.Click += new System.EventHandler(this.NewOrderB_Click);
            // 
            // AllOrdB
            // 
            this.AllOrdB.Location = new System.Drawing.Point(15, 54);
            this.AllOrdB.Name = "AllOrdB";
            this.AllOrdB.Size = new System.Drawing.Size(140, 23);
            this.AllOrdB.TabIndex = 27;
            this.AllOrdB.Text = "Отобразить все заказы";
            this.AllOrdB.UseVisualStyleBackColor = true;
            this.AllOrdB.Click += new System.EventHandler(this.AllOrdB_Click);
            // 
            // SrchB
            // 
            this.SrchB.Location = new System.Drawing.Point(269, 28);
            this.SrchB.Name = "SrchB";
            this.SrchB.Size = new System.Drawing.Size(112, 22);
            this.SrchB.TabIndex = 26;
            this.SrchB.Text = "Поиск";
            this.SrchB.UseVisualStyleBackColor = true;
            this.SrchB.Click += new System.EventHandler(this.SrchB_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(172, 12);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 13);
            this.label3.TabIndex = 25;
            this.label3.Text = "Категория:";
            // 
            // SrchFltr
            // 
            this.SrchFltr.FormattingEnabled = true;
            this.SrchFltr.Items.AddRange(new object[] {
            "Номер заказа",
            "Название",
            "Дата завершения",
            "Состояние заказа",
            "Дата получения"});
            this.SrchFltr.Location = new System.Drawing.Point(142, 28);
            this.SrchFltr.Name = "SrchFltr";
            this.SrchFltr.Size = new System.Drawing.Size(121, 21);
            this.SrchFltr.TabIndex = 24;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(28, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 13);
            this.label2.TabIndex = 23;
            this.label2.Text = "Ключевое слово:";
            // 
            // SrchWrd
            // 
            this.SrchWrd.Location = new System.Drawing.Point(15, 28);
            this.SrchWrd.Name = "SrchWrd";
            this.SrchWrd.Size = new System.Drawing.Size(121, 20);
            this.SrchWrd.TabIndex = 22;
            // 
            // Displ
            // 
            this.Displ.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Displ.Location = new System.Drawing.Point(14, 83);
            this.Displ.Name = "Displ";
            this.Displ.ReadOnly = true;
            this.Displ.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.Displ.Size = new System.Drawing.Size(484, 290);
            this.Displ.TabIndex = 20;
            this.Displ.Text = "";
            // 
            // SrvcB
            // 
            this.SrvcB.Location = new System.Drawing.Point(269, 54);
            this.SrvcB.Name = "SrvcB";
            this.SrvcB.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.SrvcB.Size = new System.Drawing.Size(112, 23);
            this.SrvcB.TabIndex = 18;
            this.SrvcB.Text = "Услуги";
            this.SrvcB.UseVisualStyleBackColor = true;
            this.SrvcB.Click += new System.EventHandler(this.SrvcB_Click);
            // 
            // CalcPrice
            // 
            this.CalcPrice.Location = new System.Drawing.Point(386, 54);
            this.CalcPrice.Name = "CalcPrice";
            this.CalcPrice.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.CalcPrice.Size = new System.Drawing.Size(112, 23);
            this.CalcPrice.TabIndex = 31;
            this.CalcPrice.Text = "Оплата";
            this.CalcPrice.UseVisualStyleBackColor = true;
            this.CalcPrice.Click += new System.EventHandler(this.CalcPrice_Click);
            // 
            // Admin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(510, 387);
            this.Controls.Add(this.CalcPrice);
            this.Controls.Add(this.NewOrderB);
            this.Controls.Add(this.AllOrdB);
            this.Controls.Add(this.SrchB);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.SrchFltr);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.SrchWrd);
            this.Controls.Add(this.Displ);
            this.Controls.Add(this.SrvcB);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Admin";
            this.Text = "Администратор";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button NewOrderB;
        private System.Windows.Forms.Button AllOrdB;
        private System.Windows.Forms.Button SrchB;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox SrchFltr;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox SrchWrd;
        private System.Windows.Forms.RichTextBox Displ;
        private System.Windows.Forms.Button SrvcB;
        private System.Windows.Forms.Button CalcPrice;
    }
}