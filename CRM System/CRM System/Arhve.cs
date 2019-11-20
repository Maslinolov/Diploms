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
    public partial class Arhve : Form
    {
        DataTable Archive;
        string queryArch = "SELECT * FROM ArchiveOrders ORDER BY id";
        
        public Arhve()
        {
            InitializeComponent();
            SLDataDB.LoadData(queryArch, out Archive);
            dGV1.DataSource = Archive;
        }

        private void dGV1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }
    }
}
