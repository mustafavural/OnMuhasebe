using Core.Entities;

namespace Entities.Concrete
{
    public class StokGrup : IEntity
    {
        public int Id { get; set; }
        public int StokId { get; set; }
        public int StokGrupKodId { get; set; }
    }
}