
using Core.Utilities.IoC;
using Core.Utilities.Services;
using MVCUI.Services.Abstract;
using MVCUI.Services.Concrete;

namespace MVCUI.Extensions
{
    public class ServicesExtension : ICoreModule
    {
        public void Load(IServiceCollection services, IConfiguration configuration)
        {
           services.AddHttpContextAccessor();
            services.AddHttpClient<Services.Abstract.IPlanService, PlanService>();
            services.AddHttpClient<Services.Abstract.IPlanStatusService, PlanStatusService>();
            services.AddScoped<IServicesIdentityService, ServicesIdentityService>();
            services.AddHttpClient<IIdentityService, IdentityService>();
        }
    }
}
