using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace detailwebapp.Models
{
    public partial class detailsContext : DbContext
    {
        //internal object Info;
       

        public detailsContext()
        {
        }

        public detailsContext(DbContextOptions<detailsContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Info> Info { get; set; }
       // public object Info { get; internal set; }

        // Unable to generate entity type for table 'dbo.Table_2'. Please see the warning messages.

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer("Server=.\\SQLEXPRESS;Database=details;Trusted_Connection=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Info>(entity =>
            {
                entity.HasKey(e => e.StudId);

                entity.ToTable("info");

                entity.HasIndex(e => e.Number)
                    .HasName("UQ__info__FD291E411AD3CBCE")
                    .IsUnique();

                entity.Property(e => e.StudId).HasColumnName("stud_ID");

                entity.Property(e => e.Age).HasColumnName("age");

                entity.Property(e => e.CreatedAt)
                    .HasColumnName("created_at")
                    .HasColumnType("date");

                entity.Property(e => e.CreatedBy)
                    .HasColumnName("created_by")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.Firstname)
                    .HasColumnName("firstname")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.Lastname)
                    .HasColumnName("lastname")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.Number).HasColumnName("number");

                entity.Property(e => e.Subject)
                    .HasColumnName("subject")
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('SQL')");

                entity.Property(e => e.UpdatedAt)
                    .HasColumnName("updated_at")
                    .HasColumnType("date");

                entity.Property(e => e.UpdatedBy)
                    .HasColumnName("updated_by")
                    .HasMaxLength(30)
                    .IsUnicode(false);
            });
        }
    }
}
