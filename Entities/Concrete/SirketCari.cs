using Core.Entities;

namespace Entities.Concrete
{
    public class SirketCari : IEntity
    {
        public int Id { get; set; }
        public int CariId { get; set; }
        public string VergiNo { get; set; }
        public string Kod { get; set; }
        public string Unvan { get; set; }
        public string VergiDairesi { get; set; }
    }
}