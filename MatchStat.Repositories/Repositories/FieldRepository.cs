using MatchStat.Database;
using MatchStat.DataModel.DataModels;
using MatchStat.Interfaces.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MatchStat.Repositories.Repositories
{
    public class FieldRepository : ParentRepository<Field>, IFieldsRepository
    {
        public FieldRepository(FootballInfoContext c): base(c) { }
       
    }
}
