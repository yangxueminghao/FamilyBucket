using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace Bucket.EFCoreContext
{
    public partial class db_ers_business_devContext : DbContext
    {
        public db_ers_business_devContext()
        {
        }

        public db_ers_business_devContext(DbContextOptions<db_ers_business_devContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Adminmenu> Adminmenu { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseMySql("server=192.168.192.128;user id=root;password=123456;database=db_ers_business_dev", x => x.ServerVersion("5.7.39-mysql"));
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Adminmenu>(entity =>
            {
                entity.HasKey(e => e.RowId)
                    .HasName("PRIMARY");

                entity.ToTable("adminmenu");

                entity.Property(e => e.RowId)
                    .HasColumnName("RowID")
                    .HasColumnType("int(11)");

                entity.Property(e => e.MenuDiscription)
                    .HasColumnType("longtext")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                entity.Property(e => e.MenuEnable).HasColumnType("int(11)");

                entity.Property(e => e.MenuId)
                    .HasColumnName("MenuID")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                entity.Property(e => e.MenuLevel).HasColumnType("int(11)");

                entity.Property(e => e.MenuName)
                    .HasColumnType("varchar(50)")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                entity.Property(e => e.MenuOrder).HasColumnType("int(11)");

                entity.Property(e => e.MenuParentId)
                    .HasColumnName("MenuParentID")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                entity.Property(e => e.MenuTime).HasColumnType("datetime");

                entity.Property(e => e.MenuUrl)
                    .HasColumnType("varchar(150)")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
