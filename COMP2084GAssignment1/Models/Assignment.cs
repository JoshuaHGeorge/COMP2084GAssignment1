using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace COMP2084GAssignment1.Models
{
    public partial class Assignment
    {
        public Assignment()
        {
            Homework = new HashSet<Homework>();
        }
        [Key]
        public int AssignmentId { get; set; }
        [Column("Assignment")]
        [StringLength(50)]
        public string Assignment1 { get; set; }

        [InverseProperty("Assignment")]
        public virtual ICollection<Homework> Homework { get; set; }
    }
}
