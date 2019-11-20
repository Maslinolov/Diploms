namespace CRM_System
{
    partial class ManagersW
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
            this.SrNam = new System.Windows.Forms.TextBox();
            this.Nm = new System.Windows.Forms.TextBox();
            this.Pass = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Nam = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.AddB = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.MangrN = new System.Windows.Forms.TextBox();
            this.DelB = new System.Windows.Forms.Button();
            this.dGV1 = new System.Windows.Forms.DataGridView();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dGV1)).BeginInit();
            this.SuspendLayout();
            // 
            // SrNam
            // 
            this.SrNam.Location = new System.Drawing.Point(14, 28);
            this.SrNam.Name = "SrNam";
            this.SrNam.Size = new System.Drawing.Size(100, 20);
            this.SrNam.TabIndex = 0;
            // 
            // Nm
            // 
            this.Nm.Location = new System.Drawing.Point(120, 28);
            this.Nm.Name = "Nm";
            this.Nm.Size = new System.Drawing.Size(100, 20);
            this.Nm.TabIndex = 1;
            // 
            // Pass
            // 
            this.Pass.Location = new System.Drawing.Point(226, 28);
            this.Pass.Name = "Pass";
            this.Pass.Size = new System.Drawing.Size(100, 20);
            this.Pass.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(35, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Фамилия:";
            // 
            // Nam
            // 
            this.Nam.AutoSize = true;
            this.Nam.Location = new System.Drawing.Point(158, 12);
            this.Nam.Name = "Nam";
            this.Nam.Size = new System.Drawing.Size(32, 13);
            this.Nam.TabIndex = 4;
            this.Nam.Text = "Имя:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(252, 12);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Пароль:";
            // 
            // AddB
            // 
            this.AddB.Location = new System.Drawing.Point(332, 26);
            this.AddB.Name = "AddB";
            this.AddB.Size = new System.Drawing.Size(75, 23);
            this.AddB.TabIndex = 6;
            this.AddB.Text = "Добавить";
            this.AddB.UseVisualStyleBackColor = true;
            this.AddB.Click += new System.EventHandler(this.AddB_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(412, 12);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(105, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Номер менеджера:";
            // 
            // MangrN
            // 
            this.MangrN.Location = new System.Drawing.Point(414, 28);
            this.MangrN.Name = "MangrN";
            this.MangrN.Size = new System.Drawing.Size(100, 20);
            this.MangrN.TabIndex = 7;
            // 
            // DelB
            // 
            this.DelB.Location = new System.Drawing.Point(520, 26);
            this.DelB.Name = "DelB";
            this.DelB.Size = new System.Drawing.Size(75, 23);
            this.DelB.TabIndex = 9;
            this.DelB.Text = "Удалить";
            this.DelB.UseVisualStyleBackColor = true;
            this.DelB.Click += new System.EventHandler(this.DelB_Click);
            // 
            // dGV1
            // 
            this.dGV1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGV1.Location = new System.Drawing.Point(15, 68);
            this.dGV1.Name = "dGV1";
            this.dGV1.Size = new System.Drawing.Size(580, 284);
            this.dGV1.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(242, 52);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(114, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Список менеджеров:";
            // 
            // ManagersW
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(612, 364);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dGV1);
            this.Controls.Add(this.DelB);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.MangrN);
            this.Controls.Add(this.AddB);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Nam);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Pass);
            this.Controls.Add(this.Nm);
            this.Controls.Add(this.SrNam);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "ManagersW";
            this.Text = "Менеджеры";
            ((System.ComponentModel.ISupportInitialize)(this.dGV1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox SrNam;
        private System.Windows.Forms.TextBox Nm;
        private System.Windows.Forms.TextBox Pass;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label Nam;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button AddB;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox MangrN;
        private System.Windows.Forms.Button DelB;
        private System.Windows.Forms.DataGridView dGV1;
        private System.Windows.Forms.Label label5;
    }
}