namespace ACHSystem.View
{
    partial class frmViewPatientMedicationList
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmViewPatientMedicationList));
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.ViewPatientMedicationListBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnViewMedList = new System.Windows.Forms.Button();
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
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            ((System.ComponentModel.ISupportInitialize)(this.ViewPatientMedicationListBindingSource)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPatient)).BeginInit();
            this.SuspendLayout();
            // 
            // ViewPatientMedicationListBindingSource
            // 
            this.ViewPatientMedicationListBindingSource.DataSource = typeof(ACHSystem.View.Entities.ViewPatientMedicationList);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnViewMedList);
            this.groupBox2.Controls.Add(this.rdByLastName);
            this.groupBox2.Controls.Add(this.rdById);
            this.groupBox2.Controls.Add(this.btnClear);
            this.groupBox2.Controls.Add(this.btnGo);
            this.groupBox2.Controls.Add(this.dgvPatient);
            this.groupBox2.Controls.Add(this.txtSearch);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(237, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(433, 286);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            // 
            // btnViewMedList
            // 
            this.btnViewMedList.Image = ((System.Drawing.Image)(resources.GetObject("btnViewMedList.Image")));
            this.btnViewMedList.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnViewMedList.Location = new System.Drawing.Point(211, 240);
            this.btnViewMedList.Name = "btnViewMedList";
            this.btnViewMedList.Size = new System.Drawing.Size(205, 33);
            this.btnViewMedList.TabIndex = 24;
            this.btnViewMedList.Text = "View Medication List";
            this.btnViewMedList.UseVisualStyleBackColor = true;
            this.btnViewMedList.Click += new System.EventHandler(this.btnViewMedList_Click);
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
            // reportViewer1
            // 
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.ViewPatientMedicationListBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "ACHSystem.View.Entities.RDLC.RptViewPatientMedicationList.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(3, 304);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(900, 293);
            this.reportViewer1.TabIndex = 3;
            // 
            // frmViewPatientMedicationList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(907, 598);
            this.Controls.Add(this.reportViewer1);
            this.Controls.Add(this.groupBox2);
            this.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmViewPatientMedicationList";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "View Patient Medication";
            this.Load += new System.EventHandler(this.frmViewPatientMedicationList_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ViewPatientMedicationListBindingSource)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPatient)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton rdByLastName;
        private System.Windows.Forms.RadioButton rdById;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnGo;
        private System.Windows.Forms.DataGridView dgvPatient;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column14;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnViewMedList;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource ViewPatientMedicationListBindingSource;
    }
}