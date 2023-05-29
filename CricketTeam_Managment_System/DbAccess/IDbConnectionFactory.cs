using System.Data.SqlClient;

namespace CricketTeam_Managment_System.DbAccess
{
    public interface IDbConnectionFactory
    {
        SqlConnection Create();
    }
}
