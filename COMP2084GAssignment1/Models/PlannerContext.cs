using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace COMP2084GAssignment1.Models
{
    public partial class PlannerContext : DbContext
    {
        public PlannerContext()
        {
        }

        public PlannerContext(DbContextOptions<PlannerContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Assignment> Assignment { get; set; }
        public virtual DbSet<Course> Course { get; set; }
        public virtual DbSet<Homework> Homework { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
//#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
//                optionsBuilder.UseSqlServer("Server=comp2084g.database.windows.net;Database=Planner;User Id=comp2084g;Password=-0asj3fsc;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("ProductVersion", "2.2.6-servicing-10079");

            modelBuilder.Entity<Assignment>(entity =>
            {
                entity.Property(e => e.Assignment1).IsUnicode(false);
            });

            modelBuilder.Entity<Course>(entity =>
            {
                entity.Property(e => e.Course1).IsUnicode(false);
            });

            modelBuilder.Entity<Homework>(entity =>
            {
                entity.Property(e => e.Description).IsUnicode(false);

                entity.HasOne(d => d.Assignment)
                    .WithMany(p => p.Homework)
                    .HasForeignKey(d => d.AssignmentId)
                    .HasConstraintName("FK_Homework_Assignment");

                entity.HasOne(d => d.Course)
                    .WithMany(p => p.Homework)
                    .HasForeignKey(d => d.CourseId)
                    .HasConstraintName("FK_Homework_Course");
            });
        }
    }
}
