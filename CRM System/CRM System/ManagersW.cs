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
    public partial class ManagersW : Form
    {
        string queryMng = "SELECT * FROM Managers ORDER BY id";
        DataTable MngrsIsh, Mng;
        public ManagersW()
        {
            InitializeComponent();
            SLDataDB.LoadData(queryMng, out MngrsIsh);
            Mng = MngrsIsh.Copy();
            UnXor();           
        }

        private void AddB_Click(object sender, EventArgs e)
        {
            if (SrNam.Text != "" && Nam.Text != "" && Pass.Text != "")
            {
                DataRow row;
                string pass = "";
                row = MngrsIsh.NewRow();
                row["Id"] = MngrsIsh.Rows.Count + 1;
                row["Surname"] = SrNam.Text;
                row["Name"] = Nm.Text;
                for (int i = 0; i < Pass.Text.Length; i++)
                    pass += (char)(Pass.Text[i] ^ 'k');
                row["Pass"] = pass;
                MngrsIsh.Rows.Add(row);
                SLDataDB.SaveData(queryMng, MngrsIsh);
                SrNam.Text = "Cохранено.";
                Nm.Text = "";
                Pass.Text = "";
                Mng = MngrsIsh.Copy();
                UnXor();
            }
        }

        private void DelB_Click(object sender, EventArgs e)
        {
            if (MangrN.Text != "")
            {
                MngrsIsh.Rows[Convert.ToInt32(MangrN.Text)].Delete();
                SLDataDB.SaveData(queryMng, MngrsIsh);
                MangrN.Text = "Удалено";
            }
        }

        private void UnXor()
        {
            for (int i = 0; i < Mng.Rows.Count; i++)
            {
                string ps = "", nps = "";
                ps = Convert.ToString(Mng.Rows[i][3]);
                for (int k = 0; k < ps.Length; k++)
                {
                    if (ps[k] != ' ')
                        nps += (char)(ps[k] ^ 'k');
                    else
                        break;
                }
                Mng.Rows[i][3] = nps;
            }
            dGV1.DataSource = Mng;
        }
    }
}
