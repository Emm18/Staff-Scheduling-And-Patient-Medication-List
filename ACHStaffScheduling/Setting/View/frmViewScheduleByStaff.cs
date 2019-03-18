using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ACHStaffScheduling.Setting.View.Entities;

namespace ACHStaffScheduling.View
{
    public partial class frmViewScheduleByEmployee : Form
    {
        public frmViewScheduleByEmployee()
        {
            InitializeComponent();
        }
        //MessageBox.Show(dtDate.Value.ToShortDateString());
        //string date1 = "1/11/2019";
        //string date2 = "1/9/2019";

        //DateTime d1 = Convert.ToDateTime(date1);
        //DateTime d2 = Convert.ToDateTime(date2);

        //List<DateTime> dts = new List<DateTime>();
        //dts.Add(d1);
        //dts.Add(d2);

        //dts.Sort();

        //foreach(DateTime asd in dts)
        //{
        //    MessageBox.Show(asd.ToString());
        //}

        //if(d1 > d2)
        //{
        //    MessageBox.Show("d1 is later than d1");
        //}

        #region Methods
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


        public void getStaffSchedule(int employeeID,string withPast)
        {
            using (ACHStaffScheduling.EDMX.ACHDBContainer db = new ACHStaffScheduling.EDMX.ACHDBContainer())
            {

                var res = db.tblSchedules.Where(z => z.EmployeeID == employeeID).Select(x => new ViewScheduleByFacilityAndStaff
                {
                    Date = x.Date,
                    EmployeeName = x.tblEmployee.LastName.ToUpper() + ", " + x.tblEmployee.FirstName.ToUpper() + " " + x.tblEmployee.MiddleName.ToUpper(),
                    Facility = x.tblFacility.Name.ToUpper(),
                    Address = x.tblFacility.Address.ToUpper()
                }).ToList();

                //dont get the past schedules
                List<ViewScheduleByFacilityAndStaff> empSched = new List<ViewScheduleByFacilityAndStaff>();

                if(withPast == "Y")
                {
                    empSched = res;
                }
                else
                {
                    foreach (var a in res)
                    {
                        if (Convert.ToDateTime(a.Date) >= DateTime.Now)
                        {
                            empSched.Add(a);
                        }
                    }
                }
                ViewScheduleByFacilityAndStaffBindingSource.DataSource = empSched;
                this.rptViewByStaff.RefreshReport();
            }
        }
        //get schedule
        //only today to future dates only

        #endregion



        private void frmViewScheduleByEmployee_Load(object sender, EventArgs e)
        {

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

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtSearch.Text = "";
            rdById.Checked = false;
            rdByLastName.Checked = false;
            ViewScheduleByFacilityAndStaffBindingSource.Clear();
            this.rptViewByStaff.RefreshReport();
            chkWithPast.Checked = false;
        }

        private void btnViewSchedule_Click(object sender, EventArgs e)
        {
            if(dgvEmployee.CurrentRow == null)
            {
                MessageBox.Show("No employee selected", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                string withPast;
                if(chkWithPast.Checked == true)
                {
                    withPast = "Y";
                }
                else
                {
                    withPast = "N";
                }
                getStaffSchedule(Convert.ToInt32(dgvEmployee[0, dgvEmployee.CurrentRow.Index].Value),withPast);
            }
            
        }
    }
}
