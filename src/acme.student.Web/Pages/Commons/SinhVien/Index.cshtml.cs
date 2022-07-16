using System.Threading.Tasks;

namespace acme.student.Web.Pages.Commons.SinhVien
{
    public class IndexModel : studentPageModel
    {
        public virtual async Task OnGetAsync()
        {
            await Task.CompletedTask;
        }
    }
}
