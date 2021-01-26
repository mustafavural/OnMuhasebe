using Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Concrete
{
    public class CariGrup : IEntity
    {
        public int Id { get; set; }
        public int CariId { get; set; }
        public int CariGrupKodId { get; set; }

    }
}
