using MatchStat.Interfaces.Database;
using MatchStat.DataModel.DataModels;
using MatchStat.Interfaces.Interfaces;

namespace MatchStat.Repositories.Repositories
{
    public abstract class ParentRepository<T> : IParentInterface<T> where T : class, IItemsWithIdField
    {
        protected IFootballInfoContext _context;
        public ParentRepository(IFootballInfoContext context)
        {
            _context = context;
        }

        public virtual List<T> GetAll()
        {

            var m = _context.Set<T>().ToList();
            return m;
        }

        protected int GetNextId()
        {
            var maximumId = _context.Set<T>().Max(p => p.Id);
            return maximumId + 1;
        }
        public virtual void Add(T item)
        {
            if (item.Id == 0)
            {
                item.Id = GetNextId();
            }
            _context.Set<T>().Add(item);
            _context.SaveChanges();
        }

        public virtual void Update(T item)
        {
            _context.Set<T>().Update(item);
            _context.SaveChanges();
        }

        public virtual void Delete(T item)
        {
            _context.Set<T>().Remove(item);
            _context.SaveChanges();
        }
    }
}
