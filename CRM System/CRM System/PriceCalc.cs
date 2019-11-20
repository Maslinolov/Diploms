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
    public partial class PriceCalc : Form
    {
        string queryOrd = "SELECT * FROM Orders ORDER BY id";
        string queryClnt = "SELECT * FROM Clients ORDER BY id";
        DataTable Orders, Clients;

        public PriceCalc()
        {
            InitializeComponent();
            SLDataDB.LoadData(queryOrd, out Orders);            
            SLDataDB.LoadData(queryClnt, out Clients);
            ClntListLd();
        }

        private void ClntListLd()
        {
            for(int i = 0; i < Clients.Rows.Count; i++)
            {
                Clnt.Items.Add(Clients.Rows[i][0] + ". " + Clients.Rows[i][1]);
            }
        }

       

        private void Description_Click(object sender, EventArgs e)
        {
            if (Ord.Text != "")
            {
                int i = 0;
                i = Convert.ToInt32(Ord.Text) - 1;
                Disp.Text = "";
                for (int k = 0; k < Orders.Columns.Count; k++)
                {
                    switch (k)
                    {
                        case 0:
                            {
                                Disp.Text += "Номер заказа: " + Orders.Rows[i][k] + "\n";
                            }
                            break;
                        case 1:
                            {
                                Disp.Text += "Название: " + Orders.Rows[i][k] + "\n";
                            }
                            break;                        
                        case 3:
                            {
                                Disp.Text += "Дата завершения: " + Orders.Rows[i][k] + "\n";
                            }
                            break;                                          
                        case 6:
                            {
                                Disp.Text += "Дата получения заказа: " + Orders.Rows[i][k] + "\n";
                            }
                            break;
                        case 7:
                            {
                                for (int m = 0; m < Clients.Rows.Count; m++)
                                {
                                    if (Convert.ToInt32(Orders.Rows[i][k]) ==
                                        Convert.ToInt32(Clients.Rows[m][0]))
                                    {
                                        Disp.Text += "Фамилия: " + Clients.Rows[m][1] + "\nИмя: " +
                                            Clients.Rows[m][2] + "\nНомер телефона: " + Clients.Rows[m][4] + 
                                            "\nСкидка: " + Clients.Rows[m][6] + "\n";
                                    }
                                }
                            }
                            break;
                        case 8:
                            {
                                Disp.Text += "Стоимость: " + Orders.Rows[i][k] + "руб.\n";
                            }
                            break;
                    }
                }                
            }
        }    

        private void Clnt_SelectedIndexChanged(object sender, EventArgs e)
        {
            Ord.Items.Clear();
            int k = 0;
            float prc = 0;
            int discount = 0;
            for(int i = 0; i < Orders.Rows.Count; i++)
            {               
                if (Convert.ToString(Orders.Rows[i][7]) == Convert.ToString(Clnt.Text[0]))
                {
                    k++;
                    prc += Convert.ToInt32(Orders.Rows[i][8]);                                        
                    Ord.Items.Add(Orders.Rows[i][0]);
                }
            }
            for (int i = 0; i < Clients.Rows.Count; i++)
            {
                if (Convert.ToString(Clients.Rows[i][0]) == Convert.ToString(Clnt.Text[0]))
                {
                    Discnt.Text = Convert.ToString(Clients.Rows[i][6]);
                    discount = Convert.ToInt32(Clients.Rows[i][6]);
                }
            }
            NumbOrd.Text = Convert.ToString(k);
            PromPrice.Text = Convert.ToString(prc);
            prc = prc - ((prc / 100) * discount);
            ResPrice.Text = Convert.ToString(prc);
        }       
    }
}
