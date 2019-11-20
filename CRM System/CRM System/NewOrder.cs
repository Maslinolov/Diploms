using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CRM_System
{
    public partial class NewOrder : Form
    {
        string queryOrd = "SELECT * FROM Orders ORDER BY id";
        string queryMng = "SELECT * FROM Managers ORDER BY id";
        string queryClnt = "SELECT * FROM Clients ORDER BY id";        
        DataTable Orders, Managers, Clients;
       
        public NewOrder()
        {
            InitializeComponent();            
            UpdInfo();
        }

        private void AddNwOrd_Click(object sender, EventArgs e)
        {
            if (NamOrd.Text != "" && DateSt.Text != "" && ClientsBx.Text != "" && ManagerBx.Text != "")
            {
                DataRow row;
                row = Orders.NewRow();
                row["Id"] = Orders.Rows.Count + 1;
                row["Name"] = NamOrd.Text;
                row["Description"] = Description.Text;
                row["Order_stage"] = 0;
                row["Deadline"] = DeadLn.Text;
                row["Date"] = DateSt.Text;
                row["Price"] = Convert.ToInt32(Price.Text);
                for (int i = 0; i < Managers.Rows.Count; i++)
                {
                    bool chk = false;
                    for (int k = 0; k < ManagerBx.Text.Length; k++)
                    {
                        string a = Convert.ToString(Managers.Rows[i][1]);
                        if (a[k] == ManagerBx.Text[k])
                        {
                            chk = true;
                        }
                        else
                        {
                            chk = false;
                            break;
                        }

                    }
                    if (chk)
                    {
                        row["ManagerID"] = Managers.Rows[i][0];
                    }
                }
                for (int i = 0; i < Clients.Rows.Count; i++)
                {
                    bool chk = false;
                    for (int k = 0; k < ClientsBx.Text.Length; k++)
                    {
                        string a = Convert.ToString(Clients.Rows[i][1]);
                        if (a[k] == ClientsBx.Text[k])
                        {
                            chk = true;
                        }
                        else
                        {
                            chk = false;
                            break;
                        }

                    }
                    if (chk)
                    {
                        row["ClientID"] = Clients.Rows[i][0];
                    }
                }
                Orders.Rows.Add(row);
                SLDataDB.SaveData(queryOrd, Orders);
                NamOrd.Text = "";
                DeadLn.Text = "";
                DateSt.Text = "";
                ClientsBx.Text = "";
                Description.Text = "Заказ добавлен.";
                ManagerBx.Text = "";
                Price.Text = "";
            }
        }    

        private void NewOrder_Activate(object sender, EventArgs e)
        {
            UpdInfo();
        }

        private void AddNwClnt_Click(object sender, EventArgs e)
        {
            Clients g = new Clients();
            g.ShowDialog();
        }

        private void UpdInfo()
        {
            SLDataDB.LoadData(queryOrd, out Orders);
            SLDataDB.LoadData(queryMng, out Managers);
            SLDataDB.LoadData(queryClnt, out Clients);
            ManagerBx.Items.Clear();
            ClientsBx.Items.Clear();
            for (int i = 0; i < Managers.Rows.Count; i++)
            {
                ManagerBx.Items.Add(Managers.Rows[i][1]);
            }
            for (int i = 0; i < Clients.Rows.Count; i++)
            {
                ClientsBx.Items.Add(Clients.Rows[i][1]);
            }
        }                  
    }
}
