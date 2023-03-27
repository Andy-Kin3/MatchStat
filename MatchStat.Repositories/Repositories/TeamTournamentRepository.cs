using MatchStat.Database;
using MatchStat.DataModel.DataModels;
using MatchStat.Interfaces.Interfaces;

namespace MatchStat.Repositories.Repositories
{
    public class TeamTournamentRepository : ParentRepository<TeamTournament>, ITeamTournamentsRepository
    {
        public TeamTournamentRepository(FootballInfoContext context) : base(context)
        {
        }

    }
}
