using System;
using System.Collections.Generic;

namespace MatchStat.DataModel.DataModels;

public partial class Team
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public virtual ICollection<Matches> MatchTeam1s { get; } = new List<Matches>();

    public virtual ICollection<Matches> MatchTeam2s { get; } = new List<Matches>();

    public virtual ICollection<Player> Players { get; } = new List<Player>();
}
