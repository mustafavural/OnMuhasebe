using Core.Entities;

namespace Entities.Concrete
{
    public class BankaSube : IEntity
    {
        public int Id { get; set; }
        public int BankaId { get; set; }
        public string Ad { get; set; }
    }
}
