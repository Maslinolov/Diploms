using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;


namespace InformacionnoSpravochnayaSystema
{
    public partial class LoginForm : Form
    {
        List<string[]> data = new List<string[]>();
        bool chk = false;

        public LoginForm()
        {
            InitializeComponent();
            LoadData();
        }

        private void LoadData()
        {
            string connectString = Properties.Settings.Default.UsersConnectionString;
            SqlConnection Conn = new SqlConnection(connectString);
            Conn.Open();
            string query = "SELECT * FROM Users ORDER BY Login";
            SqlCommand command = new SqlCommand(query, Conn);
            SqlDataReader reader = command.ExecuteReader();            
            while (reader.Read())
            {
                data.Add(new string[2]);
                data[data.Count - 1][0] = reader[0].ToString();
                data[data.Count - 1][1] = reader[1].ToString();                
            }
            reader.Close();
            Conn.Close();            
        }

        private void Authorization_Click(object sender, EventArgs e)
        {
            string Log = Login.Text;
            string Pas = Password.Text;
            switch (Log)
            {
                case "Гость":
                    {                                
                        this.Hide();
                        Guest g = new Guest();
                        g.ShowDialog();
                        this.Close();
                    }
                    break;
                case "Сотрудник":
                    {                        
                        chk = false;
                        int p = 2;
                        PasCheck(Pas, p);
                        if (chk)
                        {
                            this.Hide();
                            Sotrudnik g = new Sotrudnik();
                            g.ShowDialog();
                            this.Close();                          
                        }                          
                    }
                    break;
                case "Администратор":
                    {
                        chk = false;
                        int p = 0;
                        PasCheck(Pas, p);
                        if (chk)
                        {
                            this.Hide();
                            Admin g = new Admin();
                            g.ShowDialog();
                            this.Close();
                        }
                    }
                    break;
            }                
        }

        private void PasCheck(string Pas, int p)
        {           
            if(Pas == "")
            {
                WrongPass g = new WrongPass();
                g.ShowDialog();
            }
            string pswd = data[p][1];
            for (int i = 0; i < Pas.Length; i++)
            {
                if (Pas[i] == pswd[i])
                    chk = true;
                else
                {
                    chk = false;
                    WrongPass g = new WrongPass();
                    g.ShowDialog();
                    break;                    
                }
            }
        }
    }
}
