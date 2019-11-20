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
    public partial class Promotion : Form
    {
        DataTable Table = new DataTable();
        string connectString = Properties.Settings.Default.UsersConnectionString;

        public Promotion()
        {
            InitializeComponent();
            string query = "SELECT * FROM Promotions ORDER BY Фамилия";
            LoadData(query);
            PromDisplay.DataSource = Table;
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

        private void SaveProm_Click(object sender, EventArgs e)
        {
            string query = "SELECT * FROM Promotions ORDER BY Фамилия";
            LoadData(query);
            DataRow row;
            row = Table.NewRow();
            row["Фамилия"] = Surname.Text;
            row["Имя"] = Nam.Text;
            row["Отчество"] = Patronymic.Text;
            row["Вид поощрения"] = TypeProm.Text;
            Table.Rows.Add(row);
            SaveData(query);
            TypeProm.Text = "Cохранено.";
            Surname.Text = "";
            Nam.Text = "";
            Patronymic.Text = "";            
        }

        private void DelProm_Click(object sender, EventArgs e)
        {
            string query = "SELECT * FROM Promotions ORDER BY Фамилия";
            LoadData(query);
            string ChkSurname = SurnameDel.Text;
            string ChkName = NameDel.Text;
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
                SurnameDel.Text = "Cохранено.";                
                NameDel.Text = "";                
            }
            else
                SurnameDel.Text = "Сотрудник не найден.";
        }
    }
}
