namespace CRM_System
{
    partial class Head_of_Dep
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
            this.ManagerB = new System.Windows.Forms.Button();
            this.SrvcB = new System.Windows.Forms.Button();
            this.ClientsB = new System.Windows.Forms.Button();
            this.Displ = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SrchWrd = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SrchFltr = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.SrchB = new System.Windows.Forms.Button();
            this.AllOrdB = new System.Windows.Forms.Button();
            this.ArchiveB = new System.Windows.Forms.Button();
            this.PassCng = new System.Windows.Forms.Button();
            this.NewOrderB = new System.Windows.Forms.Button();
            this.SendTArchive = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.OrdNArh = new System.Windows.Forms.TextBox();
            this.CalcPrice = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ManagerB
            // 
            this.ManagerB.Location = new System.Drawing.Point(12, 12);
            this.ManagerB.Name = "ManagerB";
            this.ManagerB.Size = new System.Drawing.Size(87, 23);
            this.ManagerB.TabIndex = 0;
            this.ManagerB.Text = "Менеджеры";
            this.ManagerB.UseVisualStyleBackColor = true;
            this.ManagerB.Click += new System.EventHandler(this.ManagerB_Click);
            // 
            // SrvcB
            // 
            this.SrvcB.Location = new System.Drawing.Point(105, 12);
            this.SrvcB.Name = "SrvcB";
            this.SrvcB.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.SrvcB.Size = new System.Drawing.Size(87, 23);
            this.SrvcB.TabIndex = 1;
            this.SrvcB.Text = "Услуги";
            this.SrvcB.UseVisualStyleBackColor = true;
            this.SrvcB.Click += new System.EventHandler(this.SrvcB_Click);
            // 
            // ClientsB
            // 
            this.ClientsB.Location = new System.Drawing.Point(198, 12);
            this.ClientsB.Name = "ClientsB";
            this.ClientsB.Size = new System.Drawing.Size(87, 23);
            this.ClientsB.TabIndex = 2;
            this.ClientsB.Text = "Клиенты";
            this.ClientsB.UseVisualStyleBackColor = true;
            this.ClientsB.Click += new System.EventHandler(this.ClientsB_Click);
            // 
            // Displ
            // 
            this.Displ.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Displ.Location = new System.Drawing.Point(12, 137);
            this.Displ.Name = "Displ";
            this.Displ.ReadOnly = true;
            this.Displ.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.Displ.Size = new System.Drawing.Size(484, 290);
            this.Displ.TabIndex = 3;
            this.Displ.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(169, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Заказы:";
            // 
            // SrchWrd
            // 
            this.SrchWrd.Location = new System.Drawing.Point(12, 72);
            this.SrchWrd.Name = "SrchWrd";
            this.SrchWrd.Size = new System.Drawing.Size(121, 20);
            this.SrchWrd.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Ключевое слово:";
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
            this.SrchFltr.Location = new System.Drawing.Point(139, 72);
            this.SrchFltr.Name = "SrchFltr";
            this.SrchFltr.Size = new System.Drawing.Size(121, 21);
            this.SrchFltr.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(169, 56);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Категория:";
            // 
            // SrchB
            // 
            this.SrchB.Location = new System.Drawing.Point(266, 72);
            this.SrchB.Name = "SrchB";
            this.SrchB.Size = new System.Drawing.Size(112, 22);
            this.SrchB.TabIndex = 9;
            this.SrchB.Text = "Поиск";
            this.SrchB.UseVisualStyleBackColor = true;
            this.SrchB.Click += new System.EventHandler(this.SrchB_Click);
            // 
            // AllOrdB
            // 
            this.AllOrdB.Location = new System.Drawing.Point(12, 98);
            this.AllOrdB.Name = "AllOrdB";
            this.AllOrdB.Size = new System.Drawing.Size(140, 23);
            this.AllOrdB.TabIndex = 10;
            this.AllOrdB.Text = "Отобразить все заказы";
            this.AllOrdB.UseVisualStyleBackColor = true;
            this.AllOrdB.Click += new System.EventHandler(this.AllOrdB_Click);
            // 
            // ArchiveB
            // 
            this.ArchiveB.Location = new System.Drawing.Point(291, 12);
            this.ArchiveB.Name = "ArchiveB";
            this.ArchiveB.Size = new System.Drawing.Size(87, 23);
            this.ArchiveB.TabIndex = 11;
            this.ArchiveB.Text = "Архив";
            this.ArchiveB.UseVisualStyleBackColor = true;
            this.ArchiveB.Click += new System.EventHandler(this.ArchiveB_Click);
            // 
            // PassCng
            // 
            this.PassCng.Location = new System.Drawing.Point(266, 98);
            this.PassCng.Name = "PassCng";
            this.PassCng.Size = new System.Drawing.Size(112, 23);
            this.PassCng.TabIndex = 12;
            this.PassCng.Text = "Смена пароля";
            this.PassCng.UseVisualStyleBackColor = true;
            this.PassCng.Click += new System.EventHandler(this.PassCng_Click);
            // 
            // NewOrderB
            // 
            this.NewOrderB.Location = new System.Drawing.Point(158, 98);
            this.NewOrderB.Name = "NewOrderB";
            this.NewOrderB.Size = new System.Drawing.Size(102, 23);
            this.NewOrderB.TabIndex = 13;
            this.NewOrderB.Text = "Новый заказ";
            this.NewOrderB.UseVisualStyleBackColor = true;
            this.NewOrderB.Click += new System.EventHandler(this.NewOrderB_Click);
            // 
            // SendTArchive
            // 
            this.SendTArchive.Location = new System.Drawing.Point(384, 98);
            this.SendTArchive.Name = "SendTArchive";
            this.SendTArchive.Size = new System.Drawing.Size(112, 23);
            this.SendTArchive.TabIndex = 14;
            this.SendTArchive.Text = "Отправить в архив";
            this.SendTArchive.UseVisualStyleBackColor = true;
            this.SendTArchive.Click += new System.EventHandler(this.SendTArchive_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(399, 56);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 13);
            this.label4.TabIndex = 15;
            this.label4.Text = "Номер заказа:";
            // 
            // OrdNArh
            // 
            this.OrdNArh.Location = new System.Drawing.Point(384, 74);
            this.OrdNArh.Name = "OrdNArh";
            this.OrdNArh.Size = new System.Drawing.Size(112, 20);
            this.OrdNArh.TabIndex = 16;
            // 
            // CalcPrice
            // 
            this.CalcPrice.Location = new System.Drawing.Point(384, 12);
            this.CalcPrice.Name = "CalcPrice";
            this.CalcPrice.Size = new System.Drawing.Size(112, 23);
            this.CalcPrice.TabIndex = 17;
            this.CalcPrice.Text = "Оплата";
            this.CalcPrice.UseVisualStyleBackColor = true;
            this.CalcPrice.Click += new System.EventHandler(this.CalcPrice_Click);
            // 
            // Head_of_Dep
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(513, 439);
            this.Controls.Add(this.CalcPrice);
            this.Controls.Add(this.OrdNArh);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.SendTArchive);
            this.Controls.Add(this.NewOrderB);
            this.Controls.Add(this.PassCng);
            this.Controls.Add(this.ArchiveB);
            this.Controls.Add(this.AllOrdB);
            this.Controls.Add(this.SrchB);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.SrchFltr);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.SrchWrd);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Displ);
            this.Controls.Add(this.ClientsB);
            this.Controls.Add(this.SrvcB);
            this.Controls.Add(this.ManagerB);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Head_of_Dep";
            this.Text = "Начальник отдела";
            this.Activated += new System.EventHandler(this.Upd);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ManagerB;
        private System.Windows.Forms.Button SrvcB;
        private System.Windows.Forms.Button ClientsB;
        private System.Windows.Forms.RichTextBox Displ;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox SrchWrd;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox SrchFltr;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button SrchB;
        private System.Windows.Forms.Button AllOrdB;
        private System.Windows.Forms.Button ArchiveB;
        private System.Windows.Forms.Button PassCng;
        private System.Windows.Forms.Button NewOrderB;
        private System.Windows.Forms.Button SendTArchive;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox OrdNArh;
        private System.Windows.Forms.Button CalcPrice;
    }
}