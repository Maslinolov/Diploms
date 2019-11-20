namespace InformacionnoSpravochnayaSystema
{
    partial class LoginForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.Password = new System.Windows.Forms.TextBox();
            this.Login = new System.Windows.Forms.ComboBox();
            this.Authorization = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(44, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(363, 18);
            this.label2.TabIndex = 1;
            this.label2.Text = "Добро пожаловать! Пожалуйста авторизируйтесь:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(89, 62);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Учетная запись:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(291, 62);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Пароль:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(9, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(435, 24);
            this.label5.TabIndex = 5;
            this.label5.Text = "Информационно-справочная система таможни";
            // 
            // Password
            // 
            this.Password.Location = new System.Drawing.Point(233, 78);
            this.Password.Name = "Password";
            this.Password.Size = new System.Drawing.Size(174, 20);
            this.Password.TabIndex = 6;
            // 
            // Login
            // 
            this.Login.FormattingEnabled = true;
            this.Login.Items.AddRange(new object[] {
            "Гость",
            "Сотрудник",
            "Администратор"});
            this.Login.Location = new System.Drawing.Point(47, 78);
            this.Login.Name = "Login";
            this.Login.Size = new System.Drawing.Size(174, 21);
            this.Login.TabIndex = 7;
            this.Login.Text = "Гость";
            // 
            // Authorization
            // 
            this.Authorization.Location = new System.Drawing.Point(157, 105);
            this.Authorization.Name = "Authorization";
            this.Authorization.Size = new System.Drawing.Size(128, 23);
            this.Authorization.TabIndex = 8;
            this.Authorization.Text = "Авторизация";
            this.Authorization.UseVisualStyleBackColor = true;
            this.Authorization.Click += new System.EventHandler(this.Authorization_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(62, 131);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(332, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Для учетной записи \"Гость\" колонку \"Пароль\" оставить пустой";
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(454, 164);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Authorization);
            this.Controls.Add(this.Login);
            this.Controls.Add(this.Password);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.MaximizeBox = false;
            this.Name = "LoginForm";
            this.Text = "Log";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox Password;
        private System.Windows.Forms.ComboBox Login;
        private System.Windows.Forms.Button Authorization;
        private System.Windows.Forms.Label label1;
    }
}

