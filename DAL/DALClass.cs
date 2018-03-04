using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public static class DALClass
    {
        static SqlConnection con = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=Assignment;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=True;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");

        /// <summary>
        /// Method to get list of all designations.
        /// </summary>
        /// <returns>Data table</returns>
        public static DataTable GetAllDesignation()
        {
            DataTable dt = new DataTable();
            dt = ExecuteQuery(Constants.GetAllDesignation);

            return dt;
        }

        /// <summary>
        /// Method to get list of all employment status
        /// </summary>
        /// <returns>Data table</returns>
        public static DataTable GetAllEmploymentStatus()
        {
            DataTable dt = new DataTable();
            dt = ExecuteQuery(Constants.GetAllEmploymentStatus);

            return dt;
        }

        /// <summary>
        /// Method to execute query.
        /// </summary>
        /// <param name="query">Stored procedure name</param>
        /// <param name="parameterList">List of paramaters</param>
        /// <returns>Data table</returns>
        public static DataTable ExecuteQuery(string query, List<SqlParameter> parameterList = null)
        {
            DataTable dt = new DataTable();

            using (SqlCommand cmd = new SqlCommand(query, con))
            {
                if (parameterList != null)
                {
                    foreach (var parameter in parameterList)
                    {
                        cmd.Parameters.Add(parameter);
                    }

                    cmd.CommandType = CommandType.StoredProcedure;
                }

                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                sda.Fill(dt);
            }

            return dt;
        }
    }
}
