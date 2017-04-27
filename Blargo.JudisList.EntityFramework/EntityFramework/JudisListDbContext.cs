using System.Data.Common;
using System.Data.Entity;
using Abp.Zero.EntityFramework;
using Blargo.JudisList.Authorization.Roles;
using Blargo.JudisList.Authorization.Users;
using Blargo.JudisList.Chat;
using Blargo.JudisList.Friendships;
using Blargo.JudisList.MultiTenancy;
using Blargo.JudisList.Storage;

namespace Blargo.JudisList.EntityFramework
{
    /* Constructors of this DbContext is important and each one has it's own use case.
     * - Default constructor is used by EF tooling on design time.
     * - constructor(nameOrConnectionString) is used by ABP on runtime.
     * - constructor(existingConnection) is used by unit tests.
     * - constructor(existingConnection,contextOwnsConnection) can be used by ABP if DbContextEfTransactionStrategy is used.
     * See http://www.aspnetboilerplate.com/Pages/Documents/EntityFramework-Integration for more.
     */

    public class JudisListDbContext : AbpZeroDbContext<Tenant, Role, User>
    {
        /* Define an IDbSet for each entity of the application */

        public virtual IDbSet<BinaryObject> BinaryObjects { get; set; }

        public virtual IDbSet<Friendship> Friendships { get; set; }

        public virtual IDbSet<ChatMessage> ChatMessages { get; set; }

        public virtual IDbSet<ClassType> ClassTypes { get; set; }

        public JudisListDbContext()
            : base("Default")
        {
            
        }

        public JudisListDbContext(string nameOrConnectionString)
            : base(nameOrConnectionString)
        {

        }

        public JudisListDbContext(DbConnection existingConnection)
           : base(existingConnection, false)
        {

        }

        public JudisListDbContext(DbConnection existingConnection, bool contextOwnsConnection)
            : base(existingConnection, contextOwnsConnection)
        {

        }

        
    }
}
