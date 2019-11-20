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
    public partial class Authorization : Form
    {
        public static int MngID = 0;
        public Authorization()
        {
            InitializeComponent();
        }

        private void Auth_Click(object sender, EventArgs e)
        {
             if (Log.Text != "")
             {
                 DataTable Table = new DataTable();
                 if (Log.Text == "Администратор" || Log.Text == "Начальник отдела")
                 {                    
                     string pss;
                     string query = "SELECT * FROM Admins ORDER BY id";
                     string chkpas = Pass.Text;
                     SLDataDB.LoadData(query, out Table);
                     int p;
                     bool chk = false;
                     switch (Log.Text)
                     {
                         case "Администратор":
                             {
                                 p = 0;
                                 pss = Convert.ToString(Table.Rows[p][2]);
                                 PasCheck(chkpas, pss, out chk);
                                 if (chk)
                                 {
                                     this.Hide();
                                     Admin g = new Admin();
                                     g.ShowDialog();
                                     this.Close();
                                 }
                             }
                             break;
                         case "Начальник отдела":
                             {
                                 p = 1;
                                 pss = Convert.ToString(Table.Rows[p][2]);
                                 PasCheck(chkpas, pss, out chk);
                                 if (chk)
                                 {
                                     this.Hide();
                                     Head_of_Dep g = new Head_of_Dep();
                                     g.ShowDialog();
                                     this.Close();
                                 }
                             }
                             break;
                     }
                 }
                 else
                 {
                    if (Log.Text != "")
                    {
                        string pss = "";
                        string query = "SELECT * FROM Managers ORDER BY Id";
                        string chkpas = Pass.Text;
                        SLDataDB.LoadData(query, out Table);                       
                        bool chk = false;
                        int p = 0;
                        for (int i = 0; i < Table.Rows.Count; i++)
                        {
                            string LT = Log.Text;
                            string BDSrnm = Convert.ToString(Table.Rows[i][1]);
                            for (int k = 0; k < LT.Length; k++)
                            {
                                if (LT[k] == BDSrnm[k])
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
                                pss = Convert.ToString(Table.Rows[i][3]);
                                p = i;
                                break;                            
                            }
                        }  
                        if(chk == false)
                        {
                            WrongPass g = new WrongPass();
                            g.ShowDialog();
                        } 
                        if(chk)
                            PasCheck(chkpas, pss, out chk); ;
                        if (chk)
                        {
                            MngID = Convert.ToInt32(Table.Rows[p][0]);                            
                            this.Hide();
                            Manager g = new Manager();
                            g.ShowDialog();
                            this.Close();
                        }
                    }
                 }
             }         
        }


        private void PasCheck(string chkpas, string pss, out bool chk)
        {
            chk = false;  
            if (chkpas == "")
            {
                WrongPass g = new WrongPass();
                g.ShowDialog();
            }            
            for (int i = 0; i < pss.Length; i++)
            {
                if (pss[i] != ' ')
                {
                    if (i < chkpas.Length)
                    {
                        if (chkpas[i] == ((char)(pss[i] ^ 'k')))
                            chk = true;
                        else
                        {
                            chk = false;
                            WrongPass g = new WrongPass();
                            g.ShowDialog();
                            break;
                        }
                    }
                    else
                    {
                        WrongPass g = new WrongPass();
                        g.ShowDialog();
                        chk = false;
                        break;
                    }
                }
                else
                    break;
            }
        }
    }
}
