namespace Entities.Concrete
{
    public class Fatura : Evrak
    {
        public string FaturaNo { get; set; }
        public decimal BrutTutar { get; set; }
        public decimal KDVlerToplam { get; set; }
        public decimal NetTutar { get; set; }
    }
}