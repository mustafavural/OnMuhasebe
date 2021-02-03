using Core.Entities;
using System;

namespace Entities.Concrete
{
    public class CariHareket : IEntity
    {
        public int Id { get; set; }
        public int CariId { get; set; }
        public decimal Borc { get; set; }
        public decimal Alacak { get; set; }
        public DateTime Tarih { get; set; }
        public string Aciklama { get; set; }
    }
}
