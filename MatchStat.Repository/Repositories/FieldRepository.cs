using MatchStat.DataModel.DataModels;

namespace MatchStat.Repositories.Repositories
{
    public class FieldRepository
    {
        public FieldRepository() { }
        public List<Fields> GetAllFields()
        {
            using(var context = new FootballInfoContext())
            {
                var field = context.Fields.ToList();
                return field;
            }
        }
        public void AddField(Fields field)
        {
            using (var context = new FootballInfoContext())
            {
                var f = field;
                if(f.Id == 0)
                {
                    f.Id = GetFieldNextId();
                }
                context.Fields.Add(f);
                context.SaveChanges();
            }
        }
        private int GetFieldNextId()
        {
            using (var context = new FootballInfoContext())
            {
                 var maximumId = context.Fields.Max(n => n.Id);
                return maximumId + 1;
            }
        }
        public void UpdateField(Fields field)
        {
            using (var context = new FootballInfoContext())
            {
                var f = field;
                context.Fields.Update(f);
                context.SaveChanges();
            }
        }
    }
}
