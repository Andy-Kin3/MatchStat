namespace MatchStat.DataModel.DataModels;

public partial class MatchDetail
{
    public int Id { get; set; }

    public DateTime Date { get; set; }

    public int Team1Id { get; set; }

    public int Team2Id { get; set; }

    public int? TournamentId { get; set; }

    public int FieldId { get; set; }
    public string? Team1Name { get; set; }
    public string? Team2Name { get; set; }
    public string? TournamentName { get; set; }
    public string? FieldName { get; set; }

    public string MatchName
    {
        get
        {
            return $"{this.Team1Name} v {this.Team2Name}";
        }
    }
}