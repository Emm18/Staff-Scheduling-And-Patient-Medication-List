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

namespace ACHStaffScheduling.File_Maintenance
{
    public partial class frmEmployee : Form
    {

        #region Variables
        bool _isActive = false; //for DGV validation if false can trigger edit
        #endregion
        public frmEmployee()
        {
            InitializeComponent();
        }

        private void frmEmployee_Load(object sender, EventArgs e)
        {
            resetSettings();
            getAllEmployees();
        }



        #region Methods

        public void addMode()
        {
            _isActive = true;

            //get temp id to show on lblEmployeeID
            lblEmployeeId.Text = getTempId().ToString();
            chkActive.Checked = true;

            txtLastName.Text = "";
            txtFirstName.Text = "";
            txtMiddleName.Text = "";

            lblCreated.Text = "";
            lblUpdated.Text = "";

            txtLastName.Enabled = true;
            txtFirstName.Enabled = true;
            txtMiddleName.Enabled = true;

            chkActive.Enabled = true;

            txtLastName.Focus();

            btnAdd.Enabled = false;
            btnSave.Enabled = true;
            btnCancel.Enabled = true;
            btnEdit.Enabled = false;
            btnUpdate.Enabled = false;

            lblStatus.Text = "Status : Adding New Employee Information ...";
        }

        public void editMode()
        {
            _isActive = true;

            txtLastName.Enabled = true;
            txtFirstName.Enabled = true;
            txtMiddleName.Enabled = true;


            chkActive.Enabled = true;

            txtLastName.Focus();



            btnAdd.Enabled = false;
            btnSave.Enabled = false;
            btnCancel.Enabled = true;
            btnEdit.Enabled = false;
            btnUpdate.Enabled = true;

            lblStatus.Text = "Status : Editing Employee Information ...";
        }

        public void resetSettings()
        {
            _isActive = false;

            //clear fields
            lblEmployeeId.Text = "0";
            chkActive.Checked = false;

            txtLastName.Text = "";
            txtFirstName.Text = "";
            txtMiddleName.Text = "";

            lblCreated.Text = "Created";
            lblUpdated.Text = "Updated";

            chkActive.Enabled = false;

            txtLastName.Enabled = false;
            txtFirstName.Enabled = false;
            txtMiddleName.Enabled = false;

            btnAdd.Enabled = true;
            btnSave.Enabled = false;
            btnCancel.Enabled = false;
            btnEdit.Enabled = false;
            btnUpdate.Enabled = false;

            lblStatus.Text = "Status : ";
        }

