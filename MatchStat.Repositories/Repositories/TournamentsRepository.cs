using MatchStat.Database;
using MatchStat.DataModel.DataModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MatchStat.Repositories.Repositories
{
    public class TournamentsRepository
    {
        public TournamentsRepository() { }
        public List<Tournament> GetTournaments()
        {
            using(var context = new FootballInfoContext())
            {
                var tournaments = context.Tournaments.ToList();
                return tournaments;
            }
        }
        public void SaveAllTournaments(Tournament tournament)
        {
            using(var context = new FootballInfoContext())
            {
                var t = tournament;
                if(t.Id != 0)
                {
                    t.Id = GetNextTournamentId();
                }
                context.Tournaments.Add(t);
                context.SaveChanges();
            }
        }

        private int GetNextTournamentId()
        {
            using (var context = new FootballInfoContext())
            {
                var maximumId = context.Tournaments.Max(t => t.Id);
                return maximumId + 1;
            }
        }

        public void UpdateTournaments(Tournament tournament)
        {
            using (var context = new FootballInfoContext())
            {
                var t = tournament;
                context.Tournaments.Update(t);
                context.SaveChanges();
            }
        }

    }
}
