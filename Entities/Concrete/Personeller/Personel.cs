using Core.Entities;
using System;

namespace Entities.Concrete
{
    public class Personel : IEntity
    {
        public int Id { get; set; }
        public string Ad { get; set; }
        public string IkinciAd { get; set; }
        public string Soyad { get; set; }
        public string TCNo { get; set; }
        public string Cinsiyet { get; set; }
        public string MedeniHal { get; set; }
        public byte CocukSayisi { get; set; }
        public DateTime DogumTarihi { get; set; }
        public int KatSayi { get; set; }
        public string Birim { get; set; }
        public string Gorev { get; set; }
        public int Izin { get; set; }
    }
}