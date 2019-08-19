using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ACHSystem
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }
        ACHSystem.File_Maintenance.frmEmployee frmEmp;
        ACHSystem.File_Maintenance.frmFacility frmFac;
        ACHSystem.Setting.frmSetSchedule frmSetSched;
        ACHSystem.View.frmViewScheduleByEmployee frmViewSchedByEmp;
        ACHSystem.View.frmViewScheduleByFacility frmViewSchedByFac;
        ACHSystem.Edit.frmPatientMedicationList frmPatMedList;
        ACHSystem.View.frmViewPatientMedicationList frmViewPatMedList;
        ACHSystem.File_Maintenance.frmPatient frmPat;
        private void employeeInformationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Boolean IsFormShown = false;
            foreach (Form ChildForm in this.MdiChildren)
            {
                if (ChildForm.Name == "frmEmployee")
                {
                    IsFormShown = true;
                    ChildForm.Focus();
                }  // End if
            } // end for
            if (!IsFormShown)
            {
                Cursor.Current = Cursors.WaitCursor;
                frmEmp = new ACHSystem.File_Maintenance.frmEmployee();
                frmEmp.MdiParent = this;
                frmEmp.Font = this.Font;
                frmEmp.Show();
                Cursor.Current = Cursors.Default;
            }
        }

        private void facilityInformationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Boolean IsFormShown = false;
            foreach (Form ChildForm in this.MdiChildren)
            {
                if (ChildForm.Name == "frmFacility")
                {
                    IsFormShown = true;
                    ChildForm.Focus();
                }  // End if
            } // end for
            if (!IsFormShown)
            {
                Cursor.Current = Cursors.WaitCursor;
                frmFac = new ACHSystem.File_Maintenance.frmFacility();
                frmFac.MdiParent = this;
                frmFac.Font = this.Font;
                frmFac.Show();
                Cursor.Current = Cursors.Default;
            }
        }

        private void setScheduleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Boolean IsFormShown = false;
            foreach (Form ChildForm in this.MdiChildren)
            {
                if (ChildForm.Name == "frmSetSchedule")
                {
                    IsFormShown = true;
                    ChildForm.Focus();
                }  // End if
            } // end for
            if (!IsFormShown)
            {
                Cursor.Current = Cursors.WaitCursor;
                frmSetSched = new ACHSystem.Setting.frmSetSchedule();
                frmSetSched.MdiParent = this;
                frmSetSched.Font = this.Font;
                frmSetSched.Show();
                Cursor.Current = Cursors.Default;
            }
        }

        private void byFacilityToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Boolean IsFormShown = false;
            foreach (Form ChildForm in this.MdiChildren)
            {
                if (ChildForm.Name == "frmViewScheduleByFacility")
                {
                    IsFormShown = true;
                    ChildForm.Focus();
                }  // End if
            } // end for
            if (!IsFormShown)
            {
                Cursor.Current = Cursors.WaitCursor;
                frmViewSchedByFac = new ACHSystem.View.frmViewScheduleByFacility();
                frmViewSchedByFac.MdiParent = this;
                frmViewSchedByFac.Font = this.Font;
                frmViewSchedByFac.Show();
                Cursor.Current = Cursors.Default;
            }
        }

        private void byEmployeeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Boolean IsFormShown = false;
            foreach (Form ChildForm in this.MdiChildren)
            {
                if (ChildForm.Name == "frmViewScheduleByStaff")
                {
                    IsFormShown = true;
                    ChildForm.Focus();
                }  // End if
            } // end for
            if (!IsFormShown)
            {
                Cursor.Current = Cursors.WaitCursor;
                frmViewSchedByEmp = new ACHSystem.View.frmViewScheduleByEmployee();
                frmViewSchedByEmp.MdiParent = this;
                frmViewSchedByEmp.Font = this.Font;
                frmViewSchedByEmp.Show();
                Cursor.Current = Cursors.Default;
            }
        }

        private void frmMain_Load(object sender, EventArgs e)
        {

        }

        private void patientMedicationListToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Boolean IsFormShown = false;
            foreach (Form ChildForm in this.MdiChildren)
            {
                if (ChildForm.Name == "frmPatientMedicationList")
                {
                    IsFormShown = true;
                    ChildForm.Focus();
                }  // End if
            } // end for
            if (!IsFormShown)
            {
                Cursor.Current = Cursors.WaitCursor;
                frmPatMedList = new ACHSystem.Edit.frmPatientMedicationList();
                frmPatMedList.MdiParent = this;
                frmPatMedList.Font = this.Font;
                frmPatMedList.Show();
                Cursor.Current = Cursors.Default;
            }
        }

        private void patientMedicationListToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Boolean IsFormShown = false;
            foreach (Form ChildForm in this.MdiChildren)
            {
                if (ChildForm.Name == "frmViewPatientMedicationList")
                {
                    IsFormShown = true;
                    ChildForm.Focus();
                }  // End if
            } // end for
            if (!IsFormShown)
            {
                Cursor.Current = Cursors.WaitCursor;
                frmViewPatMedList = new ACHSystem.View.frmViewPatientMedicationList();
                frmViewPatMedList.MdiParent = this;
                frmViewPatMedList.Font = this.Font;
                frmViewPatMedList.Show();
                Cursor.Current = Cursors.Default;
            }
        }

        private void patientInformationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Boolean IsFormShown = false;
            foreach (Form ChildForm in this.MdiChildren)
            {
                if (ChildForm.Name == "frmPatient")
                {
                    IsFormShown = true;
                    ChildForm.Focus();
                }  // End if
            } // end for
            if (!IsFormShown)
            {
                Cursor.Current = Cursors.WaitCursor;
                frmPat = new ACHSystem.File_Maintenance.frmPatient();
                frmPat.MdiParent = this;
                frmPat.Font = this.Font;
                frmPat.Show();
                Cursor.Current = Cursors.Default;
            }
        }
    }
}
