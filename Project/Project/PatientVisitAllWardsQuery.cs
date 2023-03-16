using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project
{
    class PatientVisitAllWardsQuery : Query
    {
        // Use singleton since we only ever need one of these
        public static PatientVisitAllWardsQuery INSTANCE = new PatientVisitAllWardsQuery();

        // Instance Variables
        private string query;

        /**
         * Constructor
         **/
        private PatientVisitAllWardsQuery()
        {
            this.query = "select distinct PatientID, firstname + ' ' + lastname, DateOfBirth, Gender from Patients as P where " +
                "not exists (select WardName from Wards except (select WardName from " +
                "Registrations where PatientID = P.PatientID))";
        }

        /**
         * Gets the query that queries the database to find all patients who visited all wards
         **/
        public override string getQuery(bool and)
        {
            return this.query;
        }
    }
}
