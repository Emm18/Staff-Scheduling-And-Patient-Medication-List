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
            _isActive = true;

            //get temp id to show on lblEmployeeID
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

        public void editMode()
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

        public void saveFacility(FacilityEntity obj)
        {
            using (ACHStaffScheduling.EDMX.ACHDBContainer db = new ACHStaffScheduling.EDMX.ACHDBContainer())
            {
                EDMX.tblFacility fac = new EDMX.tblFacility
                {
                    Id = obj.FacilityId,
                    Name = obj.Name,
                    Address= obj.Address,
                    Active = obj.Active,
                    DateCreated = obj.DateCreated,
                    DateUpdated = obj.DateUpdated
                };
                db.tblFacilities.Add(fac);
                db.SaveChanges();
            }
        }

        public void updateFacility(FacilityEntity obj)
        {
            using (ACHStaffScheduling.EDMX.ACHDBContainer db = new ACHStaffScheduling.EDMX.ACHDBContainer())
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

        public void resetSettings()
        {
            _isActive = false;

            //clear fields
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

        public bool hasInvalidInput(string name,string address)
        {
            bool result = false;

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
            return result;
        }

        public int getTempId()
        {
            int result;
            if(dgvFacility.RowCount == 0)
            {
                result = 1;
            }
            else
            {
                result = Convert.ToInt32(dgvFacility[0, dgvFacility.RowCount - 1].Value) + 1;
            }

            return result;
        }

        public void getAllFacility()
        {
            List<FacilityEntity> List = new List<FacilityEntity>();
            using (ACHStaffScheduling.EDMX.ACHDBContainer db = new ACHStaffScheduling.EDMX.ACHDBContainer())
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
        #endregion

        #region objects
        private void btnAdd_Click(object sender, EventArgs e)
        {
            addMode();
        }

        private void btnSave_Click(object sender, EventArgs e)
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
            if (hasInvalidInput(txtName.Text, txtAddress.Text) == false)
            {
                //update process
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

        private void dgvFacility_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgvFacility_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        

        private void dgvFacility_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (_isActive == false) //if this is true it means the user is currently adding or editing 
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
        #endregion
    }
}
