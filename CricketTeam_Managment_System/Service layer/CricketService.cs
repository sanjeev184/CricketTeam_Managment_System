using CricketTeam_Managment_System.DbAccess;
using CricketTeam_Managment_System.Model;
using CricketTeam_Managment_System.ResponseForServiceLayer;
using CricketTeam_Managment_System.Service_layer;
using Microsoft.VisualStudio.TestPlatform.CommunicationUtilities;

namespace Non_database_Project.Service_layer
{
    public class CricketService : ICricketService
    {
        ICricketTeamDataAccess _cricketTeamDataAccess;

        public CricketService(ICricketTeamDataAccess cricketTeamDataAccess)
        {
            _cricketTeamDataAccess = cricketTeamDataAccess;
        }
        public async Task<CricketResponse> Add(CricketTeam item)
        {
            var result = await _cricketTeamDataAccess.InserterCricketerDetails(item);

            if (result == null)
            {
                return new CricketResponse(Success: false, CricketErrorMessages.Fail);
            }
            return new CricketResponse(Success: true);
        }

        public async Task<IEnumerable<CricketTeam>> Get(int id)
        {
            var getCricketTeamsById = await _cricketTeamDataAccess.GetCricketTeamsById(id);
            if (getCricketTeamsById is null)
            {
                return null;
            }
            return getCricketTeamsById;
        }

        public async Task<IEnumerable<CricketTeam>> GetAll()
        {
            var getAllCricketTeams = await _cricketTeamDataAccess.GetAllCricketTeams();
            if (getAllCricketTeams is null)
            {
                return null;
            }
            return getAllCricketTeams;
        }



        public async Task<CricketResponse> Delete(int id)
        {
            var result = await _cricketTeamDataAccess.DeleteCricketerDetails(id);

            if (result == null)
            {
                return new CricketResponse(Success: false, CricketErrorMessages.FailtoRemove);
            }
            return new CricketResponse(Success: true);
        }

        public async Task<CricketResponse> Update(CricketTeam item)
        {
            var result = await _cricketTeamDataAccess.UpdateCricketerDetails(item);

            if (result == null)
            {
                return new CricketResponse(Success: false, CricketErrorMessages.Fail);
            }
            return new CricketResponse(Success: true);
        }
    }
}


