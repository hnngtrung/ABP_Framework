using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Domain.Entities.Auditing;

namespace acme.student.Entities.Commons
{
    public class SinhVien : FullAuditedAggregateRoot<Guid>
    {
        public string name { get; set; }
        public int tuoi { get; set; }
        public int cmnd { get; set; }
        public Guid LopHocId { get; set; }
        public LopHoc LopHoc { get; set; }
    }
}
