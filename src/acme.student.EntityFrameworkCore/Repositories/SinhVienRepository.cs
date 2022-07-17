using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using acme.student.Entities.Commons;
using acme.student.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Domain.Repositories.EntityFrameworkCore;
using Volo.Abp.EntityFrameworkCore;

namespace acme.student.Repositories
{
    public class SinhVienRepository : EfCoreRepository<studentDbContext, SinhVien, Guid>, ISinhVienRepository
    {
        public SinhVienRepository(IDbContextProvider<studentDbContext> dbContextProvider) : base(dbContextProvider)
        {
        }
        public async Task<PagedResultDto<SinhVien>> GetListAsync(PagedAndSortedResultRequestDto input)
        {
            PagedResultDto<SinhVien> list = new PagedResultDto<SinhVien>();
            list.TotalCount = await GetQueryable().Where(w => !w.IsDeleted).CountAsync();
            list.Items = await GetQueryable().Where(w => !w.IsDeleted).Include(t => t.LopHoc).OrderByDescending(w => w.CreationTime).Skip(input.SkipCount).Take(input.MaxResultCount).AsNoTracking().ToListAsync();
            return list;
        }

    }
}
