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
    public partial class ChangePassword : Form
    {
        string queryOrd = "SELECT * FROM Admins ORDER BY id";
        DataTable Admins;

        public ChangePassword()
        {
            InitializeComponent();
            SLDataDB.LoadData(queryOrd, out Admins);
        }


        private void SaveB_Click(object sender, EventArgs e)
        {
            if (Lgn.Text != "" && NewPass.Text != "")
            {
                string pass = NewPass.Text;
                string ps = "";
                for (int i = 0; i < pass.Length; i++)
                {
                    ps += (char)(pass[i] ^ 'k');
                }
                if (Lgn.Text != "" && NewPass.Text != "")
                {
                    switch (Lgn.Text)
                    {
                        case "Начальник отдела":
                            {
                                Admins.Rows[1][2] = ps;
                            }
                            break;
                        case "Администратор":
                            {
                                Admins.Rows[0][2] = ps;
                            }
                            break;
                    }
                    SLDataDB.SaveData(queryOrd, Admins);
                    NewPass.Text = "Сохранено";
                }
            }
        }
    }
}
