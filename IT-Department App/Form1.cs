using Microsoft.VisualBasic.Logging;
using Npgsql;
using System.Data;

namespace IT_Department_App
{
    public partial class authWindows : Form
    {
        
        public authWindows()
        {
            InitializeComponent();      
        }


        private void enterButon_Click(object sender, EventArgs e)
        {
            //AuthWithDB authWithDB = new AuthWithDB();
            //authWithDB.authWithDb(loginBox.Text, passBox.Text);
            //this.Hide();
            NpgsqlConnectionStringBuilder build = new NpgsqlConnectionStringBuilder()
            {
                Host = "localhost",
                Port = 5432,
                Username = "postgres",
                Password = "sch2114",
                Database = "appUsers"
            };

            using (NpgsqlConnection conn = new NpgsqlConnection(build.ConnectionString))
            {
                conn.Open();

                var connSrt = "SELECT * FROM admin.users";
                using (NpgsqlCommand com = new NpgsqlCommand(connSrt,conn))
                {
                    


                    DataTable dataTable = new DataTable();

                    foreach (var dr in com.ExecuteReader())
                    {
                        MessageBox.Show(dr.ToString());
                    }
                }
            }

        }
    }

}