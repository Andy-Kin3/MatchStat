using MatchStat.Database;
using MatchStat.DataModel.DataModels;
using MatchStat.Interfaces.Interfaces;

namespace MatchStat.Repositories.Repositories
{
    public class MatchDetailsRepository : ParentRepository<MatchDetail>, IMatchesRepository
    {
        public MatchDetailsRepository(FootballInfoContext context) : base(context)
        {
        }
    }
}
