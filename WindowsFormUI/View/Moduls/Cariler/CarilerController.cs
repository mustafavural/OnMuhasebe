using Business.Abstract;
using Core.Utilities.Result;
using Entities.Concrete;
using System;
using System.Collections.Generic;

namespace WindowsFormUI.View.Moduls.Cariler
{
    public class CarilerController
    {
        ICariService<Cari> _cariService;
        ICariGrupService _cariGrupService;
        ICariGrupKodService _cariGrupKodService;


        public CarilerController(ICariService<Cari> cariService, ICariGrupService cariGrupService, ICariGrupKodService cariGrupKodService)
        {
            _cariService = cariService;
            _cariGrupService = cariGrupService;
            _cariGrupKodService = cariGrupKodService;
        }

        public IDataResult<List<CariGrupKod>> GetCariGrupList()
        {
            throw new NotImplementedException();
        }

        public IResult AddGrupKod(CariGrupKod secilen, out int Id)
        {
            throw new NotImplementedException();
        }

        public IResult UpdateGrupKod(CariGrupKod secilenKod, int Id)
        {
            throw new NotImplementedException();
        }

        public IResult DeleteGrupKod(CariGrupKod secilenKod)
        {
            throw new NotImplementedException();
        }

        public IDataResult<List<Cari>> GetCariList()
        {
            throw new NotImplementedException();
        }

        public IDataResult<List<CariGrupKod>> GetListCariGrupKod(int Id)
        {
            throw new NotImplementedException();
        }

        public IDataResult<Cari> GetById(int Id)
        {
            throw new NotImplementedException();
        }
    }
}