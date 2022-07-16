using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Threading.Tasks;
using acme.student.Models.SinhVien;
using acme.student.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Volo.Abp.Application.Dtos;
using Volo.Abp.AspNetCore.Mvc.UI.Bootstrap.TagHelpers.Form;
using static acme.student.Web.Pages.Commons.SinhVien.CreateModal;

namespace acme.student.Web.Pages.Commons.SinhVien
{
    public class EditModal : studentPageModel
    {
        [HiddenInput]
        [BindProperty(SupportsGet = true)]
        public Guid Id { get; set; }

        [BindProperty]
        public SinhVienModel ViewModel { get; set; }

        public List<SelectListItem> BoPhanList { get; set; }

        private readonly ISinhVienAppService _service;

        private readonly ILopHocAppService _lopHocService;

        public EditModal(ISinhVienAppService service, ILopHocAppService lopHocService)
        {
            _service = service;
        }

        public virtual async Task OnGetAsync()
        {
            var response = await _service.GetAsync(Id);
            ViewModel = ObjectMapper.Map<SinhVienResponse, SinhVienModel>(response);

            var lopHocList = await _lopHocService.GetListAsync(new PagedAndSortedResultRequestDto { MaxResultCount = 1000 });
            BoPhanList = new List<SelectListItem>();
            BoPhanList.Add(new SelectListItem
            {
                Value = "",
                Text = "Chọn Lớp Học",
                Selected = true
            });
            foreach (var item in lopHocList.Items)
            {
                BoPhanList.Add(new SelectListItem
                {
                    Value = item.Id.ToString(),
                    Text = item.name.ToString()
                });
            }
        }

        public virtual async Task<IActionResult> OnPostAsync()
        {
            await _service.UpdateAsync(Id, ViewModel);
            return NoContent();
        }

        public class SinhVienModel : SinhVienRequest
        {
            [SelectItems(nameof(BoPhanList))]
            [Display(Name = "BoPhan")]
            public override Guid LopHocId { get; set; }
        }
    }
}