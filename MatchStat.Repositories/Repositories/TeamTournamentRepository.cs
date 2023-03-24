using MatchStat.Database;
using MatchStat.DataModel.DataModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MatchStat.Repositories.Repositories
{
    public class TeamTournamentRepository
    {
        public TeamTournamentRepository() { }
        public List<TeamTournament> GetTeamTournaments()
        {
            using(var context = new FootballInfoContext())
            {
                var teamTournaments = context.TeamTournaments.ToList();
                return teamTournaments;
            }
        }
        public void SaveAndUpdateTeamTournaments(TeamTournament teamTournaments)
        {
            using(var context=  new FootballInfoContext())
            {
                var tt = teamTournaments;
                if(tt.Id == 0)
                {
                    tt.Id = GetNextTeamTournamentssId();
                }
                context.TeamTournaments.Add(tt);
                context.SaveChanges();
            }
        }
        public void UpdateTeamTournaments(TeamTournament teamTournments)
        {
            using( var context= new FootballInfoContext())
            {
                var tt = teamTournments;
                context.TeamTournaments.Update(tt);
                context.SaveChanges() ;
            }
        }
        private int GetNextTeamTournamentssId()
        {
            using (var context = new FootballInfoContext())
            {
                var NextMatchId = context.TeamTournaments.Max(m => m.Id);
                return NextMatchId + 1;
            }
        }
            public void RemoveTeamTournaments(TeamTournament teamTournaments)
        {
            using (var context = new FootballInfoContext())
            {
                var tt = teamTournaments;
                context.TeamTournaments.Remove(tt);
                context.SaveChanges();
            }
        }
    }
}
