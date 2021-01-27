using Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Concrete
{
    public class SirketCari : IEntity
    {
        public int Id { get; set; }
        public string Kod { get; set; }
        public string Unvan { get; set; }
        public string VergiDairesi { get; set; }
        public string VergiNo { get; set; }
    }
}
