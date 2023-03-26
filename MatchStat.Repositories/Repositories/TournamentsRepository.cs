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
        public string GetTournamentName(int id)
        {
            using (var context = new FootballInfoContext())
            {
                var tournament = context.Tournaments.FirstOrDefault(t => t.Id == id);
                if (tournament != null)
                {
                    return tournament.Name;
                }
                return string.Empty;
            }
        }
    }
}
