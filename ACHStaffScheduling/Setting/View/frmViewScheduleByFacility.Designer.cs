namespace ACHStaffScheduling.View
{
    partial class frmViewScheduleByFacility
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
            this.ViewScheduleByFacilityBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.rptViewByFacility = new Microsoft.Reporting.WinForms.ReportViewer();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.dtDate = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.btnReset = new System.Windows.Forms.Button();
            this.cboFacility = new System.Windows.Forms.ComboBox();
            this.btnGo = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.ViewScheduleByFacilityBindingSource)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // ViewScheduleByFacilityBindingSource
            // 
            this.ViewScheduleByFacilityBindingSource.DataSource = typeof(ACHStaffScheduling.Setting.View.Entities.ViewScheduleByFacilityAndStaff);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 17);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 17);
            this.label1.TabIndex = 1;
            // 
            // rptViewByFacility
            // 
            reportDataSource1.Name = "Dataset1";
            reportDataSource1.Value = this.ViewScheduleByFacilityBindingSource;
            this.rptViewByFacility.LocalReport.DataSources.Add(reportDataSource1);
            this.rptViewByFacility.LocalReport.ReportEmbeddedResource = "ACHStaffScheduling.Setting.View.Entities.RDLC.RptViewScheduleByFacility.rdlc";
            this.rptViewByFacility.Location = new System.Drawing.Point(2, 86);
            this.rptViewByFacility.Name = "rptViewByFacility";
            this.rptViewByFacility.ServerReport.BearerToken = null;
            this.rptViewByFacility.Size = new System.Drawing.Size(726, 551);
            this.rptViewByFacility.TabIndex = 7;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.dtDate);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.btnReset);
            this.groupBox1.Controls.Add(this.cboFacility);
            this.groupBox1.Controls.Add(this.btnGo);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(707, 68);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 31);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 17);
            this.label3.TabIndex = 16;
            this.label3.Text = "Date";
            // 
            // dtDate
            // 
            this.dtDate.Cursor = System.Windows.Forms.Cursors.Default;
            this.dtDate.Location = new System.Drawing.Point(65, 25);
            this.dtDate.Name = "dtDate";
            this.dtDate.Size = new System.Drawing.Size(200, 25);
            this.dtDate.TabIndex = 15;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(271, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 17);
            this.label2.TabIndex = 14;
            this.label2.Text = "Facility";
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(607, 24);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(81, 23);
            this.btnReset.TabIndex = 13;
            this.btnReset.Text = "&Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.button2_Click);
            // 
            // cboFacility
            // 
            this.cboFacility.FormattingEnabled = true;
            this.cboFacility.Location = new System.Drawing.Point(330, 24);
            this.cboFacility.Name = "cboFacility";
            this.cboFacility.Size = new System.Drawing.Size(184, 25);
            this.cboFacility.TabIndex = 12;
            // 
            // btnGo
            // 
            this.btnGo.Location = new System.Drawing.Point(520, 24);
            this.btnGo.Name = "btnGo";
            this.btnGo.Size = new System.Drawing.Size(81, 23);
            this.btnGo.TabIndex = 10;
            this.btnGo.Text = "&Go";
            this.btnGo.UseVisualStyleBackColor = true;
            this.btnGo.Click += new System.EventHandler(this.btnGo_Click);
            // 
            // frmViewScheduleByFacility
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(731, 642);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.rptViewByFacility);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmViewScheduleByFacility";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "View Schedule by Facility";
            this.Load += new System.EventHandler(this.frmViewScheduleByFacility_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ViewScheduleByFacilityBindingSource)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private Microsoft.Reporting.WinForms.ReportViewer rptViewByFacility;
        private System.Windows.Forms.BindingSource ViewScheduleByFacilityBindingSource;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dtDate;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.ComboBox cboFacility;
        private System.Windows.Forms.Button btnGo;
    }
}