using MatchStat.Database;
using MatchStat.Interfaces.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MatchStat.Repositories.Repositories
{
    public class TestRepository
    {
        FootballInfoContext _context;
        public TestRepository(FootballInfoContext context) 
        {
            _context = context;
        }

        public string GetTeamName(int Id) 
        {
            var teamName = _context.Teams.FirstOrDefault(t => t.Id == Id);
            if(teamName != null)
            {
                return teamName.Name;
            }
            return string.Empty;
        }
    }
}
