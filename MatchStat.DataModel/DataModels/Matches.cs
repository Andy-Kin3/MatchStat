using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace MatchStat.DataModel.DataModels;

public partial class Match
{
    public int Id { get; set; }

    public DateTime Date { get; set; }

    public int Team1Id { get; set; }
    public int TeamOneScore { get; set; }
    public int TeamTwoScore { get; set; }

    public int Team2Id { get; set; }

    public int? TournamentId { get; set; }

    public int FieldId { get; set; }

    public virtual Fields Field { get; set; } = null!;

    public virtual Team Team1 { get; set; } = null!;

    public virtual Team Team2 { get; set; } = null!;

    public virtual Tournament? Tournament { get; set; }
    public string? MatchName { get; set; }
}
