using Volo.Abp.Ui.Branding;
using Volo.Abp.DependencyInjection;

namespace acme.student.Web;

[Dependency(ReplaceServices = true)]
public class studentBrandingProvider : DefaultBrandingProvider
{
    public override string AppName => "student";
}
