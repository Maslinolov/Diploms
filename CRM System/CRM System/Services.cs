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
    public partial class Services : Form
    {

        string queryClnt = "SELECT * FROM Services ORDER BY id";
        DataTable Svcs;

        public Services()
        {            
            InitializeComponent();
            SLDataDB.LoadData(queryClnt, out Svcs);
            dGV1.DataSource = Svcs;
        }

        private void Add_Click(object sender, EventArgs e)
        {
            if (Nam.Text != "")
            {
                DataRow row;
                row = Svcs.NewRow();
                row["Id"] = Svcs.Rows.Count + 1;
                row["Название"] = Nam.Text;
                row["Стоимость"] = Price.Text;
                row["Описание"] = Description.Text;
                Svcs.Rows.Add(row);
                SLDataDB.SaveData(queryClnt, Svcs);
                Description.Text = "Cохранено.";
                Nam.Text = "";
                Price.Text = "";
            }     
        }

        private void DelSvcB_Click(object sender, EventArgs e)
        {
            if (IdSvc.Text != "")
            {
                Svcs.Rows[Convert.ToInt32(IdSvc.Text) - 1].Delete();
                SLDataDB.SaveData(queryClnt, Svcs);
                IdSvc.Text = "Удалено";
            }
        }
    }
}
