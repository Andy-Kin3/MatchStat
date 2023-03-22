using MatchStat.DataModel.DataModels;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace MatchStat.DataModel.EntityTypeConfigurartion
{
    public class TeamTournamentConfiguration : IEntityTypeConfiguration<TeamTournament>
    {
        public void Configure(EntityTypeBuilder<TeamTournament> entity)
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
        }
    }
}