using MatchStat.DataModel.DataModels;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace MatchStat.Database.EntityTypeConfigurartion
{
    public class MatchDetailsConfiguration : IEntityTypeConfiguration<MatchDetail>
    {
        public void Configure(EntityTypeBuilder<MatchDetail> entity)
        {
            entity.ToView("MatchesView");
        }
    }
}