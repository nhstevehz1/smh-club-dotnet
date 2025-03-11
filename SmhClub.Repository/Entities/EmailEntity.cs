using Microsoft.EntityFrameworkCore;
using SmhClub.Repository.Common;
using SmhClub.Repository.Config;
using System.ComponentModel.DataAnnotations.Schema;

namespace SmhClub.Repository.Entities
{
    [Table("emails"), EntityTypeConfiguration(typeof(EmailConfiguration))]
    public class EmailEntity : EntityBase
    {
        public required string EmailAddress { get; set; }
        public required EmailType EmailType { get; set; }
        public required MemberEntity Member { get; set; } = null!;
    }
}
