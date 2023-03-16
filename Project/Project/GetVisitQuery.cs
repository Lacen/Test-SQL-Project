using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project
{
    class GetVisitQuery : Query
    {
        private string doctorID;
        private string registrationID;
        private string year;
        private string month;
        private string date;
        private string yearRelation;

        /**
         * Constructor
         * @param doctorID, the ID of the doctor
         * @param registrationID, the ID of the registration
         * @param year, the year that the visit happened
         * @param month, the month that the visit happened
         * @param date, the date that the visit heppened
         * @param yearRelation, the year's relationship to the attribute
         **/
        public GetVisitQuery(string doctorID, string registrationID, string year, string month, string date,
            string yearRelation)
        {
            this.date = date;
            this.month = month;
            this.year = year;
            this.registrationID = registrationID;
            this.doctorID = doctorID;
            this.yearRelation = yearRelation;
        }
        
        /**
         * Creates the query resulting from the respective GetVisitQuery object
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

            string doctorIDString = getStatement(count, doctorID, "DoctorID", and);
            if (doctorIDString.StartsWith("where"))
            {
                count++;
            }

            string registrationIDString = getStatement(count, registrationID, "RegistrationID", and);
            if (registrationIDString.StartsWith("where"))
            {
                count++;
            }

            string dateString = getDateStatement(count, year, month, date, "DoctorID", yearRelation, and);

            return "select * from Visits " + doctorIDString + registrationIDString + dateString;
        }

        /**
         * Checks whether or not the  GetVisitQuery object can perform a successful query, by
         * making sure all of the data types are of the proper form
         * @return bool, true if the query can be performed successfully (inputs are of the proper
         * data type), false otherwise
         **/
        public override bool validate()
        {
            int n;
            if (date != "" && !int.TryParse(date, out n))
            {
                return false;
            }
            else if (month != "" && !int.TryParse(month, out n))
            {
                return false;
            }
            else if (year != "" && !int.TryParse(year, out n))
            {
                return false;
            }
            else if (registrationID != "" && !int.TryParse(registrationID, out n))
            {
                return false;
            }
            else if (doctorID != "" && !int.TryParse(doctorID, out n))
            {
                return false;
            }
            return true;
        }   
    }
}
