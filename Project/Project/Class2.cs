using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project
{
    class Globals
    {
        public static sql_conn database = new sql_conn("C:\\Users\\Samuel\\Desktop\\server.txt");

        /**
         * Gets data from the SQL database in order to populate the grid view
         * @return DataTable, the data table to populate the bottom grid view with
         **/
        public static DataTable GetData(string sqlCommand)
        {
            SqlCommand command = new SqlCommand(sqlCommand, database.get_sql_conn());

            SqlDataAdapter adapter = new SqlDataAdapter();
            adapter.SelectCommand = command;

            DataTable table = new DataTable();
            adapter.Fill(table);

            return table;
        }

        /**
         * Checks radio buttons for ==, <=, >=, <, and > selection and returns an appropriate string
         * to generate the SQL statement
         **/
        public static string getRelation(RadioButton gt, RadioButton lt, RadioButton ge,
            RadioButton le)
        {
            if (gt.Checked)
            {
                return ">";
            }
            else if (lt.Checked)
            {
                return "<";
            }
            else if (ge.Checked)
            {
                return ">=";
            }
            else if (le.Checked)
            {
                return "<=";
            }
            return "=";
        }

        /**
         * Raises an error upon invalid input of search criteria
         **/
        public static void raiseError()
        {
            MessageBox.Show("Error: Some inputs are not of the proper type." +
                    "\nNote that dates must be in numeric format");
        }
    }
}
