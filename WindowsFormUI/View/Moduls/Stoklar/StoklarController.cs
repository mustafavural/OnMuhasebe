using Business.Abstract;
using Core.Utilities.Result;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;

namespace WindowsFormUI.View.Moduls.Stoklar
{
    public class StoklarController
    {
        IStokService _stokService;
        IStokGrupService _stokGrupService;
        Stok _secilenStok;
        public StoklarController(IStokService stokService, IStokGrupService stokGrupService, Stok secilenStok)
        {
            _stokService = stokService;
            _secilenStok = secilenStok;
            _stokGrupService = stokGrupService;
        }

        public IResult AddStok(Stok stok, out int Id)
        {
            try
            {
                var stokResult = _stokService.Add(stok);
                var addedStok = _stokService.GetByKod(stok.Kod);
                Id = addedStok.Data.Id;
                return stokResult;
            }
            catch (Exception err)
            {
                Id = -1;
                return new ErrorResult(err.Message);
            }
        }

        public IResult DeleteStok(Stok stok)
        {
            try
            {
                stok.Id = _secilenStok.Id;
                var result = _stokService.Delete(stok);
                _secilenStok = stok;
                return result;
            }
            catch (Exception err)
            {
                return new ErrorResult(err.Message);
            }
        }

        public IResult UpdateStok(Stok stok)
        {
            try
            {
                stok.Id = _secilenStok.Id;
                var result = _stokService.Update(stok);
                _secilenStok = stok;
                return result;
            }
            catch (Exception err)
            {
                return new ErrorResult(err.Message);
            }
        }

        public IResult UpdateStokGroups(int stokId, List<StokGrupKod> stokGrupKodlar)
        {
            var mevcutlar = _stokService.GetListStokGrupKod(stokId).Data;

            var eklenecekler = stokGrupKodlar.Where(s => !mevcutlar.Exists(m => m.Id == s.Id)).ToList();
            var silinecekler = mevcutlar.Where(m => !stokGrupKodlar.Exists(s => s.Id == m.Id)).ToList();

            foreach (var item in eklenecekler)
            {
                var addGrupResult = AddOneGroupToStok(stokId, item.Id);
                if (!addGrupResult.Success)
                    return new ErrorResult(addGrupResult.Message);
            }

            foreach (var item in silinecekler)
            {
                var deleteGrupResult = DeleteOneGroupFromStok(stokId, item.Id);
                if (!deleteGrupResult.Success)
                    return new ErrorResult(deleteGrupResult.Message);
            }

            return new SuccessResult();
        }

        public IResult AddOneGroupToStok(int stokId, int stokGrupKodId)
        {
            var stok = new StokGrup { StokGrupKodId = stokGrupKodId, StokId = stokId };
            try
            {
                return _stokGrupService.Add(stok);
            }
            catch (Exception err)
            {
                return new ErrorResult(err.Message);
            }
        }

        public IResult DeleteOneGroupFromStok(int stokId, int stokGrupKodId)
        {
            var relation = _stokGrupService.GetByBothId(stokId, stokGrupKodId).Data;
            try
            {
                return _stokGrupService.Delete(relation);
            }
            catch (Exception err)
            {
                return new ErrorResult(err.Message);
            }
        }
    }
}