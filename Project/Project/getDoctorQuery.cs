using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project
{
    class GetDoctorQuery : Query
    {
        private string ID;
        private string firstName;
        private string lastName;
        private string dateOfHire;
        private string monthOfHire;
        private string yearOfHire;
        private string salary;
        private string salaryRelation;
        private string yearRelation;

        /**
         * Constructor
         * @param ID, the doctor's ID
         * @param firstName, the doctor's first name
         * @param lastName, the doctor's last name
         * @param dateOfHire, the doctor's date of hire
         * @param monthOfHire, the doctor's month of hire
         * @param yearOfHire, the doctor's year of hire
         * @param salary, the doctor's salary
         * @param salaryRelation, the salary relationship (e.g. >, <, =)
         * @param yearRelation, the year relationship (e.g. >, <, =)
         **/
        public GetDoctorQuery(string ID, string firstName, string lastName, string dateOfHire,
            string monthOfHire, string yearOfHire, string salary, string salaryRelation, string yearRelation)
        {
            this.ID = ID;
            this.firstName = firstName;
            this.lastName = lastName;
            this.dateOfHire = dateOfHire;
            this.monthOfHire = monthOfHire;
            this.yearOfHire = yearOfHire;
            this.salary = salary;
            this.salaryRelation = salaryRelation;
            this.yearRelation = yearRelation;
        }

        /**
         * Creates the query resulting from the respective getDoctorQuery object
         * @return string, the string SQL query
         **/
        public override string getQuery(bool andSelected)
        {
            int count = 0;

            // Find out whether "AND" or "OR" is selected
            string and = " or ";
            if (andSelected)
            {
                and = " and ";
            }

            string idString = getStatement(count, ID, "DoctorID", and);
            if (idString.StartsWith("where"))
            {
                count++;
            }

            string firstNameString = getNameStatement(count, firstName, "firstname", and);
            if (firstNameString.StartsWith("where"))
            {
                count++;
            }

            string lastNameString = getNameStatement(count, lastName, "lastname", and);
            if (lastNameString.StartsWith("where"))
            {
                count++;
            }

            string dateOfHireString = getDateStatement(count, yearOfHire, monthOfHire,
                dateOfHire, "HireDate", yearRelation, and);
            if (dateOfHireString.StartsWith("where"))
            {
                count++;
            }

            string salaryString = getSalaryStatement(count, salary, "salary", and);

            return "select * from Doctors " + idString + firstNameString + lastNameString + dateOfHireString + salaryString;
        }

        /**
         * A variation of the previous method getStatement() that also checks whether or not the salary
         * should be greater than, less than, or equal to the inputted salary
         * @param count, the counter that tells whether or not we should precede the statement with "where"
         * or with "and"
         * @param str, the match that the query must satisfy
         * @param field, the field that the must match str
         * @return string, the next part of the SQL query
         **/
        private string getSalaryStatement(int count, string str, string field, string and)
        {
            if (str != "")
            {
                if (count == 0)
                {
                    return "where " + field + " " + salaryRelation + " '" + str + "'";
                }
                else
                {
                    return and + field + " " + salaryRelation + " '" + str + "'";
                }
            }

            return "";
        }

        /**
         * Checks whether or not the getDoctorQuery object can perform a successful query, by
         * making sure all of the data types are of the proper form
         * @return bool, true if the query can be performed successfully (inputs are of the proper
         * data type), false otherwise
         **/
        public override bool validate()
        {
            int n;

            if (ID != "" && !int.TryParse(ID, out n))
            {
                return false;
            }
            else if (dateOfHire != "" && !int.TryParse(dateOfHire, out n))
            {
                return false;
            }
            else if (monthOfHire != "" && !int.TryParse(monthOfHire, out n))
            {
                return false;
            }
            else if (yearOfHire != "" && !int.TryParse(yearOfHire, out n))
            {
                return false;
            }
            else if (salary != "" && !int.TryParse(salary, out n))
            {
                return false;
            }
            return true;
        }

    }
}
