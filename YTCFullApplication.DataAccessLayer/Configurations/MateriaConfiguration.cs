using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YTCFullApplication.Domain;

namespace YTCFullApplication.DataAccessLayer.Configurations
{
    internal class MateriaConfiguration : IEntityTypeConfiguration<Materia>
    {
        public void Configure(EntityTypeBuilder<Materia> builder)
        {
            builder.ToTable("Materie").HasKey(x => x.Id);
            builder.HasIndex(x => x.Nome);
            builder.Property(e => e.Nome).HasMaxLength(32).IsRequired();
        }
    }
}
