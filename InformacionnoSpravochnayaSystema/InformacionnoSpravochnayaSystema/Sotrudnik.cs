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
    public partial class Sotrudnik : Form
    {
        List<string[]> data = new List<string[]>();
        List<string[]> dataCit = new List<string[]>();
        string connectString = Properties.Settings.Default.UsersConnectionString;
        string query = "SELECT * FROM FreeDays ORDER BY Surname";

        int CellPos = 0;

        public Sotrudnik()
        {
            InitializeComponent();           
        }

        private void Srch_Click(object sender, EventArgs e)
        {
            LoadData();
            FoundWorker.Text = "";
            string SrchSrName = Srname.Text;
            string Srnm;
            bool chk = false;
            for(int i = 0; i < data.Count; i++)
            {
                Srnm = data[i][0];
                for(int k = 0; k < SrchSrName.Length; k++)
                {
                    if(SrchSrName[k] == Srnm[k])
                    {
                        chk = true;
                    }
                    else
                    {
                        chk = false;
                        break;
                    }                    
                }
                if(chk)
                {
                    CellPos = i;
                    for(int k = 0; k < 5; k++)
                    {
                        if(k < 3)                       
                            FoundWorker.Text += Convert.ToString(data[i][k]);      
                        if(k == 3)
                        {
                            FoundWorker.Text += "\nНаличие увольнительного у сотрудника: ";
                            if (data[i][3] == "1")
                                FoundWorker.Text += "Да";
                            else
                                FoundWorker.Text += "Нет";
                        }
                        if (k == 4)
                        {
                            FoundWorker.Text += "\nСотрудник находится на территории части: ";
                            if (data[i][4] == "0")
                                FoundWorker.Text += "Да";
                            else
                                FoundWorker.Text += "Нет";
                        }
                    }
                    FoundWorker.Text += "\n";
                }
            }  
            if(FoundWorker.Text == "")
            {
                FoundWorker.Text = "Сотрудник не найден.";
            }          
        }

        private void SaveWorker_Click(object sender, EventArgs e)
        {            
            SqlConnection Conn = new SqlConnection(connectString);
            DataTable dTable = new DataTable(); 
            Conn.Open();
            SqlDataAdapter adapter = new SqlDataAdapter();
            adapter.SelectCommand = new SqlCommand(query, Conn);
            SqlCommandBuilder builder = new SqlCommandBuilder(adapter);             
            adapter.Fill(dTable);
            if (PokidTerr.Text == "Нет")
            {
                if (Convert.ToString(dTable.Rows[CellPos][3]) == "1")
                {
                    dTable.Rows[CellPos][4] = "1";
                    dTable.Rows[CellPos][3] = "0";
                    FoundWorker.Text = "Сохранения изменены.";
                }
                else
                    FoundWorker.Text = "Сотрудник не имеет увольнительного.";
            }
            if (PokidTerr.Text == "Да")
            {
                dTable.Rows[CellPos][4] = "0";
                FoundWorker.Text = "Сохранения изменены.";
            }          
            builder.GetUpdateCommand();
            adapter.Update(dTable);
            dTable.AcceptChanges();            
            Conn.Close();                                         
        }

        private void LoadData()
        {
            data = new List<string[]>();
            SqlConnection Conn = new SqlConnection(connectString);
            Conn.Open();            
            SqlCommand command = new SqlCommand(query, Conn);
            SqlDataReader reader = command.ExecuteReader();            
            while (reader.Read())
            {
                data.Add(new string[5]);
                data[data.Count - 1][0] = reader[0].ToString();
                data[data.Count - 1][1] = reader[1].ToString();
                data[data.Count - 1][2] = reader[2].ToString();
                data[data.Count - 1][3] = reader[3].ToString();
                data[data.Count - 1][4] = reader[4].ToString();                
            }
            reader.Close();
            Conn.Close();
        }

        private void SrchCit_Click(object sender, EventArgs e)
        {
            FoundCit.Text = "";
            string SrchPC = PasspN1.Text;
            dataCit = new List<string[]>();
            string queryCit = "SELECT * FROM Citizens ORDER BY PassportNumber";
            SqlConnection Conn = new SqlConnection(connectString);
            Conn.Open();
            SqlCommand command = new SqlCommand(queryCit, Conn);
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                dataCit.Add(new string[2]);
                dataCit[dataCit.Count - 1][0] = reader[0].ToString();
                dataCit[dataCit.Count - 1][1] = reader[1].ToString();            
            }
            reader.Close();
            Conn.Close();
            if (PasspN1.Text != "")
            {
                for (int i = 0; i < dataCit.Count; i++)
                {
                    bool Chk = false;
                    string SrchN = dataCit[i][0];
                    for (int k = 0; k < dataCit[i][0].Length; k++)
                    {
                        if (SrchPC[k] == SrchN[k])
                        {
                            Chk = true;
                        }
                        else
                        {
                            Chk = false;
                            break;
                        }
                    }
                    if (Chk)
                    {
                        if (dataCit[i][1] == "0")
                            FoundCit.Text = "Выезд разрешен.";
                        else
                            FoundCit.Text = "Выезд запрещен.";
                    }
                }
            }
            if (FoundCit.Text == "")
                FoundCit.Text = "Гражданин не найден.";
        }

        private void SaveCitizen_Click(object sender, EventArgs e)
        {
            string quer = "SELECT * FROM DepartureCitizens ORDER BY Surname";
            SqlConnection Conn = new SqlConnection(connectString);
            DataTable dTab = new DataTable(); ;
            Conn.Open();
            SqlDataAdapter adapter = new SqlDataAdapter();
            adapter.SelectCommand = new SqlCommand(quer, Conn);
            SqlCommandBuilder builder = new SqlCommandBuilder(adapter);
            adapter.Fill(dTab);
            DataRow row;
            row = dTab.NewRow();
            row["Surname"] = Surname.Text;
            row["Name"] = Nam.Text;
            row["Patronymic"] = Patronymic.Text;
            row["PassportN"] = PasspN2.Text;
            row["RegNTS"] = RegNTS.Text;
            row["TehP"] = TehP.Text;
            dTab.Rows.Add(row);
            builder.GetUpdateCommand();
            adapter.Update(dTab);
            dTab.AcceptChanges();
            Conn.Close();
            SaveChk.Text = "Гражданин добавлен в БД.";
            Surname.Text = "";
            Nam.Text = "";
            Patronymic.Text = "";
            PasspN2.Text = "";
            RegNTS.Text = "";
            TehP.Text = "";
        }      
        
    }
}
