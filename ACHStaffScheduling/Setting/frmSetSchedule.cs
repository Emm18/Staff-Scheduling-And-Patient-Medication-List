using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ACHStaffScheduling.File_Maintenance.Entities;

namespace ACHStaffScheduling.Setting
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
            mosSelectDate.MinDate = DateTime.Now;
            mosSelectDate.MaxDate = DateTime.Now.AddDays(30);

            getAllFacility();
            getAllEmployee();
        }

        #region Methods

        public void getAllFacility()
        {
            using(ACHStaffScheduling.EDMX.ACHDBContainer db = new ACHStaffScheduling.EDMX.ACHDBContainer())
            {
                var fac = db.tblFacilities.Where(x => x.Active == "Y").Select(y => new {
                                                                                Id = y.Id,
                                                                                Name = y.Name});
                int ctr = 0;
                foreach (var res in fac)
                {
                    _FacilityIDHolder.Add(res.Id);
                    cboFacility.Items.Add(res.Name);
                    ctr++;
                }
            }
        }

        public void getScheduledEmployee(string Date, int FacilityID)
        {
            using (ACHStaffScheduling.EDMX.ACHDBContainer db = new ACHStaffScheduling.EDMX.ACHDBContainer())
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

        public void removeEmployeeFromSchedule(string Date, int FacilityID, int EmployeeID)
        {//1 2 4
            DialogResult result = MessageBox.Show("Are you sure you want to remove this employee from the schedule?", "Warning!", MessageBoxButtons.YesNo,MessageBoxIcon.Warning); 
            if (result == DialogResult.Yes)
            {
                using (ACHStaffScheduling.EDMX.ACHDBContainer db = new ACHStaffScheduling.EDMX.ACHDBContainer())
                {
                    var emp = db.tblSchedules.Where(x => x.Date == Date && x.FacilityID == FacilityID && x.EmployeeID == EmployeeID).FirstOrDefault();
                    db.tblSchedules.Remove(emp);
                    db.SaveChanges();
                    MessageBox.Show("Successfuly Removed from the schedule!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        public void getAllEmployee()
        {
            using (ACHStaffScheduling.EDMX.ACHDBContainer db = new ACHStaffScheduling.EDMX.ACHDBContainer())
            {
                var emp = db.tblEmployees.Where(x => x.Active == "Y").Select(y => new {
                                                                             EmployeeID = y.Id,
                                                                             EmployeeName = y.LastName + ", " + y.FirstName + " " + y.MiddleName}).ToList();

                dgvEmployee.DataSource = emp;               
            }
        }  

        public void searchEmployeeByID(int empID)
        {        
            using (ACHStaffScheduling.EDMX.ACHDBContainer db = new ACHStaffScheduling.EDMX.ACHDBContainer())
            {
                var emp = db.tblEmployees.Where(x => x.Id == empID && x.Active == "Y").Select(y => new {
                    EmployeeID = y.Id,
                    EmployeeName = y.LastName + ", " + y.FirstName + " " + y.MiddleName
                }).ToList();

                dgvEmployee.DataSource = emp;
            }
        }

        public void searchEmployeeByLastName(string LastName)
        {
            using (ACHStaffScheduling.EDMX.ACHDBContainer db = new ACHStaffScheduling.EDMX.ACHDBContainer())
            {
                var emp = db.tblEmployees.Where(x => x.LastName == LastName && x.Active == "Y").Select(y => new {
                    EmployeeID = y.Id,
                    EmployeeName = y.LastName + ", " + y.FirstName + " " + y.MiddleName
                }).ToList();

                dgvEmployee.DataSource = emp;
            }
        }

        public bool checkConflict(string Date, int EmployeeID)
        {
            bool res = false;
            using (ACHStaffScheduling.EDMX.ACHDBContainer db = new ACHStaffScheduling.EDMX.ACHDBContainer())
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

            return res;
        }

        public string getConflict(string Date, int FacilityID, int EmployeeID)
        {
            string conflict = "";
            using (ACHStaffScheduling.EDMX.ACHDBContainer db = new ACHStaffScheduling.EDMX.ACHDBContainer())
            {
                var emp = db.tblSchedules.FirstOrDefault(x => x.Date == Date && x.EmployeeID == EmployeeID);
                conflict = "Cant add this employee because of conflict in schedule" + "\n" +
                            emp.tblEmployee.LastName + ", " + emp.tblEmployee.FirstName + " " + emp.tblEmployee.MiddleName +
                            " already have schedule on " + emp.Date + " in " + emp.tblFacility.Name; 
            }

            return conflict;
        }


        public void addEmployeeToSchedule(string Date, int FacilityID, int EmployeeID)
        {
            using (ACHStaffScheduling.EDMX.ACHDBContainer db = new ACHStaffScheduling.EDMX.ACHDBContainer())
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


        public bool hasInvalidInput(string controlType)
        {
            bool res = false;
            if (lblSelectedDate.Text == "0/0/0")
            {
                MessageBox.Show("Please Select Date First", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                res = true;
            }
            else if(cboFacility.SelectedIndex == -1)
            {
                MessageBox.Show("Please Select which Facility", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                res = true;
            }
            else if (controlType == "btnRemove")
            {
                if(dgvScheduledStaff.CurrentRow == null || dgvScheduledStaff.RowCount == 0) {
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
            
            return res;
        }
        #endregion



        #region Buttons
        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {

        }

        private void mosSelectDate_DateChanged(object sender, DateRangeEventArgs e)
        {
            lblSelectedDate.Text = mosSelectDate.SelectionStart.ToShortDateString();

            
            if(cboFacility.SelectedIndex >= 0)
            {
                //get scheduled
                getScheduledEmployee(lblSelectedDate.Text, _FacilityIDHolder[cboFacility.SelectedIndex]);
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
            if (hasInvalidInput("btnRemove") == false)
            {
                string Date = Convert.ToString(dgvScheduledStaff[1, dgvScheduledStaff.CurrentRow.Index].Value);
                int FacilityID = Convert.ToInt32(dgvScheduledStaff[2, dgvScheduledStaff.CurrentRow.Index].Value);
                int EmployeeID = Convert.ToInt32(dgvScheduledStaff[4, dgvScheduledStaff.CurrentRow.Index].Value);
                removeEmployeeFromSchedule(Date, FacilityID, EmployeeID);
                getScheduledEmployee(lblSelectedDate.Text, _FacilityIDHolder[cboFacility.SelectedIndex]);
            }
        }

        private void btnGo_Click(object sender, EventArgs e)
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
                else {
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
        private void btnClear_Click(object sender, EventArgs e)
        {
            txtSearch.Text = "";
            rdById.Checked = false;
            rdByLastName.Checked = false;
            getAllEmployee();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (hasInvalidInput("btnAdd") == false)
            {
                if(checkConflict(lblSelectedDate.Text, Convert.ToInt32(dgvEmployee[0, dgvEmployee.CurrentRow.Index].Value)) == false)
                {
                    addEmployeeToSchedule(lblSelectedDate.Text, _FacilityIDHolder[cboFacility.SelectedIndex], Convert.ToInt32(dgvEmployee[0, dgvEmployee.CurrentRow.Index].Value));
                    MessageBox.Show("Succesfully added employee in the schedule", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    getScheduledEmployee(lblSelectedDate.Text, _FacilityIDHolder[cboFacility.SelectedIndex]);
                    //refreshed dgv
                }
                else
                {
                    //get conflict?
                    MessageBox.Show(getConflict(lblSelectedDate.Text,_FacilityIDHolder[cboFacility.SelectedIndex],Convert.ToInt32(dgvEmployee[0, dgvEmployee.CurrentRow.Index].Value)), "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                //check for conflict first       
            }
        }
        private void cboFacility_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lblSelectedDate.Text == "0/0/0")
            {
                MessageBox.Show("Please Make sure you select a date before adding employee", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                //get all employee who is duty on the selected date and in the selected facilty
                getScheduledEmployee(lblSelectedDate.Text, _FacilityIDHolder[cboFacility.SelectedIndex]);
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
    }
}
