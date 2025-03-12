using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SmhClub.Repository.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmhClub.Repository.Config
{
    internal class RenewalConfiguration : IEntityTypeConfiguration<RenewalEntity
        >
    {
        public void Configure(EntityTypeBuilder<RenewalEntity> builder)
        {
            builder.Property(p => p.RenewalDate)
                .HasColumnName("renewal_date")
                .IsRequired();

            builder.Property(p => p.RenewalYear)
                .HasColumnName("renewal_year")
                .IsRequired();

        }
    }
}
