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
    public partial class Manager : Form
    {
        int MngID;
        int[] OrdersId;
        string query = "SELECT * FROM Orders ORDER BY id";
        string queryClnts = "SELECT * FROM Clients ORDER BY id";       
        DataTable Orders, Clients;
        public Manager()
        {
            int p = 0;
            MngID = Authorization.MngID;
            InitializeComponent();
            SLDataDB.LoadData(query, out Orders);
            SLDataDB.LoadData(queryClnts, out Clients);
            OrdersId = new int[Orders.Rows.Count];
            for(int i = 0; i < Orders.Rows.Count; i++)
            {
                if(MngID == Convert.ToInt32(Orders.Rows[i][5]))
                {
                    NumbersOrd.Text += Orders.Rows[i][0] + "\n";
                    OrdersId[p] = Convert.ToInt32(Orders.Rows[i][0]);
                    p++;
                }
            }                       
        }

        private void DescriptionB_Click(object sender, EventArgs e)
        {
            if (OrdN.Text != "")
            {
                Description.Text = "";
                for (int i = 0; i < OrdersId.Length; i++)
                {
                    if (OrdersId[i] == Convert.ToInt32(OrdN.Text))
                    {
                        for (int k = 0; k < Orders.Columns.Count; k++)
                        {
                            switch (k)
                            {
                                case 0:
                                    {
                                        Description.Text += "Номер заказа: " + Orders.Rows[OrdersId[i]][0] + "\n";
                                    }
                                    break;
                                case 1:
                                    {
                                        Description.Text += "Название: " + Orders.Rows[OrdersId[i]][1] + "\n";
                                    }
                                    break;
                                case 2:
                                    {
                                        Description.Text += "Описание: " + Orders.Rows[OrdersId[i]][2] + "\n";
                                    }
                                    break;
                                case 3:
                                    {
                                        Description.Text += "Срок окончания: " + Orders.Rows[OrdersId[i]][3] + "\n";
                                    }
                                    break;
                                case 4:
                                    {
                                        string r = ""; ;
                                        switch (Convert.ToInt32(Orders.Rows[OrdersId[i]][4]))
                                        {
                                            case 0:
                                                r = "Выдан";
                                                break;
                                            case 1:
                                                r = "Принят";
                                                break;
                                            case 2:
                                                r = "Выполняется";
                                                break;
                                            case 3:
                                                r = "Завершен";
                                                break;
                                        }
                                        Description.Text += "Состояние заказа: " + r + "\n";
                                    }
                                    break;
                                case 6:
                                    {
                                        Description.Text += "Дата получения: " + Orders.Rows[OrdersId[i]][6] + "\n";
                                    }
                                    break;
                                case 7:
                                    {
                                        for (int m = 0; m < Clients.Rows.Count; m++)
                                        {
                                            if (Convert.ToInt32(Orders.Rows[i][k]) ==
                                                Convert.ToInt32(Clients.Rows[m][0]))
                                            {
                                                Description.Text += "Фамилия: " + Clients.Rows[m][1] + "\nИмя: " +
                                                    Clients.Rows[m][2] + "\nНомер телефона: " + Clients.Rows[m][4] +
                                                    "\nАдрес: " + Clients.Rows[m][5] + "\nСкидка: " +
                                                    Clients.Rows[m][6] + "\n";
                                            }
                                        }
                                    }
                                    break;
                                case 8:
                                    {
                                        Description.Text += "Стоимость: " + Orders.Rows[i][k] + "руб.\n";
                                    }
                                    break;
                            }
                        }
                        break;
                    }
                }
            }
        }

        private void Svcs_Click(object sender, EventArgs e)
        {
            SvcManager g = new SvcManager();
            g.ShowDialog();
        }

        private void SaveOrd_Click(object sender, EventArgs e)
        {
            if(OrdStat.Text != "")
            {
                switch(OrdStat.Text)
                {
                    case "Получен":
                        {
                            Orders.Rows[Convert.ToInt32(OrdN.Text)][4] = 1;
                        }
                        break;
                    case "Выполняется":
                        {
                            Orders.Rows[Convert.ToInt32(OrdN.Text)][4] = 2;
                        }
                        break;
                    case "Завершен":
                        {
                            Orders.Rows[Convert.ToInt32(OrdN.Text)][4] = 3;
                        }
                        break;
                }
                SLDataDB.SaveData(query, Orders);
                Description.Text = "Изменения сохранены.";
            }            
        }
    }
}
