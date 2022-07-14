using System;
using System.Collections.Generic;
using System.Text;
using acme.student.Models.LopHoc;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;

namespace acme.student.Services
{
    public interface ILopHocAppService : ICrudAppService<
            LopHocResponse,
            Guid,
            PagedAndSortedResultRequestDto,
            LopHocRequest,
            LopHocRequest
            >
    {
    }
}
