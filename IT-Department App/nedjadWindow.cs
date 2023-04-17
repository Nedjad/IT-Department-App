using Npgsql;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IT_Department_App
{
    public partial class workSozWindow : Form
    {
        public workSozWindow()
        {
            InitializeComponent();           
        }       
        
        //static void techBaseFill()
        //{
        //    NpgsqlConnectionStringBuilder build = new NpgsqlConnectionStringBuilder()
        //    {
        //        Host = "localhost",
        //        Port = 5432,
        //        Username = "postgres",
        //        Password = "sch2114",
        //        Database = "appUsers"
        //    };

        //    using (NpgsqlConnection conn = new NpgsqlConnection(build.ConnectionString))
        //    {
        //        conn.Open();

        //        var connSrt = "SELECT * FROM admin.users";
        //        using (NpgsqlCommand com = new NpgsqlCommand(connSrt))
        //        {
        //            com.ExecuteReader();


        //            DataTable dataTable = new DataTable();

        //            foreach (DataRow dr in com.ExecuteReader())
        //            {
        //                MessageBox.Show(dr.Table.ToString());
        //            }
        //        }
        //    }
        //}
    }
}
