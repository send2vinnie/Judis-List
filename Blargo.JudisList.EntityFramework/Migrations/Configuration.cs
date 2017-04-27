using System.Data.Entity.Migrations;
using Abp.Events.Bus;
using Abp.Events.Bus.Entities;
using Abp.MultiTenancy;
using Abp.Zero.EntityFramework;
using EntityFramework.DynamicFilters;
using Blargo.JudisList.Migrations.Seed.Host;
using Blargo.JudisList.Migrations.Seed.Tenants;

namespace Blargo.JudisList.Migrations
{
    public sealed class Configuration : DbMigrationsConfiguration<EntityFramework.JudisListDbContext>, IMultiTenantSeed
    {
        public AbpTenantBase Tenant { get; set; }

        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
            ContextKey = "JudisList";
        }

        protected override void Seed(EntityFramework.JudisListDbContext context)
        {
            context.DisableAllFilters();

            context.EntityChangeEventHelper = NullEntityChangeEventHelper.Instance;
            context.EventBus = NullEventBus.Instance;

            if (Tenant == null)
            {
                //Host seed
                new InitialHostDbBuilder(context).Create();

                //Default tenant seed (in host database).
                new DefaultTenantBuilder(context).Create();
                new TenantRoleAndUserBuilder(context, 1).Create();
            }
            else
            {
                //You can add seed for tenant databases using Tenant property...
            }

            new InitialClassTypeCreator(context).Create();

            context.SaveChanges();
        }
    }
}
