using CricketTeam_Managment_System.Model;

namespace CricketTeam_Managment_System.DbAccess
{
    public interface ICricketTeamDataAccess
    {
        public Task<IEnumerable<CricketTeam>> GetCricketTeamsById(int id);
        public Task<IEnumerable<CricketTeam>> GetAllCricketTeams();
        public Task<int> InserterCricketerDetails(CricketTeam cricketTeam);
        public Task<int> UpdateCricketerDetails(CricketTeam cricketTeam);
        public Task<int> DeleteCricketerDetails(int id);

    }
}