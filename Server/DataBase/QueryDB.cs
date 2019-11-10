using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Server.DataBase
{
    public class QueryDB
    {
        private static SqlConnection connection;

        public static SqlDataReader Send(ViewDBEnum viewDB)
        {
            String conStr = ConfigurationManager.ConnectionStrings["DB"].ConnectionString;
            connection = new SqlConnection(conStr);
            try
            {
                connection.Open();
            }
            catch
            {
                //throw new Exception(ex.Message);
                return null;
            }

            var command = new SqlCommand();
            command.Connection = connection;
            command.CommandText = $"SELECT * FROM {viewDB.ToString()};";

            SqlDataReader SDReader = null;

            try
            {
                SDReader = command.ExecuteReader();
            }
            catch
            {
                //throw new Exception(ex.Message);
                return null;
            }
            command.Cancel();
            return SDReader;
        }
    }
}
