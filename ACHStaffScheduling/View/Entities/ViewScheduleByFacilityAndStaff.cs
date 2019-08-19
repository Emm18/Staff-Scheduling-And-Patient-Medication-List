using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACHSystem.Setting.View.Entities
{
    public class ViewScheduleByFacilityAndStaff
    {

        private string _Date;
        private string _EmployeeName;
        private string _Facility;
        private string _Address;

        #region Contructor
        public ViewScheduleByFacilityAndStaff()
        {

        }

        public ViewScheduleByFacilityAndStaff(string Date,
                              string EmployeeName,
                              string Facility,
                              string Address)
        {
            this._Date = Date;
            this._EmployeeName = EmployeeName;
            this._Facility = Facility;
            this._Address = Address;

        }
        #endregion


        public string Date
        {
            get { return _Date; }
            set { _Date = value; }
        }
        public string EmployeeName
        {
            get { return _EmployeeName; }
            set { _EmployeeName = value; }
        }
        public string Facility
        {
            get { return _Facility; }
            set { _Facility = value; }
        }
        public string Address
        {
            get { return _Address; }
            set { _Address = value; }
        }

    }
}
