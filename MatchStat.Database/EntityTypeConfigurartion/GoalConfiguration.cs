using MatchStat.DataModel.DataModels;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace MatchStat.DataModel.EntityTypeConfigurartion
{
    public class GoalConfiguration : IEntityTypeConfiguration<Goal>
    {
        public void Configure(EntityTypeBuilder<Goal> entity)
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

            entity.Ignore(e => e.PlayerName);
            entity.Ignore(e => e.MatchName);
        }
    }
}