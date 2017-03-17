using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace SMS.Models.SetupViewModel
{
    public class SetupBlockViewModel
    {
        public int BlockId { get; set; }
        [Display(Name = "Block Name")]
        public int BlockName { get; set; }
        public bool? Status { get; set; }
        public DateTime? CreatedDate { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public DateTime? DeletedDate { get; set; }
        public int? CreatedBy { get; set; }
        public int? UpdatedBy { get; set; }
        public int? DeletedBy { get; set; }
        public List<SetupBlockViewModel> SetupBlockViewModelList { get; set; }
    }
}