        public bool hasInvalidInput(string lastName, string firstName)
        {
            bool result = false;

            if (lastName == "" || lastName == null)
            {
                MessageBox.Show("Last Name Cannot Be Empty", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtLastName.Focus();
                result = true;
            }
            else if (firstName == "" || lastName == null)
            {
                MessageBox.Show("First Name Cannot Be Empty", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtFirstName.Focus();
                result = true;
            }
            else
            {
                result = false;
            }
            return result;
        }

        public void getAllEmployees()
        {
            List<EmployeeEntity> List = new List<EmployeeEntity>();
            using (ACHStaffScheduling.EDMX.ACHDBContainer db = new ACHStaffScheduling.EDMX.ACHDBContainer())
            {
                List = db.tblEmployees.Select(x => new EmployeeEntity { EmployeeId = x.Id,
                                                                        LastName = x.LastName,
                                                                        FirstName = x.FirstName,
                                                                        MiddleName = x.MiddleName ,
                                                                        Active = x.Active ,
                                                                        DateCreated = x.DateCreated ,
                                                                        DateUpdated = x.DateUpdated}).ToList();
            }

            dgvEmployee.DataSource = List;
        }

        // need parameter and need return type
        public EmployeeEntity searchEmployeeByID(int empID)
        {
            EmployeeEntity obj = new EmployeeEntity();
            using (ACHStaffScheduling.EDMX.ACHDBContainer db = new ACHStaffScheduling.EDMX.ACHDBContainer())
            {
               EDMX.tblEmployee emp = db.tblEmployees.FirstOrDefault(x => x.Id == empID);
                if(emp != null)
                {
                    obj.EmployeeId = emp.Id;
                    obj.LastName = emp.LastName;
                    obj.FirstName = emp.FirstName;
                    obj.MiddleName = emp.MiddleName;
                    obj.Active = emp.Active;
                    obj.DateCreated = emp.DateCreated;
                    obj.DateUpdated = emp.DateUpdated;
                }
                else
                {
                    obj = null;
                }
            }
            return obj;
        }

        public List<EmployeeEntity> searchEmployeeByLastName(string LastName)
        {
            List<EmployeeEntity> List = new List<EmployeeEntity>();
            using (ACHStaffScheduling.EDMX.ACHDBContainer db = new ACHStaffScheduling.EDMX.ACHDBContainer())
            {

                List = db.tblEmployees.Where(x => x.LastName == LastName).Select(x => new EmployeeEntity { EmployeeId = x.Id, LastName = x.LastName, FirstName = x.FirstName, MiddleName = x.MiddleName, Active = x.Active, DateCreated = x.DateCreated, DateUpdated = x.DateUpdated }).ToList();
            }

            return List;
        }

        public int getTempId() //for add mode
        {
            int result = 0;
            if(dgvEmployee.RowCount == 0)
            {
                result = 1;
            }
            else
            {
                result = Convert.ToInt32(dgvEmployee[0, dgvEmployee.RowCount - 1].Value) + 1;
            }
            return result;            
        }

        public void saveEmployee(EmployeeEntity obj)
        {
            using (ACHStaffScheduling.EDMX.ACHDBContainer db = new ACHStaffScheduling.EDMX.ACHDBContainer())
            {
                EDMX.tblEmployee emp = new EDMX.tblEmployee
                {
                    Id = obj.EmployeeId,
                    LastName = obj.LastName,
                    FirstName = obj.FirstName,
                    MiddleName = obj.MiddleName,
                    Active = obj.Active,
                    DateCreated = obj.DateCreated,
                    DateUpdated = obj.DateUpdated
                };
                db.tblEmployees.Add(emp);
                db.SaveChanges();
            }
        }

        public void updateEmployee(EmployeeEntity obj)
        {
            using(ACHStaffScheduling.EDMX.ACHDBContainer db = new ACHStaffScheduling.EDMX.ACHDBContainer())
            {
                EDMX.tblEmployee emp = db.tblEmployees.Where(x => x.Id == obj.EmployeeId).FirstOrDefault();
                emp.LastName = obj.LastName;
                emp.FirstName = obj.FirstName;
                emp.MiddleName = obj.MiddleName;
                emp.Active = obj.Active;
                emp.DateCreated = obj.DateCreated;
                emp.DateUpdated = obj.DateUpdated;
                db.SaveChanges();
            }
        }

        #endregion


        #region Objects
        private void btnAdd_Click(object sender, EventArgs e)
        {
            addMode();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            //save process
            if (hasInvalidInput(txtLastName.Text, txtFirstName.Text) == false)
            {
                EmployeeEntity emp = new EmployeeEntity();
                emp.EmployeeId = Convert.ToInt32(lblEmployeeId.Text);
                emp.LastName = txtLastName.Text;
                emp.FirstName = txtFirstName.Text;
                emp.MiddleName = txtMiddleName.Text;
                if (chkActive.Checked)
                {
                    emp.Active = "Y";
                }
                else
                {
                    emp.Active = "N";
                }
                emp.DateCreated = DateTime.Now.ToString();
                emp.DateUpdated = DateTime.Now.ToString();

                saveEmployee(emp);
                getAllEmployees();
                resetSettings();
                lblStatus.Text = "Status : Successfully Saved!";
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            resetSettings();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            editMode();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (hasInvalidInput(txtLastName.Text, txtFirstName.Text) == false)
            {
                //update process
                EmployeeEntity emp = new EmployeeEntity();
                emp.EmployeeId = Convert.ToInt32(lblEmployeeId.Text);
                emp.LastName = txtLastName.Text;
                emp.FirstName = txtFirstName.Text;
                emp.MiddleName = txtMiddleName.Text;
                if (chkActive.Checked)
                {
                    emp.Active = "Y";
                }
                else
                {
                    emp.Active = "N";
                }
                emp.DateCreated = lblCreated.Text;
                emp.DateUpdated = DateTime.Now.ToString();

                updateEmployee(emp);
                getAllEmployees();
                resetSettings();
                lblStatus.Text = "Status : Successfully Updated!";
            }
        }

        private void btnGo_Click(object sender, EventArgs e)
        {
            //search
            if(_isActive == false) {
                EmployeeEntity emp = new EmployeeEntity();
                if (rdById.Checked)
                {
                    int input;
                    bool inputChecker = Int32.TryParse(txtSearch.Text, out input);
                    if (inputChecker)
                    {
                        if (searchEmployeeByID(input) != null)
                        {
                            emp = searchEmployeeByID(input);

                            lblEmployeeId.Text = emp.EmployeeId.ToString();
                            txtLastName.Text = emp.LastName;
                            txtFirstName.Text = emp.FirstName;
                            txtMiddleName.Text = emp.MiddleName;

                            if (emp.Active == "Y")
                            {
                                chkActive.Checked = true;
                            }
                            else
                            {
                                chkActive.Checked = false;
                            }

                            lblCreated.Text = emp.DateCreated;
                            lblUpdated.Text = emp.DateUpdated;

                            btnEdit.Enabled = true;
                        }
                        else
                        {
                            MessageBox.Show("No employee found with an ID of " + txtSearch.Text, "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            txtSearch.Focus();
                        }
                    }
                    else
                    {
                        MessageBox.Show("Please input a valid ID", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        txtSearch.Focus();
                    }
                }
                else if (rdByLastName.Checked)
                {
                    if (txtSearch.Text != "")
                    {
                        dgvEmployee.DataSource = searchEmployeeByLastName(txtSearch.Text);
                    }
                    else
                    {
                        MessageBox.Show("Please enter valid Last Name","Information",MessageBoxButtons.OK,MessageBoxIcon.Information);
                        txtSearch.Focus();
                    }
                }
                else
                {
                    MessageBox.Show("Please select if By ID or By Last Name", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtSearch.Focus();
                }
            }
            else if(_isActive == true)
            {
                MessageBox.Show("Cant search now please finish adding or editing employee information", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            //clear text box
            //repopulate DGV
            txtSearch.Text = "";
            rdById.Checked = false;
            rdByLastName.Checked = false;   
            getAllEmployees();
        }

        private void dgvEmployee_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgvEmployee_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (_isActive == false) //if this is true it means the user is currently adding or editing 
            {
                lblEmployeeId.Text = Convert.ToString(dgvEmployee[0, dgvEmployee.CurrentRow.Index].Value);
                txtLastName.Text = Convert.ToString(dgvEmployee[1, dgvEmployee.CurrentRow.Index].Value);
                txtFirstName.Text = Convert.ToString(dgvEmployee[2, dgvEmployee.CurrentRow.Index].Value);
                txtMiddleName.Text = Convert.ToString(dgvEmployee[3, dgvEmployee.CurrentRow.Index].Value);
                if (Convert.ToString(dgvEmployee[4, dgvEmployee.CurrentRow.Index].Value) == "Y")
                {
                    chkActive.Checked = true;
                }
                else {
                    chkActive.Checked = false;
                }
                lblCreated.Text = Convert.ToString(dgvEmployee[5, dgvEmployee.CurrentRow.Index].Value);
                lblUpdated.Text = Convert.ToString(dgvEmployee[6, dgvEmployee.CurrentRow.Index].Value);
                btnEdit.Enabled = true;
            }
        }
        #endregion
    }
}
