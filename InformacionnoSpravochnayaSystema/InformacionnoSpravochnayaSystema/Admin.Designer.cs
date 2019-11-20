namespace InformacionnoSpravochnayaSystema
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
            this.FreeDs = new System.Windows.Forms.Button();
            this.Vziskaniya = new System.Windows.Forms.Button();
            this.ChangePass = new System.Windows.Forms.Button();
            this.AllCitDeny = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.NpaspAdd = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.NPaspDel = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.SaveAdd = new System.Windows.Forms.Button();
            this.SaveDel = new System.Windows.Forms.Button();
            this.Repeat = new System.Windows.Forms.Button();
            this.Login = new System.Windows.Forms.ComboBox();
            this.NewPass = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.WorkerList = new System.Windows.Forms.Button();
            this.Orders = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // FreeDs
            // 
            this.FreeDs.Location = new System.Drawing.Point(12, 70);
            this.FreeDs.Name = "FreeDs";
            this.FreeDs.Size = new System.Drawing.Size(121, 23);
            this.FreeDs.TabIndex = 2;
            this.FreeDs.Text = "Увольнительные";
            this.FreeDs.UseVisualStyleBackColor = true;
            this.FreeDs.Click += new System.EventHandler(this.FreeDs_Click);
            // 
            // Vziskaniya
            // 
            this.Vziskaniya.Location = new System.Drawing.Point(12, 99);
            this.Vziskaniya.Name = "Vziskaniya";
            this.Vziskaniya.Size = new System.Drawing.Size(121, 23);
            this.Vziskaniya.TabIndex = 3;
            this.Vziskaniya.Text = "Взыскания";
            this.Vziskaniya.UseVisualStyleBackColor = true;
            this.Vziskaniya.Click += new System.EventHandler(this.Vziskaniya_Click);
            // 
            // ChangePass
            // 
            this.ChangePass.Location = new System.Drawing.Point(12, 251);
            this.ChangePass.Name = "ChangePass";
            this.ChangePass.Size = new System.Drawing.Size(121, 23);
            this.ChangePass.TabIndex = 4;
            this.ChangePass.Text = "Изменить пароль";
            this.ChangePass.UseVisualStyleBackColor = true;
            this.ChangePass.Click += new System.EventHandler(this.ChangePass_Click);
            // 
            // AllCitDeny
            // 
            this.AllCitDeny.Location = new System.Drawing.Point(159, 28);
            this.AllCitDeny.Name = "AllCitDeny";
            this.AllCitDeny.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.AllCitDeny.Size = new System.Drawing.Size(201, 110);
            this.AllCitDeny.TabIndex = 5;
            this.AllCitDeny.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(217, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Список граждан:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(156, 149);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(254, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Добавить нового гражданина с запретом в БД::";
            // 
            // NpaspAdd
            // 
            this.NpaspAdd.Location = new System.Drawing.Point(159, 185);
            this.NpaspAdd.Name = "NpaspAdd";
            this.NpaspAdd.Size = new System.Drawing.Size(201, 20);
            this.NpaspAdd.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(156, 169);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Номер паспорта:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(156, 237);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(94, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "Номер паспорта:";
            // 
            // NPaspDel
            // 
            this.NPaspDel.Location = new System.Drawing.Point(159, 253);
            this.NPaspDel.Name = "NPaspDel";
            this.NPaspDel.Size = new System.Drawing.Size(201, 20);
            this.NPaspDel.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(156, 217);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(178, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Удалить запрет на выезд из БД::";
            // 
            // SaveAdd
            // 
            this.SaveAdd.Location = new System.Drawing.Point(366, 183);
            this.SaveAdd.Name = "SaveAdd";
            this.SaveAdd.Size = new System.Drawing.Size(75, 23);
            this.SaveAdd.TabIndex = 13;
            this.SaveAdd.Text = "Сохранить";
            this.SaveAdd.UseVisualStyleBackColor = true;
            this.SaveAdd.Click += new System.EventHandler(this.SaveAdd_Click);
            // 
            // SaveDel
            // 
            this.SaveDel.Location = new System.Drawing.Point(366, 251);
            this.SaveDel.Name = "SaveDel";
            this.SaveDel.Size = new System.Drawing.Size(75, 23);
            this.SaveDel.TabIndex = 14;
            this.SaveDel.Text = "Сохранить";
            this.SaveDel.UseVisualStyleBackColor = true;
            this.SaveDel.Click += new System.EventHandler(this.SaveDel_Click);
            // 
            // Repeat
            // 
            this.Repeat.Location = new System.Drawing.Point(366, 7);
            this.Repeat.Name = "Repeat";
            this.Repeat.Size = new System.Drawing.Size(75, 23);
            this.Repeat.TabIndex = 15;
            this.Repeat.Text = "Обновить";
            this.Repeat.UseVisualStyleBackColor = true;
            this.Repeat.Click += new System.EventHandler(this.Repeat_Click);
            // 
            // Login
            // 
            this.Login.FormattingEnabled = true;
            this.Login.Items.AddRange(new object[] {
            "Администратор",
            "Сотрудник"});
            this.Login.Location = new System.Drawing.Point(12, 185);
            this.Login.Name = "Login";
            this.Login.Size = new System.Drawing.Size(121, 21);
            this.Login.TabIndex = 16;
            // 
            // NewPass
            // 
            this.NewPass.Location = new System.Drawing.Point(12, 225);
            this.NewPass.Name = "NewPass";
            this.NewPass.Size = new System.Drawing.Size(121, 20);
            this.NewPass.TabIndex = 17;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 149);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(82, 13);
            this.label6.TabIndex = 18;
            this.label6.Text = "Смена пароля:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 169);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(91, 13);
            this.label7.TabIndex = 19;
            this.label7.Text = "Учетная запись:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(12, 209);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(83, 13);
            this.label8.TabIndex = 20;
            this.label8.Text = "Новый пароль:";
            // 
            // WorkerList
            // 
            this.WorkerList.Location = new System.Drawing.Point(12, 12);
            this.WorkerList.Name = "WorkerList";
            this.WorkerList.Size = new System.Drawing.Size(121, 23);
            this.WorkerList.TabIndex = 21;
            this.WorkerList.Text = "Список сотрудников";
            this.WorkerList.UseVisualStyleBackColor = true;
            this.WorkerList.Click += new System.EventHandler(this.WorkerList_Click);
            // 
            // Orders
            // 
            this.Orders.Location = new System.Drawing.Point(12, 41);
            this.Orders.Name = "Orders";
            this.Orders.Size = new System.Drawing.Size(121, 23);
            this.Orders.TabIndex = 22;
            this.Orders.Text = "Поощрения";
            this.Orders.UseVisualStyleBackColor = true;
            this.Orders.Click += new System.EventHandler(this.Orders_Click);
            // 
            // Admin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(452, 284);
            this.Controls.Add(this.Orders);
            this.Controls.Add(this.WorkerList);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.NewPass);
            this.Controls.Add(this.Login);
            this.Controls.Add(this.Repeat);
            this.Controls.Add(this.SaveDel);
            this.Controls.Add(this.SaveAdd);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.NPaspDel);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.NpaspAdd);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.AllCitDeny);
            this.Controls.Add(this.ChangePass);
            this.Controls.Add(this.Vziskaniya);
            this.Controls.Add(this.FreeDs);
            this.Name = "Admin";
            this.Text = "Admin";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button FreeDs;
        private System.Windows.Forms.Button Vziskaniya;
        private System.Windows.Forms.Button ChangePass;
        private System.Windows.Forms.RichTextBox AllCitDeny;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox NpaspAdd;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox NPaspDel;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button SaveAdd;
        private System.Windows.Forms.Button SaveDel;
        private System.Windows.Forms.Button Repeat;
        private System.Windows.Forms.ComboBox Login;
        private System.Windows.Forms.TextBox NewPass;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button WorkerList;
        private System.Windows.Forms.Button Orders;
    }
}