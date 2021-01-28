using Core.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Entities.Concrete
{
    public class SahisCari : Cari
    {
        public int CariId { get; set; }
        public string TCNo { get; set; }
        public Cari Cari { get; set; }
    }
}