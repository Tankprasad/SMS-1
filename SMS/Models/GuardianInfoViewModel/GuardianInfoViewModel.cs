using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SMS.Models.GuardianInfoViewModel
{//l
    public class GuardianInfoViewModel
    {
        public int GuardianId { get; set; }
        public int StudentId { get; set; }
        public string FirstName { get; set; }
        public string PState { get; set; }
        public string PDistrict { get; set; }
        public string PMetropolitan { get; set; }
        public string PSubMetropolitan { get; set; }
        public string PMunicipality { get; set; }
        public string PGauPalika { get; set; }
        public string PWardNo { get; set; }
        public string TState { get; set; }
        public string TDistrict { get; set; }
        public string TMetropolitan { get; set; }
        public string TSubMetropolitan { get; set; }
        public string TMunicipality { get; set; }
        public string TGauPalika { get; set; }
        public string TWardNo { get; set; }
        public string BloodGroup { get; set; }
        public string Occupation { get; set; }
        public string Gender { get; set; }
        public string EmailId { get; set; }
        public string CellNumber { get; set; }
        public Nullable<long> PhoneNumber { get; set; }
        public string CitizenNumber { get; set; }
        public Nullable<bool> Status { get; set; }
        public Nullable<System.DateTime> CreatedDate { get; set; }
        public Nullable<System.DateTime> UpdatedDate { get; set; }
        public Nullable<System.DateTime> DeletedDate { get; set; }
        public Nullable<int> CreatedBy { get; set; }
        public Nullable<int> UpdatedBy { get; set; }
        public Nullable<int> DeletedBy { get; set; }
        public string MidName { get; set; }
        public string LastName { get; set; }
    }
}