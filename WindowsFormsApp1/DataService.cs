using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    class DataService
    {
        SqlConnectionStringBuilder builder = new SqlConnectionStringBuilder();

        public DataService()
        {
            builder.DataSource = "conceptserv.database.windows.net";
            builder.UserID = "sysadm";
            builder.Password = "Password42";
            builder.InitialCatalog = "conceptDB";
        }

        public bool ValidLogin(string userName)
        {
            bool result = false;
            try
            {
                using (SqlConnection connection = new SqlConnection(builder.ConnectionString))
                {
                    String sql = "SELECT * FROM USERS WHERE userName = '" + userName + "'";

                    using (SqlCommand command = new SqlCommand(sql, connection))
                    {
                        connection.Open();
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.HasRows)
                            {
                                result = true;
                            }
                        }
                    }
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.ToString());
            }

            return result;
        }

        public void AddData(string column, string data)
        {
            
        }

        public List<object> GetData(string query)
        {
            List<object> result = new List<object>();

            try
            {
                using (SqlConnection connection = new SqlConnection(builder.ConnectionString))
                {
                    string sql = query;

                    using (SqlCommand command = new SqlCommand(sql, connection))
                    {
                        connection.Open();
                        using (SqlDataReader rdr = command.ExecuteReader())
                        {
                            while (rdr.Read())
                            {
                                if (rdr.HasRows)
                                {
                                    for(int i = 0; i < rdr.FieldCount; i++)
                                    {
                                        result.Add(rdr[i]);
                                    }
                                }
                                else
                                {
                                    return null;
                                }
                            }
                        }
                    }
                }
            }
            catch (SqlException ex)
            {
                Console.WriteLine(ex.ToString());
            }

            return result;
        }
    }
}
