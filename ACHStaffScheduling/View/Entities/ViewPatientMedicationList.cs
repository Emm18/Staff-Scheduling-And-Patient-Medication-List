using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACHSystem.View.Entities
{
    public class ViewPatientMedicationList
    {
        private int _Id;
        private int _PatientId;
        private string _MedicationName;
        private string _Dosage;
        private string _Direction;
        private string _OrderedBy;
        private string _StartDate;
        private string _EndDate;
        private string _DurationType;
        private string _Note;
        private string _PatientName;
        private string _FacilityName;


        #region Contructor
        public ViewPatientMedicationList()
        {

        }

        public ViewPatientMedicationList(int Id,
                              int PatientId,
                              string MedicationName,
                              string Dosage, 
                              string Direction,
                              string OrderedBy,
                              string StartDate,
                              string EndDate,
                              string DurationType,
                              string Note,
                              string PatientName,
                              string FacilityName)
        {
            this._Id = Id;
            this._PatientId = PatientId;
            this._MedicationName = MedicationName;
            this._Dosage = Dosage;
            this._Direction = Direction;
            this._OrderedBy = OrderedBy;
            this._StartDate = StartDate;
            this._EndDate = EndDate;
            this._DurationType = DurationType;
            this._Note = Note;
            this._PatientName = PatientName;
            this._FacilityName = FacilityName;

        }
        #endregion


        public int Id
        {
            get { return _Id; }
            set { _Id = value; }
        }
        public int PatientId
        {
            get { return _PatientId; }
            set { _PatientId = value; }
        }
        public string MedicationName
        {
            get { return _MedicationName; }
            set { _MedicationName = value; }
        }
        public string Dosage
        {
            get { return _Dosage; }
            set { _Dosage = value; }
        }
        public string Direction
        {
            get { return _Direction; }
            set { _Direction = value; }
        }
        public string OrderedBy
        {
            get { return _OrderedBy; }
            set { _OrderedBy = value; }
        }
        public string StartDate
        {
            get { return _StartDate; }
            set { _StartDate = value; }
        }
        public string EndDate
        {
            get { return _EndDate; }
            set { _EndDate = value; }
        }
        public string DurationType
        {
            get { return _DurationType; }
            set { _DurationType = value; }
        }
        public string Note
        {
            get { return _Note; }
            set { _Note = value; }
        }
        public string PatientName
        {
            get { return _PatientName; }
            set { _PatientName = value; }
        }
        public string FacilityName
        {
            get { return _FacilityName; }
            set { _FacilityName = value; }
        }
    }
}
