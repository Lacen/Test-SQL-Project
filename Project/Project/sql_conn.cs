using System.Data.SqlClient;
using System.IO;

namespace Project
{
    internal class sql_conn
    {
        private SqlConnection cnn;
        private string connectionString;

        /**
         *  Constructor
         **/
        public sql_conn(string server)
        {
            string serverName;
            using (var fileStream = new FileStream(server, FileMode.Open, FileAccess.Read))
            {
                using (StreamReader reader = new StreamReader(fileStream))
                {
                    serverName = reader.ReadToEnd();
                }
            }

            connectionString = @"Data Source =" + serverName + "; Initial Catalog = cmpt291_project; Integrated Security = True";
            cnn = new SqlConnection(connectionString);
            cnn.Open();
        }

        /**
         * Getter for the SqlConnection instance variable
         * @return SqlConnection, the SqlConnection instance variable
         **/
        public SqlConnection get_sql_conn()
        {
            return cnn;
        }

        /**
         * Queries the SQL connection
         * @return SqlDataReader, the data reader for the query
         **/
        public SqlDataReader query(string str)
        {
            SqlDataReader dataReader;
            SqlCommand command = new SqlCommand(str, this.get_sql_conn());
            dataReader = command.ExecuteReader();
            return dataReader;
        }

        /**
         * Closes the SqlConnection
         **/
        public void close()
        {
            this.get_sql_conn().Close();
        }

    }
}
