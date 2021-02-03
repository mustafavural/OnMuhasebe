using Core.Entities;

namespace Entities
{
    public class PersonelHareket : IEntity
    {
        public int Id { get; set; }
        public int PersonelId { get; set; }
    }
}