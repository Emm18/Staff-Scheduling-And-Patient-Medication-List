namespace ACHSystem.Edit
{
    partial class frmPatientMedicationList
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPatientMedicationList));
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rdByLastName = new System.Windows.Forms.RadioButton();
            this.rdById = new System.Windows.Forms.RadioButton();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnGo = new System.Windows.Forms.Button();
            this.dgvPatient = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column14 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.dgvPatientMedication = new System.Windows.Forms.DataGridView();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column13 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column15 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnAdd = new System.Windows.Forms.Button();
            this.lblPatientName = new System.Windows.Forms.Label();
            this.lblPatientId = new System.Windows.Forms.Label();
            this.lblFacility = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnRemove = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnEdit = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label19 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lblStartDate = new System.Windows.Forms.Label();
            this.rdNumOfDays = new System.Windows.Forms.RadioButton();
            this.rdDaily = new System.Windows.Forms.RadioButton();
            this.rdStop = new System.Windows.Forms.RadioButton();
            this.txtNumOfDays = new System.Windows.Forms.TextBox();
            this.lblEndDate = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.dtStarted = new System.Windows.Forms.DateTimePicker();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.label14 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.txtDosage = new System.Windows.Forms.TextBox();
            this.txtOrderedBy = new System.Windows.Forms.TextBox();
            this.txtDirection = new System.Windows.Forms.TextBox();
            this.txtMedicationName = new System.Windows.Forms.TextBox();
            this.txtNotes = new System.Windows.Forms.RichTextBox();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPatient)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPatientMedication)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rdByLastName);
            this.groupBox2.Controls.Add(this.rdById);
            this.groupBox2.Controls.Add(this.btnClear);
            this.groupBox2.Controls.Add(this.btnGo);
            this.groupBox2.Controls.Add(this.dgvPatient);
            this.groupBox2.Controls.Add(this.txtSearch);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(215, 3);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(433, 238);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            // 
            // rdByLastName
            // 
            this.rdByLastName.AutoSize = true;
            this.rdByLastName.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdByLastName.Location = new System.Drawing.Point(134, 55);
            this.rdByLastName.Name = "rdByLastName";
            this.rdByLastName.Size = new System.Drawing.Size(92, 18);
            this.rdByLastName.TabIndex = 6;
            this.rdByLastName.TabStop = true;
            this.rdByLastName.Text = "By Last Name";
            this.rdByLastName.UseVisualStyleBackColor = true;
            // 
            // rdById
            // 
            this.rdById.AutoSize = true;
            this.rdById.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdById.Location = new System.Drawing.Point(67, 55);
            this.rdById.Name = "rdById";
            this.rdById.Size = new System.Drawing.Size(50, 18);
            this.rdById.TabIndex = 5;
            this.rdById.TabStop = true;
            this.rdById.Text = "By ID";
            this.rdById.UseVisualStyleBackColor = true;
            // 
            // btnClear
            // 
            this.btnClear.Image = ((System.Drawing.Image)(resources.GetObject("btnClear.Image")));
            this.btnClear.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnClear.Location = new System.Drawing.Point(327, 20);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(89, 33);
            this.btnClear.TabIndex = 4;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnGo
            // 
            this.btnGo.Image = ((System.Drawing.Image)(resources.GetObject("btnGo.Image")));
            this.btnGo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGo.Location = new System.Drawing.Point(232, 20);
            this.btnGo.Name = "btnGo";
            this.btnGo.Size = new System.Drawing.Size(89, 33);
            this.btnGo.TabIndex = 3;
            this.btnGo.Text = "Go";
            this.btnGo.UseVisualStyleBackColor = true;
            this.btnGo.Click += new System.EventHandler(this.btnGo_Click);
            // 
            // dgvPatient
            // 
            this.dgvPatient.AllowUserToAddRows = false;
            this.dgvPatient.AllowUserToDeleteRows = false;
            this.dgvPatient.AllowUserToResizeColumns = false;
            this.dgvPatient.AllowUserToResizeRows = false;
            this.dgvPatient.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPatient.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column14,
            this.Column4});
            this.dgvPatient.Location = new System.Drawing.Point(25, 84);
            this.dgvPatient.Name = "dgvPatient";
            this.dgvPatient.ReadOnly = true;
            this.dgvPatient.RowHeadersVisible = false;
            this.dgvPatient.Size = new System.Drawing.Size(391, 150);
            this.dgvPatient.TabIndex = 7;
            this.dgvPatient.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPatient_CellDoubleClick);
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "PatientID";
            this.Column1.HeaderText = "Patient ID";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column14
            // 
            this.Column14.DataPropertyName = "FacilityName";
            this.Column14.HeaderText = "Facility";
            this.Column14.Name = "Column14";
            this.Column14.ReadOnly = true;
            this.Column14.Visible = false;
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "PatientName";
            this.Column4.HeaderText = "Patient Name";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            this.Column4.Width = 250;
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(67, 25);
            this.txtSearch.MaxLength = 50;
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(159, 25);
            this.txtSearch.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 30);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 17);
            this.label4.TabIndex = 23;
            this.label4.Text = "Search";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.dgvPatientMedication);
            this.groupBox1.Controls.Add(this.btnAdd);
            this.groupBox1.Controls.Add(this.lblPatientName);
            this.groupBox1.Controls.Add(this.lblPatientId);
            this.groupBox1.Controls.Add(this.lblFacility);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.btnRemove);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 247);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(345, 417);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(5, 81);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 14);
            this.label3.TabIndex = 69;
            this.label3.Text = "Medication List";
            // 
            // dgvPatientMedication
            // 
            this.dgvPatientMedication.AllowUserToAddRows = false;
            this.dgvPatientMedication.AllowUserToDeleteRows = false;
            this.dgvPatientMedication.AllowUserToResizeColumns = false;
            this.dgvPatientMedication.AllowUserToResizeRows = false;
            this.dgvPatientMedication.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPatientMedication.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column2,
            this.Column3,
            this.Column5,
            this.Column6,
            this.Column7,
            this.Column8,
            this.Column9,
            this.Column10,
            this.Column12,
            this.Column11,
            this.Column13,
            this.Column15});
            this.dgvPatientMedication.Location = new System.Drawing.Point(6, 96);
            this.dgvPatientMedication.Name = "dgvPatientMedication";
            this.dgvPatientMedication.ReadOnly = true;
            this.dgvPatientMedication.RowHeadersVisible = false;
            this.dgvPatientMedication.Size = new System.Drawing.Size(333, 266);
            this.dgvPatientMedication.TabIndex = 9;
            this.dgvPatientMedication.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPatientMedication_CellDoubleClick);
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "PatientId";
            this.Column2.HeaderText = "PatientID";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Visible = false;
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "FacilityName";
            this.Column3.HeaderText = "FacilityName";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            this.Column3.Visible = false;
            // 
            // Column5
            // 
            this.Column5.DataPropertyName = "PatientName";
            this.Column5.HeaderText = "PatientName";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            this.Column5.Visible = false;
            // 
            // Column6
            // 
            this.Column6.DataPropertyName = "MedicationName";
            this.Column6.HeaderText = "Medication Name";
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            this.Column6.Width = 220;
            // 
            // Column7
            // 
            this.Column7.DataPropertyName = "Dosage";
            this.Column7.HeaderText = "Dosage";
            this.Column7.Name = "Column7";
            this.Column7.ReadOnly = true;
            // 
            // Column8
            // 
            this.Column8.DataPropertyName = "Direction";
            this.Column8.HeaderText = "Direction";
            this.Column8.Name = "Column8";
            this.Column8.ReadOnly = true;
            this.Column8.Visible = false;
            // 
            // Column9
            // 
            this.Column9.DataPropertyName = "OrderedBy";
            this.Column9.HeaderText = "Ordered By";
            this.Column9.Name = "Column9";
            this.Column9.ReadOnly = true;
            this.Column9.Visible = false;
            // 
            // Column10
            // 
            this.Column10.DataPropertyName = "StartDate";
            this.Column10.HeaderText = "Start Date";
            this.Column10.Name = "Column10";
            this.Column10.ReadOnly = true;
            this.Column10.Visible = false;
            // 
            // Column12
            // 
            this.Column12.DataPropertyName = "DurationType";
            this.Column12.HeaderText = "Duration Type";
            this.Column12.Name = "Column12";
            this.Column12.ReadOnly = true;
            this.Column12.Visible = false;
            // 
            // Column11
            // 
            this.Column11.DataPropertyName = "EndDate";
            this.Column11.HeaderText = "End Date";
            this.Column11.Name = "Column11";
            this.Column11.ReadOnly = true;
            this.Column11.Visible = false;
            // 
            // Column13
            // 
            this.Column13.DataPropertyName = "Note";
            this.Column13.HeaderText = "Note";
            this.Column13.Name = "Column13";
            this.Column13.ReadOnly = true;
            this.Column13.Visible = false;
            // 
            // Column15
            // 
            this.Column15.DataPropertyName = "id";
            this.Column15.HeaderText = "id";
            this.Column15.Name = "Column15";
            this.Column15.ReadOnly = true;
            this.Column15.Visible = false;
            // 
            // btnAdd
            // 
            this.btnAdd.Image = ((System.Drawing.Image)(resources.GetObject("btnAdd.Image")));
            this.btnAdd.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAdd.Location = new System.Drawing.Point(92, 368);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(120, 37);
            this.btnAdd.TabIndex = 10;
            this.btnAdd.Text = "&Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // lblPatientName
            // 
            this.lblPatientName.AutoSize = true;
            this.lblPatientName.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblPatientName.Location = new System.Drawing.Point(129, 51);
            this.lblPatientName.Name = "lblPatientName";
            this.lblPatientName.Size = new System.Drawing.Size(18, 19);
            this.lblPatientName.TabIndex = 67;
            this.lblPatientName.Text = "0";
            // 
            // lblPatientId
            // 
            this.lblPatientId.AutoSize = true;
            this.lblPatientId.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblPatientId.Location = new System.Drawing.Point(105, 21);
            this.lblPatientId.Name = "lblPatientId";
            this.lblPatientId.Size = new System.Drawing.Size(18, 19);
            this.lblPatientId.TabIndex = 66;
            this.lblPatientId.Text = "0";
            // 
            // lblFacility
            // 
            this.lblFacility.AutoSize = true;
            this.lblFacility.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblFacility.Location = new System.Drawing.Point(227, 23);
            this.lblFacility.Name = "lblFacility";
            this.lblFacility.Size = new System.Drawing.Size(18, 19);
            this.lblFacility.TabIndex = 65;
            this.lblFacility.Text = "0";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(168, 23);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 17);
            this.label5.TabIndex = 64;
            this.label5.Text = "Facility";
            // 
            // btnRemove
            // 
            this.btnRemove.Image = global::ACHSystem.Properties.Resources.cancel;
            this.btnRemove.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRemove.Location = new System.Drawing.Point(218, 368);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(120, 37);
            this.btnRemove.TabIndex = 11;
            this.btnRemove.Text = "Remove";
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 17);
            this.label2.TabIndex = 61;
            this.label2.Text = "Patient ID";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 17);
            this.label1.TabIndex = 60;
            this.label1.Text = "Patient Name";
            // 
            // btnEdit
            // 
            this.btnEdit.Image = ((System.Drawing.Image)(resources.GetObject("btnEdit.Image")));
            this.btnEdit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEdit.Location = new System.Drawing.Point(16, 370);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(98, 37);
            this.btnEdit.TabIndex = 23;
            this.btnEdit.Text = "&Edit";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label19);
            this.groupBox3.Controls.Add(this.label18);
            this.groupBox3.Controls.Add(this.label16);
            this.groupBox3.Controls.Add(this.label15);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.lblStartDate);
            this.groupBox3.Controls.Add(this.rdNumOfDays);
            this.groupBox3.Controls.Add(this.rdDaily);
            this.groupBox3.Controls.Add(this.rdStop);
            this.groupBox3.Controls.Add(this.txtNumOfDays);
            this.groupBox3.Controls.Add(this.lblEndDate);
            this.groupBox3.Controls.Add(this.label17);
            this.groupBox3.Controls.Add(this.dtStarted);
            this.groupBox3.Controls.Add(this.btnUpdate);
            this.groupBox3.Controls.Add(this.btnCancel);
            this.groupBox3.Controls.Add(this.btnEdit);
            this.groupBox3.Controls.Add(this.btnSave);
            this.groupBox3.Controls.Add(this.label14);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.label10);
            this.groupBox3.Controls.Add(this.label11);
            this.groupBox3.Controls.Add(this.label12);
            this.groupBox3.Controls.Add(this.label13);
            this.groupBox3.Controls.Add(this.txtDosage);
            this.groupBox3.Controls.Add(this.txtOrderedBy);
            this.groupBox3.Controls.Add(this.txtDirection);
            this.groupBox3.Controls.Add(this.txtMedicationName);
            this.groupBox3.Controls.Add(this.txtNotes);
            this.groupBox3.Location = new System.Drawing.Point(363, 247);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(445, 417);
            this.groupBox3.TabIndex = 12;
            this.groupBox3.TabStop = false;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.ForeColor = System.Drawing.Color.Black;
            this.label19.Location = new System.Drawing.Point(26, 305);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(57, 14);
            this.label19.TabIndex = 101;
            this.label19.Text = "(Optional)";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.ForeColor = System.Drawing.Color.Red;
            this.label18.Location = new System.Drawing.Point(26, 225);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(60, 14);
            this.label18.TabIndex = 100;
            this.label18.Text = "(Required)";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.ForeColor = System.Drawing.Color.Red;
            this.label16.Location = new System.Drawing.Point(29, 146);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(60, 14);
            this.label16.TabIndex = 99;
            this.label16.Text = "(Required)";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.Color.Red;
            this.label15.Location = new System.Drawing.Point(29, 114);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(60, 14);
            this.label15.TabIndex = 98;
            this.label15.Text = "(Required)";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Red;
            this.label8.Location = new System.Drawing.Point(29, 83);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(60, 14);
            this.label8.TabIndex = 97;
            this.label8.Text = "(Required)";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Red;
            this.label7.Location = new System.Drawing.Point(29, 46);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(60, 14);
            this.label7.TabIndex = 96;
            this.label7.Text = "(Required)";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(26, 240);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(100, 17);
            this.label6.TabIndex = 95;
            this.label6.Text = "Selected Date";
            // 
            // lblStartDate
            // 
            this.lblStartDate.AutoSize = true;
            this.lblStartDate.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblStartDate.Location = new System.Drawing.Point(169, 238);
            this.lblStartDate.Name = "lblStartDate";
            this.lblStartDate.Size = new System.Drawing.Size(18, 19);
            this.lblStartDate.TabIndex = 94;
            this.lblStartDate.Text = "0";
            // 
            // rdNumOfDays
            // 
            this.rdNumOfDays.AutoSize = true;
            this.rdNumOfDays.Location = new System.Drawing.Point(171, 157);
            this.rdNumOfDays.Name = "rdNumOfDays";
            this.rdNumOfDays.Size = new System.Drawing.Size(88, 21);
            this.rdNumOfDays.TabIndex = 17;
            this.rdNumOfDays.Text = "# of Days";
            this.rdNumOfDays.UseVisualStyleBackColor = true;
            this.rdNumOfDays.CheckedChanged += new System.EventHandler(this.rdNumOfDays_CheckedChanged);
            // 
            // rdDaily
            // 
            this.rdDaily.AutoSize = true;
            this.rdDaily.Location = new System.Drawing.Point(313, 157);
            this.rdDaily.Name = "rdDaily";
            this.rdDaily.Size = new System.Drawing.Size(58, 21);
            this.rdDaily.TabIndex = 19;
            this.rdDaily.Text = "Daily";
            this.rdDaily.UseVisualStyleBackColor = true;
            this.rdDaily.CheckedChanged += new System.EventHandler(this.rdDaily_CheckedChanged);
            // 
            // rdStop
            // 
            this.rdStop.AutoSize = true;
            this.rdStop.Location = new System.Drawing.Point(375, 157);
            this.rdStop.Name = "rdStop";
            this.rdStop.Size = new System.Drawing.Size(56, 21);
            this.rdStop.TabIndex = 20;
            this.rdStop.Text = "Stop";
            this.rdStop.UseVisualStyleBackColor = true;
            this.rdStop.CheckedChanged += new System.EventHandler(this.rdStop_CheckedChanged);
            // 
            // txtNumOfDays
            // 
            this.txtNumOfDays.Location = new System.Drawing.Point(259, 156);
            this.txtNumOfDays.MaxLength = 50;
            this.txtNumOfDays.Name = "txtNumOfDays";
            this.txtNumOfDays.Size = new System.Drawing.Size(45, 25);
            this.txtNumOfDays.TabIndex = 18;
            // 
            // lblEndDate
            // 
            this.lblEndDate.AutoSize = true;
            this.lblEndDate.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblEndDate.Location = new System.Drawing.Point(169, 262);
            this.lblEndDate.Name = "lblEndDate";
            this.lblEndDate.Size = new System.Drawing.Size(18, 19);
            this.lblEndDate.TabIndex = 83;
            this.lblEndDate.Text = "0";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(17, 262);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(69, 17);
            this.label17.TabIndex = 81;
            this.label17.Text = "End Date";
            // 
            // dtStarted
            // 
            this.dtStarted.Cursor = System.Windows.Forms.Cursors.Default;
            this.dtStarted.Location = new System.Drawing.Point(170, 202);
            this.dtStarted.Name = "dtStarted";
            this.dtStarted.Size = new System.Drawing.Size(200, 25);
            this.dtStarted.TabIndex = 21;
            this.dtStarted.ValueChanged += new System.EventHandler(this.dtStarted_ValueChanged);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Image = ((System.Drawing.Image)(resources.GetObject("btnUpdate.Image")));
            this.btnUpdate.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUpdate.Location = new System.Drawing.Point(224, 370);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(100, 37);
            this.btnUpdate.TabIndex = 25;
            this.btnUpdate.Text = "&Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Image = ((System.Drawing.Image)(resources.GetObject("btnCancel.Image")));
            this.btnCancel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCancel.Location = new System.Drawing.Point(330, 370);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(100, 37);
            this.btnCancel.TabIndex = 26;
            this.btnCancel.Text = "&Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnSave
            // 
            this.btnSave.Image = ((System.Drawing.Image)(resources.GetObject("btnSave.Image")));
            this.btnSave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSave.Location = new System.Drawing.Point(120, 370);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(98, 37);
            this.btnSave.TabIndex = 24;
            this.btnSave.Text = "&Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(20, 288);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(46, 17);
            this.label14.TabIndex = 73;
            this.label14.Text = "Notes";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(20, 65);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(59, 17);
            this.label9.TabIndex = 71;
            this.label9.Text = "Dosage";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(17, 208);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(74, 17);
            this.label10.TabIndex = 70;
            this.label10.Text = "Start Date";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(20, 97);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(66, 17);
            this.label11.TabIndex = 69;
            this.label11.Text = "Direction";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(20, 29);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(120, 17);
            this.label12.TabIndex = 68;
            this.label12.Text = "Medication Name";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(20, 129);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(83, 17);
            this.label13.TabIndex = 67;
            this.label13.Text = "Ordered By";
            // 
            // txtDosage
            // 
            this.txtDosage.Location = new System.Drawing.Point(171, 58);
            this.txtDosage.MaxLength = 50;
            this.txtDosage.Name = "txtDosage";
            this.txtDosage.Size = new System.Drawing.Size(62, 25);
            this.txtDosage.TabIndex = 14;
            // 
            // txtOrderedBy
            // 
            this.txtOrderedBy.Location = new System.Drawing.Point(171, 126);
            this.txtOrderedBy.MaxLength = 50;
            this.txtOrderedBy.Name = "txtOrderedBy";
            this.txtOrderedBy.Size = new System.Drawing.Size(261, 25);
            this.txtOrderedBy.TabIndex = 16;
            // 
            // txtDirection
            // 
            this.txtDirection.Location = new System.Drawing.Point(171, 92);
            this.txtDirection.MaxLength = 100;
            this.txtDirection.Name = "txtDirection";
            this.txtDirection.Size = new System.Drawing.Size(261, 25);
            this.txtDirection.TabIndex = 15;
            // 
            // txtMedicationName
            // 
            this.txtMedicationName.Location = new System.Drawing.Point(171, 24);
            this.txtMedicationName.MaxLength = 50;
            this.txtMedicationName.Name = "txtMedicationName";
            this.txtMedicationName.Size = new System.Drawing.Size(261, 25);
            this.txtMedicationName.TabIndex = 13;
            // 
            // txtNotes
            // 
            this.txtNotes.Location = new System.Drawing.Point(168, 285);
            this.txtNotes.MaxLength = 250;
            this.txtNotes.Name = "txtNotes";
            this.txtNotes.Size = new System.Drawing.Size(265, 71);
            this.txtNotes.TabIndex = 22;
            this.txtNotes.Text = "";
            // 
            // frmPatientMedicationList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(820, 676);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmPatientMedicationList";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Patient Medication Information";
            this.Load += new System.EventHandler(this.frmPatientMedicationList_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPatient)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPatientMedication)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton rdByLastName;
        private System.Windows.Forms.RadioButton rdById;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnGo;
        private System.Windows.Forms.DataGridView dgvPatient;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblPatientName;
        private System.Windows.Forms.Label lblPatientId;
        private System.Windows.Forms.Label lblFacility;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DateTimePicker dtStarted;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtDosage;
        private System.Windows.Forms.TextBox txtOrderedBy;
        private System.Windows.Forms.TextBox txtDirection;
        private System.Windows.Forms.TextBox txtMedicationName;
        private System.Windows.Forms.RichTextBox txtNotes;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label lblEndDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn DurationType;
        private System.Windows.Forms.DataGridView dgvPatientMedication;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column14;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RadioButton rdNumOfDays;
        private System.Windows.Forms.RadioButton rdDaily;
        private System.Windows.Forms.RadioButton rdStop;
        private System.Windows.Forms.TextBox txtNumOfDays;
        private System.Windows.Forms.Label lblStartDate;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column9;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column10;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column12;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column11;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column13;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column15;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label19;
    }
}