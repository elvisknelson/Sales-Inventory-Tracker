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
        private SqlConnectionStringBuilder _builder = new SqlConnectionStringBuilder();

        /// <summary>
        /// DataService Constructor
        /// </summary>
        public DataService()
        {
            _builder.DataSource = "conceptserv.database.windows.net";
            _builder.UserID = "sysadm";
            _builder.Password = "Password42";
            _builder.InitialCatalog = "conceptDB";
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="startDate"></param>
        /// <param name="endDate"></param>
        /// <returns></returns>
        public DataTable SearchBins(string startDate, string endDate)
        {
            DataTable dt = new DataTable();
            using (SqlConnection con = new SqlConnection(_builder.ConnectionString))
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

        /// <summary>
        /// Returns true or false based on the username passed in
        /// </summary>
        /// <param name="userName"></param>
        /// <returns></returns>
        public bool ValidLogin(string userName)
        {
            bool result = false;
            try
            {
                using (SqlConnection connection = new SqlConnection(_builder.ConnectionString))
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

        /// <summary>
        /// Retrives data from the Azure database based on the Query passedin and returns a Datatable
        /// </summary>
        /// <param name="query"></param>
        /// <returns></returns>
        public DataTable GetDataTable(string query)
        {
            DataTable dt = new DataTable();
            using (SqlConnection con = new SqlConnection(_builder.ConnectionString))
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

        /// <summary>
        /// Retrives and returns a single value based on the query passed in
        /// </summary>
        /// <param name="query"></param>
        /// <returns></returns>
        public object GetSingleValue(string query)
        {
            object result = null;

            try
            {
                using (SqlConnection connection = new SqlConnection(_builder.ConnectionString))
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

        /// <summary>
        /// Adds data to the Azure database dynamically
        /// </summary>
        /// <param name="table"></param>
        /// <param name="pars"></param>
        public void AddData(string table, params SqlParam[] pars)
        {
            string sql = "INSERT INTO " + table;
            string sqlValues = "";
            string sqlParams = "";
            string comma = "(";
            int index = 1;

            foreach (SqlParam par in pars)
            {
                sqlValues += comma + par.column;
                sqlParams += comma + "@param" + index++;
                comma = ",";
            }

            sqlValues += ") VALUES ";
            sqlParams += ")";

            sql += sqlValues + sqlParams;
            
            try
            {
                using (SqlConnection connection = new SqlConnection(_builder.ConnectionString))
                {
                    connection.Open();
                    using (SqlCommand cmd = new SqlCommand(sql, connection))
                    {
                        index = 1;
                        foreach (SqlParam par in pars)
                        {
                            cmd.Parameters.Add("@param" + index++, par.type).Value = par.value;
                        }

                        cmd.CommandType = CommandType.Text;
                        cmd.ExecuteNonQuery();
                    }
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.ToString());
            }
            
        }
    }
}
