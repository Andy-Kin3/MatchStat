using MatchStat.Database;
using MatchStat.DataModel.DataModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MatchStat.Repositories.Repositories
{
    public class PlayerRepository
    {
        public PlayerRepository() { }
        public List<Player> GetPlayers()
        {
            using(var context = new FootballInfoContext())
            {
                var p = context.Players.ToList();
                return p;
            }
        }
        public void SavePlayer(Player player)
        {
            using( var context = new FootballInfoContext())
            {
                var p = player;
                if(p.Id == 0)
                {
                    p.Id = GetNextId();
                }
                context.Players.Add(p);
                context.SaveChanges();
            }
        }
        public void UpdatePlayer(Player player)
        {
            using(var context=  new FootballInfoContext())
            {
                var p = player;
                context.Players.Update(p);
                context.SaveChanges();
            }
        }

        private int GetNextId()
        {
           using(var context = new FootballInfoContext())
            {
                var maximumId = context.Players.Max(p => p.Id);
                return maximumId + 1;
            }
        }

        public void RemovePlayer(Player player)
        {
            using(var context = new FootballInfoContext())
            {
                var p = player;
                context.Players.Remove(p);
                context.SaveChanges();
            }
        }
    }
}
