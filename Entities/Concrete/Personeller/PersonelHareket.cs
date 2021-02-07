using Core.Entities;

namespace Entities.Concrete
{
    public class PersonelHareket : IEntity
    {
        public int Id { get; set; }
        public int PersonelId { get; set; }
    }
}