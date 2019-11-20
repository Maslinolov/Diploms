namespace CRM_System
{
    partial class ChangePassword
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
            this.Lgn = new System.Windows.Forms.ComboBox();
            this.NewPass = new System.Windows.Forms.TextBox();
            this.SaveB = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Lgn
            // 
            this.Lgn.FormattingEnabled = true;
            this.Lgn.Items.AddRange(new object[] {
            "Начальник отдела",
            "Администратор"});
            this.Lgn.Location = new System.Drawing.Point(11, 28);
            this.Lgn.Name = "Lgn";
            this.Lgn.Size = new System.Drawing.Size(121, 21);
            this.Lgn.TabIndex = 0;
            // 
            // NewPass
            // 
            this.NewPass.Location = new System.Drawing.Point(138, 29);
            this.NewPass.Name = "NewPass";
            this.NewPass.Size = new System.Drawing.Size(121, 20);
            this.NewPass.TabIndex = 1;
            // 
            // SaveB
            // 
            this.SaveB.Location = new System.Drawing.Point(265, 27);
            this.SaveB.Name = "SaveB";
            this.SaveB.Size = new System.Drawing.Size(75, 23);
            this.SaveB.TabIndex = 2;
            this.SaveB.Text = "Сохранить";
            this.SaveB.UseVisualStyleBackColor = true;
            this.SaveB.Click += new System.EventHandler(this.SaveB_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Учетная запись";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(158, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Новый пароль";
            // 
            // ChangePassword
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(353, 68);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.SaveB);
            this.Controls.Add(this.NewPass);
            this.Controls.Add(this.Lgn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "ChangePassword";
            this.Text = "Смена пароля";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox Lgn;
        private System.Windows.Forms.TextBox NewPass;
        private System.Windows.Forms.Button SaveB;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}