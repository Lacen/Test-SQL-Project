using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project
{
    class DoctorVisitPatient : Query
    {
        private string patientID;

        /**
         * Constructor
         * @param patientID the ID of the patient to find which doctors visited him/her
         **/
        public DoctorVisitPatient(string patientID)
        {
            this.patientID = patientID;
        }

        /**
         * Gets the query to query the database to see which doctors worked with the specified patient
         **/
        public override string getQuery(bool and)
        {
            return "select distinct DoctorID, FirstName +' ' + LastName, " +
                "HireDate, Salary from Doctors where DoctorID in (select DoctorID " +
                "from Registrations as R, Visits as V where R.RegistrationID = V.RegistrationID " +
                "and R.RegistrationID = V.RegistrationID and R.PatientID = " + patientID + ");";
        }
    }
}
