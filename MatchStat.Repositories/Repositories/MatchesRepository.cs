using MatchStat.Database;
using MatchStat.DataModel.DataModels;

namespace MatchStat.Repositories.Repositories
{
    public class MatchesRepository
    {
        public MatchesRepository() { }
        public List<MatchDetail> GetAllMatches()
        {
            using(var context = new FootballInfoContext())
            {
                var m = context.MatchDetails.ToList();
                return m;
            }
        }
        public void AddMatches(MatchDetail match)
        {
            using(var context =new FootballInfoContext())
            {
                var m = match;
                {
                    m.Id = GetNextId();
                }
                context.MatchDetails.Add(m);
                context.SaveChanges();
            }
        }
        public void UpdateMatch(MatchDetail? match)
        {
            using (var context = new FootballInfoContext())
            {
                var m = match;
                context.MatchDetails.Update(m);
                context.SaveChanges();
            }
        }

        private int GetNextId()
        {
            using (var context = new FootballInfoContext())
            {
                var NextMatchId = context.MatchDetails.Max(m => m.Id);
                return NextMatchId + 1;
            }
        }
        public void RemoveMatch(MatchDetail match)
        {
            using(var context = new FootballInfoContext())
            {
                var m = match;
                context.MatchDetails.Remove(m);
                context.SaveChanges();
            }
        }
    }
}
