using Microsoft.EntityFrameworkCore;
using SmhClub.Repository.Common;
using SmhClub.Repository.Config;
using System.ComponentModel.DataAnnotations.Schema;

namespace SmhClub.Repository.Entities
{
    [Table("phones"), EntityTypeConfiguration(typeof(PhoneConfiguration))]
    public class PhoneEntity : EntityBase
    {
        public required string CountryCode { get; set; }
        public required string PhoneNumber { get; set; }
        public required PhoneType PhoneType { get; set; }
        public MemberEntity Member { get; set; } = null!;
    }
}
