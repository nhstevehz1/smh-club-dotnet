using Microsoft.EntityFrameworkCore;
using SmhClub.Repository.Entities;
using System;
using System.Collections.Generic;

namespace SmhClub.Repository.Contexts
{
    public class SmhClubContext : DbContext
    {
        public DbSet<MemberEntity> Members { get; set;  }
        public DbSet<AddressEntity> Address { get; set; }
        public DbSet<EmailEntity> Emails { get; set; }
        public DbSet<PhoneEntity> Phones { get; set; }
        public DbSet<RenewalEntity> Renewals { get; set; }

        public string DbPath { get; }

        public SmhClubContext() 
        {
            var folder = Environment.SpecialFolder.LocalApplicationData;
            var path = Environment.GetFolderPath(folder);
            DbPath = System.IO.Path.Join(path, "smh-club.db");
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) 
            => optionsBuilder.UseSqlite($"Data Source={DbPath}");
  
    }
}
