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
    public partial class Clients : Form
    {
        DataTable Clnts;
        string queryClnt = "SELECT * FROM Clients ORDER BY id";
        public Clients()
        {
            InitializeComponent();
            SLDataDB.LoadData(queryClnt, out Clnts);
            dGV1.DataSource = Clnts;
        }

        private void dGV1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void Add_Click(object sender, EventArgs e)
        {
            if (PhoneN.Text != "" && Add.Text != "")
            {
                DataRow row;
                row = Clnts.NewRow();
                row["Id"] = Clnts.Rows.Count + 1;
                row["Фамилия"] = Srnam.Text;
                row["Имя"] = Nam.Text;
                row["Отчество"] = Patrn.Text;
                row["Номер телефона"] = PhoneN.Text;
                row["Адрес"] = Adress.Text;
                row["Скидка, %"] = Discount.Text;
                Clnts.Rows.Add(row);
                SLDataDB.SaveData(queryClnt, Clnts);
                Srnam.Text = "Cохранено.";
                Nam.Text = "";
                Patrn.Text = "";
                PhoneN.Text = "";
                Adress.Text = "";
                Discount.Text = "";
            }
        }

        private void DiscountChngB_Click(object sender, EventArgs e)
        {
            if (IDClient.Text != "" && DiscChng.Text != "")
            {
                for (int i = 0; i < Clnts.Rows.Count; i++)
                {
                    if (Convert.ToInt32(Clnts.Rows[i][0]) == Convert.ToInt32(IDClient.Text))
                    {
                        Clnts.Rows[i][6] = DiscChng.Text;
                        break;
                    }
                }
                SLDataDB.SaveData(queryClnt, Clnts);
            }
        }
    }
}
