using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project
{
    class PatientVisitedWard : Query
    {
        // Instance Variables
        private string wardName;

        /**
         * Constructor
         * @param wardName, the name of the ward to find all the patients who visited
         **/
        public PatientVisitedWard(string wardName)
        {
            this.wardName = wardName;
        }

        /**
         * Gets the query that finds all patients who visited the ward wardName
         **/
        public override string getQuery(bool and)
        {
            return "select distinct P.PatientID, firstname + ' ' + lastname, DateOfBirth, Gender " +
                "from Patients as P, Wards as W, Registrations as R " +
                "where P.PatientID = R.PatientID and R.WardName = W.WardName " +
                "and W.WardName = '" + wardName +"'";
        }
    }
}
