using Core.Entities;
using System;

namespace Entities.Concrete
{
    public class KasaHareket : IEntity
    {
        public int Id { get; set; }
        public int KasaId { get; set; }
        public int PersonelHarId { get; set; }
        public int CariHarId { get; set; }
        public string BelgeNo { get; set; }
        public decimal GirenMiktar { get; set; }
        public decimal CikanMiktar { get; set; }
        public DateTime Tarih { get; set; }
        public string Aciklama { get; set; }
    }
}
