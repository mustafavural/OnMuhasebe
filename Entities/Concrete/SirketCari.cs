using Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Concrete
{
    public class SirketCari : Cari
    {
        public int CariId { get; set; }
        public string VergiNo { get; set; }


        public Cari Cari { get; set; }
    }
}
