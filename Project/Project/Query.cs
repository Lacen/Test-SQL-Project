using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project
{
    class Query
    {
        /** 
         * Gets the next part of the SQL query for the childrens' getQuery() functions
         * @param count, the counter that tells whether or not we should precede the statement with "where"
         * or with "and"
         * @param str, the match that the query must satisfy
         * @param field, the field that the must match str
         * @return string, the next part of the SQL query
         **/
        protected string getStatement(int count, string str, string field, string and)
        {
            if (str != "")
            {
                if (count == 0)
                {
                    return "where " + field + " = '" + str + "'";
                }
                else
                {
                    return and + field + " = '" + str + "'";
                }
            }

            return "";
        }

    /** 
     * Gets the next part of the SQL query for the childrens' getQuery() functions, but this function is used
     * for getting the first or last name portion of the sql query
     * @param count, the counter that tells whether or not we should precede the statement with "where"
     * or with "and"
     * @param str, the match that the query must satisfy
     * @param field, the field that the must match str
     * @return string, the next part of the SQL query
    **/
        protected string getNameStatement(int count, string str, string field, string and)
        {
            if (str != "")
            {
                if (count == 0)
                {
                    return "where " + field + " like '%" + str + "%'";
                }
                else
                {
                    return and + field + " like '%" + str + "%'";
                }
            }

            return "";
        }

    /** 
     * Gets the next part of the SQL query for the childrens' getQuery() functions, but this function is used
     * for getting the date portion of the sql query
     * @param count, the counter that tells whether or not we should precede the statement with "where"
     * or with "and"
     * @param year, the year that the query must satisfy
     * @param field, the field that the must match str
     * @return string, the next part of the SQL query
    **/
        protected string getDateStatement(int count, string year, string month, string day, string field, 
            string yearRelation, string and)
        {
            // If none of year, month, and day were inputted, the user is not searching by year
            if (year == "" && month == "" && day == "")
            {
                return "";
            }

            // Parse the day - it should be 2 chars long
            if (day != "")
            {
                day = day.PadLeft(2, '0');
            }
            if (day == "")
            {
                day = "%";
            }

            // Parse the month - it should be 2 chars long
            if (month != "")
            {
                month = month.PadLeft(2, '0');
            }
            if (month == "")
            {
                month = "%";
            }

            // Parse the year - it should be 4 chars long
            if (year != "")
            {
                year = year.PadLeft(4, '0');
            }
            if (year == "")
            {
                year = "%";
            }

            // Get the proper year relationship
            if (yearRelation == "=")
            {
                // If yearRelation == "=", then we want to search by keyword
                yearRelation = " like ";
            }
            else
            {
                if (year == "%" || month == "%" || day == "%")
                    // In this case, no year, month, or day was specified and we are using a year relation of
                    // >, <, <=, or >= and these can only be used if a full date is specified. So, we send an
                    // error message saying that the full date must be specified
                {
                    MessageBox.Show("When specifying a relationship other than '=', month, date, and year must" +
                        " all be specified.");
                    return "";
                }
            }

            string str = "'" + year + "-" + month + "-" + day + "' ";
            if (count == 0)
            {
                return "where " + field + yearRelation + str;
            }
            else
            {
                return and + field + yearRelation + str;
            }
        }

        /**
         * Function that returns a valid SQL query. Child classes should override this.
         * @return string, the SQL query
         **/
        public virtual string getQuery(bool andSelected)
        {
            return "";
        }

        /**
         * Tests to ensure that the argument string has no special characters
         * @return bool, true if the argument string has no special characters, false otherwise
         **/
        public bool hasSpecialChars(String str)
        {
            Regex tester = new Regex("^[a-zA-Z0-9 ]*$");
            return tester.IsMatch(str);
        }

        /**
         * A hook method that determines if a query is valid to perform
         **/
        public virtual bool validate()
        {
            return true;
        }

        
    }
}
