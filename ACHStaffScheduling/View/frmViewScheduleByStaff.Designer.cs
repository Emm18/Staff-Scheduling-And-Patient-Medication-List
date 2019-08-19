namespace ACHSystem.View
{
    partial class frmViewScheduleByEmployee
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmViewScheduleByEmployee));
            this.rptViewByStaff = new Microsoft.Reporting.WinForms.ReportViewer();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnGo = new System.Windows.Forms.Button();
            this.chkWithPast = new System.Windows.Forms.CheckBox();
            this.dgvEmployee = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rdByLastName = new System.Windows.Forms.RadioButton();
            this.rdById = new System.Windows.Forms.RadioButton();
            this.label4 = new System.Windows.Forms.Label();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.btnViewSchedule = new System.Windows.Forms.Button();
            this.ViewScheduleByFacilityAndStaffBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmployee)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ViewScheduleByFacilityAndStaffBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // rptViewByStaff
            // 
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.ViewScheduleByFacilityAndStaffBindingSource;
            this.rptViewByStaff.LocalReport.DataSources.Add(reportDataSource1);
            this.rptViewByStaff.LocalReport.ReportEmbeddedResource = "ACHSystem.Setting.View.Entities.RDLC.RptViewScheduleByStaff.rdlc";
            this.rptViewByStaff.Location = new System.Drawing.Point(2, 274);
            this.rptViewByStaff.Name = "rptViewByStaff";
            this.rptViewByStaff.ServerReport.BearerToken = null;
            this.rptViewByStaff.Size = new System.Drawing.Size(726, 376);
            this.rptViewByStaff.TabIndex = 8;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnClear);
            this.groupBox3.Controls.Add(this.btnGo);
            this.groupBox3.Controls.Add(this.chkWithPast);
            this.groupBox3.Controls.Add(this.dgvEmployee);
            this.groupBox3.Controls.Add(this.rdByLastName);
            this.groupBox3.Controls.Add(this.rdById);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.txtSearch);
            this.groupBox3.Controls.Add(this.btnViewSchedule);
            this.groupBox3.Location = new System.Drawing.Point(72, 3);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(569, 265);
            this.groupBox3.TabIndex = 1;
            this.groupBox3.TabStop = false;
            // 
            // btnClear
            // 
            this.btnClear.Image = ((System.Drawing.Image)(resources.GetObject("btnClear.Image")));
            this.btnClear.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnClear.Location = new System.Drawing.Point(437, 21);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(92, 33);
            this.btnClear.TabIndex = 4;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click_1);
            // 
            // btnGo
            // 
            this.btnGo.Image = ((System.Drawing.Image)(resources.GetObject("btnGo.Image")));
            this.btnGo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGo.Location = new System.Drawing.Point(339, 21);
            this.btnGo.Name = "btnGo";
            this.btnGo.Size = new System.Drawing.Size(92, 33);
            this.btnGo.TabIndex = 3;
            this.btnGo.Text = "Go";
            this.btnGo.UseVisualStyleBackColor = true;
            this.btnGo.Click += new System.EventHandler(this.btnGo_Click_1);
            // 
            // chkWithPast
            // 
            this.chkWithPast.AutoSize = true;
            this.chkWithPast.Location = new System.Drawing.Point(65, 220);
            this.chkWithPast.Name = "chkWithPast";
            this.chkWithPast.Size = new System.Drawing.Size(157, 21);
            this.chkWithPast.TabIndex = 8;
            this.chkWithPast.Text = "View Past Schedule";
            this.chkWithPast.UseVisualStyleBackColor = true;
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
            this.dgvEmployee.Location = new System.Drawing.Point(65, 77);
            this.dgvEmployee.Name = "dgvEmployee";
            this.dgvEmployee.ReadOnly = true;
            this.dgvEmployee.RowHeadersVisible = false;
            this.dgvEmployee.Size = new System.Drawing.Size(438, 137);
            this.dgvEmployee.TabIndex = 7;
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
            this.rdByLastName.Location = new System.Drawing.Point(149, 53);
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
            this.rdById.Location = new System.Drawing.Point(99, 53);
            this.rdById.Name = "rdById";
            this.rdById.Size = new System.Drawing.Size(50, 18);
            this.rdById.TabIndex = 5;
            this.rdById.TabStop = true;
            this.rdById.Text = "By ID";
            this.rdById.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(38, 31);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 17);
            this.label4.TabIndex = 83;
            this.label4.Text = "Search";
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(99, 26);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(234, 25);
            this.txtSearch.TabIndex = 2;
            // 
            // btnViewSchedule
            // 
            this.btnViewSchedule.Image = ((System.Drawing.Image)(resources.GetObject("btnViewSchedule.Image")));
            this.btnViewSchedule.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnViewSchedule.Location = new System.Drawing.Point(317, 220);
            this.btnViewSchedule.Name = "btnViewSchedule";
            this.btnViewSchedule.Size = new System.Drawing.Size(186, 33);
            this.btnViewSchedule.TabIndex = 9;
            this.btnViewSchedule.Text = "View Schedule";
            this.btnViewSchedule.UseVisualStyleBackColor = true;
            this.btnViewSchedule.Click += new System.EventHandler(this.btnViewSchedule_Click);
            // 
            // ViewScheduleByFacilityAndStaffBindingSource
            // 
            this.ViewScheduleByFacilityAndStaffBindingSource.DataSource = typeof(ACHSystem.Setting.View.Entities.ViewScheduleByFacilityAndStaff);
            this.ViewScheduleByFacilityAndStaffBindingSource.CurrentChanged += new System.EventHandler(this.ViewScheduleByFacilityAndStaffBindingSource_CurrentChanged);
            // 
            // frmViewScheduleByEmployee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(729, 651);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.rptViewByStaff);
            this.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmViewScheduleByEmployee";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "View Schedule By Employee";
            this.Load += new System.EventHandler(this.frmViewScheduleByEmployee_Load);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmployee)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ViewScheduleByFacilityAndStaffBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer rptViewByStaff;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataGridView dgvEmployee;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.RadioButton rdByLastName;
        private System.Windows.Forms.RadioButton rdById;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Button btnViewSchedule;
        private System.Windows.Forms.BindingSource ViewScheduleByFacilityAndStaffBindingSource;
        private System.Windows.Forms.CheckBox chkWithPast;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnGo;
    }
}