using System;
using System.Threading.Tasks;
using acme.student.Models.LopHoc;
using acme.student.Models.Search;
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
        ///<summary>
        ///Tim kiem bo phan
        ///</summary>
        ///<param name="condition"> Dieu kien search</param>
        ///<returns></returns>

        Task<PagedResultDto<LopHocResponse>> SearchAsync(ConditionSearchRequest condition);

    }
}
