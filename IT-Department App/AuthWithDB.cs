using System.Data.SqlClient;
using System.Data;
using Npgsql;
using System.Drawing;

namespace IT_Department_App
{
    class AuthWithDB
    {
        authWindows authw = new authWindows();

        public void authWithDb()
        {         
            string login = authw.loginBox.Text.Trim();
            string password = authw.passBox.Text.Trim();

            //var login2 = "Nedjad";
            //var pass2 = "sch2114";

            NpgsqlConnectionStringBuilder build = new NpgsqlConnectionStringBuilder
            {
                Host = "localhost",
                Port = 5432,
                Username = "postgres",
                Password = "sch2114",
                Database = "appUsers"
            };

            using (NpgsqlConnection ccon = new NpgsqlConnection(build.ConnectionString))
            {
                try
                {
                    ccon.Open();
                    MessageBox.Show("Connection is successful!");

                    var conString = "SELECT COUNT(*) FROM admin.users WHERE user_login = @login AND user_pass = @password";

                    using (NpgsqlCommand cmd = new NpgsqlCommand(conString, ccon))
                    {
                        cmd.Parameters.AddWithValue("@login", login);
                        cmd.Parameters.AddWithValue("@password", password);

                        try
                        {
                            var count = Convert.ToInt32(cmd.ExecuteScalar());
                            MessageBox.Show(count.ToString());

                            if (count > 0)
                            {

                            }
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message);
                        }
                    }
                }
                catch
                {
                    MessageBox.Show("Connection failed!");
                }


            }


        }
    }
}
