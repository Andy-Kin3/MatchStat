using MatchStat.DataModel.DataModels;
using Microsoft.EntityFrameworkCore;

namespace MatchStat.Database
{
    public interface IFootballInfoContext
    {
        DbSet<Field> Fields { get; set; }
        DbSet<Goal> Goals { get; set; }
        DbSet<Match> MatchDetail { get; set; }
        DbSet<MatchDetail> MatchDetails { get; set; }
        DbSet<Player> Players { get; set; }
        DbSet<Team> Teams { get; set; }
        DbSet<TeamTournament> TeamTournaments { get; set; }
        DbSet<Tournament> Tournaments { get; set; }
    }
}