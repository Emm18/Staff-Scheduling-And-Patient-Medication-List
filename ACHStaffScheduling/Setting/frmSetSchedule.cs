using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ACHSystem.File_Maintenance.Entities;

namespace ACHSystem.Setting
{
    public partial class frmSetSchedule : Form
    {

        public frmSetSchedule()
        {
            InitializeComponent();
        }

        List<int> _FacilityIDHolder = new List<int>();

        private void frmSetSchedule_Load(object sender, EventArgs e)
        {
            try
            {
                mosSelectDate.MinDate = DateTime.Now;
                mosSelectDate.MaxDate = DateTime.Now.AddDays(30);

                getAllFacility();
                getAllEmployee();
            }
            catch (Exception ex)
            {
                ErrorLogging.Log(ex, this.Name, "Form Load");
                MessageBox.Show("Error Detected, Let the Developer know", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        #region Methods

        public void getAllFacility()
        {
            try
            {
                using (ACHSystem.EDMX.ACHDBContainer db = new ACHSystem.EDMX.ACHDBContainer())
                {
                    var fac = db.tblFacilities.Where(x => x.Active == "Y").Select(y => new {
                        Id = y.Id,
                        Name = y.Name
                    });
                    int ctr = 0;
                    foreach (var res in fac)
                    {
                        _FacilityIDHolder.Add(res.Id);
                        cboFacility.Items.Add(res.Name);
                        ctr++;
                    }
                }
            }
            catch (Exception ex)
            {
                ErrorLogging.Log(ex, this.Name, "Method Get All Facility");
                MessageBox.Show("Error Detected, Let the Developer know", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }

        public void getScheduledEmployee(string Date, int FacilityID)
        {
            try
            {
                using (ACHSystem.EDMX.ACHDBContainer db = new ACHSystem.EDMX.ACHDBContainer())
                {
                    var scheduledEmp = db.tblSchedules.Where(x => x.Date == Date && x.FacilityID == FacilityID).Select(y => new {
                        Date = y.Date,
                        FacilityID = y.FacilityID,
                        FacilityName = y.tblFacility.Name,
                        EmployeeID = y.EmployeeID,
                        employeeName = y.tblEmployee.LastName + ", " + y.tblEmployee.FirstName + " " + y.tblEmployee.MiddleName
                    }).ToList();
                    dgvScheduledStaff.DataSource = scheduledEmp;
                }
            }
            catch (Exception ex)
            {
                ErrorLogging.Log(ex, this.Name, "Method Get Scheduled Employee");
                MessageBox.Show("Error Detected, Let the Developer know", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }

        public void removeEmployeeFromSchedule(string Date, int FacilityID, int EmployeeID)
        {
            try
            {
                DialogResult result = MessageBox.Show("Are you sure you want to remove this employee from the schedule?", "Warning!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (result == DialogResult.Yes)
                {
                    using (ACHSystem.EDMX.ACHDBContainer db = new ACHSystem.EDMX.ACHDBContainer())
                    {
                        var emp = db.tblSchedules.Where(x => x.Date == Date && x.FacilityID == FacilityID && x.EmployeeID == EmployeeID).FirstOrDefault();
                        db.tblSchedules.Remove(emp);
                        db.SaveChanges();
                        MessageBox.Show("Successfuly Removed from the schedule!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            catch (Exception ex)
            {
                ErrorLogging.Log(ex, this.Name, "Method Remove from Schedule");
                MessageBox.Show("Error Detected, Let the Developer know", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }

        public void getAllEmployee()
        {
            try
            {
                using (ACHSystem.EDMX.ACHDBContainer db = new ACHSystem.EDMX.ACHDBContainer())
                {
                    var emp = db.tblEmployees.Where(x => x.Active == "Y").Select(y => new {
                        EmployeeID = y.Id,
                        EmployeeName = y.LastName + ", " + y.FirstName + " " + y.MiddleName
                    }).ToList();

                    dgvEmployee.DataSource = emp;
                }
            }
            catch (Exception ex)
            {
                ErrorLogging.Log(ex, this.Name, "Method Get All Employee");
                MessageBox.Show("Error Detected, Let the Developer know", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }  

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
                ErrorLogging.Log(ex, this.Name, "Method Search Emloyee By Last Name");
                MessageBox.Show("Error Detected, Let the Developer know", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }

        public bool checkConflict(string Date, int EmployeeID)
        {
            bool res = false;
            try
            {
                using (ACHSystem.EDMX.ACHDBContainer db = new ACHSystem.EDMX.ACHDBContainer())
                {
                    int emp = db.tblSchedules.Where(x => x.Date == Date && x.EmployeeID == EmployeeID).Count();

                    if (emp == 0)
                    {
                        res = false;
                    }
                    else
                    {
                        res = true;
                    }
                }
            }
            catch (Exception ex)
            {
                ErrorLogging.Log(ex, this.Name, "Method Check Conflict");
                MessageBox.Show("Error Detected, Let the Developer know", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                res = true;
            }
            return res;
        }

        public string getConflict(string Date, int FacilityID, int EmployeeID)
        {
            string conflict = "";
            try
            {
                using (ACHSystem.EDMX.ACHDBContainer db = new ACHSystem.EDMX.ACHDBContainer())
                {
                    var emp = db.tblSchedules.FirstOrDefault(x => x.Date == Date && x.EmployeeID == EmployeeID);
                    conflict = "Cant add this employee because of conflict in schedule" + "\n" +
                                emp.tblEmployee.LastName + ", " + emp.tblEmployee.FirstName + " " + emp.tblEmployee.MiddleName +
                                " already have schedule on " + emp.Date + " in " + emp.tblFacility.Name;
                }
            }
            catch (Exception ex)
            {
                ErrorLogging.Log(ex, this.Name, "Method Get Conflict");
                conflict = "Error Detected Please Contact Developer";
            }
            return conflict;
        }


        public void addEmployeeToSchedule(string Date, int FacilityID, int EmployeeID)
        {
            try
            {
                using (ACHSystem.EDMX.ACHDBContainer db = new ACHSystem.EDMX.ACHDBContainer())
                {
                    EDMX.tblSchedule sched = new EDMX.tblSchedule
                    {
                        Id = 1,
                        Date = Date,
                        FacilityID = FacilityID,
                        EmployeeID = EmployeeID
                    };
                    db.tblSchedules.Add(sched);
                    db.SaveChanges();
                }
            }
            catch (Exception ex)
            {
                ErrorLogging.Log(ex, this.Name, "Method Add Employee Schedule");
                MessageBox.Show("Error Detected, Let the Developer know", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }


        public bool hasInvalidInput(string controlType)
        {
            bool res = false;
            try
            {
                if (lblSelectedDate.Text == "0/0/0")
                {
                    MessageBox.Show("Please Select Date First", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    res = true;
                }
                else if (cboFacility.SelectedIndex == -1)
                {
                    MessageBox.Show("Please Select which Facility", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    res = true;
                }
                else if (controlType == "btnRemove")
                {
                    if (dgvScheduledStaff.CurrentRow == null || dgvScheduledStaff.RowCount == 0)
                    {
                        MessageBox.Show("No employee selected", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        res = true;
                    }
                }
                else if (controlType == "btnAdd")
                {
                    if (dgvEmployee.CurrentRow == null)
                    {
                        MessageBox.Show("No employee selected", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        res = true;
                    }
                }
            }
            catch (Exception ex)
            {
                ErrorLogging.Log(ex, this.Name, "Method Add Mode");
                MessageBox.Show("Error Detected, Let the Developer know", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                res = true;
            }

            
            return res;
        }
        #endregion



        #region Buttons
        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {

        }

        private void mosSelectDate_DateChanged(object sender, DateRangeEventArgs e)
        {
            try
            {
                lblSelectedDate.Text = mosSelectDate.SelectionStart.ToShortDateString();


                if (cboFacility.SelectedIndex >= 0)
                {                   
                    getScheduledEmployee(lblSelectedDate.Text, _FacilityIDHolder[cboFacility.SelectedIndex]);
                }
            }
            catch (Exception ex)
            {
                ErrorLogging.Log(ex, this.Name, "Select date");
                MessageBox.Show("Error Detected, Let the Developer know", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }

        private void btnViewByFacility_Click(object sender, EventArgs e)
        {

        }

        private void btnViewByStaff_Click(object sender, EventArgs e)
        {

        }

        private void btnViewAllSchedule_Click(object sender, EventArgs e)
        {

        }
        private void btnRemove_Click(object sender, EventArgs e)
        {
            try
            {
                if (hasInvalidInput("btnRemove") == false)
                {
                    string Date = Convert.ToString(dgvScheduledStaff[1, dgvScheduledStaff.CurrentRow.Index].Value);
                    int FacilityID = Convert.ToInt32(dgvScheduledStaff[2, dgvScheduledStaff.CurrentRow.Index].Value);
                    int EmployeeID = Convert.ToInt32(dgvScheduledStaff[4, dgvScheduledStaff.CurrentRow.Index].Value);
                    removeEmployeeFromSchedule(Date, FacilityID, EmployeeID);
                    getScheduledEmployee(lblSelectedDate.Text, _FacilityIDHolder[cboFacility.SelectedIndex]);
                }
            }
            catch (Exception ex)
            {
                ErrorLogging.Log(ex, this.Name, "Button Remove");
                MessageBox.Show("Error Detected, Let the Developer know", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }

        private void btnGo_Click(object sender, EventArgs e)
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
        private void btnClear_Click(object sender, EventArgs e)
        {
            txtSearch.Text = "";
            rdById.Checked = false;
            rdByLastName.Checked = false;
            getAllEmployee();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                if (hasInvalidInput("btnAdd") == false)
                {
                    if (checkConflict(lblSelectedDate.Text, Convert.ToInt32(dgvEmployee[0, dgvEmployee.CurrentRow.Index].Value)) == false)
                    {
                        addEmployeeToSchedule(lblSelectedDate.Text, _FacilityIDHolder[cboFacility.SelectedIndex], Convert.ToInt32(dgvEmployee[0, dgvEmployee.CurrentRow.Index].Value));
                        MessageBox.Show("Succesfully added employee in the schedule", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        getScheduledEmployee(lblSelectedDate.Text, _FacilityIDHolder[cboFacility.SelectedIndex]);
                    }
                    else
                    {
                        MessageBox.Show(getConflict(lblSelectedDate.Text, _FacilityIDHolder[cboFacility.SelectedIndex], Convert.ToInt32(dgvEmployee[0, dgvEmployee.CurrentRow.Index].Value)), "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    //check for conflict first       
                }
            }
            catch (Exception ex)
            {
                ErrorLogging.Log(ex, this.Name, "Button Add");
                MessageBox.Show("Error Detected, Let the Developer know", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }
        private void cboFacility_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (lblSelectedDate.Text == "0/0/0")
                {
                    MessageBox.Show("Please Make sure you select a date before adding employee", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    getScheduledEmployee(lblSelectedDate.Text, _FacilityIDHolder[cboFacility.SelectedIndex]);
                }
            }
            catch (Exception ex)
            {
                ErrorLogging.Log(ex, this.Name, "Combo facility");
                MessageBox.Show("Error Detected, Let the Developer know", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }

        private void cboFacility_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        #endregion

        private void dgvEmployee_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }
    }
}
