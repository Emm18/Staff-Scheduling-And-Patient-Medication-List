namespace ACHSystem
{
    partial class frmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileMaintenanceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.employeeInformationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.facilityInformationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.settingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.setScheduleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.byFacilityToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.byEmployeeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.patientMedicationListToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.patientMedicationListToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.patientInformationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileMaintenanceToolStripMenuItem,
            this.toolStripMenuItem1,
            this.settingsToolStripMenuItem,
            this.viewToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1484, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileMaintenanceToolStripMenuItem
            // 
            this.fileMaintenanceToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.employeeInformationToolStripMenuItem,
            this.facilityInformationToolStripMenuItem,
            this.patientInformationToolStripMenuItem});
            this.fileMaintenanceToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("fileMaintenanceToolStripMenuItem.Image")));
            this.fileMaintenanceToolStripMenuItem.Name = "fileMaintenanceToolStripMenuItem";
            this.fileMaintenanceToolStripMenuItem.Size = new System.Drawing.Size(125, 20);
            this.fileMaintenanceToolStripMenuItem.Text = "File Maintenance";
            // 
            // employeeInformationToolStripMenuItem
            // 
            this.employeeInformationToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("employeeInformationToolStripMenuItem.Image")));
            this.employeeInformationToolStripMenuItem.Name = "employeeInformationToolStripMenuItem";
            this.employeeInformationToolStripMenuItem.Size = new System.Drawing.Size(192, 22);
            this.employeeInformationToolStripMenuItem.Text = "Employee Information";
            this.employeeInformationToolStripMenuItem.Click += new System.EventHandler(this.employeeInformationToolStripMenuItem_Click);
            // 
            // facilityInformationToolStripMenuItem
            // 
            this.facilityInformationToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("facilityInformationToolStripMenuItem.Image")));
            this.facilityInformationToolStripMenuItem.Name = "facilityInformationToolStripMenuItem";
            this.facilityInformationToolStripMenuItem.Size = new System.Drawing.Size(192, 22);
            this.facilityInformationToolStripMenuItem.Text = "Facility Information";
            this.facilityInformationToolStripMenuItem.Click += new System.EventHandler(this.facilityInformationToolStripMenuItem_Click);
            // 
            // settingsToolStripMenuItem
            // 
            this.settingsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.setScheduleToolStripMenuItem});
            this.settingsToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("settingsToolStripMenuItem.Image")));
            this.settingsToolStripMenuItem.Name = "settingsToolStripMenuItem";
            this.settingsToolStripMenuItem.Size = new System.Drawing.Size(77, 20);
            this.settingsToolStripMenuItem.Text = "Settings";
            // 
            // setScheduleToolStripMenuItem
            // 
            this.setScheduleToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("setScheduleToolStripMenuItem.Image")));
            this.setScheduleToolStripMenuItem.Name = "setScheduleToolStripMenuItem";
            this.setScheduleToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.setScheduleToolStripMenuItem.Text = "Set Schedule";
            this.setScheduleToolStripMenuItem.Click += new System.EventHandler(this.setScheduleToolStripMenuItem_Click);
            // 
            // viewToolStripMenuItem
            // 
            this.viewToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.byFacilityToolStripMenuItem,
            this.byEmployeeToolStripMenuItem,
            this.patientMedicationListToolStripMenuItem});
            this.viewToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("viewToolStripMenuItem.Image")));
            this.viewToolStripMenuItem.Name = "viewToolStripMenuItem";
            this.viewToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.viewToolStripMenuItem.Text = "View";
            // 
            // byFacilityToolStripMenuItem
            // 
            this.byFacilityToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("byFacilityToolStripMenuItem.Image")));
            this.byFacilityToolStripMenuItem.Name = "byFacilityToolStripMenuItem";
            this.byFacilityToolStripMenuItem.Size = new System.Drawing.Size(195, 22);
            this.byFacilityToolStripMenuItem.Text = "By Facility";
            this.byFacilityToolStripMenuItem.Click += new System.EventHandler(this.byFacilityToolStripMenuItem_Click);
            // 
            // byEmployeeToolStripMenuItem
            // 
            this.byEmployeeToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("byEmployeeToolStripMenuItem.Image")));
            this.byEmployeeToolStripMenuItem.Name = "byEmployeeToolStripMenuItem";
            this.byEmployeeToolStripMenuItem.Size = new System.Drawing.Size(195, 22);
            this.byEmployeeToolStripMenuItem.Text = "By Employee";
            this.byEmployeeToolStripMenuItem.Click += new System.EventHandler(this.byEmployeeToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.patientMedicationListToolStripMenuItem1});
            this.toolStripMenuItem1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripMenuItem1.Image")));
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(55, 20);
            this.toolStripMenuItem1.Text = "Edit";
            // 
            // patientMedicationListToolStripMenuItem
            // 
            this.patientMedicationListToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("patientMedicationListToolStripMenuItem.Image")));
            this.patientMedicationListToolStripMenuItem.Name = "patientMedicationListToolStripMenuItem";
            this.patientMedicationListToolStripMenuItem.Size = new System.Drawing.Size(195, 22);
            this.patientMedicationListToolStripMenuItem.Text = "Patient Medication List";
            this.patientMedicationListToolStripMenuItem.Click += new System.EventHandler(this.patientMedicationListToolStripMenuItem_Click);
            // 
            // patientMedicationListToolStripMenuItem1
            // 
            this.patientMedicationListToolStripMenuItem1.Image = ((System.Drawing.Image)(resources.GetObject("patientMedicationListToolStripMenuItem1.Image")));
            this.patientMedicationListToolStripMenuItem1.Name = "patientMedicationListToolStripMenuItem1";
            this.patientMedicationListToolStripMenuItem1.Size = new System.Drawing.Size(195, 22);
            this.patientMedicationListToolStripMenuItem1.Text = "Patient Medication List";
            this.patientMedicationListToolStripMenuItem1.Click += new System.EventHandler(this.patientMedicationListToolStripMenuItem1_Click);
            // 
            // patientInformationToolStripMenuItem
            // 
            this.patientInformationToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("patientInformationToolStripMenuItem.Image")));
            this.patientInformationToolStripMenuItem.Name = "patientInformationToolStripMenuItem";
            this.patientInformationToolStripMenuItem.Size = new System.Drawing.Size(192, 22);
            this.patientInformationToolStripMenuItem.Text = "Patient Information";
            this.patientInformationToolStripMenuItem.Click += new System.EventHandler(this.patientInformationToolStripMenuItem_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1484, 761);
            this.Controls.Add(this.menuStrip1);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.IsMdiContainer = true;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Angelview Care Homes";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion
        private System.Windows.Forms.ToolTip toolTip;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileMaintenanceToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem employeeInformationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem facilityInformationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem settingsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem setScheduleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem byFacilityToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem byEmployeeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem patientMedicationListToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem patientMedicationListToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem patientInformationToolStripMenuItem;
    }
}



