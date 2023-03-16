using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project
{
    class GetPatientQuery : Query
    {
        private string ID;
        private string firstName;
        private string lastName;
        private string DOB;
        private string MOB;
        private string YOB;
        private string gender;
        private string yearRelation;

        /**
         * Constructor
         **/
        public GetPatientQuery(string ID, string firstName, string lastName, string DOB, string MOB, 
            string YOB, string gender, string yearRelation)
        {
            this.ID = ID;
            this.firstName = firstName;
            this.lastName = lastName;
            this.DOB = DOB;
            this.MOB = MOB;
            this.YOB = YOB;
            this.gender = gender;
            this.yearRelation = yearRelation;
        }

        /**
         * Checks whether or not the  GetPatientQuery object can perform a successful query, by
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
            else if (DOB != "" && !int.TryParse(DOB, out n))
            {
                return false;
            }
            else if (MOB != "" && !int.TryParse(MOB, out n))
            {
                return false;
            }
            else if (YOB != "" && !int.TryParse(YOB, out n))
            {
                return false;
            }
            return true;
        }

        /**
         * Creates the query resulting from the respective GetPatientQuery object
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

            string idString = getStatement(cnt, ID, "PatientID", and);
            if (idString.StartsWith("where"))
            {
                cnt++;
            }

            string firstNameString = getNameStatement(cnt, firstName, "firstname", and);
            if (firstNameString.StartsWith("where"))
            {
                cnt++;
            }

            string lastNameString = getNameStatement(cnt, lastName, "lastname", and);
            if (lastNameString.StartsWith("where"))
            {
                cnt++;
            }

            string dateString = getDateStatement(cnt, YOB, MOB, DOB, "DateOfBirth", yearRelation, and);
            if (dateString.StartsWith("where"))
            {
                cnt++;
            }

            string genderString = "";
            if (gender != "a")
            {
                // if gender != any, then get the appropriate gender
                genderString = getStatement(cnt, gender, "gender", and);
            }
            
            return "select * from Patients " + idString + firstNameString + lastNameString + dateString + genderString;
        }
    }
}
