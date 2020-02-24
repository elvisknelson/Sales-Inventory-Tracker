using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ConceptApp
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

        public DataTable SearchBins(string startDate, string endDate)
        {
            DataTable dt = new DataTable();
            using (SqlConnection con = new SqlConnection(builder.ConnectionString))
            {
                using (SqlCommand cmd = new SqlCommand("SELECT Sales_Order AS 'Sales #', Customer, Estimated_Hours AS 'Estimated Hours'," +
                    "Actual_Hours AS 'Actual Hours', Promise_Date AS 'Promise Date' FROM SALES WHERE Promise_Date BETWEEN '" + startDate + "' AND '" + endDate + "'", con))
                {
                    cmd.CommandType = CommandType.Text;
                    con.Open();
                    dt.Load(cmd.ExecuteReader());
                    con.Close();
                }
            }
            return dt;
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

        public DataTable GetDataTable(string query)
        {
            DataTable dt = new DataTable();
            using (SqlConnection con = new SqlConnection(builder.ConnectionString))
            {
                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    cmd.CommandType = CommandType.Text;
                    con.Open();
                    dt.Load(cmd.ExecuteReader());
                    con.Close();
                }
            }
            return dt;
        }

        public object GetSingleValue(string query)
        {
            object result = null;

            try
            {
                using (SqlConnection connection = new SqlConnection(builder.ConnectionString))
                {
                    connection.Open();
                    string sql = query;
                    using (SqlCommand cmd = new SqlCommand(sql, connection))
                    {
                        SqlDataReader reader = cmd.ExecuteReader();

                        while(reader.Read())
                        {
                            if(reader.HasRows)
                            {
                                result = reader.GetValue(0);
                            }
                        }
                    }
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }

            return result;
        }
    }
}
