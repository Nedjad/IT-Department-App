using System.Data.SqlClient;
using System.Data;
using Npgsql;
using System.Drawing;

namespace IT_Department_App
{
    class AuthWithDB
    {
        public void authWithDb(string login, string password)
        {         
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

                    var conString = "SELECT COUNT(*) FROM admin.users WHERE user_login = @login AND user_pass = @password";

                    using (NpgsqlCommand cmd = new NpgsqlCommand(conString, ccon))
                    {
                        cmd.Parameters.AddWithValue("@login", login);
                        cmd.Parameters.AddWithValue("@password", password);

                        try
                        {
                            var count = Convert.ToInt32(cmd.ExecuteScalar());

                            if (count > 0)
                            {
                                workSozWindow workSozWindow = new workSozWindow();
                                workSozWindow.Show();
                                
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
