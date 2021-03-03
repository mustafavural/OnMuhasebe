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
        IStokGrupKodService _stokGrupKodService;
        public StoklarController(IStokService stokService, IStokGrupService stokGrupService, IStokGrupKodService stokGrupKodService)
        {
            _stokService = stokService;
            _stokGrupService = stokGrupService;
            _stokGrupKodService = stokGrupKodService;
        }

        public IResult AddStok(Stok stok, out int Id)
        {
            try
            {
                var addResult = _stokService.Add(stok);
                var addedStok = _stokService.GetByKod(stok.Kod);
                Id = addedStok.Data.Id;
                return addResult;
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
                return _stokService.Delete(stok);
            }
            catch (Exception err)
            {
                return new ErrorResult(err.Message);
            }
        }

        public IResult UpdateStok(Stok stok, int stokId)
        {
            try
            {
                stok.Id = stokId;
                return _stokService.Update(stok);
            }
            catch (Exception err)
            {
                return new ErrorResult(err.Message);
            }
        }

        public IResult AddGrupKod(StokGrupKod stokGrupKod, out int Id)
        {
            try
            {
                var addResult = _stokGrupKodService.Add(stokGrupKod);
                var addedGrupKod = _stokGrupKodService.GetByTurAndAd(stokGrupKod.Tur, stokGrupKod.Ad);
                Id = addedGrupKod.Data.Id;
                return addResult;
            }
            catch (Exception err)
            {
                Id = -1;
                return new ErrorResult(err.Message);
            }
        }

        public IResult DeleteGrupKod(StokGrupKod stokGrupKod)
        {
            try
            {
                return _stokGrupKodService.Delete(stokGrupKod);
            }
            catch (Exception err)
            {
                return new ErrorResult(err.Message);
            }
        }

        public IResult UpdateGrupKod(StokGrupKod stokGrupKod, int Id)
        {
            try
            {
                stokGrupKod.Id = Id;
                return _stokGrupKodService.Update(stokGrupKod);
            }
            catch (Exception err)
            {
                return new ErrorResult(err.Message);
            }
        }

        public IResult UpdateRelations(int stokId, List<StokGrupKod> stokGrupKodlar)
        {
            var mevcutlar = _stokService.GetListStokGrupKod(stokId).Data;

            var eklenecekler = stokGrupKodlar.Where(s => !mevcutlar.Exists(m => m.Id == s.Id)).ToList();
            var silinecekler = mevcutlar.Where(m => !stokGrupKodlar.Exists(s => s.Id == m.Id)).ToList();

            foreach (var item in eklenecekler)
            {
                var addGrupResult = AddOneRelation(stokId, item.Id);
                if (!addGrupResult.Success)
                    return new ErrorResult(addGrupResult.Message);
            }

            foreach (var item in silinecekler)
            {
                var deleteGrupResult = DeleteOneRelation(stokId, item.Id);
                if (!deleteGrupResult.Success)
                    return new ErrorResult(deleteGrupResult.Message);
            }

            return new SuccessResult();
        }

        public IResult AddOneRelation(int stokId, int stokGrupKodId)
        {
            try
            {
                return _stokGrupService.Add(new StokGrup { StokGrupKodId = stokGrupKodId, StokId = stokId });
            }
            catch (Exception err)
            {
                return new ErrorResult(err.Message);
            }
        }

        public IResult DeleteOneRelation(int stokId, int stokGrupKodId)
        {
            try
            {
                return _stokGrupService.Delete(_stokGrupService.GetByBothId(stokId, stokGrupKodId).Data);
            }
            catch (Exception err)
            {
                return new ErrorResult(err.Message);
            }
        }

        public IDataResult<List<Stok>> GetStokList() => _stokService.GetList();
        public IDataResult<List<StokGrupKod>> GetStokGrupList() => _stokGrupKodService.GetList();
        public IDataResult<Stok> GetByKod(string kod) => _stokService.GetByKod(kod);
        public IDataResult<List<StokGrupKod>> GetListStokGrupKod(int Id) => _stokService.GetListStokGrupKod(Id);
        public IDataResult<Stok> GetById(int Id) => _stokService.GetById(Id);
    }
}