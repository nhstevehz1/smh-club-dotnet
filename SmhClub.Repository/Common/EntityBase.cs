using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmhClub.Repository.Common
{
    public abstract class EntityBase
    {
        [Column("id"), Key]
        public virtual long Id { get; set; }
    }
}
