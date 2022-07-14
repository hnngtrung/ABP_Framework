using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using acme.student.Entities.Commons;
using acme.student.Models.SinhVien;
using acme.student.Services;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;
using Volo.Abp.Domain.Repositories;

namespace acme.student.Commons
{
    public class SinhVienAppService : CrudAppService<
        SinhVien, SinhVienResponse, Guid,
            PagedAndSortedResultRequestDto,
            SinhVienRequest,
            SinhVienRequest
            >,
        ISinhVienAppService
    {
        public SinhVienAppService(IRepository<SinhVien, Guid> repository) : base(repository)
        {

        }
    }
}
