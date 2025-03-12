using Microsoft.EntityFrameworkCore;
using SmhClub.Repository.Common;
using SmhClub.Repository.Config;
using System.ComponentModel.DataAnnotations.Schema;

namespace SmhClub.Repository.Entities
{
    [Table("addresses"), EntityTypeConfiguration(typeof(AddressConfiguration))]
    public class AddressEntity : EntityBase
    {
        public AddressEntity() { }
        public required string Address1 { get; set; }
        public string? Address2 { get; set; }
        public required string City {  get; set; }
        public required string StateProvince { get; set; }
        public required string PostalCode { get; set; }
        public required AddressType AddressType { get; set; } = AddressType.Home;
        public MemberEntity Member { get; set; } = null!;
    }
}
