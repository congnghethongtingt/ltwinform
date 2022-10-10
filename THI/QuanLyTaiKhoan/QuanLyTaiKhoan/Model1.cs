using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace _QuanLyTaiKhoan
{
    public partial class Model1 : DbContext
    {
        public Model1()
            : base("name=Model1")
        {
        }

        public virtual DbSet<GiaoDich> GiaoDiches { get; set; }
        public virtual DbSet<TaiKhoan> TaiKhoans { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<TaiKhoan>()
                .Property(e => e.SoDuDauKy)
                .HasPrecision(18, 0);

            modelBuilder.Entity<TaiKhoan>()
                .HasMany(e => e.GiaoDich)
                .WithRequired(e => e.TaiKhoan)
                .WillCascadeOnDelete(false);
        }
    }
}
