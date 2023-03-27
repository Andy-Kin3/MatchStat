namespace MatchStat.Interfaces.Interfaces
{
    public interface IParentInterface<T> where T : class
    {
        void Add(T match);
        List<T> GetAll();
        void Delete(T match);
        void Update(T? match);
    }
}