using MatchStat.DataModel.DataModels;

using Microsoft.EntityFrameworkCore;

namespace MatchStat.Interfaces.Database
{
    public interface IFootballInfoContext
    {
        DbSet<Field> Fields { get; set; }
        DbSet<Goal> Goals { get; set; }
        DbSet<Match> MatchDetail { get; set; }
        DbSet<MatchDetail> MatchDetails { get; set; }
        DbSet<MyMatchStoredProcedure> myMatchStoredProcedures { get; set; }
        DbSet<Player> Players { get; set; }
        DbSet<Team> Teams { get; set; }
        DbSet<TeamTournament> TeamTournaments { get; set; }
        DbSet<Tournament> Tournaments { get; set; }
        void MigrateDatabase();
        DbSet<T> Set<T>() where T : class;
        int SaveChanges();
    }
}