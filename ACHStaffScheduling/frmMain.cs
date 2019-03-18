using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ACHStaffScheduling
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }
        ACHStaffScheduling.File_Maintenance.frmEmployee frmEmp;
        ACHStaffScheduling.File_Maintenance.frmFacility frmFac;
        ACHStaffScheduling.Setting.frmSetSchedule frmSetSched;
        ACHStaffScheduling.View.frmViewScheduleByEmployee frmViewSchedByEmp;
        ACHStaffScheduling.View.frmViewScheduleByFacility frmViewSchedByFac;
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
                frmEmp = new ACHStaffScheduling.File_Maintenance.frmEmployee();
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
                frmFac = new ACHStaffScheduling.File_Maintenance.frmFacility();
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
                frmSetSched = new ACHStaffScheduling.Setting.frmSetSchedule();
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
                frmViewSchedByFac = new ACHStaffScheduling.View.frmViewScheduleByFacility();
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
                frmViewSchedByEmp = new ACHStaffScheduling.View.frmViewScheduleByEmployee();
                frmViewSchedByEmp.MdiParent = this;
                frmViewSchedByEmp.Font = this.Font;
                frmViewSchedByEmp.Show();
                Cursor.Current = Cursors.Default;
            }
        }
    }
}
