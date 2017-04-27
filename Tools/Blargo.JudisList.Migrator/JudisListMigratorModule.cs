using System.Data.Entity;
using System.Reflection;
using Abp.Events.Bus;
using Abp.Modules;
using Castle.MicroKernel.Registration;
using Blargo.JudisList.EntityFramework;

namespace Blargo.JudisList.Migrator
{
    [DependsOn(typeof(JudisListDataModule))]
    public class JudisListMigratorModule : AbpModule
    {
        public override void PreInitialize()
        {
            Database.SetInitializer<JudisListDbContext>(null);

            Configuration.BackgroundJobs.IsJobExecutionEnabled = false;
            Configuration.ReplaceService(typeof(IEventBus), () =>
            {
                IocManager.IocContainer.Register(
                    Component.For<IEventBus>().Instance(NullEventBus.Instance)
                );
            });
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(Assembly.GetExecutingAssembly());
        }
    }
}