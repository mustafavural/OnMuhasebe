using Core.Entities;
using System;

namespace Entities.Concrete
{
    public class PersonelHareket : IEntity
    {
        public int Id { get; set; }
        public int PersonelId { get; set; }
        public string Tur { get; set; }
        public DateTime IslemTarihi { get; set; }
    }
}