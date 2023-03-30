using MatchStat.Interfaces.Database;
using MatchStat.DataModel.DataModels;
using MatchStat.Interfaces.Interfaces;

namespace MatchStat.Repositories.Repositories
{
    public class TeamTournamentRepository : ParentRepository<TeamTournament>, ITeamTournamentsRepository
    {
        public TeamTournamentRepository(IFootballInfoContext context) : base(context)
        {
        }

    }
}
