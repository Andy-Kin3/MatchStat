using MatchStat.DataModel.DataModels;

namespace MatchStat.Interfaces.Interfaces
{
    public interface ITeamsRepository : IParentInterface<Team>
    {
        string GetTeamName(int teamId);
    }
}