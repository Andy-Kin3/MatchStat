using MatchStat.Interfaces.Database;
using MatchStat.DataModel.DataModels;
using MatchStat.Interfaces.Interfaces;

namespace MatchStat.Repositories.Repositories
{
    public class GoalRepository : ParentRepository<Goal>, IGoalRepository
    {
        public GoalRepository(IFootballInfoContext c) : base(c)
        {
        }
        public string GetPlayerFullName(int playerId)
        {
            var playerName = _context.Players.FirstOrDefault(p => p.Id == playerId);
            if (playerName != null)
            {
                return playerName.FullName;
            }
            return string.Empty;
        }
        public string GetMatchName(int matchId)
        {
            var matchName = _context.MatchDetails.FirstOrDefault(p => p.Id == matchId);
            if (matchName != null)
            {
                return matchName.MatchName;
            }
            return string.Empty;
        }
    }
}
