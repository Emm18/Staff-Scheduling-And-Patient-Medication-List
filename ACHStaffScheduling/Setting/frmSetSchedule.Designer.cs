namespace ACHSystem.Setting
{
    partial class frmSetSchedule
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSetSchedule));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.lblSelectedDate = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.mosSelectDate = new System.Windows.Forms.MonthCalendar();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label8 = new System.Windows.Forms.Label();
            this.btnRemove = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.dgvScheduledStaff = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cboFacility = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.dgvEmployee = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rdByLastName = new System.Windows.Forms.RadioButton();
            this.rdById = new System.Windows.Forms.RadioButton();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.btnGo = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvScheduledStaff)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmployee)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.lblSelectedDate);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.mosSelectDate);
            this.groupBox1.Location = new System.Drawing.Point(12, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(256, 243);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(20, 208);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(191, 14);
            this.label7.TabIndex = 73;
            this.label7.Text = "Select a date to add/remove schedule";
            // 
            // lblSelectedDate
            // 
            this.lblSelectedDate.AutoSize = true;
            this.lblSelectedDate.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblSelectedDate.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSelectedDate.Location = new System.Drawing.Point(128, 27);
            this.lblSelectedDate.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSelectedDate.Name = "lblSelectedDate";
            this.lblSelectedDate.Size = new System.Drawing.Size(42, 19);
            this.lblSelectedDate.TabIndex = 2;
            this.lblSelectedDate.Text = "0/0/0";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 29);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 17);
            this.label1.TabIndex = 71;
            this.label1.Text = "Selected Date";
            // 
            // mosSelectDate
            // 
            this.mosSelectDate.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mosSelectDate.Location = new System.Drawing.Point(14, 51);
            this.mosSelectDate.Margin = new System.Windows.Forms.Padding(12);
            this.mosSelectDate.MaxDate = new System.DateTime(2022, 1, 1, 0, 0, 0, 0);
            this.mosSelectDate.MinDate = new System.DateTime(2019, 1, 1, 0, 0, 0, 0);
            this.mosSelectDate.Name = "mosSelectDate";
            this.mosSelectDate.ShowToday = false;
            this.mosSelectDate.TabIndex = 3;
            this.mosSelectDate.DateChanged += new System.Windows.Forms.DateRangeEventHandler(this.mosSelectDate_DateChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.btnRemove);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.dgvScheduledStaff);
            this.groupBox2.Controls.Add(this.cboFacility);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Location = new System.Drawing.Point(274, 2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(466, 270);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(12, 220);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(205, 14);
            this.label8.TabIndex = 76;
            this.label8.Text = "Select Staff to remove from the schedule";
            // 
            // btnRemove
            // 
            this.btnRemove.Image = ((System.Drawing.Image)(resources.GetObject("btnRemove.Image")));
            this.btnRemove.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRemove.Location = new System.Drawing.Point(291, 220);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(162, 37);
            this.btnRemove.TabIndex = 7;
            this.btnRemove.Text = "Remove Staff";
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 57);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(111, 17);
            this.label3.TabIndex = 74;
            this.label3.Text = "Scheduled Staff";
            // 
            // dgvScheduledStaff
            // 
            this.dgvScheduledStaff.AllowUserToAddRows = false;
            this.dgvScheduledStaff.AllowUserToDeleteRows = false;
            this.dgvScheduledStaff.AllowUserToResizeColumns = false;
            this.dgvScheduledStaff.AllowUserToResizeRows = false;
            this.dgvScheduledStaff.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvScheduledStaff.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6});
            this.dgvScheduledStaff.Location = new System.Drawing.Point(15, 76);
            this.dgvScheduledStaff.Name = "dgvScheduledStaff";
            this.dgvScheduledStaff.RowHeadersVisible = false;
            this.dgvScheduledStaff.Size = new System.Drawing.Size(438, 141);
            this.dgvScheduledStaff.TabIndex = 6;
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "ScheduleID";
            this.Column1.HeaderText = "Id";
            this.Column1.Name = "Column1";
            this.Column1.Visible = false;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "Date";
            this.Column2.HeaderText = "Date";
            this.Column2.Name = "Column2";
            this.Column2.Visible = false;
            this.Column2.Width = 150;
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "FacilityID";
            this.Column3.HeaderText = "FacilityID";
            this.Column3.Name = "Column3";
            this.Column3.Visible = false;
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "FacilityName";
            this.Column4.HeaderText = "Facility";
            this.Column4.Name = "Column4";
            this.Column4.Visible = false;
            this.Column4.Width = 150;
            // 
            // Column5
            // 
            this.Column5.DataPropertyName = "EmployeeID";
            this.Column5.HeaderText = "EmployeeID";
            this.Column5.Name = "Column5";
            this.Column5.Width = 150;
            // 
            // Column6
            // 
            this.Column6.DataPropertyName = "EmployeeName";
            this.Column6.HeaderText = "Employee Name";
            this.Column6.Name = "Column6";
            this.Column6.Width = 250;
            // 
            // cboFacility
            // 
            this.cboFacility.FormattingEnabled = true;
            this.cboFacility.Location = new System.Drawing.Point(65, 22);
            this.cboFacility.Name = "cboFacility";
            this.cboFacility.Size = new System.Drawing.Size(186, 25);
            this.cboFacility.TabIndex = 5;
            this.cboFacility.SelectedIndexChanged += new System.EventHandler(this.cboFacility_SelectedIndexChanged);
            this.cboFacility.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cboFacility_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 17);
            this.label2.TabIndex = 71;
            this.label2.Text = "Facility";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.dgvEmployee);
            this.groupBox3.Controls.Add(this.rdByLastName);
            this.groupBox3.Controls.Add(this.rdById);
            this.groupBox3.Controls.Add(this.btnClear);
            this.groupBox3.Controls.Add(this.btnAdd);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.txtSearch);
            this.groupBox3.Controls.Add(this.btnGo);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Location = new System.Drawing.Point(274, 273);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(466, 275);
            this.groupBox3.TabIndex = 8;
            this.groupBox3.TabStop = false;
            // 
            // dgvEmployee
            // 
            this.dgvEmployee.AllowUserToAddRows = false;
            this.dgvEmployee.AllowUserToDeleteRows = false;
            this.dgvEmployee.AllowUserToResizeColumns = false;
            this.dgvEmployee.AllowUserToResizeRows = false;
            this.dgvEmployee.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEmployee.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.dataGridViewTextBoxColumn1});
            this.dgvEmployee.Location = new System.Drawing.Point(15, 81);
            this.dgvEmployee.Name = "dgvEmployee";
            this.dgvEmployee.ReadOnly = true;
            this.dgvEmployee.RowHeadersVisible = false;
            this.dgvEmployee.Size = new System.Drawing.Size(438, 137);
            this.dgvEmployee.TabIndex = 14;
            this.dgvEmployee.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvEmployee_CellContentClick);
            // 
            // id
            // 
            this.id.DataPropertyName = "EmployeeID";
            this.id.HeaderText = "Employee ID";
            this.id.Name = "id";
            this.id.ReadOnly = true;
            this.id.Width = 150;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "EmployeeName";
            this.dataGridViewTextBoxColumn1.HeaderText = "Employee Name";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 250;
            // 
            // rdByLastName
            // 
            this.rdByLastName.AutoSize = true;
            this.rdByLastName.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdByLastName.Location = new System.Drawing.Point(117, 48);
            this.rdByLastName.Name = "rdByLastName";
            this.rdByLastName.Size = new System.Drawing.Size(92, 18);
            this.rdByLastName.TabIndex = 13;
            this.rdByLastName.TabStop = true;
            this.rdByLastName.Text = "By Last Name";
            this.rdByLastName.UseVisualStyleBackColor = true;
            // 
            // rdById
            // 
            this.rdById.AutoSize = true;
            this.rdById.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdById.Location = new System.Drawing.Point(67, 48);
            this.rdById.Name = "rdById";
            this.rdById.Size = new System.Drawing.Size(50, 18);
            this.rdById.TabIndex = 12;
            this.rdById.TabStop = true;
            this.rdById.Text = "By ID";
            this.rdById.UseVisualStyleBackColor = true;
            // 
            // btnClear
            // 
            this.btnClear.Image = ((System.Drawing.Image)(resources.GetObject("btnClear.Image")));
            this.btnClear.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnClear.Location = new System.Drawing.Point(365, 18);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(92, 33);
            this.btnClear.TabIndex = 11;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Image = ((System.Drawing.Image)(resources.GetObject("btnAdd.Image")));
            this.btnAdd.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAdd.Location = new System.Drawing.Point(291, 224);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(162, 37);
            this.btnAdd.TabIndex = 15;
            this.btnAdd.Text = "Add to Schedule";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 26);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 17);
            this.label4.TabIndex = 83;
            this.label4.Text = "Search";
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(67, 21);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(194, 25);
            this.txtSearch.TabIndex = 9;
            // 
            // btnGo
            // 
            this.btnGo.Image = ((System.Drawing.Image)(resources.GetObject("btnGo.Image")));
            this.btnGo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGo.Location = new System.Drawing.Point(267, 18);
            this.btnGo.Name = "btnGo";
            this.btnGo.Size = new System.Drawing.Size(92, 33);
            this.btnGo.TabIndex = 10;
            this.btnGo.Text = "Go";
            this.btnGo.UseVisualStyleBackColor = true;
            this.btnGo.Click += new System.EventHandler(this.btnGo_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(12, 221);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(174, 14);
            this.label6.TabIndex = 80;
            this.label6.Text = "Select Staff to add in the schedule";
            // 
            // frmSetSchedule
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(752, 570);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmSetSchedule";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Set Schedule";
            this.Load += new System.EventHandler(this.frmSetSchedule_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvScheduledStaff)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmployee)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lblSelectedDate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MonthCalendar mosSelectDate;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dgvScheduledStaff;
        private System.Windows.Forms.ComboBox cboFacility;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.RadioButton rdByLastName;
        private System.Windows.Forms.RadioButton rdById;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Button btnGo;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.DataGridView dgvEmployee;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
    }
}