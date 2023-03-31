using MatchStat.DataModel.DataModels;
using MatchStat.Interfaces.Database;
using MatchStat.Interfaces.RepositoryInterfaces;
using Microsoft.EntityFrameworkCore;

namespace MatchStat.Repositories.Repositories
{
    public class MatchStoredProcedureRepository : ParentRepository<MyMatchStoredProcedure>, IMatchStoreProcedure
    {
        public MatchStoredProcedureRepository(IFootballInfoContext c): base(c) 
        {
        }
        public List<MyMatchStoredProcedure> GetMatches()
        {
            var allMAtches = _context.myMatchStoredProcedures.FromSqlRaw("spGetAllMatches").ToList();
            return allMAtches;
        }
    }
}
