using Core.Entities;

namespace Entities.Concrete
{
    public class Banka : IEntity
    {
        public int Id { get; set; }
        public string Ad { get; set; }
    }
}
