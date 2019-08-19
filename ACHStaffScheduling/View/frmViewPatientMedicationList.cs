using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ACHSystem.View
{
    public partial class frmViewPatientMedicationList : Form
    {
        public frmViewPatientMedicationList()
        {
            InitializeComponent();
        }

        public void getMedicationList(int id,string patientName,string facilityName)
        {
            using (ACHSystem.EDMX.ACHDBContainer db = new ACHSystem.EDMX.ACHDBContainer())
            {

                var res = db.tblPatientMedicationLists.Where(y => y.PatientID == id).Select(x => new {
                    Id = x.Id,
                    PatientId = x.PatientID,
                    MedicationName = x.MedicationName.ToUpper(),
                    Dosage = x.Dosage.ToUpper(),
                    Direction = x.Direction.ToUpper(),
                    OrderedBy = x.OrderedBy.ToUpper(),
                    StartDate = x.StartDate.ToUpper(),
                    EndDate = x.EndDate.ToUpper(),
                    DurationType = x.DurationType.ToUpper(),
                    Note = x.Note.ToUpper(),
                    PatientName = patientName.ToUpper(),
                    FacilityName = facilityName.ToUpper()
                }).ToList();

                if(res.Count == 0)
                {
                    res = db.tblPatients.Where(y => y.Id == id).Select(x => new {
                        Id = x.Id,
                        PatientId = 0,
                        MedicationName = "",
                        Dosage = "",
                        Direction = "",
                        OrderedBy = "",
                        StartDate = "",
                        EndDate = "",
                        DurationType = "",
                        Note = "",
                        PatientName = patientName.ToUpper(),
                        FacilityName = facilityName.ToUpper()
                    }).ToList();
                }

                ViewPatientMedicationListBindingSource.DataSource = res;
                this.reportViewer1.RefreshReport();
            }
        }

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

        private void frmViewPatientMedicationList_Load(object sender, EventArgs e)
        {

        }

        private void btnViewMedList_Click(object sender, EventArgs e)
        {
            if (dgvPatient.CurrentRow == null || dgvPatient.RowCount == 0)
            {
                MessageBox.Show("No patient selected, please search then select patient first", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                getMedicationList(Convert.ToInt32(dgvPatient[0, dgvPatient.CurrentRow.Index].Value),
                                    Convert.ToString(dgvPatient[2, dgvPatient.CurrentRow.Index].Value),
                                    Convert.ToString(dgvPatient[1, dgvPatient.CurrentRow.Index].Value));
            }
        }

        private void btnGo_Click(object sender, EventArgs e)
        {
            try
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

            searchPatientByID(0);
            getMedicationList(0," "," ");
        }
    }
}
