using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACHSystem.File_Maintenance.Entities
{
    public class PatientEntity
    {

        private int _PatientId;
        private int _FacilityId;
        private string _FacilityName;
        private string _LastName;
        private string _FirstName;
        private string _MiddleName;
        private string _Active;
        private string _DateCreated;
        private string _DateUpdated;

        #region Contructor
        public PatientEntity()
        {

        }

        public PatientEntity(int PatientId,
                              int FacilityId,
                              string FacilityName,
                              string LastName,
                              string FirstName,
                              string MiddleName,
                              string Active,
                              string DateCreated,
                              string DateUpdated)
        {
            this._PatientId = PatientId;
            this._FacilityId = FacilityId;
            this._FacilityName = FacilityName;
            this._LastName = LastName;
            this._FirstName = FirstName;
            this._MiddleName = MiddleName;
            this._Active = Active;
            this._DateCreated = DateCreated;
            this._DateUpdated = DateUpdated;
        }
        #endregion

        public int PatientId
        {
            get { return _PatientId; }
            set { _PatientId = value; }
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
