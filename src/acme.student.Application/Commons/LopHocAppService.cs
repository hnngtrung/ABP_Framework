using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using acme.student.Entities.Commons;
using acme.student.Models.LopHoc;
using acme.student.Models.Search;
using acme.student.Permissions;
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
            GetPolicyName = studentPermissions.LopHoc.Default;
            GetListPolicyName = studentPermissions.LopHoc.Default;
            CreatePolicyName = studentPermissions.LopHoc.Create;
            UpdatePolicyName = studentPermissions.LopHoc.Update;
            DeletePolicyName = studentPermissions.LopHoc.Delete;

        }

        [HttpGet]
        public async Task<PagedResultDto<LopHocResponse>> SearchAsync (ConditionSearchRequest condition) {
            var input = new PagedAndSortedResultRequestDto { MaxResultCount = 1000, SkipCount = 0 };
            if (condition.keyword== null)
            {
                condition.keyword = "";
            }
            condition.maxResutlCount = 10;
            PagedResultDto<LopHocResponse> listResultDto = new PagedResultDto<LopHocResponse> ();
            var list = await this.GetListAsync(input);
            var resultSearch = list.Items.Where(x => x.Name.Contains(condition.keyword)).ToList();
            listResultDto.TotalCount = resultSearch.Count();
            listResultDto.Items = resultSearch.Skip(condition.skipCount).Take(condition.maxResutlCount).ToList();
            return listResultDto;
            
        }
    }
}
