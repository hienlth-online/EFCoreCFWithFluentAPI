using Microsoft.EntityFrameworkCore;

namespace EFCoreCFWithFluentAPI.Entities
{
    public class MyDbContext : DbContext
    {
        #region DbSet
        public DbSet<Loai> Loais { get; set; }
        public DbSet<HangHoa> HangHoas { get; set; }
        public DbSet<DonHang> DonHangs { get; set; }
        public DbSet<DonHangChiTiet> DonHangChiTiets { get; set; }
        #endregion

        public MyDbContext(DbContextOptions options):base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Loai>(entity => {
                entity.ToTable("Loai");
                entity.HasKey(e => e.MaLoai);
                entity.Property(e => e.TenLoai)
                    .IsRequired(true)
                    .HasMaxLength(150);
            });

            modelBuilder.Entity<HangHoa>(e => {
                e.ToTable("HangHoa");
                e.HasKey(e => e.MaHh);
                e.Property(e => e.TenHh)
                    .IsRequired(true)
                    .HasMaxLength(150);

                e.HasOne(hh => hh.Loai)
                    .WithMany(lo => lo.HangHoas)
                    .HasForeignKey(hh => hh.MaLoai)
                    .HasConstraintName("FK_HangHoa_Loai");
            });

            modelBuilder.Entity<DonHang>(e => {
                e.ToTable("DonHang");
                e.HasKey(dh => dh.MaDh);
            });

            modelBuilder.Entity<DonHangChiTiet>(e => {
                e.ToTable("ChiTietDonHang");
                e.HasKey(ctdh => new { ctdh.MaDh, ctdh.MaHh });

                e.HasOne(ctdh => ctdh.DonHang)
                    .WithMany(dh => dh.DonHangChiTiets)
                    .HasForeignKey(ctdh => ctdh.MaDh)
                    .HasConstraintName("FK_CTDH_DonHang");

                e.HasOne(ctdh => ctdh.HangHoa)
                    .WithMany(hh => hh.DonHangChiTiets)
                    .HasForeignKey(ctdh => ctdh.MaHh)
                    .HasConstraintName("FK_CTDH_HangHoa");
            });
        }
    }
}
