using System;
using System.Threading.Tasks;
using acme.student.Models.LopHoc;
using acme.student.Services;
using Microsoft.AspNetCore.Mvc;

namespace acme.student.Web.Pages.Commons.LopHoc
{
    public class EditModal : studentPageModel
    {
        [HiddenInput]
        [BindProperty(SupportsGet = true)]
        public Guid Id { get; set; }

        [BindProperty]
        public LopHocRequest ViewModel { get; set; }

        private readonly ILopHocAppService _service;

        public EditModal(ILopHocAppService service)
        {
            _service = service;
        }

        public virtual async Task OnGetAsync()
        {
            var response = await _service.GetAsync(Id);
            ViewModel = ObjectMapper.Map<LopHocResponse, LopHocRequest>(response);
        }

        public virtual async Task<IActionResult> OnPostAsync()
        {
            await _service.UpdateAsync(Id, ViewModel);
            return NoContent();
        }
    }
}