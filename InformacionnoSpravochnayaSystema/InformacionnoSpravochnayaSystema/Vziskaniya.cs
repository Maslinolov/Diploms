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
    public partial class Vziskaniya : Form
    {
        DataTable Table = new DataTable();
        string connectString = Properties.Settings.Default.UsersConnectionString;
        string query = "SELECT * FROM Vziskaniya ORDER BY Фамилия";

        public Vziskaniya()
        {
            InitializeComponent();
            LoadData(query);
            VzisDisplay.DataSource = Table;
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
        private void Save_Click(object sender, EventArgs e)
        {
            LoadData(query);                      
            DataRow row;
            row = Table.NewRow();
            row["Фамилия"] = Surname1.Text;
            row["Имя"] = Name1.Text;
            row["Отчество"] = Patronymic1.Text;
            row["Вид взыскания"] = TypeVzis.Text; ;            
            Table.Rows.Add(row);            
            SaveData(query);
            TypeVzis.Text = "Cохранено.";
            Surname1.Text = "";
            Name1.Text = "";
            Patronymic1.Text = "";
            LoadData(query);
            VzisDisplay.DataSource = Table;
        }

        private void Del_Click(object sender, EventArgs e)
        {
            string ChkSrName = Surname2.Text;
            string SrName;
            bool Chk = false;
            for (int i = 0; i < Table.Rows.Count; i++)
            {
                SrName = Convert.ToString(Table.Rows[i][0]);
                for (int k = 0; k < ChkSrName.Length; k++)
                {
                    if (ChkSrName[k] == SrName[k])
                        Chk = true;
                    else
                    {
                        Chk = false;
                        break;
                    }
                }
                if (Chk)
                {
                    Table.Rows[i].Delete();
                }
            }
            SaveData(query);
            Surname2.Text = "Изменения сохранены.";
            Name2.Text = "";
            Patronymic2.Text = "";
            LoadData(query);
            VzisDisplay.DataSource = Table;
        }
    }
}
