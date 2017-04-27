using Blargo.JudisList.EntityFramework;

namespace Blargo.JudisList.Migrations.Seed.Host
{
    public class InitialHostDbBuilder
    {
        private readonly JudisListDbContext _context;

        public InitialHostDbBuilder(JudisListDbContext context)
        {
            _context = context;
        }

        public void Create()
        {
            new DefaultEditionCreator(_context).Create();
            new DefaultLanguagesCreator(_context).Create();
            new HostRoleAndUserCreator(_context).Create();
            new DefaultSettingsCreator(_context).Create();

            _context.SaveChanges();
        }
    }
}
