using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace eCommerceProject_v1.Models
{
    public partial class QLBH_v2019Context : DbContext
    {
        public QLBH_v2019Context()
        {
        }

        public QLBH_v2019Context(DbContextOptions<QLBH_v2019Context> options)
            : base(options)
        {
        }

        public virtual DbSet<BinhLuanHh> BinhLuanHh { get; set; }
        public virtual DbSet<ChiTietHd> ChiTietHd { get; set; }
        public virtual DbSet<DangkiNcc> DangkiNcc { get; set; }
        public virtual DbSet<HangHoa> HangHoa { get; set; }
        public virtual DbSet<HoaDonBh> HoaDonBh { get; set; }
        public virtual DbSet<LoaiHangHoa> LoaiHangHoa { get; set; }
        public virtual DbSet<LogSystem> LogSystem { get; set; }
        public virtual DbSet<NguoiDung> NguoiDung { get; set; }
        public virtual DbSet<QuanTriVien> QuanTriVien { get; set; }
        public virtual DbSet<Trangthaitt> Trangthaitt { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer("Server=MSI\\SQL_EXPRESS;Database=QLBH_v2019;Trusted_Connection=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<BinhLuanHh>(entity =>
            {
                entity.HasKey(e => e.Mabl);

                entity.ToTable("BinhLuanHH");

                entity.Property(e => e.Mabl).HasColumnName("MABL");

                entity.Property(e => e.Diemdanhgia).HasColumnName("DIEMDANHGIA");

                entity.Property(e => e.Hinh)
                    .HasColumnName("HINH")
                    .HasMaxLength(20);

                entity.Property(e => e.Mahh)
                    .HasColumnName("MAHH")
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.Ngaydang)
                    .HasColumnName("NGAYDANG")
                    .HasColumnType("datetime");

                entity.Property(e => e.Nguoidung)
                    .HasColumnName("NGUOIDUNG")
                    .HasMaxLength(50);

                entity.Property(e => e.Noidung)
                    .HasColumnName("NOIDUNG")
                    .HasMaxLength(100);

                entity.HasOne(d => d.MahhNavigation)
                    .WithMany(p => p.BinhLuanHh)
                    .HasForeignKey(d => d.Mahh)
                    .HasConstraintName("FK_BinhLuanHH_HangHoa");
            });

            modelBuilder.Entity<ChiTietHd>(entity =>
            {
                entity.HasKey(e => new { e.Mahd, e.Mahh });

                entity.ToTable("ChiTietHD");

                entity.Property(e => e.Mahd).HasColumnName("MAHD");

                entity.Property(e => e.Mahh)
                    .HasColumnName("MAHH")
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.Dongia).HasColumnName("DONGIA");

                entity.Property(e => e.Giamgia).HasColumnName("GIAMGIA");

                entity.Property(e => e.Kieuhanghoa)
                    .HasColumnName("KIEUHANGHOA")
                    .HasMaxLength(20);

                entity.Property(e => e.Soluong).HasColumnName("SOLUONG");

                entity.Property(e => e.Tongtien).HasColumnName("TONGTIEN");

                entity.HasOne(d => d.MahhNavigation)
                    .WithMany(p => p.ChiTietHd)
                    .HasForeignKey(d => d.Mahh)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ChiTietHD_HangHoa");
            });

            modelBuilder.Entity<DangkiNcc>(entity =>
            {
                entity.HasKey(e => e.Mancc);

                entity.ToTable("DangkiNCC");

                entity.Property(e => e.Mancc)
                    .HasColumnName("MANCC")
                    .HasMaxLength(12)
                    .IsUnicode(false)
                    .ValueGeneratedNever();

                entity.Property(e => e.DangkiGpmbAt)
                    .HasColumnName("DANGKI_GPMB_AT")
                    .HasColumnType("datetime");

                entity.Property(e => e.Diachi)
                    .HasColumnName("DIACHI")
                    .HasMaxLength(10);

                entity.Property(e => e.Email)
                    .HasColumnName("EMAIL")
                    .HasMaxLength(50);

                entity.Property(e => e.Mota)
                    .HasColumnName("MOTA")
                    .HasMaxLength(200);

                entity.Property(e => e.Sdt)
                    .HasColumnName("SDT")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.TenNcc)
                    .HasColumnName("TEN_NCC")
                    .HasMaxLength(50);

                entity.HasOne(d => d.EmailNavigation)
                    .WithMany(p => p.DangkiNcc)
                    .HasForeignKey(d => d.Email)
                    .HasConstraintName("FK_DangkiNCC_NguoiDung1");
            });

            modelBuilder.Entity<HangHoa>(entity =>
            {
                entity.HasKey(e => e.Mahh);

                entity.Property(e => e.Mahh)
                    .HasColumnName("MAHH")
                    .HasMaxLength(12)
                    .IsUnicode(false)
                    .ValueGeneratedNever();

                entity.Property(e => e.Dongia).HasColumnName("DONGIA");

                entity.Property(e => e.Giamgia).HasColumnName("GIAMGIA");

                entity.Property(e => e.Hinh)
                    .HasColumnName("HINH")
                    .HasMaxLength(10);

                entity.Property(e => e.Maloai)
                    .HasColumnName("MALOAI")
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.Mancc)
                    .HasColumnName("MANCC")
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.Mota)
                    .HasColumnName("MOTA")
                    .HasMaxLength(200);

                entity.Property(e => e.Soluongton).HasColumnName("SOLUONGTON");

                entity.Property(e => e.Tenhh)
                    .HasColumnName("TENHH")
                    .HasMaxLength(100);

                entity.Property(e => e.TrangthaiHd).HasColumnName("TRANGTHAI_HD");

                entity.HasOne(d => d.MaloaiNavigation)
                    .WithMany(p => p.HangHoa)
                    .HasForeignKey(d => d.Maloai)
                    .HasConstraintName("FK_HangHoa_LoaiHangHoa");

                entity.HasOne(d => d.ManccNavigation)
                    .WithMany(p => p.HangHoa)
                    .HasForeignKey(d => d.Mancc)
                    .HasConstraintName("FK_HangHoa_DangkiNCC");
            });

            modelBuilder.Entity<HoaDonBh>(entity =>
            {
                entity.HasKey(e => e.Mahd);

                entity.ToTable("HoaDonBH");

                entity.Property(e => e.Mahd).HasColumnName("MAHD");

                entity.Property(e => e.DiachiNguoinhan)
                    .HasColumnName("DIACHI_NGUOINHAN")
                    .HasMaxLength(200);

                entity.Property(e => e.Ghichu)
                    .HasColumnName("GHICHU")
                    .HasMaxLength(100);

                entity.Property(e => e.HotenNguoinhan)
                    .HasColumnName("HOTEN_NGUOINHAN")
                    .HasMaxLength(100);

                entity.Property(e => e.Loaithanhtoan)
                    .HasColumnName("LOAITHANHTOAN")
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.Nguoiban)
                    .HasColumnName("NGUOIBAN")
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.Nguoimua)
                    .HasColumnName("NGUOIMUA")
                    .HasMaxLength(50);

                entity.Property(e => e.Phivanchuyen).HasColumnName("PHIVANCHUYEN");

                entity.Property(e => e.Sdt)
                    .HasColumnName("SDT")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Tongtien).HasColumnName("TONGTIEN");

                entity.Property(e => e.TrangthaiXuly).HasColumnName("TRANGTHAI_XULY");

                entity.HasOne(d => d.LoaithanhtoanNavigation)
                    .WithMany(p => p.HoaDonBh)
                    .HasForeignKey(d => d.Loaithanhtoan)
                    .HasConstraintName("FK_HoaDonBH_TRANGTHAITT");

                entity.HasOne(d => d.NguoibanNavigation)
                    .WithMany(p => p.HoaDonBh)
                    .HasForeignKey(d => d.Nguoiban)
                    .HasConstraintName("FK_HoaDonBH_DangkiNCC");

                entity.HasOne(d => d.NguoimuaNavigation)
                    .WithMany(p => p.HoaDonBh)
                    .HasForeignKey(d => d.Nguoimua)
                    .HasConstraintName("FK_HoaDonBH_NguoiDung");
            });

            modelBuilder.Entity<LoaiHangHoa>(entity =>
            {
                entity.HasKey(e => e.Maloai);

                entity.Property(e => e.Maloai)
                    .HasColumnName("MALOAI")
                    .HasMaxLength(12)
                    .IsUnicode(false)
                    .ValueGeneratedNever();

                entity.Property(e => e.Tenloai)
                    .HasColumnName("TENLOAI")
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<LogSystem>(entity =>
            {
                entity.HasKey(e => e.MalogSystem);

                entity.ToTable("Log_System");

                entity.Property(e => e.MalogSystem).HasColumnName("MALOG_SYSTEM");

                entity.Property(e => e.Ngaygio)
                    .HasColumnName("NGAYGIO")
                    .HasColumnType("datetime");

                entity.Property(e => e.NguoiThaoTac)
                    .HasColumnName("NGUOI_THAO_TAC")
                    .HasMaxLength(50);

                entity.Property(e => e.NoidungLog)
                    .HasColumnName("NOIDUNG_LOG")
                    .HasMaxLength(200);

                entity.Property(e => e.TenLog)
                    .HasColumnName("TEN_LOG")
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<NguoiDung>(entity =>
            {
                entity.HasKey(e => e.Email);

                entity.Property(e => e.Email)
                    .HasColumnName("EMAIL")
                    .HasMaxLength(50)
                    .ValueGeneratedNever();

                entity.Property(e => e.Avatar)
                    .HasColumnName("AVATAR")
                    .HasMaxLength(20);

                entity.Property(e => e.Cmnd)
                    .HasColumnName("CMND")
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.Diachi)
                    .HasColumnName("DIACHI")
                    .HasMaxLength(200);

                entity.Property(e => e.Hoten)
                    .HasColumnName("HOTEN")
                    .HasMaxLength(50);

                entity.Property(e => e.Matkhau)
                    .HasColumnName("MATKHAU")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Ngaydangki)
                    .HasColumnName("NGAYDANGKI")
                    .HasColumnType("datetime");

                entity.Property(e => e.Ngaysinh)
                    .HasColumnName("NGAYSINH")
                    .HasColumnType("datetime");

                entity.Property(e => e.Sdt)
                    .HasColumnName("SDT")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Trangthaihd).HasColumnName("TRANGTHAIHD");
            });

            modelBuilder.Entity<QuanTriVien>(entity =>
            {
                entity.HasKey(e => e.Taikhoan);

                entity.Property(e => e.Taikhoan)
                    .HasColumnName("TAIKHOAN")
                    .HasMaxLength(20)
                    .ValueGeneratedNever();

                entity.Property(e => e.IsAdmin).HasColumnName("IS_ADMIN");

                entity.Property(e => e.LastLogin)
                    .HasColumnName("LAST_LOGIN")
                    .HasColumnType("datetime");

                entity.Property(e => e.Manv)
                    .HasColumnName("MANV")
                    .HasMaxLength(10);

                entity.Property(e => e.Matkhau)
                    .HasColumnName("MATKHAU")
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<Trangthaitt>(entity =>
            {
                entity.HasKey(e => e.Maloaitt);

                entity.ToTable("TRANGTHAITT");

                entity.Property(e => e.Maloaitt)
                    .HasColumnName("MALOAITT")
                    .HasMaxLength(12)
                    .IsUnicode(false)
                    .ValueGeneratedNever();

                entity.Property(e => e.Tenloaitt)
                    .HasColumnName("TENLOAITT")
                    .HasMaxLength(50);

                entity.Property(e => e.Trangthaihd).HasColumnName("TRANGTHAIHD");
            });
        }
    }
}
