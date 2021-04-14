using Abp.AspNetCore;
using Abp.AspNetCore.TestBase;
using Abp.Modules;
using Abp.Reflection.Extensions;
using EBANK.EntityFrameworkCore;
using EBANK.Web.Startup;
using Microsoft.AspNetCore.Mvc.ApplicationParts;

namespace EBANK.Web.Tests
{
    [DependsOn(
        typeof(EBANKWebMvcModule),
        typeof(AbpAspNetCoreTestBaseModule)
    )]
    public class EBANKWebTestModule : AbpModule
    {
        public EBANKWebTestModule(EBANKEntityFrameworkModule abpProjectNameEntityFrameworkModule)
        {
            abpProjectNameEntityFrameworkModule.SkipDbContextRegistration = true;
        } 
        
        public override void PreInitialize()
        {
            Configuration.UnitOfWork.IsTransactional = false; //EF Core InMemory DB does not support transactions.
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(EBANKWebTestModule).GetAssembly());
        }
        
        public override void PostInitialize()
        {
            IocManager.Resolve<ApplicationPartManager>()
                .AddApplicationPartsIfNotAddedBefore(typeof(EBANKWebMvcModule).Assembly);
        }
    }
}