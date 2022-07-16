using System.Threading.Tasks;

namespace acme.student.Web.Pages.Commons.LopHoc
{
    public class Index : studentPageModel
    {
        public virtual async Task OnGetAsync()
        {
            await Task.CompletedTask;
        }
    }
}