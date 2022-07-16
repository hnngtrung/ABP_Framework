using System.Threading.Tasks;
using acme.student.Models.LopHoc;
using acme.student.Services;
using Microsoft.AspNetCore.Mvc;

namespace acme.student.Web.Pages.Commons.LopHoc
{
    public class CreateModal : studentPageModel
    {
        [BindProperty]
        public LopHocRequest ViewModel { get; set; }

        private readonly ILopHocAppService _service;

        public CreateModal(ILopHocAppService service)
        {
            _service = service;
        }

        public virtual async Task OnGetAsync()
        {

        }

        public virtual async Task<IActionResult> OnPostAsync()
        {
            await _service.CreateAsync(ViewModel);
            return NoContent();
        }
    }
}