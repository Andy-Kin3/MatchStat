using MatchStat.DataModel.DataModels;
using MatchStat.Interfaces.Database;
using MatchStat.Interfaces.Interfaces;

namespace MatchStat.Repositories.Repositories
{
    public class PlayersRepository : ParentRepository<Player>, IPlayersRepository
    {
        public PlayersRepository(IFootballInfoContext context) : base(context)
        {
        }
        public string GetTeamName(int teamId)
        {
            var myTeamName = _context.Teams.FirstOrDefault(t => t.Id == teamId);
            if (myTeamName != null)
            {
                return myTeamName.Name;
            }
            return string.Empty;
        }

    }
}
