using Core.Entities;

namespace Entities.Concrete
{
    public class SahisCari : IEntity
    {
        public int Id { get; set; }
        public int CariId { get; set; }
        public string TCNo { get; set; }
        public string Kod { get; set; }
        public string Unvan { get; set; }
        public string VergiDairesi { get; set; }
    }
}