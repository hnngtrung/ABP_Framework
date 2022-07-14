using acme.student.Localization;
using Volo.Abp.AspNetCore.Mvc.UI.RazorPages;

namespace acme.student.Web.Pages;

/* Inherit your PageModel classes from this class.
 */
public abstract class studentPageModel : AbpPageModel
{
    protected studentPageModel()
    {
        LocalizationResourceType = typeof(studentResource);
    }
}
