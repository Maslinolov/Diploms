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
    public partial class SvcManager : Form
    {
        DataTable Svcs;
        string queryClnt = "SELECT * FROM Services ORDER BY id";
        public SvcManager()
        {
            InitializeComponent();
            SLDataDB.LoadData(queryClnt, out Svcs);
            dataGridView1.DataSource = Svcs;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }       
      
    }
}
