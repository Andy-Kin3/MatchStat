namespace MatchStat.DataModel.DataModels;

public partial class Field : IItemsWithIdField
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;
    public string Country { get; set; }

    public virtual ICollection<Match> Matches { get; } = new List<Match>();
}
