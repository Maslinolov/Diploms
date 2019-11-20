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
    public partial class Guest : Form
    {
        List<string[]> data = new List<string[]>();

        public Guest()
        {
            InitializeComponent();
            LoadData();
        }

        private void Check_Click(object sender, EventArgs e)
        {
            string Psprt = Passport.Text;                 
            for(int k = 0; k < data.Count; k++)
            {
                if(Passport.Text == data[k][0])
                {
                    if (Convert.ToInt16(data[k][1]) == 0)
                    {
                        OutTextBox.Text = "Выезд разрешен.";
                        break;
                    }
                    else
                    {
                        OutTextBox.Text = "Выезд запрещен.";
                        break;
                    }
                }   
                if(k == (data.Count - 1))
                {
                    OutTextBox.Text = "Гражданин не найден.";
                    break;
                }             
            }
        }

        private void LoadData()
        {
            string connectString = Properties.Settings.Default.UsersConnectionString;
            SqlConnection Conn = new SqlConnection(connectString);
            Conn.Open();
            string query = "SELECT * FROM Citizens ORDER BY PassportNumber";
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

    }
}
