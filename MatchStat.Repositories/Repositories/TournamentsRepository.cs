using MatchStat.Database;
using MatchStat.DataModel.DataModels;
using MatchStat.Interfaces;

namespace MatchStat.Repositories.Repositories
{
    public class TournamentsRepository : ParentRepository<Tournament>, ITournamentsRepository
    {
        public TournamentsRepository(FootballInfoContext context) : base(context)
        {
        }
    }
}
