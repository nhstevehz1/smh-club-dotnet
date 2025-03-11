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
    internal class AddressConfiguration : IEntityTypeConfiguration<AddressEntity>
    {
        public void Configure(EntityTypeBuilder<AddressEntity> builder)
        {
            builder.Property(a => a.Address1)
                .HasColumnName("address1")
                .IsRequired();

            builder.Property(a => a.Address2)
                .HasColumnName("address2");

            builder.Property(a => a.City)
                .HasColumnName("city")
                .IsRequired();

            builder.Property(a => a.StateProvince)
                .HasColumnName("state_province")
                .IsRequired();

            builder.Property(a => a.PostalCode)
                .HasColumnName("postal_code")
                .IsRequired();

            builder.Property(a => a.AddressType)
                .HasColumnName("address_type")
                .IsRequired();
        }
    }
}
