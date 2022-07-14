using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using acme.student.Entities.Commons;
using acme.student.Models.LopHoc;
using acme.student.Services;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;
using Volo.Abp.Domain.Repositories;

namespace acme.student.Commons
{
    public class LopHocAppService : CrudAppService
        <
        LopHoc, LopHocResponse, Guid,
            PagedAndSortedResultRequestDto,
            LopHocRequest,
            LopHocRequest
            >,
        ILopHocAppService
    {
        public LopHocAppService(IRepository<LopHoc, Guid> repository) : base(repository)
        {

        }
    }
}
