using System;
using System.Collections.Generic;
using System.Text;
using acme.student.Localization;
using Volo.Abp.Application.Services;

namespace acme.student;

/* Inherit your application services from this class.
 */
public abstract class studentAppService : ApplicationService
{
    protected studentAppService()
    {
        LocalizationResource = typeof(studentResource);
    }
}
