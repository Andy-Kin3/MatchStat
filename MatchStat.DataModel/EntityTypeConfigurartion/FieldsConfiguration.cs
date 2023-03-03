using MatchStat.DataModel.DataModels;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MatchStat.DataModel.EntityTypeConfigurartion
{
    public class FieldsConfiguration: IEntityTypeConfiguration<Fields>
    {
        public void Configure(EntityTypeBuilder<Fields> entity)
        {
            entity.ToTable("Field");

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("ID");
            entity.Property(e => e.Name)
                .HasMaxLength(50)
                .IsUnicode(false);
        }
    }
}
