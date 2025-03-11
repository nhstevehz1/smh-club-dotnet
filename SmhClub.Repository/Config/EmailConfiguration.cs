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
    internal class EmailConfiguration : IEntityTypeConfiguration<EmailEntity>
    {
        public void Configure(EntityTypeBuilder<EmailEntity> builder)
        {
            builder.Property(e => e.EmailAddress)
                .HasColumnName("email_address")
                .IsRequired();

            builder.Property(e => e.EmailType)
                .HasColumnName("email_type")
                .IsRequired();
        }
    }
}
