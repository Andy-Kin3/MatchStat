using MatchStat.Interfaces.Database;
using MatchStat.DataModel.DataModels;
using MatchStat.Interfaces.Interfaces;

namespace MatchStat.Repositories.Repositories
{
    public class TournamentsRepository : ParentRepository<Tournament>, ITournamentsRepository
    {
        public TournamentsRepository(IFootballInfoContext context) : base(context)
        {
        }
        public string GetTournamentName(int id)
        {
            var tournament = _context.Tournaments.FirstOrDefault(t => t.Id == id);
            if (tournament != null)
            {
                return tournament.Name;
            }
            return string.Empty;
        }
    }
}
