namespace MatchStat.Interfaces.Interfaces
{
    public interface IParentInterface<T> where T : class
    {
        void Add(T item);
        List<T> GetAll();
        void Delete(T item);
        void Update(T item);
    }
}