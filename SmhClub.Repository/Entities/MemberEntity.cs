using Microsoft.EntityFrameworkCore;
using SmhClub.Repository.Common;
using SmhClub.Repository.Config;
using System.ComponentModel.DataAnnotations.Schema;

namespace SmhClub.Repository.Entities
{
    [Table("members"), EntityTypeConfiguration(typeof(MemberConfiguration))]
    public class MemberEntity : EntityBase
    {
        public long MemberNumber { get; set; }
        public required string FirstName { get; set; }
        public string? MiddleName { get; set; }
        public required string LastName { get; set; }
        public string? Suffix { get; set; }
        public DateOnly BirthDate { get; set; }
        public DateOnly JoinedDate { get; set; }
        public List<AddressEntity> Addresses { get; } = [];
        public List<EmailEntity> Emails { get; } = [];
        public List<PhoneEntity> Phones { get; } = [];
        public List<RenewalEntity> Renewals { get; } = [];
    }
}
