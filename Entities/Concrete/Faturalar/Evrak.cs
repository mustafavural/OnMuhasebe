using Core.Entities;
using System;

namespace Entities.Concrete
{
    public class Evrak : IEntity
    {
        public int Id { get; set; }
        public int CariHarId { get; set; }
        public int PersonelHarId { get; set; }
        public DateTime Tarih { get; set; }
        public DateTime KayitTarihi { get; set; }
        public string Aciklama { get; set; }
    }
}