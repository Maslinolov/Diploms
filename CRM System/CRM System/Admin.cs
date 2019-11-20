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
    public partial class Admin : Form
    {
        string queryOrd = "SELECT * FROM Orders ORDER BY id";
        string queryMng = "SELECT * FROM Managers ORDER BY id";
        string queryClnt = "SELECT * FROM Clients ORDER BY id";      
        DataTable Orders, Managers, Clients;

        public Admin()
        {
            Upd();
            InitializeComponent();
        }       

        private void Upd(object sender, EventArgs e)
        {
            Upd();
        }

        private void Upd()
        {
            SLDataDB.LoadData(queryOrd, out Orders);
            SLDataDB.LoadData(queryMng, out Managers);
            SLDataDB.LoadData(queryClnt, out Clients);        
        }


        private void SrchB_Click(object sender, EventArgs e)
        {
            if (SrchWrd.Text != "" && SrchFltr.Text != "")
            {
                Displ.Text = "";
                string SrWord = SrchWrd.Text;
                string CkWord = "";
                int fltr = 0;
                bool chk = false;
                switch (SrchFltr.Text)
                {
                    case "Номер заказа":
                        fltr = 0;
                        break;
                    case "Название":
                        fltr = 1;
                        break;
                    case "Дата завершения":
                        fltr = 3;
                        break;
                    case "Состояние заказа":
                        fltr = 4;
                        break;
                    case "Дата получения":
                        fltr = 6;
                        break;
                }
                for (int i = 0; i < Orders.Rows.Count; i++)
                {
                    CkWord = Convert.ToString(Orders.Rows[i][fltr]);
                    if (fltr == 4)
                    {
                        switch (Convert.ToInt32(CkWord))
                        {
                            case 0:
                                CkWord = "Принят";
                                break;
                            case 1:
                                CkWord = "Выполняется";
                                break;
                            case 2:
                                CkWord = "Завершен";
                                break;
                        }
                    }
                    for (int k = 0; k < SrchWrd.Text.Length; k++)
                    {
                        if (CkWord[k] == SrWord[k])
                            chk = true;
                        else
                        {
                            chk = false;
                            break;
                        }
                    }
                    if (chk)
                    {
                        PrintDspl(i);
                    }
                }
            }
        }

        private void AllOrdB_Click(object sender, EventArgs e)
        {
            Displ.Text = "";
            for (int i = 0; i < Orders.Rows.Count; i++)
            {
                PrintDspl(i);
            }
        }

        private void NewOrderB_Click(object sender, EventArgs e)
        {
            NewOrder g = new NewOrder();
            g.ShowDialog();
        }

        private void CalcPrice_Click(object sender, EventArgs e)
        {
            PriceCalc g = new PriceCalc();
            g.ShowDialog();
        }

        private void SrvcB_Click(object sender, EventArgs e)
        {
            SvcManager g = new SvcManager();
            g.ShowDialog();
        }

        private void PrintDspl(int i)
        {
            for (int k = 0; k < Orders.Columns.Count; k++)
            {
                switch (k)
                {
                    case 0:
                        {
                            Displ.Text += "Номер заказа: " + Orders.Rows[i][k] + "\n";
                        }
                        break;
                    case 1:
                        {
                            Displ.Text += "Название: " + Orders.Rows[i][k] + "\n";
                        }
                        break;
                    case 2:
                        {
                            Displ.Text += "Описание: " + Orders.Rows[i][k] + "\n";
                        }
                        break;
                    case 3:
                        {
                            Displ.Text += "Дата завершения: " + Orders.Rows[i][k] + "\n";
                        }
                        break;
                    case 4:
                        {
                            string p = "";
                            switch (Convert.ToInt32(Orders.Rows[i][k]))
                            {
                                case 0:
                                    {
                                        p = "Принят";
                                    }
                                    break;
                                case 1:
                                    {
                                        p = "Выполняется";
                                    }
                                    break;
                                case 2:
                                    {
                                        p = "Завершен";
                                    }
                                    break;
                            }
                            Displ.Text += "Состояние заказа: " + p + "\n";
                        }
                        break;
                    case 5:
                        {
                            for (int m = 0; m < Managers.Rows.Count; m++)
                            {
                                if (Convert.ToInt32(Orders.Rows[i][k]) ==
                                    Convert.ToInt32(Managers.Rows[m][0]))
                                {
                                    Displ.Text += "Менеджер: " + Managers.Rows[m][1] +
                                        "\nID Менеджера :" + Managers.Rows[m][0] + "\n";
                                }
                            }
                        }
                        break;
                    case 6:
                        {
                            Displ.Text += "Дата получения заказа: " + Orders.Rows[i][k] + "\n";
                        }
                        break;
                    case 7:
                        {
                            for (int m = 0; m < Clients.Rows.Count; m++)
                            {
                                if (Convert.ToInt32(Orders.Rows[i][k]) ==
                                    Convert.ToInt32(Clients.Rows[m][0]))
                                {
                                    Displ.Text += "Фамилия: " + Clients.Rows[m][1] + "\nИмя: " +
                                        Clients.Rows[m][2] + "\nНомер телефона: " + Clients.Rows[m][4] +
                                        "\nАдрес: " + Clients.Rows[m][5] + "\nСкидка: " +
                                        Clients.Rows[m][6] + "\n";
                                }
                            }
                        }
                        break;
                    case 8:
                        {
                            Displ.Text += "Стоимость: " + Orders.Rows[i][k] + "руб.\n";
                        }
                        break;
                }
            }
            Displ.Text += "_____________________________________\n";
        }
    }
}
