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
    public partial class frmViewScheduleByFacility : Form
    {
        public frmViewScheduleByFacility()
        {
            InitializeComponent();
        }

        List<int> _facilityID = new List<int>();

        private void frmViewScheduleByFacility_Load(object sender, EventArgs e)
        {
            //dtdate.mindate = datetime.now;
            //dtdate.maxdate = datetime.now.adddays(30);
            

            getAllFacility();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void btnGo_Click(object sender, EventArgs e)
        {
            if (cboFacility.SelectedIndex >= 0)
            {
                    getScheduleByFacility(dtDate.Value.ToShortDateString(), _facilityID[cboFacility.SelectedIndex]);
            }
            else
            {
                MessageBox.Show("Make sure to select date and facility", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            dtDate.Value = DateTime.Now;
            cboFacility.SelectedIndex = -1;
            ViewScheduleByFacilityBindingSource.DataSource = null;
            this.rptViewByFacility.RefreshReport();
        }
        
        private void cboFacility_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }


        #region Methods

        public void getAllFacility()
        {
            using (ACHStaffScheduling.EDMX.ACHDBContainer db = new ACHStaffScheduling.EDMX.ACHDBContainer())
            {
                var res = db.tblFacilities.Where(x => x.Active == "Y").ToList();

                foreach (var a in res)
                {
                    _facilityID.Add(a.Id);
                    cboFacility.Items.Add(a.Name);
                }
            }
        }

        public void getScheduleByFacility(string Date, int FacilityID)
        {
            using (ACHStaffScheduling.EDMX.ACHDBContainer db = new ACHStaffScheduling.EDMX.ACHDBContainer())
            {

                var res = db.tblSchedules.Where(z => z.Date == Date && z.FacilityID == FacilityID).Select(x => new ViewScheduleByFacilityAndStaff
                {
                    Date = x.Date,
                    EmployeeName = x.tblEmployee.LastName.ToUpper() + ", " + x.tblEmployee.FirstName.ToUpper() + " " + x.tblEmployee.MiddleName.ToUpper(),
                    Facility = x.tblFacility.Name.ToUpper(),
                    Address = x.tblFacility.Address.ToUpper()
                }).ToList();
                
                ViewScheduleByFacilityBindingSource.DataSource = res;
                this.rptViewByFacility.RefreshReport();
            }
        }
        #endregion

    }
    }

