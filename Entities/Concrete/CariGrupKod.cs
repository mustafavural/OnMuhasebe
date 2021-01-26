using Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Concrete
{
    public class CariGrupKod : IEntity
    {
        public int Id { get; set; }
        public string Tur { get; set; }
        public string Ad { get; set; }
    }
}
