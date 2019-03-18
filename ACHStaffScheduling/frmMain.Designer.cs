namespace ACHStaffScheduling
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
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileMaintenanceToolStripMenuItem,
            this.settingsToolStripMenuItem,
            this.viewToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(843, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileMaintenanceToolStripMenuItem
            // 
            this.fileMaintenanceToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.employeeInformationToolStripMenuItem,
            this.facilityInformationToolStripMenuItem});
            this.fileMaintenanceToolStripMenuItem.Name = "fileMaintenanceToolStripMenuItem";
            this.fileMaintenanceToolStripMenuItem.Size = new System.Drawing.Size(109, 20);
            this.fileMaintenanceToolStripMenuItem.Text = "File Maintenance";
            // 
            // employeeInformationToolStripMenuItem
            // 
            this.employeeInformationToolStripMenuItem.Name = "employeeInformationToolStripMenuItem";
            this.employeeInformationToolStripMenuItem.Size = new System.Drawing.Size(192, 22);
            this.employeeInformationToolStripMenuItem.Text = "Employee Information";
            this.employeeInformationToolStripMenuItem.Click += new System.EventHandler(this.employeeInformationToolStripMenuItem_Click);
            // 
            // facilityInformationToolStripMenuItem
            // 
            this.facilityInformationToolStripMenuItem.Name = "facilityInformationToolStripMenuItem";
            this.facilityInformationToolStripMenuItem.Size = new System.Drawing.Size(192, 22);
            this.facilityInformationToolStripMenuItem.Text = "Facility Information";
            this.facilityInformationToolStripMenuItem.Click += new System.EventHandler(this.facilityInformationToolStripMenuItem_Click);
            // 
            // settingsToolStripMenuItem
            // 
            this.settingsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.setScheduleToolStripMenuItem});
            this.settingsToolStripMenuItem.Name = "settingsToolStripMenuItem";
            this.settingsToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.settingsToolStripMenuItem.Text = "Settings";
            // 
            // setScheduleToolStripMenuItem
            // 
            this.setScheduleToolStripMenuItem.Name = "setScheduleToolStripMenuItem";
            this.setScheduleToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.setScheduleToolStripMenuItem.Text = "Set Schedule";
            this.setScheduleToolStripMenuItem.Click += new System.EventHandler(this.setScheduleToolStripMenuItem_Click);
            // 
            // viewToolStripMenuItem
            // 
            this.viewToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.byFacilityToolStripMenuItem,
            this.byEmployeeToolStripMenuItem});
            this.viewToolStripMenuItem.Name = "viewToolStripMenuItem";
            this.viewToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.viewToolStripMenuItem.Text = "View";
            // 
            // byFacilityToolStripMenuItem
            // 
            this.byFacilityToolStripMenuItem.Name = "byFacilityToolStripMenuItem";
            this.byFacilityToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.byFacilityToolStripMenuItem.Text = "By Facility";
            this.byFacilityToolStripMenuItem.Click += new System.EventHandler(this.byFacilityToolStripMenuItem_Click);
            // 
            // byEmployeeToolStripMenuItem
            // 
            this.byEmployeeToolStripMenuItem.Name = "byEmployeeToolStripMenuItem";
            this.byEmployeeToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.byEmployeeToolStripMenuItem.Text = "By Employee";
            this.byEmployeeToolStripMenuItem.Click += new System.EventHandler(this.byEmployeeToolStripMenuItem_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(843, 592);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.IsMdiContainer = true;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Angelview Care Homes";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
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
    }
}



