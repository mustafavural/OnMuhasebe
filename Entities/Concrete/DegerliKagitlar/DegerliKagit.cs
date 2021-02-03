using Core.Entities;
using System;

namespace Entities.Concrete
{
    public class DegerliKagit : IEntity
    {
        public int Id { get; set; }
        public DateTime Vade { get; set; }
        public decimal Tutar { get; set; }
        public string Aciklama { get; set; }
    }
}
