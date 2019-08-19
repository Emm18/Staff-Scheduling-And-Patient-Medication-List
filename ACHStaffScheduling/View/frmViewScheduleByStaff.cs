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
    public partial class frmViewScheduleByEmployee : Form
    {
        public frmViewScheduleByEmployee()
        {
            InitializeComponent();
        }

        #region Methods
        public void searchEmployeeByID(int empID)
        {
            try
            {
                using (ACHSystem.EDMX.ACHDBContainer db = new ACHSystem.EDMX.ACHDBContainer())
                {
                    var emp = db.tblEmployees.Where(x => x.Id == empID && x.Active == "Y").Select(y => new {
                        EmployeeID = y.Id,
                        EmployeeName = y.LastName + ", " + y.FirstName + " " + y.MiddleName
                    }).ToList();

                    dgvEmployee.DataSource = emp;
                }
            }
            catch (Exception ex)
            {
                ErrorLogging.Log(ex, this.Name, "Method Search Employee By ID");
                MessageBox.Show("Error Detected, Let the Developer know", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }

        public void searchEmployeeByLastName(string LastName)
        {
            try
            {
                using (ACHSystem.EDMX.ACHDBContainer db = new ACHSystem.EDMX.ACHDBContainer())
                {
                    var emp = db.tblEmployees.Where(x => x.LastName.Contains(LastName) && x.Active == "Y").Select(y => new {
                        EmployeeID = y.Id,
                        EmployeeName = y.LastName + ", " + y.FirstName + " " + y.MiddleName
                    }).ToList();

                    dgvEmployee.DataSource = emp;
                }
            }
            catch (Exception ex)
            {
                ErrorLogging.Log(ex, this.Name, "Method Search Employee By Last Name");
                MessageBox.Show("Error Detected, Let the Developer know", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }


        public void getStaffSchedule(int employeeID,string withPast)
        {
            try
            {
                using (ACHSystem.EDMX.ACHDBContainer db = new ACHSystem.EDMX.ACHDBContainer())
                {

                    var res = db.tblSchedules.Where(z => z.EmployeeID == employeeID).Select(x => new ViewScheduleByFacilityAndStaff
                    {
                        Date = x.Date,
                        EmployeeName = x.tblEmployee.LastName.ToUpper() + ", " + x.tblEmployee.FirstName.ToUpper() + " " + x.tblEmployee.MiddleName.ToUpper(),
                        Facility = x.tblFacility.Name.ToUpper(),
                        Address = x.tblFacility.Address.ToUpper()
                    }).ToList();

                    List<ViewScheduleByFacilityAndStaff> empSched = new List<ViewScheduleByFacilityAndStaff>();

                    if (withPast == "Y")
                    {
                        empSched = res;
                    }
                    else
                    {
                        foreach (var a in res)
                        {
                            if (Convert.ToDateTime(a.Date) >= Convert.ToDateTime(DateTime.Now.ToShortDateString()))
                            {
                                empSched.Add(a);
                            }
                        }
                    }
                    ViewScheduleByFacilityAndStaffBindingSource.DataSource = empSched;
                    this.rptViewByStaff.RefreshReport();
                }
            }
            catch (Exception ex)
            {
                ErrorLogging.Log(ex, this.Name, "Method Get Staff Schedule");
                MessageBox.Show("Error Detected, Let the Developer know", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }

        #endregion



        private void frmViewScheduleByEmployee_Load(object sender, EventArgs e)
        {

        }

        private void btnViewSchedule_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvEmployee.CurrentRow == null)
                {
                    MessageBox.Show("No employee selected", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    string withPast;
                    if (chkWithPast.Checked == true)
                    {
                        withPast = "Y";
                    }
                    else
                    {
                        withPast = "N";
                    }
                    getStaffSchedule(Convert.ToInt32(dgvEmployee[0, dgvEmployee.CurrentRow.Index].Value), withPast);
                }
            }
            catch (Exception ex)
            {
                ErrorLogging.Log(ex, this.Name, "Button View Schedule");
                MessageBox.Show("Error Detected, Let the Developer know", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            
        }

        private void btnGo_Click_1(object sender, EventArgs e)
        {
            try
            {
                if (rdById.Checked == false && rdByLastName.Checked == false)
                {
                    MessageBox.Show("Please Select Search by Id or Last Name", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtSearch.Focus();
                }
                else
                {
                    if (txtSearch.Text == "")
                    {
                        if (rdById.Checked == true)
                        {
                            MessageBox.Show("Please Enter ID", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            txtSearch.Focus();
                        }
                        else if (rdByLastName.Checked == true)
                        {
                            MessageBox.Show("Please Enter Last Name", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            txtSearch.Focus();
                        }

                    }
                    else
                    {
                        if (rdById.Checked == true)
                        {
                            int input;
                            bool inputChecker = Int32.TryParse(txtSearch.Text, out input);
                            if (inputChecker)
                            {
                                searchEmployeeByID(Convert.ToInt32(txtSearch.Text));
                            }
                            else
                            {
                                MessageBox.Show("Please input a valid ID", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                txtSearch.Focus();
                            }
                        }
                        else if (rdByLastName.Checked == true)
                        {
                            if (txtSearch.Text != "")
                            {
                                searchEmployeeByLastName(txtSearch.Text);
                            }
                            else
                            {
                                MessageBox.Show("Please enter valid Last Name", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                txtSearch.Focus();
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                ErrorLogging.Log(ex, this.Name, "Button Go");
                MessageBox.Show("Error Detected, Let the Developer know", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }

        private void btnClear_Click_1(object sender, EventArgs e)
        {
            try
            {
                txtSearch.Text = "";
                rdById.Checked = false;
                rdByLastName.Checked = false;
                ViewScheduleByFacilityAndStaffBindingSource.Clear();
                this.rptViewByStaff.RefreshReport();
                chkWithPast.Checked = false;
            }
            catch (Exception ex)
            {
                ErrorLogging.Log(ex, this.Name, "Button Clear");
                MessageBox.Show("Error Detected, Let the Developer know", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }

        private void ViewScheduleByFacilityAndStaffBindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }
    }
}
