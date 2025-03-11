using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.Extensions.Logging.Abstractions;
using SmhClub.Repository.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmhClub.Repository.Config
{
    internal class PhoneConfiguration : IEntityTypeConfiguration<PhoneEntity>
    {
        public void Configure(EntityTypeBuilder<PhoneEntity> builder)
        {
            builder.Property(p => p.CountryCode)
                .HasColumnName("country_code")
                .IsRequired();

            builder.Property(p => p.PhoneNumber)
                .HasColumnName("phone_number")
                .IsRequired();
        }
    }
}
