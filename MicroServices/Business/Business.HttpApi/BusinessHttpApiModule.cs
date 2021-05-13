using Microsoft.Extensions.DependencyInjection;
using System;
using Volo.Abp.AspNetCore.Mvc;
using Volo.Abp.AspNetCore.Mvc.AntiForgery;
using Volo.Abp.Modularity;
using XCZ;

namespace Business
{
    [DependsOn(
        typeof(BusinessApplicationContractsModule),
        typeof(FormHttpApiModule),
        typeof(AbpAspNetCoreMvcModule)
    )]
    public class BusinessHttpApiModule : AbpModule
    {
        public override void PreConfigureServices(ServiceConfigurationContext context)
        {
            PreConfigure<IMvcBuilder>(mvcBuilder =>
            {
                mvcBuilder.AddApplicationPartIfNotExists(typeof(BusinessHttpApiModule).Assembly);
            });
        }
        public override void ConfigureServices(ServiceConfigurationContext context)
        {
            Configure<AbpAntiForgeryOptions>(options =>
            {
                options.TokenCookie.Expiration = TimeSpan.FromDays(365 * 5);
                options.AutoValidateIgnoredHttpMethods.Add("PUT");
                options.AutoValidateIgnoredHttpMethods.Add("POST");
                options.AutoValidateIgnoredHttpMethods.Add("DELETE");
            });
        }
    }
}
