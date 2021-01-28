using Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Concrete.EntityFramework.Context
{
    public class OnMuhasebeContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(
                connectionString: @"Server=.\SQLEXPRESS;Database=OnMuhasebe;user id=sa;password=sapass");
        }
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