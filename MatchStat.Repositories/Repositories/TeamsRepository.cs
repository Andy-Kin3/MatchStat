using MatchStat.Database;
using MatchStat.DataModel.DataModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MatchStat.Repositories.Repositories
{
    public class TeamsRepository
    {
        public TeamsRepository() { }
        public List<Team> GetAllTeams()
        {
            using(var context = new FootballInfoContext())
            {
                var teams = context.Teams.ToList();
                return teams;
            }
        }
        public void SaveAndUpdateTeams(Team teams)
        {
            using (var context = new FootballInfoContext())
            {
                var t = teams;
                if(t.Id == 0)
                {
                    t.Id = GetNextTeamId();
                }
                context.SaveChanges();
            }
        }
        public void UpdateTeam(Team team)
        {
            using(var context = new FootballInfoContext())
            {
                var t = team;
                context.Teams.Update(t);
                context.SaveChanges();
            }
        }
        private int GetNextTeamId()
        {
            using (var context = new FootballInfoContext())
            {
                var NextMatchId = context.Teams.Max(m => m.Id);
                return NextMatchId + 1;
            }
        }
            public void RemoveTeamInDb(Team teams)
        {
            using (var context = new FootballInfoContext())
            {
                var t = teams;
                context.Teams.Remove(t);
                context.SaveChanges();
            }
        }
    }
}
