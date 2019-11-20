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
    public partial class FreeDays : Form
    {
        DataTable Table = new DataTable();
        string connectString = Properties.Settings.Default.UsersConnectionString;
        string query = "SELECT * FROM FreeDays ORDER BY Surname";

        public FreeDays()
        {
            InitializeComponent();
            FillDisplay();
        }     

        private void LoadData(string query)
        {
            SqlConnection Conn = new SqlConnection(connectString);
            Table = new DataTable();
            Conn.Open();
            SqlDataAdapter adapter = new SqlDataAdapter();
            adapter.SelectCommand = new SqlCommand(query, Conn);
            SqlCommandBuilder builder = new SqlCommandBuilder(adapter);
            adapter.Fill(Table);
            Table.AcceptChanges();
            Conn.Close();
        }

        private void SaveData(string query)
        {
            SqlConnection Conn = new SqlConnection(connectString);
            Conn.Open();
            SqlDataAdapter adapter = new SqlDataAdapter();
            adapter.SelectCommand = new SqlCommand(query, Conn);
            SqlCommandBuilder builder = new SqlCommandBuilder(adapter);
            builder.GetUpdateCommand();
            adapter.Update(Table);
            Table.AcceptChanges();
            Conn.Close();
        }

        private void FillDisplay()
        {
            FreeDDisplay.Text = "";
            LoadData(query);
            for(int i = 0; i < Table.Rows.Count; i++)
            {
                for(int k = 0; k < Table.Columns.Count; k++)
                {
                    if(k < 3)
                        FreeDDisplay.Text += Table.Rows[i][k];
                    if (k == 3)
                    {
                        if(Convert.ToString(Table.Rows[i][k]) == "0")
                            FreeDDisplay.Text += "\nУвольнительного нет.";
                        else
                            FreeDDisplay.Text += "\nУвольнительный есть.";
                    }
                    if(k == 4)
                    {
                        if (Convert.ToString(Table.Rows[i][k]) == "0")
                            FreeDDisplay.Text += "\nСотрудник находится  в части.";
                        else
                            FreeDDisplay.Text += "\nСотрудник за пределами части.";
                    }
                }
                FreeDDisplay.Text += "\n";
            }
        }

        private void Reload_Click(object sender, EventArgs e)
        {
            FillDisplay();
        }

        private void Save_Click(object sender, EventArgs e)
        {            
            LoadData(query);          
            string SrName = Surname.Text;
            string ChSrName;
            bool Chk = false;
            for(int i = 0; i < Table.Rows.Count; i++)
            {
                ChSrName = Convert.ToString(Table.Rows[i][0]);
                for(int k = 0; k < SrName.Length; k++)
                {
                    if (ChSrName[k] == SrName[k])
                        Chk = true;
                    else
                    {
                        Chk = false;
                        break;
                    }
                }
                if(Chk)
                {
                    Table.Rows[i][3] = 1;
                    break;
                }
            }
            if(Chk == false)
            {
                DataRow row;
                row = Table.NewRow();
                row["Surname"] = Surname.Text;
                row["Name"] = Nam.Text;
                row["Patronymic"] = Patronymic.Text;
                row["FreeDay"] = 1;
                row["StrdOut"] = 0;
                Table.Rows.Add(row);
            }
            SaveData(query);
            FreeDDisplay.Text = "Cохранено.";
            Surname.Text = "";
            Nam.Text = "";
            Patronymic.Text = "";
        }

        private void Delete_Click(object sender, EventArgs e)
        {
            LoadData(query);
            string SrName = SurnameDel.Text;
            string ChSrName;
            bool Chk = false;
            for (int i = 0; i < Table.Rows.Count; i++)
            {
                ChSrName = Convert.ToString(Table.Rows[i][0]);
                for (int k = 0; k < SrName.Length; k++)
                {
                    if (ChSrName[k] == SrName[k])
                        Chk = true;
                    else
                    {
                        Chk = false;
                        break;
                    }
                }
                if (Chk)
                {
                    Table.Rows[i][3] = 0;
                    break;
                }
            }            
            SaveData(query);
            FreeDDisplay.Text = "Cохранено.";
            SurnameDel.Text = "";
            NameDel.Text = "";            
        }
    }
}
