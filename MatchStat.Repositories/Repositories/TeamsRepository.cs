using MatchStat.Database;
using MatchStat.DataModel.DataModels;
using MatchStat.Interfaces.Interfaces;

namespace MatchStat.Repositories.Repositories
{
    public class TeamsRepository : ParentRepository<Team>, ITeamsRepository
    {
        public TeamsRepository(FootballInfoContext context) : base(context)
        {

        }

        public string GetTeamName(int teamId)
        {
            using (var context = new FootballInfoContext())
            {
                var team = context.Teams.FirstOrDefault(t => t.Id == teamId);
                if (team != null)
                {
                    return team.Name;
                }
                return string.Empty;
            }
        }
    }
}
