﻿using MatchStat.DataModel.DataModels;
using MatchStat.DataModel.EntityTypeConfigurartion;
using Microsoft.EntityFrameworkCore;

namespace MatchStat;

public partial class FootballInfoContext : DbContext
{
    public FootballInfoContext()
    {
    }

    public FootballInfoContext(DbContextOptions<FootballInfoContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Fields> Fields { get; set; }

    public virtual DbSet<Goal> Goals { get; set; }

    public virtual DbSet<Match> MatchDetail { get; set; }

    public virtual DbSet<Player> Players { get; set; }

    public virtual DbSet<Team> Teams { get; set; }
    public virtual DbSet<TeamTournament> TeamTournaments { get; set; }

    public virtual DbSet<Tournament> Tournaments { get; set; }

    public virtual DbSet<MatchDetail> MatchDetails { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer("server=.;database=FootballInfo;TrustServerCertificate=true;Integrated Security=true");
    }

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
