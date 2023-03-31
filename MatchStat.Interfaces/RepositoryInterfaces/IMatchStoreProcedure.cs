using MatchStat.DataModel.DataModels;
using MatchStat.Interfaces.Database;
using MatchStat.Interfaces.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MatchStat.Interfaces.RepositoryInterfaces
{
    public interface IMatchStoreProcedure: IParentInterface<MyMatchStoredProcedure>
    {
        List<MyMatchStoredProcedure> GetMatches();
    }
}
