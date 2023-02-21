using System;
using System.Collections.Generic;

namespace MatchStat.DataModel.DataModels;

public partial class Player
{
    public int Id { get; set; }

    public string FirstName { get; set; } = null!;
    public string LastName { get; set; }= null!;

    public DateTime Dob { get; set; }

    public int TeamId { get; set; }

    public virtual ICollection<Goal> Goals { get; } = new List<Goal>();

    public virtual Team Team { get; set; } = null!;
}
