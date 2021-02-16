using Business.Abstract;
using Core.Utilities.Result;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;

namespace WindowsFormUI.View.Moduls.Stoklar
{
    public partial class FrmStokListe : FrmBase
    {
        IStokService _stokService;
        IDataResult<List<Stok>> _stokResult;
        public FrmStokListe(IStokService stokService)
        {
            InitializeComponent();
            _stokService = stokService;
        }

        private void FrmStokListe_Load(object sender, EventArgs e)
        {
            _stokResult = _stokService.GetList();
            if (_stokResult.Success)
            {
                dgvStokListe.DataSource = _stokResult.Data.Select(s => new { s.Kod, s.Barkod, s.Ad }).ToList();
            }
        }
    }
}
