using System;
using System.Collections.Generic;

namespace MatchStat.DataModel.DataModels;

public partial class Team : IItemsWithIdField
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public virtual ICollection<Match> MatchTeam1s { get; } = new List<Match>();

    public virtual ICollection<Match> MatchTeam2s { get; } = new List<Match>();

    public virtual ICollection<Player> Players { get; } = new List<Player>();
}
