using CricketTeam_Managment_System.Model;
using Dapper;
using System.Data;
using System.Data.SqlClient;

namespace CricketTeam_Managment_System.DbAccess
{
    public class CricketTeamDataAccess : ICricketTeamDataAccess
    {
        private readonly IDbConnectionFactory _dbConnectionFactory;
        public CricketTeamDataAccess(IDbConnectionFactory dbConnectionFactory)
        {
            _dbConnectionFactory = dbConnectionFactory;
        }

        public async Task<IEnumerable<CricketTeam>> GetAllCricketTeams()
        {
            await using var connection = _dbConnectionFactory.Create();

            return await connection.QueryAsync<CricketTeam>("[dbo].[GetAll]",
                commandType: CommandType.StoredProcedure);
        }

        public async Task<IEnumerable<CricketTeam>> GetCricketTeamsById(int id)
        {
            await using var connection = _dbConnectionFactory.Create();
            var parameters = new DynamicParameters();
            parameters.Add("@Id", id);
            return await connection.QueryAsync<CricketTeam>("[dbo].[GetById]",
                parameters, commandType: CommandType.StoredProcedure);
        }


        public async Task<int> InserterCricketerDetails(CricketTeam cricketTeam)
        {
            await using var connection = _dbConnectionFactory.Create();

            return await connection.QuerySingleOrDefaultAsync<int>("[dbo].[InsertToCricketTeam]",
                new
                {
                    cricketTeam.Jerseynumber,
                    cricketTeam.Jerseyname,
                    cricketTeam.Playerage,
                    cricketTeam.Average
                },
                commandType: CommandType.StoredProcedure);
        }



        public async Task<int> UpdateCricketerDetails(CricketTeam cricketTeam)
        {
            await using var connection = _dbConnectionFactory.Create();

            return await connection.QuerySingleOrDefaultAsync<int>("[dbo].[Update_CricketTeam]",
                new
                {
                    cricketTeam.Jerseynumber,
                    cricketTeam.Jerseyname,
                    cricketTeam.Playerage,
                    cricketTeam.Average
                },
                commandType: CommandType.StoredProcedure);
        }

        public async Task<int> DeleteCricketerDetails(int id)
        {
            await using var connection = _dbConnectionFactory.Create();
            
            return await connection.QuerySingleOrDefaultAsync<int>("[dbo].[DeletePlayer]",
                new
                {
                    @Id=id
                },
                
                commandType: CommandType.StoredProcedure);
        }

    }
}



