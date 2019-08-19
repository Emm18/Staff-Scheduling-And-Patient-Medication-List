using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACHSystem.File_Maintenance.Entities
{
    public class FacilityEntity
    {
        private int _FacilityId;
        private string _Name;
        private string _Address;

        private string _Active;
        private string _DateCreated;
        private string _DateUpdated;

        #region Contructor
        public FacilityEntity()
        {

        }

        public FacilityEntity(int FacilityId,
                              string Name,
                              string Address,
                              string Active,
                              string DateCreated,
                              string DateUpdated)
        {
            this._FacilityId = FacilityId;
            this._Name = Name;
            this._Address = Address;
            this._Active = Active;
            this._DateCreated = DateCreated;
            this._DateUpdated = DateUpdated;
        }
        #endregion

        public int FacilityId
        {
            get { return _FacilityId; }
            set { _FacilityId = value; }
        }
        public string Name
        {
            get { return _Name; }
            set { _Name = value; }
        }
        public string Address
        {
            get { return _Address; }
            set { _Address = value; }
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
