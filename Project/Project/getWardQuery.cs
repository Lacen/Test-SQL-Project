using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project
{
    class GetWardQuery : Query
    {
        private string name;
        private string capacity;
        private string count;
        private string capacityRelation;
        private string countRelation;

        /**
         * Constructor
         **/
        public GetWardQuery(string name, string capacity, string count, string capacityRelation,
            string countRelation)
        {
            this.name = name;
            this.capacity = capacity;
            this.count = count;
            this.capacityRelation = capacityRelation;
            this.countRelation = countRelation;
        }

        /**
         * Checks whether or not the GetWard Query object can perform a successful query, by
         * making sure all of the data types are of the proper form
         * @return bool, true if the query can be performed successfully (inputs are of the proper
         * data type), false otherwise
         **/
        public override bool validate()
        {
            int n;
            if (capacity != "" && !int.TryParse(capacity, out n))
            {
                return false;
            }
            else if (count != "" && !int.TryParse(count, out n))
            {
                return false;
            }
            return true;
        }

        /**
         * Creates the query resulting from the respective GetWardQuery object
         * @return string, the string SQL query
         **/
        public override string getQuery(bool andSelected)
        {
            int cnt = 0;
            
            // Find out whether "AND" or "OR" is selected
            string and = " or ";
            if (andSelected)
            {
                and = " and ";
            }

            string nameString = getNameStatement(cnt, name, "WardName", and);
            if (nameString.StartsWith("where"))
            {
                cnt++;
            }

            string capacityString = getCapacityStatement(cnt, capacity, "MaxCapacity", capacityRelation, and);
            if (capacityString.StartsWith("where"))
            {
                cnt++;
            }

            string countString = getCapacityStatement(cnt, count, "CurrentCapacity", countRelation, and);

            return "select * from Wards " + nameString + capacityString + countString;
        }

        /**
         * A variation of the previous method getStatement() that also checks whether or not the str
         * should be greater than, less than, or equal to the inputted field
         * @param count, the counter that tells whether or not we should precede the statement with "where"
         * or with "and"
         * @param str, the match that the query must satisfy
         * @param field, the field that the must match str
         * @param relation, the relationship between str and field
         * @return string, the next part of the SQL query
         **/
        private string getCapacityStatement(int count, string str, string field, string relation, string and)
        {
            if (str != "")
            {
                if (count == 0)
                {
                    return "where " + field + " " + relation + " '" + str + "'";
                }
                else
                {
                    return and + field + " " + relation + " '" + str + "'";
                }
            }
            return "";
        }
    }
}
