using Core.Entities;
using System;

namespace Entities.Concrete
{
    public class StokHareket : IEntity
    {
        public int Id { get; set; }
        public int StokId { get; set; }
        public int FaturaId { get; set; }
        public int DepoId { get; set; }
        public decimal GirenMiktar { get; set; }
        public decimal CikanMiktar { get; set; }
        public string Birim { get; set; }
        public decimal Fiyat { get; set; }
        public int KDV { get; set; }
        public decimal BrutTutar { get; set; }
        public decimal NetTutar { get; set; }
        public DateTime Tarih { get; set; }
        public string Aciklama { get; set; }
    }
}