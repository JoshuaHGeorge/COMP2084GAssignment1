using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace COMP2084GAssignment1.Models
{
    public partial class Class
    {
        public Class()
        {
            Event = new HashSet<Event>();
        }

        [Key]
        [Column("ClassID")]
        public int ClassId { get; set; }
        [Column("Class")]
        [StringLength(50)]
        public string Class1 { get; set; }

        [InverseProperty("Class")]
        public virtual ICollection<Event> Event { get; set; }
    }
}
