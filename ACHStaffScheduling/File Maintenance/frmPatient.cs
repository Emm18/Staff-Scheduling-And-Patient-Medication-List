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

namespace ACHSystem.File_Maintenance
{
    public partial class frmPatient : Form
    {

        #region Variables
        bool _isActive;
        List<int> _FacilityIDHolder = new List<int>();
        #endregion

        public frmPatient()
        {
            InitializeComponent();
        }


        #region Methods

        public void addMode()
        {
            try
            {
                _isActive = true;

                lblPatientId.Text = getTempId().ToString();
                chkActive.Checked = true;

                cboFacility.SelectedIndex = -1;
                txtLastName.Text = "";
                txtFirstName.Text = "";
                txtMiddleName.Text = "";

                lblCreated.Text = "";
                lblUpdated.Text = "";

                cboFacility.Enabled = true;
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

                lblStatus.Text = "Status : Adding New Patient Information ...";
            }
            catch (Exception ex)
            {
                ErrorLogging.Log(ex, this.Name, "Method Add Mode");
                MessageBox.Show("Error Detected, Let the Developer know", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }

        public void editMode()
        {
            try
            {
                _isActive = true;

                cboFacility.Enabled = true;
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

                lblStatus.Text = "Status : Editing Patient Information ...";
            }
            catch (Exception ex)
            {
                ErrorLogging.Log(ex, this.Name, "Method Edit Mode");
                MessageBox.Show("Error Detected, Let the Developer know", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        public void resetSettings()
        {
            try
            {
                _isActive = false;

                cboFacility.Enabled = false;
                lblPatientId.Text = "0";
                chkActive.Checked = false;

                cboFacility.SelectedIndex = -1;
                txtLastName.Text = "";
                txtFirstName.Text = "";
                txtMiddleName.Text = "";

                lblCreated.Text = "Created";
                lblUpdated.Text = "Updated";

                chkActive.Enabled = false;

                cboFacility.Enabled = false;
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
            catch (Exception ex)
            {
                ErrorLogging.Log(ex, this.Name, "Method Reset Settings");
                MessageBox.Show("Error Detected, Let the Developer know", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        public bool hasInvalidInput(string lastName, string firstName)
        {
            bool result = false;
            try
            {
                if (cboFacility.SelectedIndex == -1)
                {
                    MessageBox.Show("Please Select Which Facility", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    cboFacility.Focus();
                    result = true;
                }
                else if (lastName == "" || lastName == null)
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
            }
            catch (Exception ex)
            {
                ErrorLogging.Log(ex, this.Name, "Method Has Invalid Input");
                MessageBox.Show("Error Detected, Let the Developer know", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                result = true;
            }
            return result;
        }

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

        public void getAllPatient()
        {
            try
            {
                List<PatientEntity> List = new List<PatientEntity>();
                using (ACHSystem.EDMX.ACHDBContainer db = new ACHSystem.EDMX.ACHDBContainer())
                {
                    List = db.tblPatients.Select(x => new PatientEntity
                    {
                        PatientId = x.Id,
                        FacilityId = x.FacilityID,
                        FacilityName = x.tblFacility.Name,
                        LastName = x.LastName,
                        FirstName = x.FirstName,
                        MiddleName = x.MiddleName,
                        Active = x.Active,
                        DateCreated = x.DateCreated,
                        DateUpdated = x.DateUpdated
                    }).ToList();
                }

                dgvPatient.DataSource = List;
            }
            catch (Exception ex)
            {
                ErrorLogging.Log(ex, this.Name, "Method Get All Patient");
                MessageBox.Show("Error Detected, Let the Developer know", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }

        public PatientEntity searchPatientByID(int patientID)
        {
            PatientEntity obj = new PatientEntity();
            try
            {
                using (ACHSystem.EDMX.ACHDBContainer db = new ACHSystem.EDMX.ACHDBContainer())
                {
                    EDMX.tblPatient pat = db.tblPatients.FirstOrDefault(x => x.Id == patientID);
                    if (pat != null)
                    {
                        obj.PatientId = pat.Id;
                        obj.FacilityId = pat.FacilityID;
                        obj.FacilityName = pat.tblFacility.Name;
                        obj.LastName = pat.LastName;
                        obj.FirstName = pat.FirstName;
                        obj.MiddleName = pat.MiddleName;
                        obj.Active = pat.Active;
                        obj.DateCreated = pat.DateCreated;
                        obj.DateUpdated = pat.DateUpdated;
                    }
                    else
                    {
                        obj = null;
                    }
                }
            }
            catch (Exception ex)
            {
                ErrorLogging.Log(ex, this.Name, "Method Search Patient By ID");
                MessageBox.Show("Error Detected, Let the Developer know", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                obj = null;
            }

            return obj;
        }

        public List<PatientEntity> searchPatientByLastName(string LastName)
        {
            List<PatientEntity> List = new List<PatientEntity>();
            try
            {
                using (ACHSystem.EDMX.ACHDBContainer db = new ACHSystem.EDMX.ACHDBContainer())
                {

                    List = db.tblPatients.Where(x => x.LastName.Contains(LastName)).Select(x => new PatientEntity
                    {
                        PatientId = x.Id,
                        FacilityId = x.FacilityID,
                        FacilityName = x.tblFacility.Name,
                        LastName = x.LastName,
                        FirstName = x.FirstName,
                        MiddleName = x.MiddleName,
                        Active = x.Active,
                        DateCreated = x.DateCreated,
                        DateUpdated = x.DateUpdated
                    }).ToList();
                }
            }
            catch (Exception ex)
            {
                ErrorLogging.Log(ex, this.Name, "Method Search Patient By Last Name");
                MessageBox.Show("Error Detected, Let the Developer know", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            return List;
        }

        public int getTempId()
        {
            int result = 0;
            try
            {
                if (dgvPatient.RowCount == 0)
                {
                    result = 1;
                }
                else
                {
                    result = Convert.ToInt32(dgvPatient[0, dgvPatient.RowCount - 1].Value) + 1;
                }
            }
            catch (Exception ex)
            {
                ErrorLogging.Log(ex, this.Name, "Method Get Temp ID");
                MessageBox.Show("Error Detected, Let the Developer know", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                result = 1;
            }
            return result;
        }

        public void savePatient(PatientEntity obj)
        {
            try
            {
                using (ACHSystem.EDMX.ACHDBContainer db = new ACHSystem.EDMX.ACHDBContainer())
                {
                    EDMX.tblPatient pat = new EDMX.tblPatient
                    {
                        Id = obj.PatientId,
                        LastName = obj.LastName,
                        FirstName = obj.FirstName,
                        MiddleName = obj.MiddleName,
                        FacilityID = obj.FacilityId,
                        Active = obj.Active,
                        DateCreated = obj.DateCreated,
                        DateUpdated = obj.DateUpdated
                    };
                    db.tblPatients.Add(pat);
                    db.SaveChanges();
                }
            }
            catch (Exception ex)
            {
                ErrorLogging.Log(ex, this.Name, "Method Save Patient");
                MessageBox.Show("Error Detected, Let the Developer know", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }

        public void updatePatient(PatientEntity obj)
        {
            try
            {
                using (ACHSystem.EDMX.ACHDBContainer db = new ACHSystem.EDMX.ACHDBContainer())
                {
                    EDMX.tblPatient pat = db.tblPatients.Where(x => x.Id == obj.PatientId).FirstOrDefault();
                    pat.LastName = obj.LastName;
                    pat.FirstName = obj.FirstName;
                    pat.MiddleName = obj.MiddleName;
                    pat.FacilityID = obj.FacilityId;
                    pat.Active = obj.Active;
                    pat.DateCreated = obj.DateCreated;
                    pat.DateUpdated = obj.DateUpdated;
                    db.SaveChanges();
                }
            }
            catch (Exception ex)
            {
                ErrorLogging.Log(ex, this.Name, "Method Update Patient");
                MessageBox.Show("Error Detected, Let the Developer know", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        #endregion


        #region BUTTONS
        private void frmPatient_Load(object sender, EventArgs e)
        {
            resetSettings();
            getAllFacility();
            getAllPatient();

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            addMode();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (hasInvalidInput(txtLastName.Text, txtFirstName.Text) == false)
                {
                    PatientEntity pat = new PatientEntity();
                    pat.PatientId = Convert.ToInt32(lblPatientId.Text);
                    pat.FacilityId = _FacilityIDHolder[cboFacility.SelectedIndex];
                    pat.LastName = txtLastName.Text;
                    pat.FirstName = txtFirstName.Text;
                    pat.MiddleName = txtMiddleName.Text;
                    if (chkActive.Checked)
                    {
                        pat.Active = "Y";
                    }
                    else
                    {
                        pat.Active = "N";
                    }
                    pat.DateCreated = DateTime.Now.ToString();
                    pat.DateUpdated = DateTime.Now.ToString();

                    savePatient(pat);
                    getAllPatient();
                    resetSettings();
                    lblStatus.Text = "Status : Successfully Saved!";
                }
            }
            catch (Exception ex)
            {
                ErrorLogging.Log(ex, this.Name, "Button Save");
                MessageBox.Show("Error Detected, Let the Developer know", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
            try
            {
                if (hasInvalidInput(txtLastName.Text, txtFirstName.Text) == false)
                {
                    PatientEntity pat = new PatientEntity();
                    pat.PatientId = Convert.ToInt32(lblPatientId.Text);
                    pat.FacilityId = _FacilityIDHolder[cboFacility.SelectedIndex];
                    pat.LastName = txtLastName.Text;
                    pat.FirstName = txtFirstName.Text;
                    pat.MiddleName = txtMiddleName.Text;
                    if (chkActive.Checked)
                    {
                        pat.Active = "Y";
                    }
                    else
                    {
                        pat.Active = "N";
                    }
                    pat.DateCreated = lblCreated.Text;
                    pat.DateUpdated = DateTime.Now.ToString();

                    updatePatient(pat);
                    getAllPatient();
                    resetSettings();
                    lblStatus.Text = "Status : Successfully Updated!";
                }
            }
            catch (Exception ex)
            {
                ErrorLogging.Log(ex, this.Name, "Button Update");
                MessageBox.Show("Error Detected, Let the Developer know", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnGo_Click(object sender, EventArgs e)
        {
            try
            {
                if (_isActive == false)
                {
                    List<PatientEntity> pat = new List<PatientEntity>();
                    if (rdById.Checked)
                    {
                        int input;
                        bool inputChecker = Int32.TryParse(txtSearch.Text, out input);
                        if (inputChecker)
                        {
                            if (searchPatientByID(input) != null)
                            {
                                pat.Add(searchPatientByID(input));
                                dgvPatient.DataSource = pat;
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
                            dgvPatient.DataSource = searchPatientByLastName(txtSearch.Text);
                        }
                        else
                        {
                            MessageBox.Show("Please enter valid Last Name", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            txtSearch.Focus();
                        }
                    }
                    else
                    {
                        MessageBox.Show("Please select if By ID or By Last Name", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        txtSearch.Focus();
                    }
                }
                else if (_isActive == true)
                {
                    MessageBox.Show("Cant search now please finish adding or editing employee information", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
            getAllPatient();
        }

        private void dgvPatient_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgvPatient_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            //cboFacility.SelectedItem = dgvPatient[2, dgvPatient.CurrentRow.Index].Value.ToString();


        }

        private void cboFacility_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }


        private void dgvPatient_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (_isActive == false)
                {
                    lblPatientId.Text = Convert.ToString(dgvPatient[0, dgvPatient.CurrentRow.Index].Value);
                    cboFacility.SelectedItem = Convert.ToString(dgvPatient[2, dgvPatient.CurrentRow.Index].Value);
                    txtLastName.Text = Convert.ToString(dgvPatient[3, dgvPatient.CurrentRow.Index].Value);
                    txtFirstName.Text = Convert.ToString(dgvPatient[4, dgvPatient.CurrentRow.Index].Value);
                    txtMiddleName.Text = Convert.ToString(dgvPatient[5, dgvPatient.CurrentRow.Index].Value);
                    if (Convert.ToString(dgvPatient[6, dgvPatient.CurrentRow.Index].Value) == "Y")
                    {
                        chkActive.Checked = true;
                    }
                    else
                    {
                        chkActive.Checked = false;
                    }
                    lblCreated.Text = Convert.ToString(dgvPatient[7, dgvPatient.CurrentRow.Index].Value);
                    lblUpdated.Text = Convert.ToString(dgvPatient[8, dgvPatient.CurrentRow.Index].Value);
                    btnEdit.Enabled = true;
                }
            }
            catch (Exception ex)
            {
                ErrorLogging.Log(ex, this.Name, "DataGridView Patient");
                MessageBox.Show("Error Detected, Let the Developer know", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        #endregion
    }
}
