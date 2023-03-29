namespace MatchStat.DataModel.DataModels;

public partial class Tournament : IItemsWithIdField
{
    public int Id { get; set; }

    public string? Name { get; set; }

    public DateTime? StartDate { get; set; }

    public DateTime? EndDate { get; set; }

    public virtual ICollection<Match> Matches { get; } = new List<Match>();
}
