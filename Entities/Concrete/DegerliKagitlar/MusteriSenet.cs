using System;

namespace Entities.Concrete
{
    public class MusteriSenet : Senet
    {
        public int CariIdCiroEden { get; set; }
        public int CariIdCiroEdilen { get; set; }
        public int HesapIdTahsileVerilen { get; set; }
        public string AsilBorclu { get; set; }
        public DateTime AlisTarihi { get; set; }
        public DateTime CikisTarihi { get; set; }
    }
}
