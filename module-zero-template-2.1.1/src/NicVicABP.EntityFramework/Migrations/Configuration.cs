using System.Data.Entity.Migrations;
using Abp.MultiTenancy;
using Abp.Zero.EntityFramework;
using NicVicABP.Migrations.SeedData;
using EntityFramework.DynamicFilters;
using NicVicABP.People;

namespace NicVicABP.Migrations
{
    public sealed class Configuration : DbMigrationsConfiguration<NicVicABP.EntityFramework.NicVicABPDbContext>, IMultiTenantSeed
    {
        public AbpTenantBase Tenant { get; set; }

        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
            ContextKey = "NicVicABP";
        }

        protected override void Seed(NicVicABP.EntityFramework.NicVicABPDbContext context)
        {
            context.DisableAllFilters();

            if (Tenant == null)
            {
                //Host seed
                new InitialHostDbBuilder(context).Create();

                //Default tenant seed (in host database).
                new DefaultTenantCreator(context).Create();
                new TenantRoleAndUserBuilder(context, 1).Create();
            }
            else
            {
                //You can add seed for tenant databases and use Tenant property...
            }

            context.People.AddOrUpdate(
                p => p.Name,
                new Person { Name = "Isaac Asimov" },
                new Person { Name = "Thomas More" },
                new Person { Name = "George Orwell" },
                new Person { Name = "Douglas Adams" }
                );

            context.SaveChanges();
        }
    }
}
