using acme.student.Localization;
using Volo.Abp.AspNetCore.Mvc;

namespace acme.student.Controllers;

/* Inherit your controllers from this class.
 */
public abstract class studentController : AbpControllerBase
{
    protected studentController()
    {
        LocalizationResource = typeof(studentResource);
    }
}
