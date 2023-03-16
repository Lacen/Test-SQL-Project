namespace Project
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.doctorsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.projectDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.wardBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.wardsTab = new System.Windows.Forms.TabPage();
            this.panel9 = new System.Windows.Forms.Panel();
            this.wardOR = new System.Windows.Forms.RadioButton();
            this.wardAND = new System.Windows.Forms.RadioButton();
            this.panel3 = new System.Windows.Forms.Panel();
            this.countEq = new System.Windows.Forms.RadioButton();
            this.countLe = new System.Windows.Forms.RadioButton();
            this.countGt = new System.Windows.Forms.RadioButton();
            this.countGe = new System.Windows.Forms.RadioButton();
            this.countLt = new System.Windows.Forms.RadioButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.capacityEq = new System.Windows.Forms.RadioButton();
            this.capacityLe = new System.Windows.Forms.RadioButton();
            this.capacityGt = new System.Windows.Forms.RadioButton();
            this.capacityGe = new System.Windows.Forms.RadioButton();
            this.capacityLt = new System.Windows.Forms.RadioButton();
            this.wardReset = new System.Windows.Forms.Button();
            this.wardGridView = new System.Windows.Forms.DataGridView();
            this.wardNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.maxCapacityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.currentCapacityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.wardsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cmpt291_projectDataSet = new Project.cmpt291_projectDataSet();
            this.wardCountLabel = new System.Windows.Forms.Label();
            this.wardCount = new System.Windows.Forms.TextBox();
            this.wardCapacity = new System.Windows.Forms.TextBox();
            this.wardName = new System.Windows.Forms.TextBox();
            this.wardCapacityLabel = new System.Windows.Forms.Label();
            this.wardNameLabel = new System.Windows.Forms.Label();
            this.wardApply = new System.Windows.Forms.Button();
            this.doctorsTab = new System.Windows.Forms.TabPage();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.doctorIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.firstNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lastNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hireDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.salaryDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.doctorsBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.doctorReset = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel8 = new System.Windows.Forms.Panel();
            this.doctorOR = new System.Windows.Forms.RadioButton();
            this.doctorAND = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.panel7 = new System.Windows.Forms.Panel();
            this.doctorYearLt = new System.Windows.Forms.RadioButton();
            this.doctorYearGt = new System.Windows.Forms.RadioButton();
            this.doctorYearLe = new System.Windows.Forms.RadioButton();
            this.doctorYearEq = new System.Windows.Forms.RadioButton();
            this.doctorYearGe = new System.Windows.Forms.RadioButton();
            this.panel6 = new System.Windows.Forms.Panel();
            this.doctorSalaryLt = new System.Windows.Forms.RadioButton();
            this.doctorSalaryGt = new System.Windows.Forms.RadioButton();
            this.doctorSalaryLe = new System.Windows.Forms.RadioButton();
            this.doctorSalaryEq = new System.Windows.Forms.RadioButton();
            this.doctorSalaryGe = new System.Windows.Forms.RadioButton();
            this.wardSearchLabel = new System.Windows.Forms.Label();
            this.doctorSalaryLabel = new System.Windows.Forms.Label();
            this.doctorSalary = new System.Windows.Forms.TextBox();
            this.yearOfHireLabel = new System.Windows.Forms.Label();
            this.doctorYearOfHire = new System.Windows.Forms.TextBox();
            this.doctorMonthOfHireLabel = new System.Windows.Forms.Label();
            this.doctorMonthOfHire = new System.Windows.Forms.TextBox();
            this.doctorDateOfHireLabel = new System.Windows.Forms.Label();
            this.doctorDateOfHire = new System.Windows.Forms.TextBox();
            this.doctorLastName = new System.Windows.Forms.TextBox();
            this.doctorLastNameLabel = new System.Windows.Forms.Label();
            this.doctorFirstNameLabel = new System.Windows.Forms.Label();
            this.doctorIDLabel = new System.Windows.Forms.Label();
            this.doctorID = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.doctorFirstName = new System.Windows.Forms.TextBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.patientsTab = new System.Windows.Forms.TabPage();
            this.panel10 = new System.Windows.Forms.Panel();
            this.patientOR = new System.Windows.Forms.RadioButton();
            this.patientAND = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.patientEq = new System.Windows.Forms.RadioButton();
            this.patientLe = new System.Windows.Forms.RadioButton();
            this.patientGt = new System.Windows.Forms.RadioButton();
            this.patientGe = new System.Windows.Forms.RadioButton();
            this.patientLt = new System.Windows.Forms.RadioButton();
            this.panel4 = new System.Windows.Forms.Panel();
            this.patientMale = new System.Windows.Forms.RadioButton();
            this.patientAllSex = new System.Windows.Forms.RadioButton();
            this.patientFemale = new System.Windows.Forms.RadioButton();
            this.patientGenderLabel = new System.Windows.Forms.Label();
            this.patientReset = new System.Windows.Forms.Button();
            this.patientYOBLabel = new System.Windows.Forms.Label();
            this.patientYOB = new System.Windows.Forms.TextBox();
            this.patientMOBLabel = new System.Windows.Forms.Label();
            this.patientMOB = new System.Windows.Forms.TextBox();
            this.patientDOBLabel = new System.Windows.Forms.Label();
            this.patientDOB = new System.Windows.Forms.TextBox();
            this.patientLastName = new System.Windows.Forms.TextBox();
            this.patientLastNameLabel = new System.Windows.Forms.Label();
            this.patientFIrstNameLabel = new System.Windows.Forms.Label();
            this.patientFirstName = new System.Windows.Forms.TextBox();
            this.patientID = new System.Windows.Forms.TextBox();
            this.patientIDLabel = new System.Windows.Forms.Label();
            this.patientApply = new System.Windows.Forms.Button();
            this.patientGridView = new System.Windows.Forms.DataGridView();
            this.patientIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.firstNameDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lastNameDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateOfBirthDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.genderDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.patientsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.visitsTab = new System.Windows.Forms.TabPage();
            this.panel12 = new System.Windows.Forms.Panel();
            this.visitsYearEq = new System.Windows.Forms.RadioButton();
            this.visitsLe = new System.Windows.Forms.RadioButton();
            this.visitsGt = new System.Windows.Forms.RadioButton();
            this.visitsGe = new System.Windows.Forms.RadioButton();
            this.visitsLt = new System.Windows.Forms.RadioButton();
            this.visitsYearLabel = new System.Windows.Forms.Label();
            this.visitsYear = new System.Windows.Forms.TextBox();
            this.visitsMonthLabel = new System.Windows.Forms.Label();
            this.visitsMonth = new System.Windows.Forms.TextBox();
            this.visitsDateLabel = new System.Windows.Forms.Label();
            this.visitsDate = new System.Windows.Forms.TextBox();
            this.visitsRegistrationID = new System.Windows.Forms.TextBox();
            this.visitsRegistrationIDLabel = new System.Windows.Forms.Label();
            this.visitsReset = new System.Windows.Forms.Button();
            this.visitsGridView = new System.Windows.Forms.DataGridView();
            this.registrationIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.doctorIDDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.timeStampDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.notesDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.visitsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.panel11 = new System.Windows.Forms.Panel();
            this.visitsOR = new System.Windows.Forms.RadioButton();
            this.visitsAND = new System.Windows.Forms.RadioButton();
            this.visitsDoctorId = new System.Windows.Forms.TextBox();
            this.visitsDoctorIDLabel = new System.Windows.Forms.Label();
            this.visitsApply = new System.Windows.Forms.Button();
            this.queriesTab = new System.Windows.Forms.TabPage();
            this.QueryTabControl = new System.Windows.Forms.TabControl();
            this.patientTab2 = new System.Windows.Forms.TabPage();
            this.resultsList = new System.Windows.Forms.ListView();
            this.idListViewHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.fullnameListViewHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.dobListViewHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.genderListViewHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.queryResults = new System.Windows.Forms.Label();
            this.patientVisitEveryWard = new System.Windows.Forms.RadioButton();
            this.wardsComboBox = new System.Windows.Forms.ComboBox();
            this.visitedSpecificWard = new System.Windows.Forms.RadioButton();
            this.applyQuery = new System.Windows.Forms.Button();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.doctorResultsList = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label4 = new System.Windows.Forms.Label();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.doctorWorkedWithBox = new System.Windows.Forms.ComboBox();
            this.patientsBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.doctorsWorkWith = new System.Windows.Forms.RadioButton();
            this.doctorQueryApply = new System.Windows.Forms.Button();
            this.queryLabel = new System.Windows.Forms.Label();
            this.wardsBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.patienBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.patienBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.doctorsBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.doctorsTableAdapter1 = new Project.cmpt291_projectDataSetTableAdapters.DoctorsTableAdapter();
            this.wardsTableAdapter = new Project.cmpt291_projectDataSetTableAdapters.WardsTableAdapter();
            this.patientsTableAdapter = new Project.cmpt291_projectDataSetTableAdapters.PatientsTableAdapter();
            this.patientsBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.visitsTableAdapter = new Project.cmpt291_projectDataSetTableAdapters.VisitsTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.doctorsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.projectDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.wardBindingSource)).BeginInit();
            this.wardsTab.SuspendLayout();
            this.panel9.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.wardGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.wardsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmpt291_projectDataSet)).BeginInit();
            this.doctorsTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.doctorsBindingSource2)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel8.SuspendLayout();
            this.panel7.SuspendLayout();
            this.panel6.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.patientsTab.SuspendLayout();
            this.panel10.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.patientGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.patientsBindingSource)).BeginInit();
            this.visitsTab.SuspendLayout();
            this.panel12.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.visitsGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.visitsBindingSource)).BeginInit();
            this.panel11.SuspendLayout();
            this.queriesTab.SuspendLayout();
            this.QueryTabControl.SuspendLayout();
            this.patientTab2.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.patientsBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.wardsBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.patienBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.patienBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.doctorsBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.patientsBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // doctorsBindingSource
            // 
            this.doctorsBindingSource.DataMember = "doctors";
            this.doctorsBindingSource.DataSource = this.projectDataSetBindingSource;
            // 
            // projectDataSetBindingSource
            // 
            this.projectDataSetBindingSource.Position = 0;
            // 
            // projectDataSet
            // 
            //
            // wardBindingSource
            // 
            this.wardBindingSource.DataMember = "ward";
            this.wardBindingSource.DataSource = this.projectDataSetBindingSource;
            // 
            // wardsTab
            // 
            this.wardsTab.Controls.Add(this.panel9);
            this.wardsTab.Controls.Add(this.panel3);
            this.wardsTab.Controls.Add(this.panel2);
            this.wardsTab.Controls.Add(this.wardReset);
            this.wardsTab.Controls.Add(this.wardGridView);
            this.wardsTab.Controls.Add(this.wardCountLabel);
            this.wardsTab.Controls.Add(this.wardCount);
            this.wardsTab.Controls.Add(this.wardCapacity);
            this.wardsTab.Controls.Add(this.wardName);
            this.wardsTab.Controls.Add(this.wardCapacityLabel);
            this.wardsTab.Controls.Add(this.wardNameLabel);
            this.wardsTab.Controls.Add(this.wardApply);
            this.wardsTab.Location = new System.Drawing.Point(4, 25);
            this.wardsTab.Name = "wardsTab";
            this.wardsTab.Padding = new System.Windows.Forms.Padding(3);
            this.wardsTab.Size = new System.Drawing.Size(791, 566);
            this.wardsTab.TabIndex = 1;
            this.wardsTab.Text = "Wards";
            this.wardsTab.UseVisualStyleBackColor = true;
            this.wardsTab.Click += new System.EventHandler(this.tabPage2_Click);
            // 
            // panel9
            // 
            this.panel9.Controls.Add(this.wardOR);
            this.panel9.Controls.Add(this.wardAND);
            this.panel9.Location = new System.Drawing.Point(364, 19);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(124, 23);
            this.panel9.TabIndex = 43;
            // 
            // wardOR
            // 
            this.wardOR.AutoSize = true;
            this.wardOR.Location = new System.Drawing.Point(69, 1);
            this.wardOR.Name = "wardOR";
            this.wardOR.Size = new System.Drawing.Size(50, 21);
            this.wardOR.TabIndex = 32;
            this.wardOR.Text = "OR";
            this.wardOR.UseVisualStyleBackColor = true;
            // 
            // wardAND
            // 
            this.wardAND.AutoSize = true;
            this.wardAND.Checked = true;
            this.wardAND.Location = new System.Drawing.Point(5, 1);
            this.wardAND.Name = "wardAND";
            this.wardAND.Size = new System.Drawing.Size(58, 21);
            this.wardAND.TabIndex = 33;
            this.wardAND.TabStop = true;
            this.wardAND.Text = "AND";
            this.wardAND.UseVisualStyleBackColor = true;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.countEq);
            this.panel3.Controls.Add(this.countLe);
            this.panel3.Controls.Add(this.countGt);
            this.panel3.Controls.Add(this.countGe);
            this.panel3.Controls.Add(this.countLt);
            this.panel3.Location = new System.Drawing.Point(278, 76);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(233, 25);
            this.panel3.TabIndex = 42;
            // 
            // countEq
            // 
            this.countEq.AutoSize = true;
            this.countEq.Checked = true;
            this.countEq.Location = new System.Drawing.Point(3, 3);
            this.countEq.Name = "countEq";
            this.countEq.Size = new System.Drawing.Size(37, 21);
            this.countEq.TabIndex = 38;
            this.countEq.TabStop = true;
            this.countEq.Text = "=";
            this.countEq.UseVisualStyleBackColor = true;
            // 
            // countLe
            // 
            this.countLe.AutoSize = true;
            this.countLe.Location = new System.Drawing.Point(132, 3);
            this.countLe.Name = "countLe";
            this.countLe.Size = new System.Drawing.Size(45, 21);
            this.countLe.TabIndex = 40;
            this.countLe.Text = "<=";
            this.countLe.UseVisualStyleBackColor = true;
            // 
            // countGt
            // 
            this.countGt.AutoSize = true;
            this.countGt.Location = new System.Drawing.Point(89, 3);
            this.countGt.Name = "countGt";
            this.countGt.Size = new System.Drawing.Size(37, 21);
            this.countGt.TabIndex = 36;
            this.countGt.Text = ">";
            this.countGt.UseVisualStyleBackColor = true;
            // 
            // countGe
            // 
            this.countGe.AutoSize = true;
            this.countGe.Location = new System.Drawing.Point(183, 3);
            this.countGe.Name = "countGe";
            this.countGe.Size = new System.Drawing.Size(45, 21);
            this.countGe.TabIndex = 39;
            this.countGe.Text = ">=";
            this.countGe.UseVisualStyleBackColor = true;
            // 
            // countLt
            // 
            this.countLt.AutoSize = true;
            this.countLt.Location = new System.Drawing.Point(46, 3);
            this.countLt.Name = "countLt";
            this.countLt.Size = new System.Drawing.Size(37, 21);
            this.countLt.TabIndex = 37;
            this.countLt.Text = "<";
            this.countLt.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.capacityEq);
            this.panel2.Controls.Add(this.capacityLe);
            this.panel2.Controls.Add(this.capacityGt);
            this.panel2.Controls.Add(this.capacityGe);
            this.panel2.Controls.Add(this.capacityLt);
            this.panel2.Location = new System.Drawing.Point(278, 45);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(233, 25);
            this.panel2.TabIndex = 41;
            // 
            // capacityEq
            // 
            this.capacityEq.AutoSize = true;
            this.capacityEq.Checked = true;
            this.capacityEq.Location = new System.Drawing.Point(3, 3);
            this.capacityEq.Name = "capacityEq";
            this.capacityEq.Size = new System.Drawing.Size(37, 21);
            this.capacityEq.TabIndex = 38;
            this.capacityEq.TabStop = true;
            this.capacityEq.Text = "=";
            this.capacityEq.UseVisualStyleBackColor = true;
            // 
            // capacityLe
            // 
            this.capacityLe.AutoSize = true;
            this.capacityLe.Location = new System.Drawing.Point(132, 3);
            this.capacityLe.Name = "capacityLe";
            this.capacityLe.Size = new System.Drawing.Size(45, 21);
            this.capacityLe.TabIndex = 40;
            this.capacityLe.Text = "<=";
            this.capacityLe.UseVisualStyleBackColor = true;
            // 
            // capacityGt
            // 
            this.capacityGt.AutoSize = true;
            this.capacityGt.Location = new System.Drawing.Point(89, 3);
            this.capacityGt.Name = "capacityGt";
            this.capacityGt.Size = new System.Drawing.Size(37, 21);
            this.capacityGt.TabIndex = 36;
            this.capacityGt.Text = ">";
            this.capacityGt.UseVisualStyleBackColor = true;
            // 
            // capacityGe
            // 
            this.capacityGe.AutoSize = true;
            this.capacityGe.Location = new System.Drawing.Point(183, 3);
            this.capacityGe.Name = "capacityGe";
            this.capacityGe.Size = new System.Drawing.Size(45, 21);
            this.capacityGe.TabIndex = 39;
            this.capacityGe.Text = ">=";
            this.capacityGe.UseVisualStyleBackColor = true;
            // 
            // capacityLt
            // 
            this.capacityLt.AutoSize = true;
            this.capacityLt.Location = new System.Drawing.Point(46, 3);
            this.capacityLt.Name = "capacityLt";
            this.capacityLt.Size = new System.Drawing.Size(37, 21);
            this.capacityLt.TabIndex = 37;
            this.capacityLt.Text = "<";
            this.capacityLt.UseVisualStyleBackColor = true;
            // 
            // wardReset
            // 
            this.wardReset.Location = new System.Drawing.Point(708, 537);
            this.wardReset.Name = "wardReset";
            this.wardReset.Size = new System.Drawing.Size(75, 23);
            this.wardReset.TabIndex = 28;
            this.wardReset.Text = "Reset";
            this.wardReset.UseVisualStyleBackColor = true;
            this.wardReset.Click += new System.EventHandler(this.wardReset_Click);
            // 
            // wardGridView
            // 
            this.wardGridView.AutoGenerateColumns = false;
            this.wardGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.wardGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.wardNameDataGridViewTextBoxColumn,
            this.maxCapacityDataGridViewTextBoxColumn,
            this.currentCapacityDataGridViewTextBoxColumn});
            this.wardGridView.DataSource = this.wardsBindingSource;
            this.wardGridView.Location = new System.Drawing.Point(3, 240);
            this.wardGridView.Name = "wardGridView";
            this.wardGridView.RowTemplate.Height = 24;
            this.wardGridView.Size = new System.Drawing.Size(780, 295);
            this.wardGridView.TabIndex = 27;
            // 
            // wardNameDataGridViewTextBoxColumn
            // 
            this.wardNameDataGridViewTextBoxColumn.DataPropertyName = "WardName";
            this.wardNameDataGridViewTextBoxColumn.HeaderText = "WardName";
            this.wardNameDataGridViewTextBoxColumn.Name = "wardNameDataGridViewTextBoxColumn";
            // 
            // maxCapacityDataGridViewTextBoxColumn
            // 
            this.maxCapacityDataGridViewTextBoxColumn.DataPropertyName = "MaxCapacity";
            this.maxCapacityDataGridViewTextBoxColumn.HeaderText = "MaxCapacity";
            this.maxCapacityDataGridViewTextBoxColumn.Name = "maxCapacityDataGridViewTextBoxColumn";
            // 
            // currentCapacityDataGridViewTextBoxColumn
            // 
            this.currentCapacityDataGridViewTextBoxColumn.DataPropertyName = "CurrentCapacity";
            this.currentCapacityDataGridViewTextBoxColumn.HeaderText = "CurrentCapacity";
            this.currentCapacityDataGridViewTextBoxColumn.Name = "currentCapacityDataGridViewTextBoxColumn";
            // 
            // wardsBindingSource
            // 
            this.wardsBindingSource.DataMember = "Wards";
            this.wardsBindingSource.DataSource = this.cmpt291_projectDataSet;
            // 
            // cmpt291_projectDataSet
            // 
            this.cmpt291_projectDataSet.DataSetName = "cmpt291_projectDataSet";
            this.cmpt291_projectDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // wardCountLabel
            // 
            this.wardCountLabel.AutoSize = true;
            this.wardCountLabel.Location = new System.Drawing.Point(7, 82);
            this.wardCountLabel.Name = "wardCountLabel";
            this.wardCountLabel.Size = new System.Drawing.Size(53, 17);
            this.wardCountLabel.TabIndex = 26;
            this.wardCountLabel.Text = "Count: ";
            // 
            // wardCount
            // 
            this.wardCount.Location = new System.Drawing.Point(93, 76);
            this.wardCount.Name = "wardCount";
            this.wardCount.Size = new System.Drawing.Size(168, 22);
            this.wardCount.TabIndex = 25;
            // 
            // wardCapacity
            // 
            this.wardCapacity.Location = new System.Drawing.Point(93, 48);
            this.wardCapacity.Name = "wardCapacity";
            this.wardCapacity.Size = new System.Drawing.Size(168, 22);
            this.wardCapacity.TabIndex = 23;
            // 
            // wardName
            // 
            this.wardName.Location = new System.Drawing.Point(93, 20);
            this.wardName.Name = "wardName";
            this.wardName.Size = new System.Drawing.Size(168, 22);
            this.wardName.TabIndex = 21;
            // 
            // wardCapacityLabel
            // 
            this.wardCapacityLabel.AutoSize = true;
            this.wardCapacityLabel.Location = new System.Drawing.Point(7, 54);
            this.wardCapacityLabel.Name = "wardCapacityLabel";
            this.wardCapacityLabel.Size = new System.Drawing.Size(66, 17);
            this.wardCapacityLabel.TabIndex = 24;
            this.wardCapacityLabel.Text = "Capacity:";
            // 
            // wardNameLabel
            // 
            this.wardNameLabel.AutoSize = true;
            this.wardNameLabel.Location = new System.Drawing.Point(7, 26);
            this.wardNameLabel.Name = "wardNameLabel";
            this.wardNameLabel.Size = new System.Drawing.Size(49, 17);
            this.wardNameLabel.TabIndex = 22;
            this.wardNameLabel.Text = "Name:";
            // 
            // wardApply
            // 
            this.wardApply.Location = new System.Drawing.Point(278, 19);
            this.wardApply.Name = "wardApply";
            this.wardApply.Size = new System.Drawing.Size(80, 24);
            this.wardApply.TabIndex = 20;
            this.wardApply.Text = "Apply";
            this.wardApply.UseVisualStyleBackColor = true;
            this.wardApply.Click += new System.EventHandler(this.wardApply_Click);
            // 
            // doctorsTab
            // 
            this.doctorsTab.Controls.Add(this.dataGridView1);
            this.doctorsTab.Controls.Add(this.doctorReset);
            this.doctorsTab.Controls.Add(this.panel1);
            this.doctorsTab.Location = new System.Drawing.Point(4, 25);
            this.doctorsTab.Name = "doctorsTab";
            this.doctorsTab.Padding = new System.Windows.Forms.Padding(3);
            this.doctorsTab.Size = new System.Drawing.Size(791, 566);
            this.doctorsTab.TabIndex = 0;
            this.doctorsTab.Text = "Doctors";
            this.doctorsTab.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.doctorIDDataGridViewTextBoxColumn,
            this.firstNameDataGridViewTextBoxColumn,
            this.lastNameDataGridViewTextBoxColumn,
            this.hireDateDataGridViewTextBoxColumn,
            this.salaryDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.doctorsBindingSource2;
            this.dataGridView1.Location = new System.Drawing.Point(5, 238);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(780, 295);
            this.dataGridView1.TabIndex = 1;
            // 
            // doctorIDDataGridViewTextBoxColumn
            // 
            this.doctorIDDataGridViewTextBoxColumn.DataPropertyName = "DoctorID";
            this.doctorIDDataGridViewTextBoxColumn.HeaderText = "DoctorID";
            this.doctorIDDataGridViewTextBoxColumn.Name = "doctorIDDataGridViewTextBoxColumn";
            this.doctorIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // firstNameDataGridViewTextBoxColumn
            // 
            this.firstNameDataGridViewTextBoxColumn.DataPropertyName = "FirstName";
            this.firstNameDataGridViewTextBoxColumn.HeaderText = "FirstName";
            this.firstNameDataGridViewTextBoxColumn.Name = "firstNameDataGridViewTextBoxColumn";
            // 
            // lastNameDataGridViewTextBoxColumn
            // 
            this.lastNameDataGridViewTextBoxColumn.DataPropertyName = "LastName";
            this.lastNameDataGridViewTextBoxColumn.HeaderText = "LastName";
            this.lastNameDataGridViewTextBoxColumn.Name = "lastNameDataGridViewTextBoxColumn";
            // 
            // hireDateDataGridViewTextBoxColumn
            // 
            this.hireDateDataGridViewTextBoxColumn.DataPropertyName = "HireDate";
            this.hireDateDataGridViewTextBoxColumn.HeaderText = "HireDate";
            this.hireDateDataGridViewTextBoxColumn.Name = "hireDateDataGridViewTextBoxColumn";
            // 
            // salaryDataGridViewTextBoxColumn
            // 
            this.salaryDataGridViewTextBoxColumn.DataPropertyName = "Salary";
            this.salaryDataGridViewTextBoxColumn.HeaderText = "Salary";
            this.salaryDataGridViewTextBoxColumn.Name = "salaryDataGridViewTextBoxColumn";
            // 
            // doctorsBindingSource2
            // 
            this.doctorsBindingSource2.DataMember = "Doctors";
            this.doctorsBindingSource2.DataSource = this.cmpt291_projectDataSet;
            // 
            // doctorReset
            // 
            this.doctorReset.Location = new System.Drawing.Point(710, 539);
            this.doctorReset.Name = "doctorReset";
            this.doctorReset.Size = new System.Drawing.Size(75, 23);
            this.doctorReset.TabIndex = 14;
            this.doctorReset.Text = "Reset";
            this.doctorReset.UseVisualStyleBackColor = true;
            this.doctorReset.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel8);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.panel7);
            this.panel1.Controls.Add(this.panel6);
            this.panel1.Controls.Add(this.wardSearchLabel);
            this.panel1.Controls.Add(this.doctorSalaryLabel);
            this.panel1.Controls.Add(this.doctorSalary);
            this.panel1.Controls.Add(this.yearOfHireLabel);
            this.panel1.Controls.Add(this.doctorYearOfHire);
            this.panel1.Controls.Add(this.doctorMonthOfHireLabel);
            this.panel1.Controls.Add(this.doctorMonthOfHire);
            this.panel1.Controls.Add(this.doctorDateOfHireLabel);
            this.panel1.Controls.Add(this.doctorDateOfHire);
            this.panel1.Controls.Add(this.doctorLastName);
            this.panel1.Controls.Add(this.doctorLastNameLabel);
            this.panel1.Controls.Add(this.doctorFirstNameLabel);
            this.panel1.Controls.Add(this.doctorIDLabel);
            this.panel1.Controls.Add(this.doctorID);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.doctorFirstName);
            this.panel1.Location = new System.Drawing.Point(4, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(784, 228);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // panel8
            // 
            this.panel8.Controls.Add(this.doctorOR);
            this.panel8.Controls.Add(this.doctorAND);
            this.panel8.Location = new System.Drawing.Point(365, 15);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(124, 23);
            this.panel8.TabIndex = 39;
            // 
            // doctorOR
            // 
            this.doctorOR.AutoSize = true;
            this.doctorOR.Location = new System.Drawing.Point(69, 1);
            this.doctorOR.Name = "doctorOR";
            this.doctorOR.Size = new System.Drawing.Size(50, 21);
            this.doctorOR.TabIndex = 32;
            this.doctorOR.Text = "OR";
            this.doctorOR.UseVisualStyleBackColor = true;
            // 
            // doctorAND
            // 
            this.doctorAND.AutoSize = true;
            this.doctorAND.Checked = true;
            this.doctorAND.Location = new System.Drawing.Point(5, 1);
            this.doctorAND.Name = "doctorAND";
            this.doctorAND.Size = new System.Drawing.Size(58, 21);
            this.doctorAND.TabIndex = 33;
            this.doctorAND.TabStop = true;
            this.doctorAND.Text = "AND";
            this.doctorAND.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(355, 79);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 17);
            this.label1.TabIndex = 39;
            this.label1.Text = "label1";
            // 
            // panel7
            // 
            this.panel7.Controls.Add(this.doctorYearLt);
            this.panel7.Controls.Add(this.doctorYearGt);
            this.panel7.Controls.Add(this.doctorYearLe);
            this.panel7.Controls.Add(this.doctorYearEq);
            this.panel7.Controls.Add(this.doctorYearGe);
            this.panel7.Location = new System.Drawing.Point(274, 159);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(265, 22);
            this.panel7.TabIndex = 38;
            // 
            // doctorYearLt
            // 
            this.doctorYearLt.AutoSize = true;
            this.doctorYearLt.Location = new System.Drawing.Point(48, 1);
            this.doctorYearLt.Name = "doctorYearLt";
            this.doctorYearLt.Size = new System.Drawing.Size(37, 21);
            this.doctorYearLt.TabIndex = 32;
            this.doctorYearLt.Text = "<";
            this.doctorYearLt.UseVisualStyleBackColor = true;
            // 
            // doctorYearGt
            // 
            this.doctorYearGt.AutoSize = true;
            this.doctorYearGt.Location = new System.Drawing.Point(91, 1);
            this.doctorYearGt.Name = "doctorYearGt";
            this.doctorYearGt.Size = new System.Drawing.Size(37, 21);
            this.doctorYearGt.TabIndex = 31;
            this.doctorYearGt.Text = ">";
            this.doctorYearGt.UseVisualStyleBackColor = true;
            // 
            // doctorYearLe
            // 
            this.doctorYearLe.AutoSize = true;
            this.doctorYearLe.Location = new System.Drawing.Point(134, 1);
            this.doctorYearLe.Name = "doctorYearLe";
            this.doctorYearLe.Size = new System.Drawing.Size(45, 21);
            this.doctorYearLe.TabIndex = 35;
            this.doctorYearLe.Text = "<=";
            this.doctorYearLe.UseVisualStyleBackColor = true;
            // 
            // doctorYearEq
            // 
            this.doctorYearEq.AutoSize = true;
            this.doctorYearEq.Checked = true;
            this.doctorYearEq.Location = new System.Drawing.Point(5, 1);
            this.doctorYearEq.Name = "doctorYearEq";
            this.doctorYearEq.Size = new System.Drawing.Size(37, 21);
            this.doctorYearEq.TabIndex = 33;
            this.doctorYearEq.TabStop = true;
            this.doctorYearEq.Text = "=";
            this.doctorYearEq.UseVisualStyleBackColor = true;
            // 
            // doctorYearGe
            // 
            this.doctorYearGe.AutoSize = true;
            this.doctorYearGe.Location = new System.Drawing.Point(185, 1);
            this.doctorYearGe.Name = "doctorYearGe";
            this.doctorYearGe.Size = new System.Drawing.Size(45, 21);
            this.doctorYearGe.TabIndex = 34;
            this.doctorYearGe.Text = ">=";
            this.doctorYearGe.UseVisualStyleBackColor = true;
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.doctorSalaryLt);
            this.panel6.Controls.Add(this.doctorSalaryGt);
            this.panel6.Controls.Add(this.doctorSalaryLe);
            this.panel6.Controls.Add(this.doctorSalaryEq);
            this.panel6.Controls.Add(this.doctorSalaryGe);
            this.panel6.Location = new System.Drawing.Point(274, 187);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(265, 22);
            this.panel6.TabIndex = 37;
            // 
            // doctorSalaryLt
            // 
            this.doctorSalaryLt.AutoSize = true;
            this.doctorSalaryLt.Location = new System.Drawing.Point(48, 1);
            this.doctorSalaryLt.Name = "doctorSalaryLt";
            this.doctorSalaryLt.Size = new System.Drawing.Size(37, 21);
            this.doctorSalaryLt.TabIndex = 32;
            this.doctorSalaryLt.Text = "<";
            this.doctorSalaryLt.UseVisualStyleBackColor = true;
            // 
            // doctorSalaryGt
            // 
            this.doctorSalaryGt.AutoSize = true;
            this.doctorSalaryGt.Location = new System.Drawing.Point(91, 1);
            this.doctorSalaryGt.Name = "doctorSalaryGt";
            this.doctorSalaryGt.Size = new System.Drawing.Size(37, 21);
            this.doctorSalaryGt.TabIndex = 31;
            this.doctorSalaryGt.Text = ">";
            this.doctorSalaryGt.UseVisualStyleBackColor = true;
            // 
            // doctorSalaryLe
            // 
            this.doctorSalaryLe.AutoSize = true;
            this.doctorSalaryLe.Location = new System.Drawing.Point(134, 1);
            this.doctorSalaryLe.Name = "doctorSalaryLe";
            this.doctorSalaryLe.Size = new System.Drawing.Size(45, 21);
            this.doctorSalaryLe.TabIndex = 35;
            this.doctorSalaryLe.Text = "<=";
            this.doctorSalaryLe.UseVisualStyleBackColor = true;
            // 
            // doctorSalaryEq
            // 
            this.doctorSalaryEq.AutoSize = true;
            this.doctorSalaryEq.Checked = true;
            this.doctorSalaryEq.Location = new System.Drawing.Point(5, 1);
            this.doctorSalaryEq.Name = "doctorSalaryEq";
            this.doctorSalaryEq.Size = new System.Drawing.Size(37, 21);
            this.doctorSalaryEq.TabIndex = 33;
            this.doctorSalaryEq.TabStop = true;
            this.doctorSalaryEq.Text = "=";
            this.doctorSalaryEq.UseVisualStyleBackColor = true;
            // 
            // doctorSalaryGe
            // 
            this.doctorSalaryGe.AutoSize = true;
            this.doctorSalaryGe.Location = new System.Drawing.Point(185, 1);
            this.doctorSalaryGe.Name = "doctorSalaryGe";
            this.doctorSalaryGe.Size = new System.Drawing.Size(45, 21);
            this.doctorSalaryGe.TabIndex = 34;
            this.doctorSalaryGe.Text = ">=";
            this.doctorSalaryGe.UseVisualStyleBackColor = true;
            // 
            // wardSearchLabel
            // 
            this.wardSearchLabel.AutoSize = true;
            this.wardSearchLabel.Location = new System.Drawing.Point(3, 5);
            this.wardSearchLabel.Name = "wardSearchLabel";
            this.wardSearchLabel.Size = new System.Drawing.Size(53, 17);
            this.wardSearchLabel.TabIndex = 36;
            this.wardSearchLabel.Text = "Search";
            // 
            // doctorSalaryLabel
            // 
            this.doctorSalaryLabel.AutoSize = true;
            this.doctorSalaryLabel.Location = new System.Drawing.Point(3, 192);
            this.doctorSalaryLabel.Name = "doctorSalaryLabel";
            this.doctorSalaryLabel.Size = new System.Drawing.Size(52, 17);
            this.doctorSalaryLabel.TabIndex = 30;
            this.doctorSalaryLabel.Text = "Salary:";
            // 
            // doctorSalary
            // 
            this.doctorSalary.Location = new System.Drawing.Point(89, 187);
            this.doctorSalary.Name = "doctorSalary";
            this.doctorSalary.Size = new System.Drawing.Size(168, 22);
            this.doctorSalary.TabIndex = 29;
            // 
            // yearOfHireLabel
            // 
            this.yearOfHireLabel.AutoSize = true;
            this.yearOfHireLabel.Location = new System.Drawing.Point(3, 164);
            this.yearOfHireLabel.Name = "yearOfHireLabel";
            this.yearOfHireLabel.Size = new System.Drawing.Size(72, 17);
            this.yearOfHireLabel.TabIndex = 28;
            this.yearOfHireLabel.Text = "Hire Year:";
            // 
            // doctorYearOfHire
            // 
            this.doctorYearOfHire.Location = new System.Drawing.Point(89, 159);
            this.doctorYearOfHire.Name = "doctorYearOfHire";
            this.doctorYearOfHire.Size = new System.Drawing.Size(168, 22);
            this.doctorYearOfHire.TabIndex = 27;
            // 
            // doctorMonthOfHireLabel
            // 
            this.doctorMonthOfHireLabel.AutoSize = true;
            this.doctorMonthOfHireLabel.Location = new System.Drawing.Point(3, 136);
            this.doctorMonthOfHireLabel.Name = "doctorMonthOfHireLabel";
            this.doctorMonthOfHireLabel.Size = new System.Drawing.Size(81, 17);
            this.doctorMonthOfHireLabel.TabIndex = 26;
            this.doctorMonthOfHireLabel.Text = "Hire Month:";
            // 
            // doctorMonthOfHire
            // 
            this.doctorMonthOfHire.Location = new System.Drawing.Point(89, 131);
            this.doctorMonthOfHire.Name = "doctorMonthOfHire";
            this.doctorMonthOfHire.Size = new System.Drawing.Size(168, 22);
            this.doctorMonthOfHire.TabIndex = 25;
            // 
            // doctorDateOfHireLabel
            // 
            this.doctorDateOfHireLabel.AutoSize = true;
            this.doctorDateOfHireLabel.Location = new System.Drawing.Point(3, 108);
            this.doctorDateOfHireLabel.Name = "doctorDateOfHireLabel";
            this.doctorDateOfHireLabel.Size = new System.Drawing.Size(72, 17);
            this.doctorDateOfHireLabel.TabIndex = 24;
            this.doctorDateOfHireLabel.Text = "Hire Date:";
            // 
            // doctorDateOfHire
            // 
            this.doctorDateOfHire.Location = new System.Drawing.Point(89, 103);
            this.doctorDateOfHire.Name = "doctorDateOfHire";
            this.doctorDateOfHire.Size = new System.Drawing.Size(168, 22);
            this.doctorDateOfHire.TabIndex = 23;
            // 
            // doctorLastName
            // 
            this.doctorLastName.Location = new System.Drawing.Point(89, 74);
            this.doctorLastName.Name = "doctorLastName";
            this.doctorLastName.Size = new System.Drawing.Size(168, 22);
            this.doctorLastName.TabIndex = 22;
            // 
            // doctorLastNameLabel
            // 
            this.doctorLastNameLabel.AutoSize = true;
            this.doctorLastNameLabel.Location = new System.Drawing.Point(3, 79);
            this.doctorLastNameLabel.Name = "doctorLastNameLabel";
            this.doctorLastNameLabel.Size = new System.Drawing.Size(80, 17);
            this.doctorLastNameLabel.TabIndex = 21;
            this.doctorLastNameLabel.Text = "Last Name:";
            // 
            // doctorFirstNameLabel
            // 
            this.doctorFirstNameLabel.AutoSize = true;
            this.doctorFirstNameLabel.Location = new System.Drawing.Point(3, 51);
            this.doctorFirstNameLabel.Name = "doctorFirstNameLabel";
            this.doctorFirstNameLabel.Size = new System.Drawing.Size(80, 17);
            this.doctorFirstNameLabel.TabIndex = 20;
            this.doctorFirstNameLabel.Text = "First Name:";
            // 
            // doctorIDLabel
            // 
            this.doctorIDLabel.AutoSize = true;
            this.doctorIDLabel.Location = new System.Drawing.Point(3, 22);
            this.doctorIDLabel.Name = "doctorIDLabel";
            this.doctorIDLabel.Size = new System.Drawing.Size(25, 17);
            this.doctorIDLabel.TabIndex = 19;
            this.doctorIDLabel.Text = "ID:";
            // 
            // doctorID
            // 
            this.doctorID.Location = new System.Drawing.Point(89, 16);
            this.doctorID.Name = "doctorID";
            this.doctorID.Size = new System.Drawing.Size(168, 22);
            this.doctorID.TabIndex = 18;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(274, 15);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(80, 24);
            this.button2.TabIndex = 17;
            this.button2.Text = "Apply";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // doctorFirstName
            // 
            this.doctorFirstName.Location = new System.Drawing.Point(89, 46);
            this.doctorFirstName.Name = "doctorFirstName";
            this.doctorFirstName.Size = new System.Drawing.Size(168, 22);
            this.doctorFirstName.TabIndex = 16;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.doctorsTab);
            this.tabControl1.Controls.Add(this.wardsTab);
            this.tabControl1.Controls.Add(this.patientsTab);
            this.tabControl1.Controls.Add(this.visitsTab);
            this.tabControl1.Controls.Add(this.queriesTab);
            this.tabControl1.Location = new System.Drawing.Point(3, 2);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(799, 595);
            this.tabControl1.TabIndex = 0;
            // 
            // patientsTab
            // 
            this.patientsTab.Controls.Add(this.panel10);
            this.patientsTab.Controls.Add(this.label2);
            this.patientsTab.Controls.Add(this.panel5);
            this.patientsTab.Controls.Add(this.panel4);
            this.patientsTab.Controls.Add(this.patientGenderLabel);
            this.patientsTab.Controls.Add(this.patientReset);
            this.patientsTab.Controls.Add(this.patientYOBLabel);
            this.patientsTab.Controls.Add(this.patientYOB);
            this.patientsTab.Controls.Add(this.patientMOBLabel);
            this.patientsTab.Controls.Add(this.patientMOB);
            this.patientsTab.Controls.Add(this.patientDOBLabel);
            this.patientsTab.Controls.Add(this.patientDOB);
            this.patientsTab.Controls.Add(this.patientLastName);
            this.patientsTab.Controls.Add(this.patientLastNameLabel);
            this.patientsTab.Controls.Add(this.patientFIrstNameLabel);
            this.patientsTab.Controls.Add(this.patientFirstName);
            this.patientsTab.Controls.Add(this.patientID);
            this.patientsTab.Controls.Add(this.patientIDLabel);
            this.patientsTab.Controls.Add(this.patientApply);
            this.patientsTab.Controls.Add(this.patientGridView);
            this.patientsTab.Location = new System.Drawing.Point(4, 25);
            this.patientsTab.Name = "patientsTab";
            this.patientsTab.Padding = new System.Windows.Forms.Padding(3);
            this.patientsTab.Size = new System.Drawing.Size(791, 566);
            this.patientsTab.TabIndex = 2;
            this.patientsTab.Text = "Patients";
            this.patientsTab.UseVisualStyleBackColor = true;
            this.patientsTab.Click += new System.EventHandler(this.tabPage1_Click);
            // 
            // panel10
            // 
            this.panel10.Controls.Add(this.patientOR);
            this.panel10.Controls.Add(this.patientAND);
            this.panel10.Location = new System.Drawing.Point(393, 21);
            this.panel10.Name = "panel10";
            this.panel10.Size = new System.Drawing.Size(124, 23);
            this.panel10.TabIndex = 50;
            // 
            // patientOR
            // 
            this.patientOR.AutoSize = true;
            this.patientOR.Location = new System.Drawing.Point(69, 1);
            this.patientOR.Name = "patientOR";
            this.patientOR.Size = new System.Drawing.Size(50, 21);
            this.patientOR.TabIndex = 32;
            this.patientOR.Text = "OR";
            this.patientOR.UseVisualStyleBackColor = true;
            // 
            // patientAND
            // 
            this.patientAND.AutoSize = true;
            this.patientAND.Checked = true;
            this.patientAND.Location = new System.Drawing.Point(5, 1);
            this.patientAND.Name = "patientAND";
            this.patientAND.Size = new System.Drawing.Size(58, 21);
            this.patientAND.TabIndex = 33;
            this.patientAND.TabStop = true;
            this.patientAND.Text = "AND";
            this.patientAND.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(330, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 17);
            this.label2.TabIndex = 49;
            this.label2.Text = "label2";
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.patientEq);
            this.panel5.Controls.Add(this.patientLe);
            this.panel5.Controls.Add(this.patientGt);
            this.panel5.Controls.Add(this.patientGe);
            this.panel5.Controls.Add(this.patientLt);
            this.panel5.Location = new System.Drawing.Point(284, 157);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(233, 25);
            this.panel5.TabIndex = 48;
            // 
            // patientEq
            // 
            this.patientEq.AutoSize = true;
            this.patientEq.Checked = true;
            this.patientEq.Location = new System.Drawing.Point(3, 3);
            this.patientEq.Name = "patientEq";
            this.patientEq.Size = new System.Drawing.Size(37, 21);
            this.patientEq.TabIndex = 38;
            this.patientEq.TabStop = true;
            this.patientEq.Text = "=";
            this.patientEq.UseVisualStyleBackColor = true;
            // 
            // patientLe
            // 
            this.patientLe.AutoSize = true;
            this.patientLe.Location = new System.Drawing.Point(132, 3);
            this.patientLe.Name = "patientLe";
            this.patientLe.Size = new System.Drawing.Size(45, 21);
            this.patientLe.TabIndex = 40;
            this.patientLe.Text = "<=";
            this.patientLe.UseVisualStyleBackColor = true;
            // 
            // patientGt
            // 
            this.patientGt.AutoSize = true;
            this.patientGt.Location = new System.Drawing.Point(89, 3);
            this.patientGt.Name = "patientGt";
            this.patientGt.Size = new System.Drawing.Size(37, 21);
            this.patientGt.TabIndex = 36;
            this.patientGt.Text = ">";
            this.patientGt.UseVisualStyleBackColor = true;
            // 
            // patientGe
            // 
            this.patientGe.AutoSize = true;
            this.patientGe.Location = new System.Drawing.Point(183, 3);
            this.patientGe.Name = "patientGe";
            this.patientGe.Size = new System.Drawing.Size(45, 21);
            this.patientGe.TabIndex = 39;
            this.patientGe.Text = ">=";
            this.patientGe.UseVisualStyleBackColor = true;
            // 
            // patientLt
            // 
            this.patientLt.AutoSize = true;
            this.patientLt.Location = new System.Drawing.Point(46, 3);
            this.patientLt.Name = "patientLt";
            this.patientLt.Size = new System.Drawing.Size(37, 21);
            this.patientLt.TabIndex = 37;
            this.patientLt.Text = "<";
            this.patientLt.UseVisualStyleBackColor = true;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.patientMale);
            this.panel4.Controls.Add(this.patientAllSex);
            this.panel4.Controls.Add(this.patientFemale);
            this.panel4.Location = new System.Drawing.Point(110, 187);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(223, 22);
            this.panel4.TabIndex = 47;
            // 
            // patientMale
            // 
            this.patientMale.AutoSize = true;
            this.patientMale.Location = new System.Drawing.Point(3, 3);
            this.patientMale.Name = "patientMale";
            this.patientMale.Size = new System.Drawing.Size(59, 21);
            this.patientMale.TabIndex = 44;
            this.patientMale.Text = "Male";
            this.patientMale.UseVisualStyleBackColor = true;
            // 
            // patientAllSex
            // 
            this.patientAllSex.AutoSize = true;
            this.patientAllSex.Checked = true;
            this.patientAllSex.Location = new System.Drawing.Point(150, 3);
            this.patientAllSex.Name = "patientAllSex";
            this.patientAllSex.Size = new System.Drawing.Size(53, 21);
            this.patientAllSex.TabIndex = 46;
            this.patientAllSex.TabStop = true;
            this.patientAllSex.Text = "Any";
            this.patientAllSex.UseVisualStyleBackColor = true;
            // 
            // patientFemale
            // 
            this.patientFemale.AutoSize = true;
            this.patientFemale.Location = new System.Drawing.Point(69, 3);
            this.patientFemale.Name = "patientFemale";
            this.patientFemale.Size = new System.Drawing.Size(75, 21);
            this.patientFemale.TabIndex = 45;
            this.patientFemale.Text = "Female";
            this.patientFemale.UseVisualStyleBackColor = true;
            // 
            // patientGenderLabel
            // 
            this.patientGenderLabel.AutoSize = true;
            this.patientGenderLabel.Location = new System.Drawing.Point(7, 192);
            this.patientGenderLabel.Name = "patientGenderLabel";
            this.patientGenderLabel.Size = new System.Drawing.Size(35, 17);
            this.patientGenderLabel.TabIndex = 43;
            this.patientGenderLabel.Text = "Sex:";
            // 
            // patientReset
            // 
            this.patientReset.Location = new System.Drawing.Point(706, 537);
            this.patientReset.Name = "patientReset";
            this.patientReset.Size = new System.Drawing.Size(75, 23);
            this.patientReset.TabIndex = 42;
            this.patientReset.Text = "Reset";
            this.patientReset.UseVisualStyleBackColor = true;
            this.patientReset.Click += new System.EventHandler(this.patientReset_Click);
            // 
            // patientYOBLabel
            // 
            this.patientYOBLabel.AutoSize = true;
            this.patientYOBLabel.Location = new System.Drawing.Point(7, 166);
            this.patientYOBLabel.Name = "patientYOBLabel";
            this.patientYOBLabel.Size = new System.Drawing.Size(91, 17);
            this.patientYOBLabel.TabIndex = 41;
            this.patientYOBLabel.Text = "Year of Birth:";
            // 
            // patientYOB
            // 
            this.patientYOB.Location = new System.Drawing.Point(110, 160);
            this.patientYOB.Name = "patientYOB";
            this.patientYOB.Size = new System.Drawing.Size(168, 22);
            this.patientYOB.TabIndex = 40;
            // 
            // patientMOBLabel
            // 
            this.patientMOBLabel.AutoSize = true;
            this.patientMOBLabel.Location = new System.Drawing.Point(7, 138);
            this.patientMOBLabel.Name = "patientMOBLabel";
            this.patientMOBLabel.Size = new System.Drawing.Size(100, 17);
            this.patientMOBLabel.TabIndex = 39;
            this.patientMOBLabel.Text = "Month of Birth:";
            // 
            // patientMOB
            // 
            this.patientMOB.Location = new System.Drawing.Point(110, 132);
            this.patientMOB.Name = "patientMOB";
            this.patientMOB.Size = new System.Drawing.Size(168, 22);
            this.patientMOB.TabIndex = 38;
            // 
            // patientDOBLabel
            // 
            this.patientDOBLabel.AutoSize = true;
            this.patientDOBLabel.Location = new System.Drawing.Point(7, 110);
            this.patientDOBLabel.Name = "patientDOBLabel";
            this.patientDOBLabel.Size = new System.Drawing.Size(91, 17);
            this.patientDOBLabel.TabIndex = 37;
            this.patientDOBLabel.Text = "Date of Birth:";
            // 
            // patientDOB
            // 
            this.patientDOB.Location = new System.Drawing.Point(110, 104);
            this.patientDOB.Name = "patientDOB";
            this.patientDOB.Size = new System.Drawing.Size(168, 22);
            this.patientDOB.TabIndex = 36;
            // 
            // patientLastName
            // 
            this.patientLastName.Location = new System.Drawing.Point(110, 76);
            this.patientLastName.Name = "patientLastName";
            this.patientLastName.Size = new System.Drawing.Size(168, 22);
            this.patientLastName.TabIndex = 35;
            // 
            // patientLastNameLabel
            // 
            this.patientLastNameLabel.AutoSize = true;
            this.patientLastNameLabel.Location = new System.Drawing.Point(7, 81);
            this.patientLastNameLabel.Name = "patientLastNameLabel";
            this.patientLastNameLabel.Size = new System.Drawing.Size(80, 17);
            this.patientLastNameLabel.TabIndex = 34;
            this.patientLastNameLabel.Text = "Last Name:";
            // 
            // patientFIrstNameLabel
            // 
            this.patientFIrstNameLabel.AutoSize = true;
            this.patientFIrstNameLabel.Location = new System.Drawing.Point(7, 53);
            this.patientFIrstNameLabel.Name = "patientFIrstNameLabel";
            this.patientFIrstNameLabel.Size = new System.Drawing.Size(80, 17);
            this.patientFIrstNameLabel.TabIndex = 33;
            this.patientFIrstNameLabel.Text = "First Name:";
            // 
            // patientFirstName
            // 
            this.patientFirstName.Location = new System.Drawing.Point(110, 48);
            this.patientFirstName.Name = "patientFirstName";
            this.patientFirstName.Size = new System.Drawing.Size(168, 22);
            this.patientFirstName.TabIndex = 32;
            // 
            // patientID
            // 
            this.patientID.Location = new System.Drawing.Point(110, 21);
            this.patientID.Name = "patientID";
            this.patientID.Size = new System.Drawing.Size(168, 22);
            this.patientID.TabIndex = 30;
            // 
            // patientIDLabel
            // 
            this.patientIDLabel.AutoSize = true;
            this.patientIDLabel.Location = new System.Drawing.Point(7, 26);
            this.patientIDLabel.Name = "patientIDLabel";
            this.patientIDLabel.Size = new System.Drawing.Size(25, 17);
            this.patientIDLabel.TabIndex = 31;
            this.patientIDLabel.Text = "ID:";
            // 
            // patientApply
            // 
            this.patientApply.Location = new System.Drawing.Point(295, 20);
            this.patientApply.Name = "patientApply";
            this.patientApply.Size = new System.Drawing.Size(80, 24);
            this.patientApply.TabIndex = 29;
            this.patientApply.Text = "Apply";
            this.patientApply.UseVisualStyleBackColor = true;
            this.patientApply.Click += new System.EventHandler(this.patientApply_Click_1);
            // 
            // patientGridView
            // 
            this.patientGridView.AutoGenerateColumns = false;
            this.patientGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.patientGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.patientIDDataGridViewTextBoxColumn,
            this.firstNameDataGridViewTextBoxColumn1,
            this.lastNameDataGridViewTextBoxColumn1,
            this.dateOfBirthDataGridViewTextBoxColumn,
            this.genderDataGridViewTextBoxColumn});
            this.patientGridView.DataSource = this.patientsBindingSource;
            this.patientGridView.Location = new System.Drawing.Point(3, 236);
            this.patientGridView.Name = "patientGridView";
            this.patientGridView.RowTemplate.Height = 24;
            this.patientGridView.Size = new System.Drawing.Size(780, 295);
            this.patientGridView.TabIndex = 28;
            // 
            // patientIDDataGridViewTextBoxColumn
            // 
            this.patientIDDataGridViewTextBoxColumn.DataPropertyName = "PatientID";
            this.patientIDDataGridViewTextBoxColumn.HeaderText = "PatientID";
            this.patientIDDataGridViewTextBoxColumn.Name = "patientIDDataGridViewTextBoxColumn";
            this.patientIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // firstNameDataGridViewTextBoxColumn1
            // 
            this.firstNameDataGridViewTextBoxColumn1.DataPropertyName = "FirstName";
            this.firstNameDataGridViewTextBoxColumn1.HeaderText = "FirstName";
            this.firstNameDataGridViewTextBoxColumn1.Name = "firstNameDataGridViewTextBoxColumn1";
            // 
            // lastNameDataGridViewTextBoxColumn1
            // 
            this.lastNameDataGridViewTextBoxColumn1.DataPropertyName = "LastName";
            this.lastNameDataGridViewTextBoxColumn1.HeaderText = "LastName";
            this.lastNameDataGridViewTextBoxColumn1.Name = "lastNameDataGridViewTextBoxColumn1";
            // 
            // dateOfBirthDataGridViewTextBoxColumn
            // 
            this.dateOfBirthDataGridViewTextBoxColumn.DataPropertyName = "DateOfBirth";
            this.dateOfBirthDataGridViewTextBoxColumn.HeaderText = "DateOfBirth";
            this.dateOfBirthDataGridViewTextBoxColumn.Name = "dateOfBirthDataGridViewTextBoxColumn";
            // 
            // genderDataGridViewTextBoxColumn
            // 
            this.genderDataGridViewTextBoxColumn.DataPropertyName = "Gender";
            this.genderDataGridViewTextBoxColumn.HeaderText = "Gender";
            this.genderDataGridViewTextBoxColumn.Name = "genderDataGridViewTextBoxColumn";
            // 
            // patientsBindingSource
            // 
            this.patientsBindingSource.DataMember = "Patients";
            this.patientsBindingSource.DataSource = this.cmpt291_projectDataSet;
            // 
            // visitsTab
            // 
            this.visitsTab.Controls.Add(this.panel12);
            this.visitsTab.Controls.Add(this.visitsYearLabel);
            this.visitsTab.Controls.Add(this.visitsYear);
            this.visitsTab.Controls.Add(this.visitsMonthLabel);
            this.visitsTab.Controls.Add(this.visitsMonth);
            this.visitsTab.Controls.Add(this.visitsDateLabel);
            this.visitsTab.Controls.Add(this.visitsDate);
            this.visitsTab.Controls.Add(this.visitsRegistrationID);
            this.visitsTab.Controls.Add(this.visitsRegistrationIDLabel);
            this.visitsTab.Controls.Add(this.visitsReset);
            this.visitsTab.Controls.Add(this.visitsGridView);
            this.visitsTab.Controls.Add(this.panel11);
            this.visitsTab.Controls.Add(this.visitsDoctorId);
            this.visitsTab.Controls.Add(this.visitsDoctorIDLabel);
            this.visitsTab.Controls.Add(this.visitsApply);
            this.visitsTab.Location = new System.Drawing.Point(4, 25);
            this.visitsTab.Name = "visitsTab";
            this.visitsTab.Padding = new System.Windows.Forms.Padding(3);
            this.visitsTab.Size = new System.Drawing.Size(791, 566);
            this.visitsTab.TabIndex = 3;
            this.visitsTab.Text = "Visits";
            this.visitsTab.UseVisualStyleBackColor = true;
            // 
            // panel12
            // 
            this.panel12.Controls.Add(this.visitsYearEq);
            this.panel12.Controls.Add(this.visitsLe);
            this.panel12.Controls.Add(this.visitsGt);
            this.panel12.Controls.Add(this.visitsGe);
            this.panel12.Controls.Add(this.visitsLt);
            this.panel12.Location = new System.Drawing.Point(292, 133);
            this.panel12.Name = "panel12";
            this.panel12.Size = new System.Drawing.Size(233, 25);
            this.panel12.TabIndex = 65;
            // 
            // visitsYearEq
            // 
            this.visitsYearEq.AutoSize = true;
            this.visitsYearEq.Checked = true;
            this.visitsYearEq.Location = new System.Drawing.Point(3, 3);
            this.visitsYearEq.Name = "visitsYearEq";
            this.visitsYearEq.Size = new System.Drawing.Size(37, 21);
            this.visitsYearEq.TabIndex = 38;
            this.visitsYearEq.TabStop = true;
            this.visitsYearEq.Text = "=";
            this.visitsYearEq.UseVisualStyleBackColor = true;
            // 
            // visitsLe
            // 
            this.visitsLe.AutoSize = true;
            this.visitsLe.Location = new System.Drawing.Point(132, 3);
            this.visitsLe.Name = "visitsLe";
            this.visitsLe.Size = new System.Drawing.Size(45, 21);
            this.visitsLe.TabIndex = 40;
            this.visitsLe.Text = "<=";
            this.visitsLe.UseVisualStyleBackColor = true;
            // 
            // visitsGt
            // 
            this.visitsGt.AutoSize = true;
            this.visitsGt.Location = new System.Drawing.Point(89, 3);
            this.visitsGt.Name = "visitsGt";
            this.visitsGt.Size = new System.Drawing.Size(37, 21);
            this.visitsGt.TabIndex = 36;
            this.visitsGt.Text = ">";
            this.visitsGt.UseVisualStyleBackColor = true;
            // 
            // visitsGe
            // 
            this.visitsGe.AutoSize = true;
            this.visitsGe.Location = new System.Drawing.Point(183, 3);
            this.visitsGe.Name = "visitsGe";
            this.visitsGe.Size = new System.Drawing.Size(45, 21);
            this.visitsGe.TabIndex = 39;
            this.visitsGe.Text = ">=";
            this.visitsGe.UseVisualStyleBackColor = true;
            // 
            // visitsLt
            // 
            this.visitsLt.AutoSize = true;
            this.visitsLt.Location = new System.Drawing.Point(46, 3);
            this.visitsLt.Name = "visitsLt";
            this.visitsLt.Size = new System.Drawing.Size(37, 21);
            this.visitsLt.TabIndex = 37;
            this.visitsLt.Text = "<";
            this.visitsLt.UseVisualStyleBackColor = true;
            // 
            // visitsYearLabel
            // 
            this.visitsYearLabel.AutoSize = true;
            this.visitsYearLabel.Location = new System.Drawing.Point(7, 141);
            this.visitsYearLabel.Name = "visitsYearLabel";
            this.visitsYearLabel.Size = new System.Drawing.Size(42, 17);
            this.visitsYearLabel.TabIndex = 64;
            this.visitsYearLabel.Text = "Year:";
            // 
            // visitsYear
            // 
            this.visitsYear.Location = new System.Drawing.Point(118, 136);
            this.visitsYear.Name = "visitsYear";
            this.visitsYear.Size = new System.Drawing.Size(168, 22);
            this.visitsYear.TabIndex = 63;
            // 
            // visitsMonthLabel
            // 
            this.visitsMonthLabel.AutoSize = true;
            this.visitsMonthLabel.Location = new System.Drawing.Point(7, 111);
            this.visitsMonthLabel.Name = "visitsMonthLabel";
            this.visitsMonthLabel.Size = new System.Drawing.Size(51, 17);
            this.visitsMonthLabel.TabIndex = 62;
            this.visitsMonthLabel.Text = "Month:";
            this.visitsMonthLabel.Click += new System.EventHandler(this.label4_Click);
            // 
            // visitsMonth
            // 
            this.visitsMonth.Location = new System.Drawing.Point(118, 108);
            this.visitsMonth.Name = "visitsMonth";
            this.visitsMonth.Size = new System.Drawing.Size(168, 22);
            this.visitsMonth.TabIndex = 61;
            // 
            // visitsDateLabel
            // 
            this.visitsDateLabel.AutoSize = true;
            this.visitsDateLabel.Location = new System.Drawing.Point(7, 85);
            this.visitsDateLabel.Name = "visitsDateLabel";
            this.visitsDateLabel.Size = new System.Drawing.Size(42, 17);
            this.visitsDateLabel.TabIndex = 60;
            this.visitsDateLabel.Text = "Date:";
            this.visitsDateLabel.Click += new System.EventHandler(this.label5_Click);
            // 
            // visitsDate
            // 
            this.visitsDate.Location = new System.Drawing.Point(118, 80);
            this.visitsDate.Name = "visitsDate";
            this.visitsDate.Size = new System.Drawing.Size(168, 22);
            this.visitsDate.TabIndex = 59;
            // 
            // visitsRegistrationID
            // 
            this.visitsRegistrationID.Location = new System.Drawing.Point(118, 52);
            this.visitsRegistrationID.Name = "visitsRegistrationID";
            this.visitsRegistrationID.Size = new System.Drawing.Size(168, 22);
            this.visitsRegistrationID.TabIndex = 57;
            // 
            // visitsRegistrationIDLabel
            // 
            this.visitsRegistrationIDLabel.AutoSize = true;
            this.visitsRegistrationIDLabel.Location = new System.Drawing.Point(7, 55);
            this.visitsRegistrationIDLabel.Name = "visitsRegistrationIDLabel";
            this.visitsRegistrationIDLabel.Size = new System.Drawing.Size(105, 17);
            this.visitsRegistrationIDLabel.TabIndex = 58;
            this.visitsRegistrationIDLabel.Text = "Registration ID:";
            // 
            // visitsReset
            // 
            this.visitsReset.Location = new System.Drawing.Point(706, 533);
            this.visitsReset.Name = "visitsReset";
            this.visitsReset.Size = new System.Drawing.Size(75, 23);
            this.visitsReset.TabIndex = 56;
            this.visitsReset.Text = "Reset";
            this.visitsReset.UseVisualStyleBackColor = true;
            // 
            // visitsGridView
            // 
            this.visitsGridView.AutoGenerateColumns = false;
            this.visitsGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.visitsGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.registrationIDDataGridViewTextBoxColumn,
            this.doctorIDDataGridViewTextBoxColumn1,
            this.timeStampDataGridViewTextBoxColumn,
            this.notesDataGridViewTextBoxColumn});
            this.visitsGridView.DataSource = this.visitsBindingSource;
            this.visitsGridView.Location = new System.Drawing.Point(5, 237);
            this.visitsGridView.Name = "visitsGridView";
            this.visitsGridView.RowTemplate.Height = 24;
            this.visitsGridView.Size = new System.Drawing.Size(780, 290);
            this.visitsGridView.TabIndex = 55;
            // 
            // registrationIDDataGridViewTextBoxColumn
            // 
            this.registrationIDDataGridViewTextBoxColumn.DataPropertyName = "RegistrationID";
            this.registrationIDDataGridViewTextBoxColumn.HeaderText = "RegistrationID";
            this.registrationIDDataGridViewTextBoxColumn.Name = "registrationIDDataGridViewTextBoxColumn";
            // 
            // doctorIDDataGridViewTextBoxColumn1
            // 
            this.doctorIDDataGridViewTextBoxColumn1.DataPropertyName = "DoctorID";
            this.doctorIDDataGridViewTextBoxColumn1.HeaderText = "DoctorID";
            this.doctorIDDataGridViewTextBoxColumn1.Name = "doctorIDDataGridViewTextBoxColumn1";
            // 
            // timeStampDataGridViewTextBoxColumn
            // 
            this.timeStampDataGridViewTextBoxColumn.DataPropertyName = "TimeStamp";
            this.timeStampDataGridViewTextBoxColumn.HeaderText = "TimeStamp";
            this.timeStampDataGridViewTextBoxColumn.Name = "timeStampDataGridViewTextBoxColumn";
            // 
            // notesDataGridViewTextBoxColumn
            // 
            this.notesDataGridViewTextBoxColumn.DataPropertyName = "Notes";
            this.notesDataGridViewTextBoxColumn.HeaderText = "Notes";
            this.notesDataGridViewTextBoxColumn.Name = "notesDataGridViewTextBoxColumn";
            // 
            // visitsBindingSource
            // 
            this.visitsBindingSource.DataMember = "Visits";
            this.visitsBindingSource.DataSource = this.cmpt291_projectDataSet;
            // 
            // panel11
            // 
            this.panel11.Controls.Add(this.visitsOR);
            this.panel11.Controls.Add(this.visitsAND);
            this.panel11.Location = new System.Drawing.Point(393, 22);
            this.panel11.Name = "panel11";
            this.panel11.Size = new System.Drawing.Size(124, 23);
            this.panel11.TabIndex = 54;
            // 
            // visitsOR
            // 
            this.visitsOR.AutoSize = true;
            this.visitsOR.Location = new System.Drawing.Point(69, 1);
            this.visitsOR.Name = "visitsOR";
            this.visitsOR.Size = new System.Drawing.Size(50, 21);
            this.visitsOR.TabIndex = 32;
            this.visitsOR.Text = "OR";
            this.visitsOR.UseVisualStyleBackColor = true;
            // 
            // visitsAND
            // 
            this.visitsAND.AutoSize = true;
            this.visitsAND.Checked = true;
            this.visitsAND.Location = new System.Drawing.Point(5, 1);
            this.visitsAND.Name = "visitsAND";
            this.visitsAND.Size = new System.Drawing.Size(58, 21);
            this.visitsAND.TabIndex = 33;
            this.visitsAND.TabStop = true;
            this.visitsAND.Text = "AND";
            this.visitsAND.UseVisualStyleBackColor = true;
            // 
            // visitsDoctorId
            // 
            this.visitsDoctorId.Location = new System.Drawing.Point(118, 23);
            this.visitsDoctorId.Name = "visitsDoctorId";
            this.visitsDoctorId.Size = new System.Drawing.Size(168, 22);
            this.visitsDoctorId.TabIndex = 52;
            this.visitsDoctorId.TextChanged += new System.EventHandler(this.visitsDoctorId_TextChanged);
            // 
            // visitsDoctorIDLabel
            // 
            this.visitsDoctorIDLabel.AutoSize = true;
            this.visitsDoctorIDLabel.Location = new System.Drawing.Point(7, 28);
            this.visitsDoctorIDLabel.Name = "visitsDoctorIDLabel";
            this.visitsDoctorIDLabel.Size = new System.Drawing.Size(71, 17);
            this.visitsDoctorIDLabel.TabIndex = 53;
            this.visitsDoctorIDLabel.Text = "Doctor ID:";
            // 
            // visitsApply
            // 
            this.visitsApply.Location = new System.Drawing.Point(295, 21);
            this.visitsApply.Name = "visitsApply";
            this.visitsApply.Size = new System.Drawing.Size(80, 24);
            this.visitsApply.TabIndex = 51;
            this.visitsApply.Text = "Apply";
            this.visitsApply.UseVisualStyleBackColor = true;
            this.visitsApply.Click += new System.EventHandler(this.visitsApply_Click);
            // 
            // queriesTab
            // 
            this.queriesTab.Controls.Add(this.QueryTabControl);
            this.queriesTab.Controls.Add(this.queryLabel);
            this.queriesTab.Location = new System.Drawing.Point(4, 25);
            this.queriesTab.Name = "queriesTab";
            this.queriesTab.Padding = new System.Windows.Forms.Padding(3);
            this.queriesTab.Size = new System.Drawing.Size(791, 566);
            this.queriesTab.TabIndex = 4;
            this.queriesTab.Text = "Queries";
            this.queriesTab.UseVisualStyleBackColor = true;
            // 
            // QueryTabControl
            // 
            this.QueryTabControl.Controls.Add(this.patientTab2);
            this.QueryTabControl.Controls.Add(this.tabPage1);
            this.QueryTabControl.Location = new System.Drawing.Point(9, 23);
            this.QueryTabControl.Name = "QueryTabControl";
            this.QueryTabControl.SelectedIndex = 0;
            this.QueryTabControl.Size = new System.Drawing.Size(776, 531);
            this.QueryTabControl.TabIndex = 11;
            // 
            // patientTab2
            // 
            this.patientTab2.Controls.Add(this.resultsList);
            this.patientTab2.Controls.Add(this.queryResults);
            this.patientTab2.Controls.Add(this.patientVisitEveryWard);
            this.patientTab2.Controls.Add(this.wardsComboBox);
            this.patientTab2.Controls.Add(this.visitedSpecificWard);
            this.patientTab2.Controls.Add(this.applyQuery);
            this.patientTab2.Location = new System.Drawing.Point(4, 25);
            this.patientTab2.Name = "patientTab2";
            this.patientTab2.Padding = new System.Windows.Forms.Padding(3);
            this.patientTab2.Size = new System.Drawing.Size(768, 502);
            this.patientTab2.TabIndex = 0;
            this.patientTab2.Text = "Patients";
            this.patientTab2.UseVisualStyleBackColor = true;
            // 
            // resultsList
            // 
            this.resultsList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.idListViewHeader,
            this.fullnameListViewHeader,
            this.dobListViewHeader,
            this.genderListViewHeader});
            this.resultsList.Location = new System.Drawing.Point(267, 60);
            this.resultsList.Name = "resultsList";
            this.resultsList.Size = new System.Drawing.Size(495, 436);
            this.resultsList.TabIndex = 15;
            this.resultsList.UseCompatibleStateImageBehavior = false;
            this.resultsList.View = System.Windows.Forms.View.Details;
            // 
            // idListViewHeader
            // 
            this.idListViewHeader.Text = "ID";
            this.idListViewHeader.Width = 56;
            // 
            // fullnameListViewHeader
            // 
            this.fullnameListViewHeader.Text = "Fullname";
            this.fullnameListViewHeader.Width = 97;
            // 
            // dobListViewHeader
            // 
            this.dobListViewHeader.Text = "Date of Birth";
            this.dobListViewHeader.Width = 150;
            // 
            // genderListViewHeader
            // 
            this.genderListViewHeader.Text = "Gender";
            // 
            // queryResults
            // 
            this.queryResults.AutoSize = true;
            this.queryResults.Location = new System.Drawing.Point(264, 15);
            this.queryResults.Name = "queryResults";
            this.queryResults.Size = new System.Drawing.Size(59, 17);
            this.queryResults.TabIndex = 13;
            this.queryResults.Text = "Results:";
            // 
            // patientVisitEveryWard
            // 
            this.patientVisitEveryWard.AutoSize = true;
            this.patientVisitEveryWard.Checked = true;
            this.patientVisitEveryWard.Location = new System.Drawing.Point(8, 6);
            this.patientVisitEveryWard.Name = "patientVisitEveryWard";
            this.patientVisitEveryWard.Size = new System.Drawing.Size(226, 21);
            this.patientVisitEveryWard.TabIndex = 1;
            this.patientVisitEveryWard.TabStop = true;
            this.patientVisitEveryWard.Text = "Patients who visited every ward";
            this.patientVisitEveryWard.UseVisualStyleBackColor = true;
            // 
            // wardsComboBox
            // 
            this.wardsComboBox.DataSource = this.wardsBindingSource;
            this.wardsComboBox.DisplayMember = "WardName";
            this.wardsComboBox.FormattingEnabled = true;
            this.wardsComboBox.Location = new System.Drawing.Point(44, 60);
            this.wardsComboBox.Name = "wardsComboBox";
            this.wardsComboBox.Size = new System.Drawing.Size(121, 24);
            this.wardsComboBox.TabIndex = 4;
            // 
            // visitedSpecificWard
            // 
            this.visitedSpecificWard.AutoSize = true;
            this.visitedSpecificWard.Location = new System.Drawing.Point(8, 33);
            this.visitedSpecificWard.Name = "visitedSpecificWard";
            this.visitedSpecificWard.Size = new System.Drawing.Size(157, 21);
            this.visitedSpecificWard.TabIndex = 3;
            this.visitedSpecificWard.TabStop = true;
            this.visitedSpecificWard.Text = "Patients who visited:";
            this.visitedSpecificWard.UseVisualStyleBackColor = true;
            // 
            // applyQuery
            // 
            this.applyQuery.Location = new System.Drawing.Point(186, 473);
            this.applyQuery.Name = "applyQuery";
            this.applyQuery.Size = new System.Drawing.Size(75, 23);
            this.applyQuery.TabIndex = 10;
            this.applyQuery.Text = "Apply";
            this.applyQuery.UseVisualStyleBackColor = true;
            this.applyQuery.Click += new System.EventHandler(this.applyQuery_Click_1);
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.doctorResultsList);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.radioButton1);
            this.tabPage1.Controls.Add(this.doctorWorkedWithBox);
            this.tabPage1.Controls.Add(this.doctorsWorkWith);
            this.tabPage1.Controls.Add(this.doctorQueryApply);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(768, 502);
            this.tabPage1.TabIndex = 2;
            this.tabPage1.Text = "Doctors";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // doctorResultsList
            // 
            this.doctorResultsList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4});
            this.doctorResultsList.Location = new System.Drawing.Point(267, 60);
            this.doctorResultsList.Name = "doctorResultsList";
            this.doctorResultsList.Size = new System.Drawing.Size(495, 436);
            this.doctorResultsList.TabIndex = 15;
            this.doctorResultsList.UseCompatibleStateImageBehavior = false;
            this.doctorResultsList.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "ID";
            this.columnHeader1.Width = 56;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Fullname";
            this.columnHeader2.Width = 97;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Hire Date";
            this.columnHeader3.Width = 150;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Salary";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(264, 15);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 17);
            this.label4.TabIndex = 13;
            this.label4.Text = "Results:";
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Checked = true;
            this.radioButton1.Location = new System.Drawing.Point(8, 6);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(114, 21);
            this.radioButton1.TabIndex = 1;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "DOCOTRS....";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // doctorWorkedWithBox
            // 
            this.doctorWorkedWithBox.DataSource = this.patientsBindingSource2;
            this.doctorWorkedWithBox.DisplayMember = "LastName";
            this.doctorWorkedWithBox.FormattingEnabled = true;
            this.doctorWorkedWithBox.Location = new System.Drawing.Point(44, 60);
            this.doctorWorkedWithBox.Name = "doctorWorkedWithBox";
            this.doctorWorkedWithBox.Size = new System.Drawing.Size(121, 24);
            this.doctorWorkedWithBox.TabIndex = 4;
            this.doctorWorkedWithBox.ValueMember = "PatientID";
            // 
            // patientsBindingSource2
            // 
            this.patientsBindingSource2.DataMember = "Patients";
            this.patientsBindingSource2.DataSource = this.cmpt291_projectDataSet;
            // 
            // doctorsWorkWith
            // 
            this.doctorsWorkWith.AutoSize = true;
            this.doctorsWorkWith.Location = new System.Drawing.Point(8, 33);
            this.doctorsWorkWith.Name = "doctorsWorkWith";
            this.doctorsWorkWith.Size = new System.Drawing.Size(188, 21);
            this.doctorsWorkWith.TabIndex = 3;
            this.doctorsWorkWith.TabStop = true;
            this.doctorsWorkWith.Text = "Doctors who worked with:";
            this.doctorsWorkWith.UseVisualStyleBackColor = true;
            // 
            // doctorQueryApply
            // 
            this.doctorQueryApply.Location = new System.Drawing.Point(186, 473);
            this.doctorQueryApply.Name = "doctorQueryApply";
            this.doctorQueryApply.Size = new System.Drawing.Size(75, 23);
            this.doctorQueryApply.TabIndex = 10;
            this.doctorQueryApply.Text = "Apply";
            this.doctorQueryApply.UseVisualStyleBackColor = true;
            this.doctorQueryApply.Click += new System.EventHandler(this.doctorQueryApplyClick);
            // 
            // queryLabel
            // 
            this.queryLabel.AutoSize = true;
            this.queryLabel.Location = new System.Drawing.Point(6, 3);
            this.queryLabel.Name = "queryLabel";
            this.queryLabel.Size = new System.Drawing.Size(58, 17);
            this.queryLabel.TabIndex = 7;
            this.queryLabel.Text = "Queries";
            // 
            // wardsBindingSource1
            // 
            this.wardsBindingSource1.DataMember = "Wards";
            this.wardsBindingSource1.DataSource = this.cmpt291_projectDataSet;
            // 
            // patienBindingSource1
            // 
            this.patienBindingSource1.DataMember = "patien";
            this.patienBindingSource1.DataSource = this.projectDataSetBindingSource;
            // 
            // doctorsTableAdapter
            // 
            // 
            // wardTableAdapter
            // 
            // 
            // patienBindingSource
            // 
            this.patienBindingSource.DataMember = "patien";
            // 
            // patienTableAdapter
            //
            // 
            // doctorsBindingSource1
            // 
            this.doctorsBindingSource1.DataMember = "Doctors";
            this.doctorsBindingSource1.DataSource = this.cmpt291_projectDataSet;
            // 
            // doctorsTableAdapter1
            // 
            this.doctorsTableAdapter1.ClearBeforeFill = true;
            // 
            // wardsTableAdapter
            // 
            this.wardsTableAdapter.ClearBeforeFill = true;
            // 
            // patientsTableAdapter
            // 
            this.patientsTableAdapter.ClearBeforeFill = true;
            // 
            // patientsBindingSource1
            // 
            this.patientsBindingSource1.DataMember = "Patients";
            this.patientsBindingSource1.DataSource = this.cmpt291_projectDataSet;
            // 
            // visitsTableAdapter
            // 
            this.visitsTableAdapter.ClearBeforeFill = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 593);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "\'";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.doctorsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.wardBindingSource)).EndInit();
            this.wardsTab.ResumeLayout(false);
            this.wardsTab.PerformLayout();
            this.panel9.ResumeLayout(false);
            this.panel9.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.wardGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.wardsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmpt291_projectDataSet)).EndInit();
            this.doctorsTab.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.doctorsBindingSource2)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel8.ResumeLayout(false);
            this.panel8.PerformLayout();
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.patientsTab.ResumeLayout(false);
            this.patientsTab.PerformLayout();
            this.panel10.ResumeLayout(false);
            this.panel10.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.patientGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.patientsBindingSource)).EndInit();
            this.visitsTab.ResumeLayout(false);
            this.visitsTab.PerformLayout();
            this.panel12.ResumeLayout(false);
            this.panel12.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.visitsGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.visitsBindingSource)).EndInit();
            this.panel11.ResumeLayout(false);
            this.panel11.PerformLayout();
            this.queriesTab.ResumeLayout(false);
            this.queriesTab.PerformLayout();
            this.QueryTabControl.ResumeLayout(false);
            this.patientTab2.ResumeLayout(false);
            this.patientTab2.PerformLayout();
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.patientsBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.wardsBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.patienBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.patienBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.doctorsBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.patientsBindingSource1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.BindingSource projectDataSetBindingSource;
        private System.Windows.Forms.BindingSource doctorsBindingSource;
        private System.Windows.Forms.BindingSource wardBindingSource;
        private System.Windows.Forms.TabPage wardsTab;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.RadioButton countEq;
        private System.Windows.Forms.RadioButton countLe;
        private System.Windows.Forms.RadioButton countGt;
        private System.Windows.Forms.RadioButton countGe;
        private System.Windows.Forms.RadioButton countLt;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.RadioButton capacityEq;
        private System.Windows.Forms.RadioButton capacityLe;
        private System.Windows.Forms.RadioButton capacityGt;
        private System.Windows.Forms.RadioButton capacityGe;
        private System.Windows.Forms.RadioButton capacityLt;
        private System.Windows.Forms.Button wardReset;
        private System.Windows.Forms.DataGridView wardGridView;
        private System.Windows.Forms.Label wardCountLabel;
        private System.Windows.Forms.TextBox wardCount;
        private System.Windows.Forms.TextBox wardCapacity;
        private System.Windows.Forms.TextBox wardName;
        private System.Windows.Forms.Label wardCapacityLabel;
        private System.Windows.Forms.Label wardNameLabel;
        private System.Windows.Forms.Button wardApply;
        private System.Windows.Forms.TabPage doctorsTab;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button doctorReset;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label wardSearchLabel;
        private System.Windows.Forms.RadioButton doctorSalaryLe;
        private System.Windows.Forms.RadioButton doctorSalaryGe;
        private System.Windows.Forms.RadioButton doctorSalaryEq;
        private System.Windows.Forms.RadioButton doctorSalaryLt;
        private System.Windows.Forms.RadioButton doctorSalaryGt;
        private System.Windows.Forms.Label doctorSalaryLabel;
        private System.Windows.Forms.TextBox doctorSalary;
        private System.Windows.Forms.Label yearOfHireLabel;
        private System.Windows.Forms.TextBox doctorYearOfHire;
        private System.Windows.Forms.Label doctorMonthOfHireLabel;
        private System.Windows.Forms.TextBox doctorMonthOfHire;
        private System.Windows.Forms.Label doctorDateOfHireLabel;
        private System.Windows.Forms.TextBox doctorDateOfHire;
        private System.Windows.Forms.TextBox doctorLastName;
        private System.Windows.Forms.Label doctorLastNameLabel;
        private System.Windows.Forms.Label doctorFirstNameLabel;
        private System.Windows.Forms.Label doctorIDLabel;
        private System.Windows.Forms.TextBox doctorID;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox doctorFirstName;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage patientsTab;
        private System.Windows.Forms.DataGridView patientGridView;
        private System.Windows.Forms.BindingSource patienBindingSource;
        private System.Windows.Forms.BindingSource patienBindingSource1;
        private System.Windows.Forms.TextBox patientID;
        private System.Windows.Forms.Label patientIDLabel;
        private System.Windows.Forms.Button patientApply;
        private System.Windows.Forms.Label patientYOBLabel;
        private System.Windows.Forms.TextBox patientYOB;
        private System.Windows.Forms.Label patientMOBLabel;
        private System.Windows.Forms.TextBox patientMOB;
        private System.Windows.Forms.Label patientDOBLabel;
        private System.Windows.Forms.TextBox patientDOB;
        private System.Windows.Forms.TextBox patientLastName;
        private System.Windows.Forms.Label patientLastNameLabel;
        private System.Windows.Forms.Label patientFIrstNameLabel;
        private System.Windows.Forms.TextBox patientFirstName;
        private System.Windows.Forms.Button patientReset;
        private System.Windows.Forms.RadioButton patientFemale;
        private System.Windows.Forms.RadioButton patientMale;
        private System.Windows.Forms.Label patientGenderLabel;
        private System.Windows.Forms.RadioButton patientAllSex;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.RadioButton patientEq;
        private System.Windows.Forms.RadioButton patientLe;
        private System.Windows.Forms.RadioButton patientGt;
        private System.Windows.Forms.RadioButton patientGe;
        private System.Windows.Forms.RadioButton patientLt;
        private cmpt291_projectDataSet cmpt291_projectDataSet;
        private System.Windows.Forms.BindingSource doctorsBindingSource1;
        private cmpt291_projectDataSetTableAdapters.DoctorsTableAdapter doctorsTableAdapter1;
        private System.Windows.Forms.BindingSource wardsBindingSource;
        private cmpt291_projectDataSetTableAdapters.WardsTableAdapter wardsTableAdapter;
        private System.Windows.Forms.BindingSource patientsBindingSource;
        private cmpt291_projectDataSetTableAdapters.PatientsTableAdapter patientsTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn wardNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn maxCapacityDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn currentCapacityDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn doctorIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn firstNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lastNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn hireDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn salaryDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource doctorsBindingSource2;
        private System.Windows.Forms.DataGridViewTextBoxColumn patientIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn firstNameDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn lastNameDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateOfBirthDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn genderDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource patientsBindingSource1;
        private System.Windows.Forms.BindingSource patientsBindingSource2;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.RadioButton doctorYearLt;
        private System.Windows.Forms.RadioButton doctorYearGt;
        private System.Windows.Forms.RadioButton doctorYearLe;
        private System.Windows.Forms.RadioButton doctorYearEq;
        private System.Windows.Forms.RadioButton doctorYearGe;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.RadioButton doctorOR;
        private System.Windows.Forms.RadioButton doctorAND;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.RadioButton wardOR;
        private System.Windows.Forms.RadioButton wardAND;
        private System.Windows.Forms.Panel panel10;
        private System.Windows.Forms.RadioButton patientOR;
        private System.Windows.Forms.RadioButton patientAND;
        private System.Windows.Forms.TabPage visitsTab;
        private System.Windows.Forms.TextBox visitsRegistrationID;
        private System.Windows.Forms.Label visitsRegistrationIDLabel;
        private System.Windows.Forms.Button visitsReset;
        private System.Windows.Forms.DataGridView visitsGridView;
        private System.Windows.Forms.Panel panel11;
        private System.Windows.Forms.RadioButton visitsOR;
        private System.Windows.Forms.RadioButton visitsAND;
        private System.Windows.Forms.TextBox visitsDoctorId;
        private System.Windows.Forms.Label visitsDoctorIDLabel;
        private System.Windows.Forms.Button visitsApply;
        private System.Windows.Forms.Panel panel12;
        private System.Windows.Forms.RadioButton visitsYearEq;
        private System.Windows.Forms.RadioButton visitsLe;
        private System.Windows.Forms.RadioButton visitsGt;
        private System.Windows.Forms.RadioButton visitsGe;
        private System.Windows.Forms.RadioButton visitsLt;
        private System.Windows.Forms.Label visitsYearLabel;
        private System.Windows.Forms.TextBox visitsYear;
        private System.Windows.Forms.Label visitsMonthLabel;
        private System.Windows.Forms.TextBox visitsMonth;
        private System.Windows.Forms.Label visitsDateLabel;
        private System.Windows.Forms.TextBox visitsDate;
        private System.Windows.Forms.BindingSource visitsBindingSource;
        private cmpt291_projectDataSetTableAdapters.VisitsTableAdapter visitsTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn registrationIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn doctorIDDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn timeStampDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn notesDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource wardsBindingSource1;
        private System.Windows.Forms.TabPage queriesTab;
        private System.Windows.Forms.Label queryLabel;
        private System.Windows.Forms.TabControl QueryTabControl;
        private System.Windows.Forms.TabPage patientTab2;
        private System.Windows.Forms.ListView resultsList;
        private System.Windows.Forms.ColumnHeader idListViewHeader;
        private System.Windows.Forms.ColumnHeader fullnameListViewHeader;
        private System.Windows.Forms.ColumnHeader dobListViewHeader;
        private System.Windows.Forms.ColumnHeader genderListViewHeader;
        private System.Windows.Forms.Label queryResults;
        private System.Windows.Forms.RadioButton patientVisitEveryWard;
        private System.Windows.Forms.ComboBox wardsComboBox;
        private System.Windows.Forms.RadioButton visitedSpecificWard;
        private System.Windows.Forms.Button applyQuery;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.ListView doctorResultsList;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.ComboBox doctorWorkedWithBox;
        private System.Windows.Forms.RadioButton doctorsWorkWith;
        private System.Windows.Forms.Button doctorQueryApply;
    }
}

