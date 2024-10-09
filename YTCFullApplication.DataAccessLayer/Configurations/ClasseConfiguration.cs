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
    internal class ClasseConfiguration : IEntityTypeConfiguration<Classe>
    {
        public void Configure(EntityTypeBuilder<Classe> builder)
        {
            builder.ToTable("Classi").HasKey(x => x.Id);
            builder.HasIndex(x => x.Nome);
            builder.Property(e => e.Nome).HasMaxLength(16).IsRequired();
        }
    }
}
