
using MatchStat.DataModel.DataModels;

namespace MatchStat.Interfaces
{
    public interface ITournamentsRepository : IParentInterface<Tournament>
    {
        string GetTournamentName(int id);
    }
}
