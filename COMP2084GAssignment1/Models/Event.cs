using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace COMP2084GAssignment1.Models
{
    public partial class Event
    {
        [Key]
        [Column("EventID")]
        public int EventId { get; set; }
        [Column("ClassID")]
        public int? ClassId { get; set; }
        [Column("TypeID")]
        public int? TypeId { get; set; }
        [Column(TypeName = "date")]
        public DateTime? Date { get; set; }
        [StringLength(50)]
        public string Description { get; set; }

        [ForeignKey("ClassId")]
        [InverseProperty("Event")]
        public virtual Class Class { get; set; }
        [ForeignKey("TypeId")]
        [InverseProperty("Event")]
        public virtual Type Type { get; set; }
    }
}
