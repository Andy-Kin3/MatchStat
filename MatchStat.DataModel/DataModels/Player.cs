namespace MatchStat.DataModel.DataModels;

public partial class Player : IItemsWithIdField
{
    public int Id { get; set; }

    public string FirstName { get; set; } = null!;
    public string LastName { get; set; } = null!;

    public string FullName
    {
        get { return $"{this.FirstName} {this.LastName}"; }
    }

    public DateTime Dob { get; set; }

    public int TeamId { get; set; }

    public virtual ICollection<Goal> Goals { get; } = new List<Goal>();

    public virtual Team Team { get; set; } = null!;
}
