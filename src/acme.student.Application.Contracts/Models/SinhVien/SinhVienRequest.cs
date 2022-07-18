using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace acme.student.Models.SinhVien
{
    public class SinhVienRequest
    {
        [Required(ErrorMessage = "Required")]
        [StringLength(255)]
        [Display(Name = "TenSInhVien", Prompt = "PlaceHolder")]
        public string name { get; set; }
        [Display(Name = "Tuoi", Prompt = "PlaceHolder")]
        public int tuoi { get; set; }
        [Display(Name = "SinhViencmnd", Prompt = "PlaceHolder")]
        public int cmnd { get; set; }
        [Required(ErrorMessage = "Required")]
        public virtual Guid LopHocId  { get; set; }
    }
}
