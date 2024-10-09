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
    internal class FrequenzaConfiguration : IEntityTypeConfiguration<Frequenza>
    {
        public void Configure(EntityTypeBuilder<Frequenza> builder)
        {
            builder.ToTable("Frequenze").HasKey(x => x.Id);
            
        }
    }
}
