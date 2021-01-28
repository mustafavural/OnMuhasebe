using Core.DataAccess;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Abstract
{
    public interface ISirketCariDal : IEntityRepository<SirketCari>
    {
        SirketCari GetById(int cariId);
    }
}