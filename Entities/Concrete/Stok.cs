using Core.Entities;

namespace Entities.Concrete
{
    public class Stok : IEntity
    {
        public int Id { get; set; }
        public string Kod { get; set; }
        public string Barkod { get; set; }
        public string Ad { get; set; }
        public int KDV { get; set; }
        public string Birim { get; set; }
        public string Birim2 { get; set; }
        public decimal Birim2Oran { get; set; }
        public string Birim3 { get; set; }
        public decimal Birim3Oran { get; set; }
    }
}