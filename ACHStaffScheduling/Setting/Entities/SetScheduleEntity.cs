using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACHStaffScheduling.Setting
{
    public class SetScheduleEntity
    {
        private int _ScheduleId;
        private string _Date;
        private int _FacilityId;
        private string _FacilityName;
        private int _EmployeeId;
        private string _EmployeeName;

        #region Contructor
        public SetScheduleEntity()
        {

        }

        public SetScheduleEntity(int ScheduleId,
                              string Date,
                              int FacilityId,
                              string FacilityName,
                              int EmployeeId,
                              string EmployeeName)
        {
            this._ScheduleId = ScheduleId;
            this._Date = Date;
            this._FacilityId = FacilityId;
            this._FacilityName = FacilityName;
            this._EmployeeId = EmployeeId;
            this._EmployeeName = EmployeeName;
        }
        #endregion

        public int ScheduleId
        {
            get { return _ScheduleId; }
            set { _ScheduleId = value; }
        }
        public string Date
        {
            get { return _Date; }
            set { _Date = value; }
        }
        public int FacilityId
        {
            get { return _FacilityId; }
            set { _FacilityId = value; }
        }
        public string FacilityName
        {
            get { return _FacilityName; }
            set { _FacilityName = value; }
        }
        public int EmployeeId
        {
            get { return _EmployeeId; }
            set { _EmployeeId = value; }
        }
        public string EmployeeName
        {
            get { return _EmployeeName; }
            set { _EmployeeName = value; }
        }
    }
}
