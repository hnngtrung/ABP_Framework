using System;
using System.Collections.Generic;
using System.Text;
using acme.student.Models.SinhVien;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;

namespace acme.student.Services
{
    public interface ISinhVienAppService : ICrudAppService<
            SinhVienResponse,
            Guid,
            PagedAndSortedResultRequestDto,
            SinhVienRequest,
            SinhVienRequest
            >
    {
    }
}
