using Core.Entities;

namespace Entities.Concrete
{
    public class CariGrup : IEntity
    {
        public int Id { get; set; }
        public int CariId { get; set; }
        public int CariGrupKodId { get; set; }
    }
}
