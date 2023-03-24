using System;
using System.Collections.Generic;

namespace MatchStat.DataModel.DataModels;

public partial class Goal : IItemsWithIdField
{
    public int Id { get; set; }

    public int PlayerId { get; set; }

    public int MatchId { get; set; }

    public int NumberOfGoal { get; set; }

    public virtual Player Player { get; set; } = null!;

    public string? PlayerName { get; set; }
    public string? MatchName { get; set; }
}
