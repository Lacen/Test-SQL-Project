using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'cmpt291_projectDataSet.Visits' table. You can move, or remove it, as needed.
            this.visitsTableAdapter.Fill(this.cmpt291_projectDataSet.Visits);
            // TODO: This line of code loads data into the 'cmpt291_projectDataSet.Patients' table. You can move, or remove it, as needed.
            this.patientsTableAdapter.Fill(this.cmpt291_projectDataSet.Patients);
            // TODO: This line of code loads data into the 'cmpt291_projectDataSet.Wards' table. You can move, or remove it, as needed.
            this.wardsTableAdapter.Fill(this.cmpt291_projectDataSet.Wards);
            // TODO: This line of code loads data into the 'cmpt291_projectDataSet.Doctors' table. You can move, or remove it, as needed.
            this.doctorsTableAdapter1.Fill(this.cmpt291_projectDataSet.Doctors);

        }

        private void tabPage2_Click(object sender, EventArgs e)
        {
        }

        /**
         * Populates the grid view depending on the argument string
         * @param str, the string to populate the grid view with (SQL query)
         **/
        private void populateGridView(string str, DataGridView dataGridView)
        {
            BindingSource tableContents = new BindingSource();
            tableContents.DataSource = Globals.GetData(str);
            dataGridView.DataSource = tableContents;
        }

        /**
         * Applies the search results for a doctor
         **/
        private void button2_Click_1(object sender, EventArgs e)
        {
            // Get the salary and year relationships
            string salaryRelation = Globals.getRelation(doctorSalaryGt, doctorSalaryLt, doctorSalaryGe,
                doctorSalaryLe);
            string yearRelation = Globals.getRelation(doctorYearGt, doctorYearLt, doctorYearGe, doctorYearLe);

            GetDoctorQuery query = new GetDoctorQuery(doctorID.Text, doctorFirstName.Text,
                doctorLastName.Text, doctorDateOfHire.Text, doctorMonthOfHire.Text,
                doctorYearOfHire.Text, doctorSalary.Text, salaryRelation, yearRelation);

            if (query.validate())
            {
                populateGridView(query.getQuery(doctorAND.Checked), dataGridView1);
                label1.Text = query.getQuery(doctorAND.Checked);
            }
            else
            {
                Globals.raiseError();
            }
        }

        /**
         * Paints the back panel for the doctor tab, enabling autoscroll
         **/
        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            panel1.AutoScroll = true;
        }

        /**
         * Reset button for the doctor grid view
         **/
        private void button1_Click(object sender, EventArgs e)
        {
            populateGridView("select * from Doctors", dataGridView1);
        }

        /**
         * Applies the search results for a ward
         **/
        private void wardApply_Click(object sender, EventArgs e)
        {
            // Get the appropriate relationship for capacity as defined in the radio buttons
            string capacityRelation = Globals.getRelation(capacityGt, capacityLt, capacityGe, capacityLe);
            string countRelation = Globals.getRelation(countGt, countLt, countGe, countLe);

            GetWardQuery query = new GetWardQuery(wardName.Text, wardCapacity.Text, wardCount.Text,
                capacityRelation, countRelation);

            if (query.validate())
            {
                populateGridView(query.getQuery(wardAND.Checked), wardGridView);
            }
            else
            {
                Globals.raiseError();
            }
        }

        /**
         * Reset button for the doctor grid view
         **/
        private void wardReset_Click(object sender, EventArgs e)
        {
            populateGridView("select * from Wards", wardGridView);
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        /**
         * Resets the patient grid view
         **/
        private void patientReset_Click(object sender, EventArgs e)
        {
            populateGridView("select * from Patients", patientGridView);
        }

        /**
         * Applies search results for patient tab on the grid view
         **/
        private void patientApply_Click_1(object sender, EventArgs e)
        {
            // Get the proper gender
            string gender = "a";
            if (patientMale.Checked)
            {
                gender = "m";
            }
            else if (patientFemale.Checked)
            {
                gender = "f";
            }
            else if (patientAllSex.Checked)
            {
                gender = "a";
            }

            string yearRelation = Globals.getRelation(patientGt, patientLt, patientGe, patientLe);

            GetPatientQuery query = new GetPatientQuery(patientID.Text, patientFirstName.Text, patientLastName.Text,
                patientDOB.Text, patientMOB.Text, patientYOB.Text, gender, yearRelation);

            if (query.validate())
            {
                populateGridView(query.getQuery(patientAND.Checked), patientGridView);
                label2.Text = query.getQuery(patientAND.Checked);
            }
            else
            {
                Globals.raiseError();
            }
        }

        /* Garbage functions which break the application if we remove..... */
        private void visitsDoctorId_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }


        private void splitContainer1_Panel2_Paint(object sender, PaintEventArgs e)
        {
            panel2.AutoScroll = true;
        }
        /* ---------------------------------------- */


        private void visitsApply_Click(object sender, EventArgs e)
        {

            string yearRelation = Globals.getRelation(visitsGt, visitsLt, visitsGe, visitsLe);

            GetVisitQuery query = new GetVisitQuery(visitsDoctorId.Text, visitsRegistrationID.Text, visitsYear.Text,
                visitsMonth.Text, visitsDate.Text, yearRelation);

            if (query.validate())
            {
                populateGridView(query.getQuery(visitsAND.Checked), visitsGridView);
            }
            else
            {
                Globals.raiseError();
            }
        }

        private void applyQuery_Click_1(object sender, EventArgs e)
        {
            if (patientVisitEveryWard.Checked)
            {
                patientVisitedAllWards(resultsList);
            }
            else if (visitedSpecificWard.Checked)
            {
                patientVisitedWard(wardsComboBox.Text, resultsList);

            }
        }

        /**
          * Given a ListView object, this method populates it with all patients who visited every ward
          * @param list the ListView to populate
         **/
        private void patientVisitedAllWards(ListView list)
        {
            SqlDataReader reader = Globals.database.query(PatientVisitAllWardsQuery.INSTANCE.getQuery(true));

            list.Items.Clear();
            while (reader.Read())
            {
                string[] arr = new string[4];
                arr[0] = reader.GetValue(0) + "";
                arr[1] = reader.GetValue(1) + "";
                arr[2] = reader.GetValue(2) + "";
                arr[3] = reader.GetValue(3) + "";
                var listViewItem = new ListViewItem(arr);
                list.Items.Add(listViewItem);
            }
            reader.Close();
        }

        /**
         * Given a ward name, this function populates a given list view with all the patients' information
         * who were in that ward
         * @param wardName, the name of the ward
         * @param list the ListView to populate
         **/
        private void patientVisitedWard(String wardName, ListView list)
        {
            SqlDataReader reader = Globals.database.query(new PatientVisitedWard(wardName).getQuery(true));

            list.Items.Clear();
            while (reader.Read())
            {
                string[] arr = new string[4];
                arr[0] = reader.GetValue(0) + "";
                arr[1] = reader.GetValue(1) + "";
                arr[2] = reader.GetValue(2) + "";
                arr[3] = reader.GetValue(3) + "";
                var listViewItem = new ListViewItem(arr);
                list.Items.Add(listViewItem);
            }
            reader.Close();
        }

        private void doctorQueryApplyClick(object sender, EventArgs e)
        {
            if (doctorsWorkWith.Checked)
            {
                doctorVisitPatient(doctorWorkedWithBox.SelectedValue + "", doctorResultsList);
            }
        }

        /** Given a patient ID, this function populates the argument list with all the doctors who
         * visited that patient
         * @param patientID, the ID of the patient
         * @param list the ListView object to populate
         **/
        private void doctorVisitPatient(string patientID, ListView list)
        {
            DoctorVisitPatient query = new DoctorVisitPatient(patientID);
            SqlDataReader reader = Globals.database.query(query.getQuery(true));

            list.Items.Clear();
            while (reader.Read())
            {
                string[] arr = new string[4];
                arr[0] = reader.GetValue(0) + "";
                arr[1] = reader.GetValue(1) + "";
                arr[2] = reader.GetValue(2) + "";
                arr[3] = reader.GetValue(3) + "";
                var listViewItem = new ListViewItem(arr);
                list.Items.Add(listViewItem);
            }
            reader.Close();
        }
    }
}
