using System;
using System.Collections.Generic;
using System.Text;
using Volo.Abp.Application.Dtos;

namespace acme.student.Models.SinhVien
{
    public class SinhVienResponse : EntityDto<Guid>
    {
        public string name { get; set; }
        public int tuoi { get; set; }
        public int cmnd { get; set; }
        public string LopHocID { get; set; }
    }
}
