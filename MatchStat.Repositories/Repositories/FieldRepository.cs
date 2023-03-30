using MatchStat.Interfaces.Database;
using MatchStat.DataModel.DataModels;
using MatchStat.Interfaces.Interfaces;

namespace MatchStat.Repositories.Repositories
{
    public class FieldRepository : ParentRepository<Field>, IFieldsRepository
    {
        public FieldRepository(IFootballInfoContext c) : base(c) { }

    }
}
