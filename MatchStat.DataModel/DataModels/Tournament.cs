using System;
using System.Collections.Generic;

namespace MatchStat.DataModel.DataModels;

public partial class Tournament
{
    public int Id { get; set; }

    public string? Name { get; set; }

    public DateTime? StartDate { get; set; }

    public DateTime? EndDate { get; set; }

    public virtual ICollection<Matches> Matches { get; } = new List<Matches>();
}
