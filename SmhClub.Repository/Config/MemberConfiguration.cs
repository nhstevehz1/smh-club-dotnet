using Microsoft.EntityFrameworkCore;
using SmhClub.Repository.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmhClub.Repository.Config
{
    internal class MemberConfiguration : IEntityTypeConfiguration<MemberEntity>
    {
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<MemberEntity> builder)
        {
        
            builder.HasAlternateKey(m => m.MemberNumber);

            builder.Property(m => m.MemberNumber)
                .HasColumnName("member_number")
                .IsRequired();

            builder.Property(m => m.FirstName)
                .HasColumnName("first_name")
                .IsRequired();

            builder.Property(m => m.MiddleName)
                .HasColumnName("middle_name")
                .HasDefaultValue(null);

            builder.Property(m => m.LastName)
                .HasColumnName("last_name")
                .IsRequired();

            builder.Property(m => m.Suffix)
                .HasColumnName("suffix");

            builder.Property(m => m.BirthDate)
                .HasColumnName("birth_date")
                .IsRequired();

            builder.Property(m => m.JoinedDate)
                .HasColumnName("joined_date")
                .IsRequired();

            builder
                .HasMany(m => m.Addresses)
                .WithOne(a => a.Member)
                .HasForeignKey("member_id")
                .IsRequired();

            builder
                .HasMany(m => m.Emails)
                .WithOne(e => e.Member)
                .HasForeignKey("member_id")
                .IsRequired();

            builder
                .HasMany(m => m.Phones)
                .WithOne(p => p.Member)
                .HasForeignKey("member_id")
                .IsRequired();

            builder
                .HasMany(m => m.Renewals)
                .WithOne(p => p.Member)
                .HasForeignKey("member_id")
                .IsRequired();
        }
    }
}
