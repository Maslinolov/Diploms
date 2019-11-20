using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace CRM_System
{
    class SLDataDB
    {
        static string connectString = Properties.Settings.Default.ConnectionString;

        public static void LoadData(string query, out DataTable Table)
        {           
            SqlConnection Conn = new SqlConnection(connectString);
            Table = new DataTable();
            Conn.Open();
            SqlDataAdapter adapter = new SqlDataAdapter();
            adapter.SelectCommand = new SqlCommand(query, Conn);
            SqlCommandBuilder builder = new SqlCommandBuilder(adapter);
            adapter.Fill(Table);
            Table.AcceptChanges();
            Conn.Close();
        }

        public static void SaveData(string query, DataTable Table)
        {
            SqlConnection Conn = new SqlConnection(connectString);
            Conn.Open();
            SqlDataAdapter adapter = new SqlDataAdapter();
            adapter.SelectCommand = new SqlCommand(query, Conn);
            SqlCommandBuilder builder = new SqlCommandBuilder(adapter);
            builder.GetUpdateCommand();
            adapter.Update(Table);
            Table.AcceptChanges();
            Conn.Close();
        }
    }
}
