using Core.Entities;

namespace Entities.Concrete
{
    public class Depo : IEntity
    {
        public int Id { get; set; }
        public int AdresId { get; set; }
        public string Ad { get; set; }
    }
}
