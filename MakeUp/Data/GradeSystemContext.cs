using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace MakeUp
{
    public partial class GradeSystemContext : DbContext
    {

        public GradeSystemContext(DbContextOptions<GradeSystemContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Course> Course { get; set; }
        public virtual DbSet<CourseGrade> CourseGrade { get; set; }
        public virtual DbSet<Student> Student { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer("Data Source=DESKTOP-D5BMNCV\\SQLEXPRESS;Initial Catalog=GradeSystem;Trusted_Connection=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Course>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.CourseGrade).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.CourseName)
                    .IsRequired()
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Discription)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Proffesor)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.SemestarYear)
                    .HasMaxLength(255)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Student>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.Gpa)
                    .HasColumnName("GPA")
                    .HasColumnType("decimal(18, 0)");

                entity.Property(e => e.StudentEmail)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.StudentIndex)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.StudentName)
                    .IsRequired()
                    .HasMaxLength(255)
                    .IsUnicode(false);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
