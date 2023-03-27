using MatchStat.Database;
using MatchStat.DataModel.DataModels;
using MatchStat.Interfaces.Interfaces;
using Microsoft.Identity.Client;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MatchStat.Repositories.Repositories
{
    public class TeamsRepository : ParentRepository<Team>, ITeamsRepository
    {
        public TeamsRepository(FootballInfoContext context) : base(context)
        {
            
        }

        public string GetTeamName(int teamId)
        {
            using (var context = new FootballInfoContext())
            {
                var team = context.Teams.FirstOrDefault(t => t.Id == teamId);
                if (team != null)
                {
                    return team.Name;
                }
                return string.Empty;
            }
        }
    }
}
