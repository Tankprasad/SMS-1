using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace SMS.Models.SetupViewModel
{
    public class SetupSubjectViewModel
    {
        public int SubjectId { get; set; }
        [Required (ErrorMessage="Subject Name is Required")]
        public string SubjectName { get; set; }
        public bool IsOptional { get; set; }
        public DateTime? CreatedDate { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public DateTime? DeletedDate { get; set; }
        public int? CreatedBy { get; set; }
        public int? UpdatedBy { get; set; }
        public int? DeletedBy { get; set; }

        public List<SetupSubjectViewModel> SetupSubjectViewModelList { get; set; }


    }
}