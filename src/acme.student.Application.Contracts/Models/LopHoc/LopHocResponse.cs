using System;
using System.Collections.Generic;
using System.Text;
using Volo.Abp.Application.Dtos;

namespace acme.student.Models.LopHoc
{
    public class LopHocResponse : EntityDto<Guid>
    {
        public string Name { get; set; }
        public string ghiChu { get; set; }
    }
}
