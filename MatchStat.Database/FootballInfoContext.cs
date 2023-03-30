using MatchStat.Database.EntityTypeConfigurartion;
using MatchStat.DataModel.DataModels;
using MatchStat.Interfaces.Database;

using Microsoft.EntityFrameworkCore;

namespace MatchStat.Database;

public partial class FootballInfoContext : DbContext, IFootballInfoContext
{
    public FootballInfoContext()
    {
    }

    public FootballInfoContext(DbContextOptions<FootballInfoContext> options)
        : base(options)
    {
    }
    public void MigrateDatabase()
    {
        this.Database.Migrate();
    }

    public virtual DbSet<Field> Fields { get; set; }

    public virtual DbSet<Goal> Goals { get; set; }

    public virtual DbSet<Match> MatchDetail { get; set; }

    public virtual DbSet<Player> Players { get; set; }

    public virtual DbSet<Team> Teams { get; set; }
    public virtual DbSet<TeamTournament> TeamTournaments { get; set; }

    public virtual DbSet<Tournament> Tournaments { get; set; }

    public virtual DbSet<MatchDetail> MatchDetails { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("server=.;database=FootballInfo;TrustServerCertificate=true;Integrated Security=true");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.ApplyConfiguration(new FieldsConfiguration());
        modelBuilder.ApplyConfiguration(new GoalConfiguration());
        modelBuilder.ApplyConfiguration(new MatchesConfiguration());
        modelBuilder.ApplyConfiguration(new MatchDetailsConfiguration());
        modelBuilder.ApplyConfiguration(new PlayerConfiguration());
        modelBuilder.ApplyConfiguration(new TeamConfigurartion());
        modelBuilder.ApplyConfiguration(new TeamTournamentConfiguration());
        modelBuilder.ApplyConfiguration(new TournamentConfiguration());

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
