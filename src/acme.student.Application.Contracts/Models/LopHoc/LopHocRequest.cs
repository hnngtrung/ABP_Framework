using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace acme.student.Models.LopHoc
{
    public class LopHocRequest
    {
        [Required(ErrorMessage = "Required")]
        [StringLength(255)]
        [Display(Name ="TenLopHoc", Prompt = "PlaceHolder")]
        public string name { get; set; }
        [StringLength(1000)]
        [Display(Name = "GhiChuLopHoc")]
        public string ghichu { get; set; }
    }
}
