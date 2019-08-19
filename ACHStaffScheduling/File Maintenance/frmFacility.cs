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
    public partial class frmFacility : Form
    {
        bool _isActive;

        public frmFacility()
        {
            InitializeComponent();
        }

        private void frmFacility_Load(object sender, EventArgs e)
        {
            resetSettings();
            getAllFacility();
        }


        #region Methods
        public void addMode()
        {
            try
            {
                _isActive = true;

                lblFacilityId.Text = getTempId().ToString();
                chkActive.Checked = true;

                txtName.Text = "";
                txtAddress.Text = "";

                lblCreated.Text = "";
                lblUpdated.Text = "";

                txtName.Enabled = true;
                txtAddress.Enabled = true;

                chkActive.Enabled = true;

                txtName.Focus();

                btnAdd.Enabled = false;
                btnSave.Enabled = true;
                btnCancel.Enabled = true;
                btnEdit.Enabled = false;
                btnUpdate.Enabled = false;

                lblStatus.Text = "Status : Adding New Facility Information ...";
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

                txtName.Enabled = true;
                txtAddress.Enabled = true;

                chkActive.Enabled = true;

                txtName.Focus();

                btnAdd.Enabled = false;
                btnSave.Enabled = false;
                btnCancel.Enabled = true;
                btnEdit.Enabled = false;
                btnUpdate.Enabled = true;

                lblStatus.Text = "Status : Editing Facility Information ...";
            }
            catch (Exception ex)
            {
                ErrorLogging.Log(ex, this.Name, "Method Edit Mode");
                MessageBox.Show("Error Detected, Let the Developer know", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }

        public void saveFacility(FacilityEntity obj)
        {
            try
            {
                using (ACHSystem.EDMX.ACHDBContainer db = new ACHSystem.EDMX.ACHDBContainer())
                {
                    EDMX.tblFacility fac = new EDMX.tblFacility
                    {
                        Id = obj.FacilityId,
                        Name = obj.Name,
                        Address = obj.Address,
                        Active = obj.Active,
                        DateCreated = obj.DateCreated,
                        DateUpdated = obj.DateUpdated
                    };
                    db.tblFacilities.Add(fac);
                    db.SaveChanges();
                }
            }
            catch (Exception ex)
            {
                ErrorLogging.Log(ex, this.Name, "Method Save Facility");
                MessageBox.Show("Error Detected, Let the Developer know", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }

        public void updateFacility(FacilityEntity obj)
        {
            try
            {
                using (ACHSystem.EDMX.ACHDBContainer db = new ACHSystem.EDMX.ACHDBContainer())
                {
                    EDMX.tblFacility emp = db.tblFacilities.Where(x => x.Id == obj.FacilityId).FirstOrDefault();
                    emp.Name = obj.Name;
                    emp.Address = obj.Address;
                    emp.Active = obj.Active;
                    emp.DateCreated = obj.DateCreated;
                    emp.DateUpdated = obj.DateUpdated;
                    db.SaveChanges();
                }
            }
            catch (Exception ex)
            {
                ErrorLogging.Log(ex, this.Name, "Method Update Facility");
                MessageBox.Show("Error Detected, Let the Developer know", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }

        public void resetSettings()
        {
            try
            {
                _isActive = false;

                lblFacilityId.Text = "0";
                chkActive.Checked = false;

                txtName.Text = "";
                txtAddress.Text = "";

                lblCreated.Text = "Created";
                lblUpdated.Text = "Updated";

                txtName.Enabled = false;
                txtAddress.Enabled = false;

                chkActive.Enabled = false;

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

        public bool hasInvalidInput(string name,string address)
        {
            bool result = false;
            try
            {
                if (name == "" || name == null)
                {
                    MessageBox.Show("Name Cannot Be Empty", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtName.Focus();
                    result = true;
                }
                else if (address == "" || address == null)
                {
                    MessageBox.Show("Address Cannot Be Empty", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtAddress.Focus();
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

        public int getTempId()
        {
            int result;
            try
            {
                if (dgvFacility.RowCount == 0)
                {
                    result = 1;
                }
                else
                {
                    result = Convert.ToInt32(dgvFacility[0, dgvFacility.RowCount - 1].Value) + 1;
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

        public void getAllFacility()
        {
            try
            {
                List<FacilityEntity> List = new List<FacilityEntity>();
                using (ACHSystem.EDMX.ACHDBContainer db = new ACHSystem.EDMX.ACHDBContainer())
                {
                    List = db.tblFacilities.Select(x => new FacilityEntity
                    {
                        FacilityId = x.Id,
                        Name = x.Name,
                        Address = x.Address,
                        Active = x.Active,
                        DateCreated = x.DateCreated,
                        DateUpdated = x.DateUpdated
                    }).ToList();
                }

                dgvFacility.DataSource = List;
            }
            catch (Exception ex)
            {
                ErrorLogging.Log(ex, this.Name, "Method Get All Facility");
                MessageBox.Show("Error Detected, Let the Developer know", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }
        #endregion

        #region objects

        private void dgvFacility_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgvFacility_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        

        private void dgvFacility_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (_isActive == false) 
                {
                    lblFacilityId.Text = Convert.ToString(dgvFacility[0, dgvFacility.CurrentRow.Index].Value);
                    txtName.Text = Convert.ToString(dgvFacility[1, dgvFacility.CurrentRow.Index].Value);
                    txtAddress.Text = Convert.ToString(dgvFacility[2, dgvFacility.CurrentRow.Index].Value);
                    if (Convert.ToString(dgvFacility[3, dgvFacility.CurrentRow.Index].Value) == "Y")
                    {
                        chkActive.Checked = true;
                    }
                    else
                    {
                        chkActive.Checked = false;
                    }
                    lblCreated.Text = Convert.ToString(dgvFacility[4, dgvFacility.CurrentRow.Index].Value);
                    lblUpdated.Text = Convert.ToString(dgvFacility[5, dgvFacility.CurrentRow.Index].Value);
                    btnEdit.Enabled = true;
                }
            }
            catch (Exception ex)
            {
                ErrorLogging.Log(ex, this.Name, "DataGridView Facility");
                MessageBox.Show("Error Detected, Let the Developer know", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }

        private void btnAdd_Click_1(object sender, EventArgs e)
        {
            addMode();
        }

        private void btnSave_Click_1(object sender, EventArgs e)
        {
            try
            {
                if (hasInvalidInput(txtName.Text, txtAddress.Text) == false)
                {
                    FacilityEntity fac = new FacilityEntity();
                    fac.FacilityId = Convert.ToInt32(lblFacilityId.Text);
                    fac.Name = txtName.Text;
                    fac.Address = txtAddress.Text;
                    if (chkActive.Checked)
                    {
                        fac.Active = "Y";
                    }
                    else
                    {
                        fac.Active = "N";
                    }
                    fac.DateCreated = DateTime.Now.ToString();
                    fac.DateUpdated = DateTime.Now.ToString();

                    saveFacility(fac);
                    getAllFacility();
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

        private void btnCancel_Click_1(object sender, EventArgs e)
        {
            resetSettings();
        }

        private void btnEdit_Click_1(object sender, EventArgs e)
        {
            editMode();
        }

        private void btnUpdate_Click_1(object sender, EventArgs e)
        {
            try
            {
                if (hasInvalidInput(txtName.Text, txtAddress.Text) == false)
                {
                    FacilityEntity fac = new FacilityEntity();
                    fac.FacilityId = Convert.ToInt32(lblFacilityId.Text);
                    fac.Name = txtName.Text;
                    fac.Address = txtAddress.Text;
                    if (chkActive.Checked)
                    {
                        fac.Active = "Y";
                    }
                    else
                    {
                        fac.Active = "N";
                    }
                    fac.DateCreated = lblCreated.Text;
                    fac.DateUpdated = DateTime.Now.ToString();

                    updateFacility(fac);
                    getAllFacility();
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
        #endregion
    }
}
