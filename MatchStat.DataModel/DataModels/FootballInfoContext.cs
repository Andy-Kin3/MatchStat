using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace MatchStat.DataModel.DataModels;

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

    public virtual DbSet<Matches> Matches { get; set; }

    public virtual DbSet<Player> Players { get; set; }

    public virtual DbSet<Team> Teams { get; set; }

    public virtual DbSet<TeamTournament> TeamTournaments { get; set; }

    public virtual DbSet<Tournament> Tournaments { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("server=.;database=FootballInfo;TrustServerCertificate=true;Integrated Security=true");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Fields>(entity =>
        {
            entity.ToTable("Field");

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("ID");
            entity.Property(e => e.Name)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<Goal>(entity =>
        {
            entity.ToTable("Goal");

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("ID");
            entity.Property(e => e.MatchId).HasColumnName("MatchID");
            entity.Property(e => e.PlayerId).HasColumnName("PlayerID");

            entity.HasOne(d => d.Player).WithMany(p => p.Goals)
                .HasForeignKey(d => d.PlayerId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Goal_Player");
        });

        modelBuilder.Entity<Matches>(entity =>
        {
            entity.ToTable("Match");

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("ID");
            entity.Property(e => e.Date).HasColumnType("date");
            entity.Property(e => e.FieldId).HasColumnName("FieldID");
            entity.Property(e => e.Team1Id).HasColumnName("Team1ID");
            entity.Property(e => e.Team2Id).HasColumnName("Team2ID");
            entity.Property(e => e.TournamentId).HasColumnName("TournamentID");

            entity.HasOne(d => d.Field).WithMany(p => p.Matches)
                .HasForeignKey(d => d.FieldId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Match_Field");

            entity.HasOne(d => d.Team1).WithMany(p => p.MatchTeam1s)
                .HasForeignKey(d => d.Team1Id)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Match_Team");

            entity.HasOne(d => d.Team2).WithMany(p => p.MatchTeam2s)
                .HasForeignKey(d => d.Team2Id)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Match_Team1");

            entity.HasOne(d => d.Tournament).WithMany(p => p.Matches)
                .HasForeignKey(d => d.TournamentId)
                .HasConstraintName("FK_Match_Tournament");
        });

        modelBuilder.Entity<Player>(entity =>
        {
            entity.ToTable("Player");

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("ID");
            entity.Property(e => e.Dob)
                .HasColumnType("date")
                .HasColumnName("DOB");
            entity.Property(e => e.FirstName)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.TeamId).HasColumnName("TeamID");

            entity.HasOne(d => d.Team).WithMany(p => p.Players)
                .HasForeignKey(d => d.TeamId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Player_Team");
        });

        modelBuilder.Entity<Team>(entity =>
        {
            entity.ToTable("Team");
            entity.HasKey(e => e.Id);
            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("ID");
            entity.Property(e => e.Name)
                .HasMaxLength(60)
                .IsUnicode(false);
        });

        modelBuilder.Entity<TeamTournament>(entity =>
        {
            entity.HasKey(e => e.Id);

            entity.Property(e => e.Id).ValueGeneratedNever();

            entity.Property(e => e.TeamId).HasColumnName("TeamID");
            entity.Property(e => e.TournamentId).HasColumnName("TournamentID");

            entity.HasOne(d => d.Team).WithMany()
                .HasForeignKey(d => d.TeamId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_TeamTournament_Team");

            entity.HasOne(d => d.Tournament).WithMany()
                .HasForeignKey(d => d.TournamentId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_TeamTournament_Tournament");
        });

        modelBuilder.Entity<Tournament>(entity =>
        {
            entity.ToTable("Tournament");
            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("ID");
            entity.Property(e => e.EndDate).HasColumnType("date");
            entity.Property(e => e.Name)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.StartDate).HasColumnType("date");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
