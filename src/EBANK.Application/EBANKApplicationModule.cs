using Abp.AutoMapper;
using Abp.Modules;
using Abp.Reflection.Extensions;
using EBANK.Authorization;

namespace EBANK
{
    [DependsOn(
        typeof(EBANKCoreModule), 
        typeof(AbpAutoMapperModule))]
    public class EBANKApplicationModule : AbpModule
    {
        public override void PreInitialize()
        {
            Configuration.Authorization.Providers.Add<EBANKAuthorizationProvider>();
        }

        public override void Initialize()
        {
            var thisAssembly = typeof(EBANKApplicationModule).GetAssembly();

            IocManager.RegisterAssemblyByConvention(thisAssembly);

            Configuration.Modules.AbpAutoMapper().Configurators.Add(
                // Scan the assembly for classes which inherit from AutoMapper.Profile
                cfg => cfg.AddMaps(thisAssembly)
            );
        }
    }
}
