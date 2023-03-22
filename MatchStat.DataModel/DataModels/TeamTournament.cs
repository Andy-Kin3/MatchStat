namespace MatchStat.DataModel.DataModels;

public partial class TeamTournament
{
    public int Id { get; set; }

    public int TeamId { get; set; }

    public int TournamentId { get; set; }

    public virtual Team Team { get; set; } = null!;

    public virtual Tournament Tournament { get; set; } = null!;
}
