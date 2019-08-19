using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ACHSystem.Setting.View.Entities;

namespace ACHSystem.View
{
    public partial class frmViewScheduleByFacility : Form
    {
        public frmViewScheduleByFacility()
        {
            InitializeComponent();
        }

        List<int> _facilityID = new List<int>();

        private void frmViewScheduleByFacility_Load(object sender, EventArgs e)
        {
            getAllFacility();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void btnGo_Click(object sender, EventArgs e)
        {
            try
            {
                if (cboFacility.SelectedIndex >= 0)
                {
                    getScheduleByFacility(dtDate.Value.ToShortDateString(), _facilityID[cboFacility.SelectedIndex]);
                }
                else
                {
                    MessageBox.Show("Make sure to select date and facility", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                ErrorLogging.Log(ex, this.Name, "Button Go");
                MessageBox.Show("Error Detected, Let the Developer know", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                dtDate.Value = DateTime.Now;
                cboFacility.SelectedIndex = -1;
                ViewScheduleByFacilityAndStaffBindingSource.DataSource = null;
                this.rptViewByFacility.RefreshReport();
            }
            catch (Exception ex)
            {
                ErrorLogging.Log(ex, this.Name, "Button Clear");
                MessageBox.Show("Error Detected, Let the Developer know", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }
        
        private void cboFacility_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }


        #region Methods

        public void getAllFacility()
        {
            try
            {
                using (ACHSystem.EDMX.ACHDBContainer db = new ACHSystem.EDMX.ACHDBContainer())
                {
                    var res = db.tblFacilities.Where(x => x.Active == "Y").ToList();

                    foreach (var a in res)
                    {
                        _facilityID.Add(a.Id);
                        cboFacility.Items.Add(a.Name);
                    }
                }
            }
            catch (Exception ex)
            {
                ErrorLogging.Log(ex, this.Name, "Method Get All Facility");
                MessageBox.Show("Error Detected, Let the Developer know", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }

        public void getScheduleByFacility(string Date, int FacilityID)
        {
            try
            {
                using (ACHSystem.EDMX.ACHDBContainer db = new ACHSystem.EDMX.ACHDBContainer())
                {

                    var res = db.tblSchedules.Where(z => z.Date == Date && z.FacilityID == FacilityID).Select(x => new ViewScheduleByFacilityAndStaff
                    {
                        Date = x.Date,
                        EmployeeName = x.tblEmployee.LastName.ToUpper() + ", " + x.tblEmployee.FirstName.ToUpper() + " " + x.tblEmployee.MiddleName.ToUpper(),
                        Facility = x.tblFacility.Name.ToUpper(),
                        Address = x.tblFacility.Address.ToUpper()
                    }).ToList();

                    ViewScheduleByFacilityAndStaffBindingSource.DataSource = res;
                    this.rptViewByFacility.RefreshReport();
                }
            }
            catch (Exception ex)
            {
                ErrorLogging.Log(ex, this.Name, "Method Get Schedule By Facility");
                MessageBox.Show("Error Detected, Let the Developer know", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }
        #endregion

    }
    }

