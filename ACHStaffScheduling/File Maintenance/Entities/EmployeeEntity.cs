using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACHStaffScheduling.File_Maintenance.Entities
{
    public class EmployeeEntity
    {
        private int _EmployeeId;
        private string _LastName;
        private string _FirstName;
        private string _MiddleName;

        private string _Active;
        private string _DateCreated;
        private string _DateUpdated;

        #region Contructor
        public EmployeeEntity()
        {

        }

        public EmployeeEntity(int EmployeeId, 
                              string LastName, 
                              string FirstName, 
                              string MiddleName, 
                              string Active, 
                              string DateCreated, 
                              string DateUpdated)
        {
            this._EmployeeId = EmployeeId;
            this._LastName = LastName;
            this._FirstName = FirstName;
            this._MiddleName = MiddleName;
            this._Active = Active;
            this._DateCreated = DateCreated;
            this._DateUpdated = DateUpdated;
        }
        #endregion

        public int EmployeeId
        {
            get { return _EmployeeId; }
            set { _EmployeeId = value; }
        }
        public string LastName
        {
            get { return _LastName; }
            set { _LastName = value; }
        }
        public string FirstName
        {
            get { return _FirstName; }
            set { _FirstName = value; }
        }
        public string MiddleName
        {
            get { return _MiddleName; }
            set { _MiddleName = value; }
        }
        public string Active
        {
            get { return _Active; }
            set { _Active = value; }
        }
        public string DateCreated
        {
            get { return _DateCreated; }
            set { _DateCreated = value; }
        }
        public string DateUpdated
        {
            get { return _DateUpdated; }
            set { _DateUpdated = value; }
        }


    }
}
