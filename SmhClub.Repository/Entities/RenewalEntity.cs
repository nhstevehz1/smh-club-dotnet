using Microsoft.EntityFrameworkCore;
using SmhClub.Repository.Common;
using SmhClub.Repository.Config;
using System.ComponentModel.DataAnnotations.Schema;

namespace SmhClub.Repository.Entities
{
    [Table("renewals"), EntityTypeConfiguration(typeof(RenewalConfiguration))]  
    public class RenewalEntity : EntityBase
    {
        public required DateOnly RenewalDate { get; set; }
        public required int RenewalYear {  get; set; }
        public MemberEntity Member { get; set; } = null!;
    }
}
