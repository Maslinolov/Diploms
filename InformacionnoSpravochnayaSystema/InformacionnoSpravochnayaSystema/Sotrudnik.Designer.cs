namespace InformacionnoSpravochnayaSystema
{
    partial class Sotrudnik
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
            this.label1 = new System.Windows.Forms.Label();
            this.Srname = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.FoundWorker = new System.Windows.Forms.RichTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.PokidTerr = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.SaveWorker = new System.Windows.Forms.Button();
            this.Srch = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.FoundCit = new System.Windows.Forms.RichTextBox();
            this.PasspN1 = new System.Windows.Forms.TextBox();
            this.SrchCit = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.Surname = new System.Windows.Forms.TextBox();
            this.Nam = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.Patronymic = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.PasspN2 = new System.Windows.Forms.TextBox();
            this.RegNTS = new System.Windows.Forms.TextBox();
            this.TehP = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.SaveCitizen = new System.Windows.Forms.Button();
            this.SaveChk = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(274, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Проверка увольнительных сотрудников:";
            // 
            // Srname
            // 
            this.Srname.Location = new System.Drawing.Point(15, 52);
            this.Srname.Name = "Srname";
            this.Srname.Size = new System.Drawing.Size(161, 20);
            this.Srname.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(164, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Введите фамилию сотрудника:";
            // 
            // FoundWorker
            // 
            this.FoundWorker.Location = new System.Drawing.Point(15, 103);
            this.FoundWorker.Name = "FoundWorker";
            this.FoundWorker.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.FoundWorker.Size = new System.Drawing.Size(271, 96);
            this.FoundWorker.TabIndex = 3;
            this.FoundWorker.Text = "";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 87);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(192, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Сотрудники найденные по фамилии:";
            // 
            // PokidTerr
            // 
            this.PokidTerr.FormattingEnabled = true;
            this.PokidTerr.Items.AddRange(new object[] {
            "Да",
            "Нет"});
            this.PokidTerr.Location = new System.Drawing.Point(15, 227);
            this.PokidTerr.Name = "PokidTerr";
            this.PokidTerr.Size = new System.Drawing.Size(46, 21);
            this.PokidTerr.TabIndex = 5;
            this.PokidTerr.Text = "Да";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 211);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(225, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Сотрудник находится на территории части:";
            // 
            // SaveWorker
            // 
            this.SaveWorker.Location = new System.Drawing.Point(15, 254);
            this.SaveWorker.Name = "SaveWorker";
            this.SaveWorker.Size = new System.Drawing.Size(107, 25);
            this.SaveWorker.TabIndex = 7;
            this.SaveWorker.Text = "Сохранить";
            this.SaveWorker.UseVisualStyleBackColor = true;
            this.SaveWorker.Click += new System.EventHandler(this.SaveWorker_Click);
            // 
            // Srch
            // 
            this.Srch.Location = new System.Drawing.Point(182, 49);
            this.Srch.Name = "Srch";
            this.Srch.Size = new System.Drawing.Size(104, 25);
            this.Srch.TabIndex = 8;
            this.Srch.Text = "Найти";
            this.Srch.UseVisualStyleBackColor = true;
            this.Srch.Click += new System.EventHandler(this.Srch_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(326, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(371, 17);
            this.label5.TabIndex = 9;
            this.label5.Text = "Проверка возможности выезда из страны гражданина:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(326, 36);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(137, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "Введите номер паспорта:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(326, 87);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(230, 13);
            this.label7.TabIndex = 11;
            this.label7.Text = "Гражданин найденный по номеру паспорта:";
            // 
            // FoundCit
            // 
            this.FoundCit.Location = new System.Drawing.Point(329, 103);
            this.FoundCit.Name = "FoundCit";
            this.FoundCit.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.FoundCit.Size = new System.Drawing.Size(271, 48);
            this.FoundCit.TabIndex = 12;
            this.FoundCit.Text = "";
            // 
            // PasspN1
            // 
            this.PasspN1.Location = new System.Drawing.Point(329, 52);
            this.PasspN1.Name = "PasspN1";
            this.PasspN1.Size = new System.Drawing.Size(161, 20);
            this.PasspN1.TabIndex = 13;
            // 
            // SrchCit
            // 
            this.SrchCit.Location = new System.Drawing.Point(496, 49);
            this.SrchCit.Name = "SrchCit";
            this.SrchCit.Size = new System.Drawing.Size(104, 25);
            this.SrchCit.TabIndex = 14;
            this.SrchCit.Text = "Найти";
            this.SrchCit.UseVisualStyleBackColor = true;
            this.SrchCit.Click += new System.EventHandler(this.SrchCit_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.Location = new System.Drawing.Point(326, 164);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(342, 17);
            this.label8.TabIndex = 15;
            this.label8.Text = "Регистрация пересекающего границу гражданина:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(343, 186);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(59, 13);
            this.label9.TabIndex = 16;
            this.label9.Text = "Фамилия:";
            // 
            // Surname
            // 
            this.Surname.Location = new System.Drawing.Point(329, 202);
            this.Surname.Name = "Surname";
            this.Surname.Size = new System.Drawing.Size(100, 20);
            this.Surname.TabIndex = 17;
            // 
            // Nam
            // 
            this.Nam.Location = new System.Drawing.Point(435, 202);
            this.Nam.Name = "Nam";
            this.Nam.Size = new System.Drawing.Size(100, 20);
            this.Nam.TabIndex = 19;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(468, 186);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(32, 13);
            this.label10.TabIndex = 18;
            this.label10.Text = "Имя:";
            // 
            // Patronymic
            // 
            this.Patronymic.Location = new System.Drawing.Point(543, 202);
            this.Patronymic.Name = "Patronymic";
            this.Patronymic.Size = new System.Drawing.Size(100, 20);
            this.Patronymic.TabIndex = 21;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(563, 186);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(57, 13);
            this.label11.TabIndex = 20;
            this.label11.Text = "Отчество:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(335, 227);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(94, 13);
            this.label12.TabIndex = 22;
            this.label12.Text = "Номер паспорта:";
            // 
            // PasspN2
            // 
            this.PasspN2.Location = new System.Drawing.Point(329, 243);
            this.PasspN2.Name = "PasspN2";
            this.PasspN2.Size = new System.Drawing.Size(100, 20);
            this.PasspN2.TabIndex = 23;
            // 
            // RegNTS
            // 
            this.RegNTS.Location = new System.Drawing.Point(435, 243);
            this.RegNTS.Name = "RegNTS";
            this.RegNTS.Size = new System.Drawing.Size(100, 20);
            this.RegNTS.TabIndex = 24;
            // 
            // TehP
            // 
            this.TehP.Location = new System.Drawing.Point(543, 243);
            this.TehP.Name = "TehP";
            this.TehP.Size = new System.Drawing.Size(100, 20);
            this.TehP.TabIndex = 25;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(447, 227);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(75, 13);
            this.label13.TabIndex = 26;
            this.label13.Text = "Рег. знак ТС:";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(554, 227);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(86, 13);
            this.label14.TabIndex = 27;
            this.label14.Text = "Техпаспорт ТС:";
            // 
            // SaveCitizen
            // 
            this.SaveCitizen.Location = new System.Drawing.Point(543, 269);
            this.SaveCitizen.Name = "SaveCitizen";
            this.SaveCitizen.Size = new System.Drawing.Size(100, 25);
            this.SaveCitizen.TabIndex = 28;
            this.SaveCitizen.Text = "Сохранить";
            this.SaveCitizen.UseVisualStyleBackColor = true;
            this.SaveCitizen.Click += new System.EventHandler(this.SaveCitizen_Click);
            // 
            // SaveChk
            // 
            this.SaveChk.Location = new System.Drawing.Point(329, 272);
            this.SaveChk.Name = "SaveChk";
            this.SaveChk.Size = new System.Drawing.Size(206, 20);
            this.SaveChk.TabIndex = 29;
            // 
            // Sotrudnik
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(700, 306);
            this.Controls.Add(this.SaveChk);
            this.Controls.Add(this.SaveCitizen);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.TehP);
            this.Controls.Add(this.RegNTS);
            this.Controls.Add(this.PasspN2);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.Patronymic);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.Nam);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.Surname);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.SrchCit);
            this.Controls.Add(this.PasspN1);
            this.Controls.Add(this.FoundCit);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.Srch);
            this.Controls.Add(this.SaveWorker);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.PokidTerr);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.FoundWorker);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Srname);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Sotrudnik";
            this.Text = "Sotrudnik";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Srname;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RichTextBox FoundWorker;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox PokidTerr;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button SaveWorker;
        private System.Windows.Forms.Button Srch;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.RichTextBox FoundCit;
        private System.Windows.Forms.TextBox PasspN1;
        private System.Windows.Forms.Button SrchCit;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox Surname;
        private System.Windows.Forms.TextBox Nam;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox Patronymic;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox PasspN2;
        private System.Windows.Forms.TextBox RegNTS;
        private System.Windows.Forms.TextBox TehP;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Button SaveCitizen;
        private System.Windows.Forms.TextBox SaveChk;
    }
}