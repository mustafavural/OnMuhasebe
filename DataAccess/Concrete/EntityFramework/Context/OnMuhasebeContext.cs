using Core.Entities.Concrete;
using Entities.Concrete;
using Microsoft.EntityFrameworkCore;

namespace DataAccess.Concrete.EntityFramework.Context
{
    public class OnMuhasebeContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(
                connectionString: @"Server=.\SQLEXPRESS;Database=OnMuhasebe;user id=sa;password=sapass");
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Cari>().ToTable("Cariler");
            modelBuilder.Entity<SahisCari>().ToTable("SahisCariler").HasBaseType<Cari>();
            modelBuilder.Entity<SirketCari>().ToTable("SirketCariler").HasBaseType<Cari>();

            modelBuilder.Entity<Evrak>().ToTable("Evraklar");
            modelBuilder.Entity<Fatura>().ToTable("Faturalar").HasBaseType<Evrak>();
            modelBuilder.Entity<Irsaliye>().ToTable("Irsaliyeler").HasBaseType<Evrak>();

            modelBuilder.Entity<DegerliKagit>().ToTable("DegerliKagitlar");
            modelBuilder.Entity<Cek>().ToTable("Cekler").HasBaseType<DegerliKagit>();
            modelBuilder.Entity<Senet>().ToTable("Senetler").HasBaseType<DegerliKagit>();
            modelBuilder.Entity<MusteriCek>().ToTable("MusteriCekler").HasBaseType<Cek>();
            modelBuilder.Entity<BorcCek>().ToTable("BorcCekler").HasBaseType<Cek>();
            modelBuilder.Entity<MusteriSenet>().ToTable("MusteriSenetler").HasBaseType<Senet>();
            modelBuilder.Entity<BorcSenet>().ToTable("BorcSenetler").HasBaseType<Senet>();
        }
        public DbSet<OperationClaim> OperationClaims { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<UserOperationClaim> UserOperationClaims { get; set; }
        public DbSet<Stok> Stoklar { get; set; }
        public DbSet<StokGrup> StokGruplar { get; set; }
        public DbSet<StokGrupKod> StokGrupKodlar { get; set; }
        public DbSet<StokHareket> StokHareketler { get; set; }
        public DbSet<Cari> Cariler { get; set; }
        public DbSet<SahisCari> SahisCariler { get; set; }
        public DbSet<SirketCari> SirketCariler { get; set; }
        public DbSet<CariGrup> CariGruplar { get; set; }
        public DbSet<CariGrupKod> CariGrupKodlar { get; set; }
        public DbSet<CariHareket> CariHareketler { get; set; }
        public DbSet<Evrak> Evraklar { get; set; }
        public DbSet<Fatura> Faturalar { get; set; }
        public DbSet<Irsaliye> Irsaliyeler { get; set; }
        public DbSet<DegerliKagit> DegerliKagitlar { get; set; }
        public DbSet<Cek> Cekler { get; set; }
        public DbSet<Senet> Senetler { get; set; }
        public DbSet<BorcCek> BorcCekler { get; set; }
        public DbSet<BorcSenet> BorcSenetler { get; set; }
        public DbSet<MusteriCek> MusteriCekler { get; set; }
        public DbSet<MusteriSenet> MusteriSenetler { get; set; }
    }
}