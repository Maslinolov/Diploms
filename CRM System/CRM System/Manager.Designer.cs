namespace CRM_System
{
    partial class Manager
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
            this.NumbersOrd = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Description = new System.Windows.Forms.RichTextBox();
            this.OrdN = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.DescriptionB = new System.Windows.Forms.Button();
            this.OrdStat = new System.Windows.Forms.ComboBox();
            this.SaveOrd = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.Svcs = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // NumbersOrd
            // 
            this.NumbersOrd.Location = new System.Drawing.Point(12, 27);
            this.NumbersOrd.Name = "NumbersOrd";
            this.NumbersOrd.ReadOnly = true;
            this.NumbersOrd.Size = new System.Drawing.Size(100, 50);
            this.NumbersOrd.TabIndex = 0;
            this.NumbersOrd.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(9, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Номера заказов:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(184, 90);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(153, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Подробное описание:";
            // 
            // Description
            // 
            this.Description.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Description.Location = new System.Drawing.Point(12, 110);
            this.Description.Name = "Description";
            this.Description.ReadOnly = true;
            this.Description.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.Description.Size = new System.Drawing.Size(524, 222);
            this.Description.TabIndex = 2;
            this.Description.Text = "";
            // 
            // OrdN
            // 
            this.OrdN.Location = new System.Drawing.Point(126, 27);
            this.OrdN.Name = "OrdN";
            this.OrdN.Size = new System.Drawing.Size(164, 20);
            this.OrdN.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(184, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 15);
            this.label3.TabIndex = 5;
            this.label3.Text = "Номер:";
            // 
            // DescriptionB
            // 
            this.DescriptionB.Location = new System.Drawing.Point(165, 51);
            this.DescriptionB.Name = "DescriptionB";
            this.DescriptionB.Size = new System.Drawing.Size(82, 23);
            this.DescriptionB.TabIndex = 6;
            this.DescriptionB.Text = "Подробности";
            this.DescriptionB.UseVisualStyleBackColor = true;
            this.DescriptionB.Click += new System.EventHandler(this.DescriptionB_Click);
            // 
            // OrdStat
            // 
            this.OrdStat.FormattingEnabled = true;
            this.OrdStat.Items.AddRange(new object[] {
            "Получен",
            "Выполняется",
            "Завершен"});
            this.OrdStat.Location = new System.Drawing.Point(296, 27);
            this.OrdStat.Name = "OrdStat";
            this.OrdStat.Size = new System.Drawing.Size(164, 21);
            this.OrdStat.TabIndex = 7;
            // 
            // SaveOrd
            // 
            this.SaveOrd.Location = new System.Drawing.Point(342, 54);
            this.SaveOrd.Name = "SaveOrd";
            this.SaveOrd.Size = new System.Drawing.Size(76, 23);
            this.SaveOrd.TabIndex = 8;
            this.SaveOrd.Text = "Сохранить";
            this.SaveOrd.UseVisualStyleBackColor = true;
            this.SaveOrd.Click += new System.EventHandler(this.SaveOrd_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(319, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(115, 15);
            this.label4.TabIndex = 9;
            this.label4.Text = "Состояние заказа:";
            // 
            // Svcs
            // 
            this.Svcs.Location = new System.Drawing.Point(12, 81);
            this.Svcs.Name = "Svcs";
            this.Svcs.Size = new System.Drawing.Size(76, 23);
            this.Svcs.TabIndex = 10;
            this.Svcs.Text = "Услуги";
            this.Svcs.UseVisualStyleBackColor = true;
            this.Svcs.Click += new System.EventHandler(this.Svcs_Click);
            // 
            // Manager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(548, 344);
            this.Controls.Add(this.Svcs);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.SaveOrd);
            this.Controls.Add(this.OrdStat);
            this.Controls.Add(this.DescriptionB);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.OrdN);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Description);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.NumbersOrd);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Manager";
            this.Text = "Менеджер";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox NumbersOrd;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RichTextBox Description;
        private System.Windows.Forms.TextBox OrdN;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button DescriptionB;
        private System.Windows.Forms.ComboBox OrdStat;
        private System.Windows.Forms.Button SaveOrd;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button Svcs;
    }
}