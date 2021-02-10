using Core.Entities;

namespace Entities.Concrete
{
    public class Kasa : IEntity
    {
        public int Id { get; set; }
        public string Ad { get; set; }
        public string Aciklama { get; set; }
    }
}
