using MatchStat.DataModel.DataModels;

namespace MatchStat.Interfaces.Interfaces
{
    public interface ITournamentsRepository : IParentInterface<Tournament>
    {
        string GetTournamentName(int id);
    }
}
