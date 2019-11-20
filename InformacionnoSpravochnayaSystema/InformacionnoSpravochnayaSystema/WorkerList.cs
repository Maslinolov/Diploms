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
    public partial class WorkerList : Form
    {
        DataTable Table = new DataTable();
        string connectString = Properties.Settings.Default.UsersConnectionString;

        public WorkerList()
        {
            InitializeComponent();
            string query = "SELECT * FROM Workers ORDER BY Фамилия";
            LoadData(query);            
            WorkerOutDisplay.DataSource = Table;
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

        private void AddWorker_Click(object sender, EventArgs e)
        {
            string query = "SELECT * FROM Workers ORDER BY Фамилия";
            LoadData(query);            
            DataRow row;
            row = Table.NewRow();
            row["Фамилия"] = Surname1.Text;
            row["Имя"] = Name1.Text;
            row["Отчество"] = Patronymic1.Text;
            row["Звание"] = Rank.Text;
            Table.Rows.Add(row);
            SaveData(query);
            Saved.Text = "Cохранено.";
            Surname1.Text = "";
            Name1.Text = "";
            Patronymic1.Text = "";
            Rank.Text = "";
        }

        private void DelWorker_Click(object sender, EventArgs e)
        {
            if(CheckDel.Text == "Да")
            {
                string query = "SELECT * FROM Workers ORDER BY Фамилия";
                LoadData(query);
                string ChkSurname = Surname2.Text;
                string ChkName = Name2.Text;
                string SurnameFT, NameFT;
                bool ChkF = false, ChkS = false;
                for (int i = 0; i < Table.Rows.Count; i++)
                {
                    SurnameFT = Convert.ToString(Table.Rows[i][0]);
                    for (int k = 0; k < ChkSurname.Length; k++)
                    {
                        if (ChkSurname[k] == SurnameFT[k])
                            ChkF = true;
                        else
                        {
                            ChkF = false;
                            break;
                        }
                    }
                    NameFT = Convert.ToString(Table.Rows[i][1]);
                    for (int k = 0; k < ChkName.Length; k++)
                    {
                        if (ChkName[k] == NameFT[k])
                            ChkS = true;
                        else
                        {
                            ChkS = false;
                            break;
                        }
                    }
                    if (ChkF && ChkS)
                    {
                        Table.Rows[i].Delete();
                    }
                }
                if (ChkF && ChkS)
                {
                    SaveData(query);
                    Saved.Text = "Cохранено.";
                    Surname2.Text = "";
                    Name2.Text = "";
                    Patronymic2.Text = "";
                    CheckDel.Text = "";
                }
                else
                    Saved.Text = "Сотрудник не найден.";
            }
        }
    }
}
