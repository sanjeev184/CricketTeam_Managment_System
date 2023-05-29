using CricketTeam_Managment_System.Model;
using CricketTeam_Managment_System.ResponseForServiceLayer;

namespace CricketTeam_Managment_System.Service_layer
{
    public interface ICricketService
    {
        Task<IEnumerable<CricketTeam>> GetAll();
        Task<IEnumerable<CricketTeam>> Get(int id);
        Task<CricketResponse> Add(CricketTeam item);
        Task<CricketResponse> Delete(int id);
        Task<CricketResponse> Update(CricketTeam item);
    }
}
