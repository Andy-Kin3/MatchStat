using MatchStat.Database;
using MatchStat.DataModel.DataModels;
using MatchStat.Interfaces;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MatchStat.Repositories.Repositories
{
    public class PlayersRepository : ParentRepository<Player>, IPlayersRepository
    {
        public PlayersRepository(FootballInfoContext context) : base(context)
        {
        }

    }
}
