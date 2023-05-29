using System.Data.SqlClient;

namespace CricketTeam_Managment_System.DbAccess
{
    public class DbConnectionFactory : IDbConnectionFactory
    {
        private readonly IConfiguration _configuration;

        public DbConnectionFactory(IConfiguration configuration)
        {
            _configuration = configuration ?? throw new ArgumentNullException(nameof(configuration));
        }

        public SqlConnection Create()
        {
            return new SqlConnection(_configuration.GetConnectionString("Default"));
        }
    }
}
