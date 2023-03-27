using MatchStat.Database;
using MatchStat.DataModel.DataModels;
using MatchStat.Interfaces.Interfaces;

namespace MatchStat.Repositories.Repositories
{
    public class GoalRepository : ParentRepository<Goal>, IGoalRepository
    {
        public GoalRepository(FootballInfoContext c) : base(c) 
        {
        }
        public string GetPlayerFullName(int playerId)
        {
            using (var context = new FootballInfoContext())
            {
                var playerName = context.Players.FirstOrDefault(p => p.Id == playerId);
                if (playerName != null)
                {
                    return playerName.FullName;
                }
                return string.Empty;
            }
        }
        public string GetMatchName(int matchId)
        {
            using (var context = new FootballInfoContext())
            {
                var matchName = context.MatchDetails.FirstOrDefault(p => p.Id == matchId);
                if (matchName != null)
                {
                    return matchName.MatchName;
                }
                return string.Empty;
            }
        }
    }
}
