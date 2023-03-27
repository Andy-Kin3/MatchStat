using MatchStat.DataModel.DataModels;

namespace MatchStat.Interfaces.Interfaces
{
    public interface IGoalRepository : IParentInterface<Goal>
    {
        string GetMatchName(int matchId);
        string GetPlayerFullName(int playerId);
    }
}