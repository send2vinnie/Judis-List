using System.Data.SqlClient;
using Shouldly;
using Xunit;

namespace Blargo.JudisList.Tests.General
{
    public class ConnectionString_Tests
    {
        [Fact]
        public void SqlConnectionStringBuilder_Test()
        {
            var csb = new SqlConnectionStringBuilder("Server=localhost; Database=JudisList; Trusted_Connection=True;");
            csb["Database"].ShouldBe("JudisList");
        }
    }
}
