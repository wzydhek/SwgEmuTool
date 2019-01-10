using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace SwgEmuTool
{
    public static class db
    {
        public static SqlConnection GetConn()
        {
            SqlConnection conn = new SqlConnection("Server=localhost;Database=swgemu;Trusted_Connection=True;");
            conn.Open();
            return conn;
        }

        public static DataTable GetDataTable(string query, CommandType type, Dictionary<string, object> parms)
        {
            DataTable result = new DataTable();
            SqlConnection conn = GetConn();
            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.CommandType = type;
            if (parms != null && parms.Count > 0)
            {
                foreach (string key in parms.Keys)
                {
                    cmd.Parameters.AddWithValue(key, parms[key]);
                }
            }
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            sda.Fill(result);
            conn.Close();
            return result;
        }

        public static void ExecuteNonQuery(string query, CommandType type, Dictionary<string, object> parms)
        {
            SqlConnection conn = GetConn();
            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.CommandType = type;
            if (parms != null && parms.Count > 0)
            {
                foreach (string key in parms.Keys)
                {
                    cmd.Parameters.AddWithValue(key, parms[key]);
                }
            }
            cmd.ExecuteNonQuery();
            conn.Close();
        }

        public static int ExecuteScalar(string query, CommandType type, Dictionary<string, object> parms)
        {
            SqlConnection conn = GetConn();
            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.CommandType = type;
            if (parms != null && parms.Count > 0)
            {
                foreach (string key in parms.Keys)
                {
                    cmd.Parameters.AddWithValue(key, parms[key]);
                }
            }
            var result = cmd.ExecuteScalar();
            conn.Close();
            return (int)(decimal)result;
        }

        public static int ExecuteScalarI(string query, CommandType type, Dictionary<string, object> parms)
        {
            SqlConnection conn = GetConn();
            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.CommandType = type;
            if (parms != null && parms.Count > 0)
            {
                foreach (string key in parms.Keys)
                {
                    cmd.Parameters.AddWithValue(key, parms[key]);
                }
            }
            var result = cmd.ExecuteScalar();
            conn.Close();
            if (result == null)
                return -1;
            return (int)result;
        }

        public static string ExecuteScalarS(string query, CommandType type, Dictionary<string, object> parms)
        {
            SqlConnection conn = GetConn();
            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.CommandType = type;
            if (parms != null && parms.Count > 0)
            {
                foreach (string key in parms.Keys)
                {
                    cmd.Parameters.AddWithValue(key, parms[key]);
                }
            }
            var result = cmd.ExecuteScalar();
            conn.Close();
            return (string)result;
        }
    }
}
