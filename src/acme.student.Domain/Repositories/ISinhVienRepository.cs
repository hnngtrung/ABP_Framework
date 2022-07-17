using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using acme.student.Entities.Commons;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Domain.Repositories;

namespace acme.student.Repositories
{
    public interface ISinhVienRepository : IRepository<SinhVien, Guid>
    {
        Task<PagedResultDto<SinhVien>> GetListAsync(PagedAndSortedResultRequestDto input);
    }
}
