using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace SMS.Models.StudentInfoViewModel
{
    public class StudentInfoViewModel
    {
        public int StudentId { get; set; }
        [Required(ErrorMessage="First Name is Required")]
        [Display(Name ="First Name")]
        public string FirstName { get; set; }
        [Display(Name = "Middle Name")]
        public string MidName { get; set; }
        [Required(ErrorMessage = "Last Name is Required")]
        [Display(Name = "Last Name")]
        public string LastName { get; set; }
        [Required(ErrorMessage = "Permanent State is Required")]
        [Display(Name = "Permanent State")]
        public string PState { get; set; }
        [Required(ErrorMessage = "Permanent District is Required")]
        [Display(Name = "Permanent District")]
        public string PDistrict { get; set; }
        [Display(Name = "Permanent Metropolitan")]
        public string PMetropolitan { get; set; }
        [Display(Name = "Permanent Sub-Metropolitan")]
        public string PSubMetropolitan { get; set; }
        [Display(Name = "Permanent Municipality")]
        public string PMunicipality { get; set; }
        [Display(Name = "Permanent GauPalika")]
        public string PGauPalika { get; set; }
        [Display(Name = "Permanent WardNo")]
        public string PWardNo { get; set; }
        [Display(Name = "Temporary State")]
        public string TState { get; set; }
        [Display(Name = "Temporary District")]
        public string TDistrict { get; set; }
        [Display(Name = "Temporary Metropolitan")]
        public string TMetropolitan { get; set; }
        [Display(Name = "Temporary Sub-Metropolitan")]
        public string TSubMetropolitan { get; set; }
        [Display(Name = "Temporary Municipality")]
        public string TMunicipality { get; set; }
        [Display(Name = "Temporary GauPalika")]
        public string TGauPalika { get; set; }
        [Display(Name = "Temporary WardNo")]
        public string TWardNo { get; set; }
        [Display(Name = "BloodGroup")]
        public string BloodGroup { get; set; }
        [Display(Name = "DateOfBirth")]
        public DateTime? DateOfBirth { get; set; }
        [Display(Name = "EmailId")]
        public string EmailId { get; set; }
        [Display(Name ="Mobile Number")]
        public long? CellNumber { get; set; }
        [Display(Name = "Gender")]
        public string Gender { get; set; }
        public string ImageName { get; set; }
        public string ImagePath { get; set; }
        public bool? Status { get; set; }
        public DateTime? CreatedDate { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public DateTime? DeletedDate { get; set; }
        public int? CreatedBy { get; set; }
        public int? UpdatedBy { get; set; }
        public int? DeletedBy { get; set; }
        
    }
}