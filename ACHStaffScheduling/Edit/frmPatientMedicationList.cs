using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ACHSystem.Edit
{
    public partial class frmPatientMedicationList : Form
    {
        public frmPatientMedicationList()
        {
            InitializeComponent();
        }

        #region Variables
        bool _isActive;
        int _medIdHolder;
        #endregion

        #region Methods


        public void searchPatientByID(int patID)
        {
            try
            {
                using (ACHSystem.EDMX.ACHDBContainer db = new ACHSystem.EDMX.ACHDBContainer())
                {
                    var pat = db.tblPatients.Where(x => x.Id == patID && x.Active == "Y").Select(y => new {
                        PatientID = y.Id,
                        FacilityName = y.tblFacility.Name,
                        PatientName = y.LastName + ", " + y.FirstName + " " + y.MiddleName
                    }).ToList();

                    dgvPatient.DataSource = pat;
                }
            }
            catch (Exception ex)
            {
                ErrorLogging.Log(ex, this.Name, "Method Search Employee By ID");
                MessageBox.Show("Error Detected, Let the Developer know", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }

        public void searchPatientByLastName(string LastName)
        {
            try
            {
                using (ACHSystem.EDMX.ACHDBContainer db = new ACHSystem.EDMX.ACHDBContainer())
                {
                    var pat = db.tblPatients.Where(x => x.LastName.Contains(LastName) && x.Active == "Y").Select(y => new
                    {
                        PatientID = y.Id,
                        FacilityName = y.tblFacility.Name,
                        PatientName = y.LastName + ", " + y.FirstName + " " + y.MiddleName
                    }).ToList();

                    dgvPatient.DataSource = pat;
                }
            }
            catch (Exception ex)
            {
                ErrorLogging.Log(ex, this.Name, "Method Search Emloyee By Last Name");
                MessageBox.Show("Error Detected, Let the Developer know", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }

        public void deletePatientMedication(int medId)
        {
            using (ACHSystem.EDMX.ACHDBContainer db = new ACHSystem.EDMX.ACHDBContainer())
            {
                var patMed = db.tblPatientMedicationLists.Where(x => x.Id == medId).FirstOrDefault();
                db.tblPatientMedicationLists.Remove(patMed);
                db.SaveChanges();
                MessageBox.Show("Successfully removed medication", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        public void savePatientMedication()
        {
            string durationType ="";
            if(rdNumOfDays.Checked == true)
            {
                durationType = "N";
            }
            else if(rdDaily.Checked == true)
            {
                durationType = "D";   
            }
            else if(rdStop.Checked == true)
            {
                durationType = "S";
            }
            using (ACHSystem.EDMX.ACHDBContainer db = new ACHSystem.EDMX.ACHDBContainer())
            {
                EDMX.tblPatientMedicationList patMed = new EDMX.tblPatientMedicationList
                {
                    PatientID = Convert.ToInt32(lblPatientId.Text),
                    MedicationName = txtMedicationName.Text,
                    Dosage = txtDosage.Text,
                    Direction = txtDirection.Text,
                    OrderedBy = txtOrderedBy.Text,
                    StartDate = lblStartDate.Text,
                    EndDate = lblEndDate.Text,
                    DurationType = durationType,
                    Note = txtNotes.Text
                };
                db.tblPatientMedicationLists.Add(patMed);
                db.SaveChanges();
            }
        }

        public void updatePatientMedication(int medId)
        {
            using (ACHSystem.EDMX.ACHDBContainer db = new ACHSystem.EDMX.ACHDBContainer())
            {
                EDMX.tblPatientMedicationList patMed = db.tblPatientMedicationLists.Where(x => x.Id == medId).FirstOrDefault();
                patMed.MedicationName = txtMedicationName.Text;
                patMed.Dosage = txtDosage.Text;
                patMed.Direction = txtDirection.Text;
                patMed.OrderedBy = txtOrderedBy.Text;
                patMed.StartDate = lblStartDate.Text;
                patMed.EndDate = lblEndDate.Text;

                if(rdNumOfDays.Checked == true)
                {
                    patMed.DurationType = "N";
                }
                else if (rdDaily.Checked == true)
                {
                    patMed.DurationType = "D";
                }
                else if(rdStop.Checked == true)
                {
                    patMed.DurationType = "S";
                }

                patMed.Note = txtNotes.Text;
                db.SaveChanges();
            }
        }


        public void addMode()
        {
            _isActive = true;

            txtMedicationName.Text = "";
            txtDosage.Text = "";
            txtDirection.Text = "";
            txtOrderedBy.Text = "";
            txtNotes.Text = "";

            rdNumOfDays.Checked = false;
            txtNumOfDays.Text = "";
            rdDaily.Checked = false;
            rdStop.Checked = false;
            lblStartDate.Text = "0";
            lblEndDate.Text = "0";

            

            txtMedicationName.Enabled = true;
            txtDosage.Enabled = true;
            txtDirection.Enabled = true;
            txtOrderedBy.Enabled = true;
            //dtStarted.Enabled = true;

            rdNumOfDays.Enabled = true;
            rdDaily.Enabled = true;
            rdStop.Enabled = false;
            //txtNumOfDays.Enabled = true;


            txtNotes.Enabled = true;

            btnAdd.Enabled = false;
            btnRemove.Enabled = false;
            btnSave.Enabled = true;
            btnEdit.Enabled = false;
            btnUpdate.Enabled = false;
            btnCancel.Enabled = true;

            txtMedicationName.Focus();
        }

        public void editMode()
        {
            _isActive = true;

            txtMedicationName.Enabled = true;
            txtDosage.Enabled = true;
            txtDirection.Enabled = true;
            txtOrderedBy.Enabled = true;
            dtStarted.Enabled = true;

            rdNumOfDays.Enabled = true;
            rdDaily.Enabled = true;
            rdStop.Enabled = true;
            //txtNumOfDays.Enabled = true;


            txtNotes.Enabled = true;

            btnAdd.Enabled = false;
            btnRemove.Enabled = false;
            btnSave.Enabled = false;
            btnEdit.Enabled = false;
            btnUpdate.Enabled = true;
            btnCancel.Enabled = true;

            txtMedicationName.Focus();
        }

        public void resetSettingsSearchAndInfo()
        {
            txtSearch.Text = "";
            rdById.Checked = false;
            rdByLastName.Checked = false;

            lblPatientId.Text = "0";
            lblFacility.Text = "0";
            lblPatientName.Text = "0";

            searchPatientByID(0);
            getPatientMedication(0);

            btnAdd.Enabled = false;
            btnRemove.Enabled = false;
        }

        public void resetSettingsAddMed()
        {
            _isActive = false;

            //lblPatientId.Text = "0";
            //lblFacility.Text = "0";
            //lblPatientName.Text = "0";

            //dgvPatient.DataSource = null;


            txtMedicationName.Text = "";
            txtDosage.Text = "";
            txtDirection.Text = "";
            txtOrderedBy.Text = "";
            txtNotes.Text = "";
            lblStartDate.Text = "0";
            lblEndDate.Text = "0";

            rdNumOfDays.Checked = false;
            rdNumOfDays.Enabled = false;

            txtNumOfDays.Text = "";
            txtNumOfDays.Enabled = false;

            rdDaily.Checked = false;
            rdDaily.Enabled = false;

            rdStop.Checked = false;
            rdStop.Enabled = false;

            txtMedicationName.Enabled = false;
            txtDosage.Enabled = false;
            txtDirection.Enabled = false;
            txtOrderedBy.Enabled = false;
            dtStarted.Enabled = false;

            txtNotes.Enabled = false;

            //btnAdd.Enabled = true;
            //btnRemove.Enabled = true;
            btnSave.Enabled = false;
            btnEdit.Enabled = false;
            btnUpdate.Enabled = false;
            btnCancel.Enabled = false;
        }

        public bool hasInvalidInput()
        {
            bool result = false;
            //MessageBox.Show("Last Name Cannot Be Empty", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            if (txtMedicationName.Text == "")
            {
                MessageBox.Show("Please enter medication name", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtMedicationName.Focus();
                result = true;
            }
            else if (txtDosage.Text == "")
            {
                MessageBox.Show("Please enter dosage", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtDosage.Focus();

                result = true;
            }
            else if (txtDirection.Text == "")
            {
                MessageBox.Show("Please enter direction", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtDirection.Focus();
                result = true;
            }
            else if (txtOrderedBy.Text == "")
            {
                MessageBox.Show("Please enter who ordered the medication", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtOrderedBy.Focus();
                result = true;
            }
            else if (rdNumOfDays.Checked == false && rdDaily.Checked == false && rdStop.Checked==false)
            {
                MessageBox.Show("Please select number of days or daily or stop", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                rdNumOfDays.Focus();
                result = true;
            }
            else if(rdNumOfDays.Checked ==true && txtNumOfDays.Text == "")
            {
                MessageBox.Show("Please enter number of days", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtNumOfDays.Focus();
                result = true;
            }
            else if (lblStartDate.Text == "0")
            {
                MessageBox.Show("Please select start date", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                dtStarted.Focus();
                result = true;
            }


            return result;
        }
        //remove
        //Save
        //Update

        public void getPatientMedication(int patID)
        {
            using(ACHSystem.EDMX.ACHDBContainer db = new ACHSystem.EDMX.ACHDBContainer())
            {
                var patMed = db.tblPatientMedicationLists.Where(x => x.PatientID == patID).Select(y => new
                {
                    patientId = y.PatientID,
                    facilityName = y.tblPatient.tblFacility.Name,
                    patientName = y.tblPatient.LastName + ", " + y.tblPatient.FirstName,
                    medicationName = y.MedicationName,
                    dosage = y.Dosage,
                    direction = y.Direction,
                    orderedBy = y.OrderedBy,
                    startDate = y.StartDate,
                    endDate = y.EndDate,
                    durationType = y.DurationType,
                    note = y.Note,
                    id = y.Id
                }).ToList();


                
                dgvPatientMedication.DataSource = patMed;
            }
        }


        #endregion


        #region Controls
        private void frmPatientMedicationList_Load(object sender, EventArgs e)
        {
            resetSettingsSearchAndInfo();
            resetSettingsAddMed();

            //getPatientMedication(3);
            //for(int i =0; i < 10; i++)
            //{
            //    MessageBox.Show(Convert.ToString(dgvPatientMedication[i, dgvPatientMedication.CurrentRow.Index].Value));
            //}
        }

        private void btnGo_Click(object sender, EventArgs e)
        {
            try
            {
                if (_isActive == false)
                {
                    if (rdById.Checked)
                    {
                        int input;
                        bool inputChecker = Int32.TryParse(txtSearch.Text, out input);
                        if (inputChecker)
                        {
                                searchPatientByID(input);
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
                            searchPatientByLastName(txtSearch.Text);
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
            if(_isActive == false)
            {
                resetSettingsSearchAndInfo();
                resetSettingsAddMed();
            }
            else
            {
                //messagebox finish first
            }
        }

        private void dgvPatient_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if(dgvPatient.RowCount != 0)
            {
                if(_isActive == false)
                {
                    lblPatientId.Text = Convert.ToString(dgvPatient[0, dgvPatient.CurrentRow.Index].Value);
                    lblFacility.Text = Convert.ToString(dgvPatient[1, dgvPatient.CurrentRow.Index].Value);
                    lblPatientName.Text = Convert.ToString(dgvPatient[2, dgvPatient.CurrentRow.Index].Value);
                    getPatientMedication(Convert.ToInt32(lblPatientId.Text));

                    btnAdd.Enabled = true;
                    btnRemove.Enabled = true;
                }
            }
            
        }      

        private void btnAdd_Click(object sender, EventArgs e)
        {
                addMode();        
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            if(dgvPatientMedication.CurrentRow != null || dgvPatientMedication.RowCount != 0)
            {
                
                DialogResult result = MessageBox.Show("Are you sure you want to remove this medication from the list?", "Warning!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (result == DialogResult.Yes)
                {
                    //delete
                    deletePatientMedication(Convert.ToInt32(dgvPatientMedication[11, dgvPatientMedication.CurrentRow.Index].Value));
                    getPatientMedication(Convert.ToInt32(lblPatientId.Text));
                    resetSettingsAddMed();
                }
            }
            else
            {
                MessageBox.Show("No medication is selected", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if(hasInvalidInput() == false)
            {
                //save
                savePatientMedication();
                getPatientMedication(Convert.ToInt32(lblPatientId.Text));
                resetSettingsAddMed();
                btnAdd.Enabled = true;
                btnRemove.Enabled = true;
            }
            
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            editMode();
            if (rdNumOfDays.Checked == true)
            {
                txtNumOfDays.Enabled = true;
            }
            else if (rdStop.Checked == true)
            {
                dtStarted.Enabled = false;
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if(hasInvalidInput() == false)
            {
                updatePatientMedication(_medIdHolder);
                getPatientMedication(Convert.ToInt32(lblPatientId.Text));
                resetSettingsAddMed();
                btnAdd.Enabled = true;
                btnRemove.Enabled = true;
                //MessageBox.Show(_medIdHolder.ToString());
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            resetSettingsAddMed();
            btnAdd.Enabled = true;
            btnRemove.Enabled = true;
        }

        private void dgvPatientMedication_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (_isActive == false)
            {
                if (dgvPatientMedication.RowCount != 0)
                {
                    txtMedicationName.Text = Convert.ToString(dgvPatientMedication[3, dgvPatientMedication.CurrentRow.Index].Value);
                    txtDosage.Text = Convert.ToString(dgvPatientMedication[4, dgvPatientMedication.CurrentRow.Index].Value);
                    txtDirection.Text = Convert.ToString(dgvPatientMedication[5, dgvPatientMedication.CurrentRow.Index].Value);
                    txtOrderedBy.Text = Convert.ToString(dgvPatientMedication[6, dgvPatientMedication.CurrentRow.Index].Value);
                    dtStarted.Value = Convert.ToDateTime(dgvPatientMedication[7, dgvPatientMedication.CurrentRow.Index].Value);

                    if (Convert.ToString(dgvPatientMedication[9, dgvPatientMedication.CurrentRow.Index].Value) == "N")
                    {
                        rdNumOfDays.Checked = true;
                        rdDaily.Checked = false;
                        rdStop.Checked = false;

                        TimeSpan dayDiff = Convert.ToDateTime(dgvPatientMedication[8, dgvPatientMedication.CurrentRow.Index].Value) - Convert.ToDateTime(dgvPatientMedication[7, dgvPatientMedication.CurrentRow.Index].Value);
                        txtNumOfDays.Text = dayDiff.Days.ToString();
                        lblStartDate.Text = dgvPatientMedication[7, dgvPatientMedication.CurrentRow.Index].Value.ToString();
                        lblEndDate.Text = Convert.ToDateTime(dgvPatientMedication[7, dgvPatientMedication.CurrentRow.Index].Value).AddDays(dayDiff.Days).ToString();
                    }
                    else if (Convert.ToString(dgvPatientMedication[9, dgvPatientMedication.CurrentRow.Index].Value) == "D")
                    {
                        rdNumOfDays.Checked = false;
                        txtNumOfDays.Text = "";
                        rdDaily.Checked = true;
                        rdStop.Checked = false;

                        lblStartDate.Text = dgvPatientMedication[7, dgvPatientMedication.CurrentRow.Index].Value.ToString();
                        lblEndDate.Text = dgvPatientMedication[8, dgvPatientMedication.CurrentRow.Index].Value.ToString();
                    }
                    else if (Convert.ToString(dgvPatientMedication[9, dgvPatientMedication.CurrentRow.Index].Value) == "S")
                    {
                        txtNumOfDays.Text = "";
                        rdNumOfDays.Checked = false;
                        rdDaily.Checked = false;
                        rdStop.Checked = true;

                        lblStartDate.Text = dgvPatientMedication[7, dgvPatientMedication.CurrentRow.Index].Value.ToString();
                        lblEndDate.Text = dgvPatientMedication[8, dgvPatientMedication.CurrentRow.Index].Value.ToString();
                    }

                    txtNotes.Text = Convert.ToString(dgvPatientMedication[10, dgvPatientMedication.CurrentRow.Index].Value);
                    btnEdit.Enabled = true;
                    _medIdHolder = Convert.ToInt32(dgvPatientMedication[11, dgvPatientMedication.CurrentRow.Index].Value);
                }
            }

        }
        #endregion



        private void rdNumOfDays_CheckedChanged(object sender, EventArgs e)
        {
            if(_isActive == true)
            {
                if (rdNumOfDays.Checked == true)
                {
                    txtNumOfDays.Enabled = true;
                    txtNumOfDays.Focus();

                    dtStarted.Enabled = true;
                    lblStartDate.Text = "0";
                    lblEndDate.Text = "0";
                }
            }

        }

        private void rdDaily_CheckedChanged(object sender, EventArgs e)
        {
            if (_isActive == true)
            {
                if (rdDaily.Checked == true)
                {
                    txtNumOfDays.Enabled = false;
                    txtNumOfDays.Text = "";

                    dtStarted.Enabled = true;
                    lblStartDate.Text = "0";
                    lblEndDate.Text = "INDEFINITE";
                }
            }

        }

        private void rdStop_CheckedChanged(object sender, EventArgs e)
        {
            if (_isActive == true)
            {
                if (rdStop.Checked == true)
                {
                    if(lblStartDate.Text != "0")
                    {
                        txtNumOfDays.Enabled = false;
                        txtNumOfDays.Text = "";

                        dtStarted.Enabled = false;
                        lblEndDate.Text = DateTime.Now.ToShortDateString();
                    }
                    else
                    {
                        MessageBox.Show("Please select start date first", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        rdStop.Checked = false;
                        rdDaily.Checked = true;
                    }

                }
            }

        }

        private void dtStarted_ValueChanged(object sender, EventArgs e)
        {
            if(_isActive == true)
            {
                if (rdNumOfDays.Checked == true)
                {
                    int input;
                    bool isNumber = int.TryParse(txtNumOfDays.Text, out input);
                    if (isNumber)
                    {
                        if (txtNumOfDays.Text != "")
                        {
                            lblStartDate.Text = dtStarted.Value.ToShortDateString();
                            lblEndDate.Text = dtStarted.Value.AddDays(Convert.ToInt32(input)).ToShortDateString();
                        }
                        else
                        {
                            MessageBox.Show("Please input number of days", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            txtNumOfDays.Focus();
                        }

                    }
                    else
                    {
                        MessageBox.Show("Please input a valid number of days", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        txtNumOfDays.Focus();
                    }
                }
                else if (rdDaily.Checked == true)
                {
                    lblStartDate.Text = dtStarted.Value.ToShortDateString();
                    lblEndDate.Text = "INDEFINITE";
                }
                else
                {
                    MessageBox.Show("Please select if by number of days, Daily, or it needs to be stopped", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }
    }
}
