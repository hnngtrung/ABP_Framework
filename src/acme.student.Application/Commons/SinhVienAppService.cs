using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using acme.student.Entities.Commons;
using acme.student.Models.SinhVien;
using acme.student.Permissions;
using acme.student.Repositories;
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

        private readonly ISinhVienRepository _repository;
        public SinhVienAppService(ISinhVienRepository sinhVien, IRepository<SinhVien, Guid> repository) : base(repository)
        {

        }
        public async override Task<PagedResultDto<SinhVienResponse>> GetListAsync(PagedAndSortedResultRequestDto input)
        {
            PagedResultDto<SinhVien> item = await _repository.GetListAsync(input);
            List<SinhVienResponse> result = new List<SinhVienResponse>();
            foreach (var itemDto in item.Items)
            {
                var sinhVienResponse = ObjectMapper.Map<SinhVien, SinhVienResponse>(itemDto);
                sinhVienResponse.LopHoc = itemDto.LopHoc == null ? "" : itemDto.LopHoc.name;
                result.Add(sinhVienResponse);
            }
            return new PagedResultDto<SinhVienResponse>(item.TotalCount, result);
        }
    }
}
