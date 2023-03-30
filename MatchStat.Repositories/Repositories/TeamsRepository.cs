using MatchStat.Interfaces.Database;
using MatchStat.DataModel.DataModels;
using MatchStat.Interfaces.Interfaces;

namespace MatchStat.Repositories.Repositories
{
    public class TeamsRepository : ParentRepository<Team>, ITeamsRepository
    {
        public TeamsRepository(IFootballInfoContext context) : base(context)
        {

        }

        public string GetTeamName(int teamId)
        {
            var team = _context.Teams.FirstOrDefault(t => t.Id == teamId);
            if (team != null)
            {
                return team.Name;
            }
            return string.Empty;
        }
    }
}
