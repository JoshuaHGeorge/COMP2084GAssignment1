using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace COMP2084GAssignment1.Models
{
    public partial class Type
    {
        public Type()
        {
            Event = new HashSet<Event>();
        }

        [Column("TypeID")]
        public int TypeId { get; set; }
        [Column("Type")]
        [StringLength(50)]
        public string Type1 { get; set; }

        [InverseProperty("Type")]
        public virtual ICollection<Event> Event { get; set; }
    }
}
