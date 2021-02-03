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
    }
}