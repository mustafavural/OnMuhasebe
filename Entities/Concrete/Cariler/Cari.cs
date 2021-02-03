using Core.Entities;

namespace Entities.Concrete
{
    public class Cari : IEntity
    {
        public int Id { get; set; }
        public string Kod { get; set; }
        public string Unvan { get; set; }
        public string VergiDairesi { get; set; }
    }
}