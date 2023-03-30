using MatchStat.Interfaces.Database;
using MatchStat.DataModel.DataModels;
using MatchStat.Interfaces.Interfaces;

namespace MatchStat.Repositories.Repositories
{
    public class MatchDetailsRepository : ParentRepository<MatchDetail>, IMatchesRepository
    {
        public MatchDetailsRepository(IFootballInfoContext context) : base(context)
        {
        }
    }
}
