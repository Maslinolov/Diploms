namespace InformacionnoSpravochnayaSystema
{
    partial class WorkerList
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
            this.Surname1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Name1 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.Patronymic1 = new System.Windows.Forms.TextBox();
            this.Rank = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.AddWorker = new System.Windows.Forms.Button();
            this.DelWorker = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.Patronymic2 = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.Name2 = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.Surname2 = new System.Windows.Forms.TextBox();
            this.CheckDel = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.WorkerOutDisplay = new System.Windows.Forms.DataGridView();
            this.Saved = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.WorkerOutDisplay)).BeginInit();
            this.SuspendLayout();
            // 
            // Surname1
            // 
            this.Surname1.Location = new System.Drawing.Point(9, 48);
            this.Surname1.Name = "Surname1";
            this.Surname1.Size = new System.Drawing.Size(100, 20);
            this.Surname1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(174, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(159, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Добавить нового сотрудника:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(28, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Фамилия:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(148, 32);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Имя:";
            // 
            // Name1
            // 
            this.Name1.Location = new System.Drawing.Point(115, 48);
            this.Name1.Name = "Name1";
            this.Name1.Size = new System.Drawing.Size(100, 20);
            this.Name1.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(240, 32);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Отчество:";
            // 
            // Patronymic1
            // 
            this.Patronymic1.Location = new System.Drawing.Point(221, 48);
            this.Patronymic1.Name = "Patronymic1";
            this.Patronymic1.Size = new System.Drawing.Size(100, 20);
            this.Patronymic1.TabIndex = 6;
            // 
            // Rank
            // 
            this.Rank.Location = new System.Drawing.Point(327, 48);
            this.Rank.Name = "Rank";
            this.Rank.Size = new System.Drawing.Size(100, 20);
            this.Rank.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(351, 32);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Звание:";
            // 
            // AddWorker
            // 
            this.AddWorker.Location = new System.Drawing.Point(433, 46);
            this.AddWorker.Name = "AddWorker";
            this.AddWorker.Size = new System.Drawing.Size(75, 23);
            this.AddWorker.TabIndex = 10;
            this.AddWorker.Text = "Добавить";
            this.AddWorker.UseVisualStyleBackColor = true;
            this.AddWorker.Click += new System.EventHandler(this.AddWorker_Click);
            // 
            // DelWorker
            // 
            this.DelWorker.Location = new System.Drawing.Point(433, 107);
            this.DelWorker.Name = "DelWorker";
            this.DelWorker.Size = new System.Drawing.Size(75, 23);
            this.DelWorker.TabIndex = 20;
            this.DelWorker.Text = "Удалить";
            this.DelWorker.UseVisualStyleBackColor = true;
            this.DelWorker.Click += new System.EventHandler(this.DelWorker_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(240, 94);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(57, 13);
            this.label7.TabIndex = 17;
            this.label7.Text = "Отчество:";
            // 
            // Patronymic2
            // 
            this.Patronymic2.Location = new System.Drawing.Point(221, 110);
            this.Patronymic2.Name = "Patronymic2";
            this.Patronymic2.Size = new System.Drawing.Size(100, 20);
            this.Patronymic2.TabIndex = 16;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(148, 94);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(32, 13);
            this.label8.TabIndex = 15;
            this.label8.Text = "Имя:";
            // 
            // Name2
            // 
            this.Name2.Location = new System.Drawing.Point(115, 110);
            this.Name2.Name = "Name2";
            this.Name2.Size = new System.Drawing.Size(100, 20);
            this.Name2.TabIndex = 14;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(28, 94);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(59, 13);
            this.label9.TabIndex = 13;
            this.label9.Text = "Фамилия:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(195, 71);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(114, 13);
            this.label10.TabIndex = 12;
            this.label10.Text = "Удалить сотрудника:";
            // 
            // Surname2
            // 
            this.Surname2.Location = new System.Drawing.Point(9, 110);
            this.Surname2.Name = "Surname2";
            this.Surname2.Size = new System.Drawing.Size(100, 20);
            this.Surname2.TabIndex = 11;
            // 
            // CheckDel
            // 
            this.CheckDel.FormattingEnabled = true;
            this.CheckDel.Items.AddRange(new object[] {
            "Нет",
            "Да"});
            this.CheckDel.Location = new System.Drawing.Point(327, 110);
            this.CheckDel.Name = "CheckDel";
            this.CheckDel.Size = new System.Drawing.Size(100, 21);
            this.CheckDel.TabIndex = 21;
            this.CheckDel.Text = "Нет";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(341, 94);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(74, 13);
            this.label6.TabIndex = 22;
            this.label6.Text = "Вы уверены?";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(195, 142);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(114, 13);
            this.label11.TabIndex = 24;
            this.label11.Text = "Список сотрудников:";
            // 
            // WorkerOutDisplay
            // 
            this.WorkerOutDisplay.AllowUserToAddRows = false;
            this.WorkerOutDisplay.AllowUserToDeleteRows = false;
            this.WorkerOutDisplay.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.WorkerOutDisplay.Location = new System.Drawing.Point(9, 158);
            this.WorkerOutDisplay.Name = "WorkerOutDisplay";
            this.WorkerOutDisplay.ReadOnly = true;
            this.WorkerOutDisplay.Size = new System.Drawing.Size(499, 155);
            this.WorkerOutDisplay.TabIndex = 25;
            // 
            // Saved
            // 
            this.Saved.Location = new System.Drawing.Point(380, 9);
            this.Saved.Name = "Saved";
            this.Saved.Size = new System.Drawing.Size(128, 20);
            this.Saved.TabIndex = 26;
            // 
            // WorkerList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(520, 335);
            this.Controls.Add(this.Saved);
            this.Controls.Add(this.WorkerOutDisplay);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.CheckDel);
            this.Controls.Add(this.DelWorker);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.Patronymic2);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.Name2);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.Surname2);
            this.Controls.Add(this.AddWorker);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.Rank);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Patronymic1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Name1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Surname1);
            this.Name = "WorkerList";
            this.Text = "WorkerList";
            ((System.ComponentModel.ISupportInitialize)(this.WorkerOutDisplay)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Surname1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox Name1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox Patronymic1;
        private System.Windows.Forms.TextBox Rank;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button AddWorker;
        private System.Windows.Forms.Button DelWorker;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox Patronymic2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox Name2;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox Surname2;
        private System.Windows.Forms.ComboBox CheckDel;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.DataGridView WorkerOutDisplay;
        private System.Windows.Forms.TextBox Saved;
    }
}