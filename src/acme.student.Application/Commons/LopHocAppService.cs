using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using acme.student.Entities.Commons;
using acme.student.Models.LopHoc;
using acme.student.Models.Search;
using acme.student.Services;
using Microsoft.AspNetCore.Mvc;
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

        [HttpGet]
        public async Task<PagedResultDto<LopHocResponse>> SearchAsync (ConditionSearchRequest condition) {
            var input = new PagedAndSortedResultRequestDto { MaxResultCount = 1000, SkipCount = 0 };
            if (condition.keyword== null)
            {
                condition.keyword = "";
            }
            PagedResultDto<LopHocResponse> listResultDto = new PagedResultDto<LopHocResponse> ();
            var list = await this.GetListAsync(input);
            var resultSearch = list.Items.Where(x => x.Name.Contains(condition.keyword));
            listResultDto.TotalCount = resultSearch.Count();
            listResultDto.Items = resultSearch.Skip(condition.SkipCount).Take(condition.MaxResutlCount).ToList();
            return listResultDto;
            
        }
    }
}
