namespace CRM_System
{
    partial class Services
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
            this.Nam = new System.Windows.Forms.TextBox();
            this.Price = new System.Windows.Forms.TextBox();
            this.Description = new System.Windows.Forms.TextBox();
            this.Add = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.IdSvc = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.DelSvcB = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dGV1)).BeginInit();
            this.SuspendLayout();
            // 
            // dGV1
            // 
            this.dGV1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGV1.Location = new System.Drawing.Point(7, 105);
            this.dGV1.Name = "dGV1";
            this.dGV1.Size = new System.Drawing.Size(576, 256);
            this.dGV1.TabIndex = 0;
            // 
            // Nam
            // 
            this.Nam.Location = new System.Drawing.Point(7, 27);
            this.Nam.Name = "Nam";
            this.Nam.Size = new System.Drawing.Size(100, 20);
            this.Nam.TabIndex = 1;
            // 
            // Price
            // 
            this.Price.Location = new System.Drawing.Point(113, 27);
            this.Price.Name = "Price";
            this.Price.Size = new System.Drawing.Size(100, 20);
            this.Price.TabIndex = 2;
            // 
            // Description
            // 
            this.Description.Location = new System.Drawing.Point(5, 66);
            this.Description.Name = "Description";
            this.Description.Size = new System.Drawing.Size(289, 20);
            this.Description.TabIndex = 3;
            // 
            // Add
            // 
            this.Add.Location = new System.Drawing.Point(219, 25);
            this.Add.Name = "Add";
            this.Add.Size = new System.Drawing.Size(75, 23);
            this.Add.TabIndex = 4;
            this.Add.Text = "Добавить";
            this.Add.UseVisualStyleBackColor = true;
            this.Add.Click += new System.EventHandler(this.Add_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Название:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(133, 11);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Стоимость:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(122, 50);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Описание:";
            // 
            // IdSvc
            // 
            this.IdSvc.Location = new System.Drawing.Point(309, 27);
            this.IdSvc.Name = "IdSvc";
            this.IdSvc.Size = new System.Drawing.Size(100, 20);
            this.IdSvc.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(314, 11);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Номер услуги:";
            // 
            // DelSvcB
            // 
            this.DelSvcB.Location = new System.Drawing.Point(415, 25);
            this.DelSvcB.Name = "DelSvcB";
            this.DelSvcB.Size = new System.Drawing.Size(75, 23);
            this.DelSvcB.TabIndex = 10;
            this.DelSvcB.Text = "Удалить";
            this.DelSvcB.UseVisualStyleBackColor = true;
            this.DelSvcB.Click += new System.EventHandler(this.DelSvcB_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(237, 89);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(77, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Список услуг:";
            // 
            // Services
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(595, 373);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.DelSvcB);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.IdSvc);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Add);
            this.Controls.Add(this.Description);
            this.Controls.Add(this.Price);
            this.Controls.Add(this.Nam);
            this.Controls.Add(this.dGV1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Services";
            this.Text = "Услуги";
            ((System.ComponentModel.ISupportInitialize)(this.dGV1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dGV1;
        private System.Windows.Forms.TextBox Nam;
        private System.Windows.Forms.TextBox Price;
        private System.Windows.Forms.TextBox Description;
        private System.Windows.Forms.Button Add;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox IdSvc;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button DelSvcB;
        private System.Windows.Forms.Label label5;
    }
}