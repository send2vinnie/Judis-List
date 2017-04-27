using EntityFramework.DynamicFilters;
using Blargo.JudisList.EntityFramework;

namespace Blargo.JudisList.Tests.TestDatas
{
    public class TestDataBuilder
    {
        private readonly JudisListDbContext _context;
        private readonly int _tenantId;

        public TestDataBuilder(JudisListDbContext context, int tenantId)
        {
            _context = context;
            _tenantId = tenantId;
        }

        public void Create()
        {
            _context.DisableAllFilters();

            new TestOrganizationUnitsBuilder(_context, _tenantId).Create();

            _context.SaveChanges();
        }
    }
}
