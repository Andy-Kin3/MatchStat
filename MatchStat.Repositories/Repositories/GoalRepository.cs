using MatchStat.DataModel.DataModels;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MatchStat.Repositories.Repositories
{
    public class GoalRepository
    {
        public GoalRepository() { }
        public List<Goal> GetAllGoals()
        {
            using(var context = new FootballInfoContext())
            {
                var g = context.Goals.ToList();
                return g;
            }
        }
        public void AddGoal(Goal? goal)
        {
            using(var context = new FootballInfoContext())
            {
                var g = goal;
                
                if(g.Id == 0)
                {
                    g.Id = GetNextGoalId();
                }
                context.Goals.Add(g);
                context.SaveChanges();
            }
        }
        public void UpdateGoal(Goal goal)
        {
            using(var context = new FootballInfoContext())
            {
                var g = goal;
                context.Goals.Update(g);
                context.SaveChanges();
            }
        }

        public string GetPlayerFullName(int playerId)
        {
            using (var context = new FootballInfoContext())
            {
                var playerName = context.Players.FirstOrDefault(p => p.Id == playerId);
                if (playerName != null)
                {
                    return playerName.FullName;
                }
                return string.Empty;
            }
        }
        public string GetMatchName(int matchId)
        {
            using (var context = new FootballInfoContext())
            {
                var matchName = context.MatchDetails.FirstOrDefault(p => p.Id == matchId);
                if (matchName != null)
                {
                    return matchName.MatchName;
                }
                return string.Empty;
            }
        }


        private int GetNextGoalId()
        {
            using(var context = new FootballInfoContext())
            {
                var g = context.Goals.Max(x => x.Id);
                return g;
            }
        }
        public void RemoveGoal(Goal goalId)
        {
            using (var context = new FootballInfoContext())
            {
                var g = context.Goals.FirstOrDefault(x => x.Id == goalId.Id);
                if (g != null)
                {
                    context.Goals.Remove(g);
                    context.SaveChanges();
                }
            }
        }
    }
}
