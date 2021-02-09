using Core.Entities;

namespace Entities.Concrete
{
    public class BankaHesap : IEntity
    {
        public int Id { get; set; }
        public int SubeId { get; set; }
        public string Ad { get; set; }
        public string No { get; set; }
        public string IBAN { get; set; }
        public string MusteriYetkili { get; set; }
        public string Aciklama { get; set; }
    }
}
