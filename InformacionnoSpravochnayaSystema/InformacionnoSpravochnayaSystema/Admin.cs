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
    public partial class Admin : Form
    {
        DataTable Table = new DataTable();
        string connectString = Properties.Settings.Default.UsersConnectionString;        

        public Admin()
        {
            InitializeComponent();                        
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

        private void SaveAdd_Click(object sender, EventArgs e)
        {
            string query = "SELECT * FROM Citizens ORDER BY PassportNumber";
            LoadData(query);
            DataRow row;
            row = Table.NewRow();
            row["PassportNumber"] = NpaspAdd.Text;
            row["DepartureBlocked"] = "1";            
            Table.Rows.Add(row);
            SaveData(query);            
            AllCitDeny.Text = "Изменения сохранены.";
            NpaspAdd.Text = "";            
        }

        private void SaveDel_Click(object sender, EventArgs e)
        {
            string query = "SELECT * FROM Citizens ORDER BY PAssportNumber";
            LoadData(query);
            string ChkPN = NPaspDel.Text;
            string PaspN;
            bool Chk = false;          
            for(int i = 0; i < Table.Rows.Count; i++)
            {
                PaspN = Convert.ToString(Table.Rows[i][0]);
                for(int k = 0; k < ChkPN.Length; k++)
                {
                    if (PaspN[k] == ChkPN[k])
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
            AllCitDeny.Text = "Изменения сохранены.";
            NPaspDel.Text = "";
        }               

        private void Repeat_Click(object sender, EventArgs e)
        {
            string query = "SELECT * FROM Citizens ORDER BY PAssportNumber";
            LoadData(query);
            AllCitDeny.Text = "";
            for (int i = 0; i < Table.Rows.Count; i++)
            {
                AllCitDeny.Text += Table.Rows[i][0] + " | ";
                if (Convert.ToString(Table.Rows[i][1]) == "0")
                    AllCitDeny.Text += "Разрешен\n";
                else
                    AllCitDeny.Text += "Запрещен\n";
            }
        }

        private void ChangePass_Click(object sender, EventArgs e)
        {
            string query = "SELECT * FROM Users ORDER BY Login";
            LoadData(query);
            switch (Login.Text)
            {
                case "Администратор":                    
                    Table.Rows[0][1] = NewPass.Text;                    
                    break;
                case "Сотрудник":
                    Table.Rows[0][2] = NewPass.Text;
                    break;
            }
            SaveData(query);
            NewPass.Text = "Изменения сохранены.";            
        }

        private void WorkerList_Click(object sender, EventArgs e)
        {
            WorkerList g = new WorkerList();
            g.ShowDialog();
        }

        private void Orders_Click(object sender, EventArgs e)
        {
            Promotion g = new Promotion();
            g.ShowDialog();
        }

        private void FreeDs_Click(object sender, EventArgs e)
        {
            FreeDays g = new FreeDays();
            g.ShowDialog();
        }

        private void Vziskaniya_Click(object sender, EventArgs e)
        {
            Vziskaniya g = new Vziskaniya();
            g.ShowDialog();
        }
    }
}
