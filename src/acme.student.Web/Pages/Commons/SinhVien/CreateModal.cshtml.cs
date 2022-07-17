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

namespace acme.student.Web.Pages.Commons.SinhVien
{
    public class CreateModal : studentPageModel
    {
        [BindProperty]
        public SinhVienModel ViewModel { get; set; }

        public List<SelectListItem> LopHocList { get; set; }

        private readonly ILopHocAppService _service;

        private readonly ILopHocAppService _lophocappservice;
        private ILopHocAppService _lopHocAppService;

        public CreateModal(ISinhVienAppService service, ILopHocAppService lopHocService)
        {
            _lopHocAppService = lopHocService;
        }

        public virtual async Task OnGetAsync()
        {
            var lopHocList = await _lopHocAppService.GetListAsync(new PagedAndSortedResultRequestDto { MaxResultCount = 1000 });
            LopHocList = new List<SelectListItem>();
            LopHocList.Add(new SelectListItem
            {
                Value = "",
                Text = "Chon lop hoc",
                Selected = true
            });
            foreach (var item in lopHocList.Items)
            {
                LopHocList.Add(new SelectListItem
                {
                    Value = item.Id.ToString(),
                    Text = item.Name.ToString()
                });
            }
        }

        public virtual async Task<IActionResult> OnPostAsync()
        {
            //await _service.CreateAsync(ViewModel);
            return NoContent();
        }

        public class SinhVienModel : SinhVienRequest
        {
            [SelectItems(nameof(LopHocList))]
            [Display(Name = "LopHoc")]
            public override Guid LopHocId { get; set; }
        }
    }
}