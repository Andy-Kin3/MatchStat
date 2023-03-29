namespace MatchStat.DataModel.DataModels;

public partial class MatchDetail : IItemsWithIdField
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
    public int TeamOneScore { get; set; }
    public int TeamTwoScore { get; set; }

    public string MatchName
    {
        get
        {
            if (TeamOneScore != 0 && TeamTwoScore != 0)
            {
                return $"{this.Team1Name} {this.TeamOneScore} : {this.TeamTwoScore} {this.Team2Name}";
            }
            return $"{this.Team1Name}  VS  {this.Team2Name}";
        }
    }
}