namespace CRM_System
{
    partial class Authorization
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Log = new System.Windows.Forms.TextBox();
            this.Pass = new System.Windows.Forms.TextBox();
            this.Auth = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(100, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(147, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Добро пожаловать!";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(64, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(209, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Пожалуйста авторизируйтесь:";
            // 
            // Log
            // 
            this.Log.Location = new System.Drawing.Point(12, 67);
            this.Log.Name = "Log";
            this.Log.Size = new System.Drawing.Size(140, 20);
            this.Log.TabIndex = 2;
            // 
            // Pass
            // 
            this.Pass.Location = new System.Drawing.Point(168, 67);
            this.Pass.Name = "Pass";
            this.Pass.Size = new System.Drawing.Size(140, 20);
            this.Pass.TabIndex = 3;
            // 
            // Auth
            // 
            this.Auth.Location = new System.Drawing.Point(84, 93);
            this.Auth.Name = "Auth";
            this.Auth.Size = new System.Drawing.Size(144, 23);
            this.Auth.TabIndex = 4;
            this.Auth.Text = "Авторизация";
            this.Auth.UseVisualStyleBackColor = true;
            this.Auth.Click += new System.EventHandler(this.Auth_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(34, 51);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Учетная запись:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(216, 51);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Пароль:";
            // 
            // Authorization
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(326, 125);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Auth);
            this.Controls.Add(this.Pass);
            this.Controls.Add(this.Log);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Authorization";
            this.Text = "Авторизация";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox Log;
        private System.Windows.Forms.TextBox Pass;
        private System.Windows.Forms.Button Auth;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}

