using System;

namespace Entities.Concrete
{
    public class BorcCek : Cek
    {
        public int CariIdVerilen { get; set; }
        public int HesapId { get; set; }
        public DateTime CikisTarihi { get; set; }
    }
}
