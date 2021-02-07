using Business.Abstract;
using Entities.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StoklarController : ControllerBase
    {
        IStokService _stokService;
        public StoklarController(IStokService stokService)
        {
            _stokService = stokService;
        }
        [HttpGet("getlist")]
        public IActionResult GetList()
        {
            var result = _stokService.GetList();
            if (result.Success)
            {
                return Ok(result.Data);
            }
            return BadRequest(result.Message);
        }
        [HttpGet("getbyid")]
        public IActionResult GetById(int stokId)
        {
            var result = _stokService.GetById(stokId);
            if (result.Success)
            {
                return Ok(result.Data);
            }
            return BadRequest(result.Message);
        }
        [HttpGet("getbygrup")]
        public IActionResult GetByGrup(string grupAd)
        {
            var result = _stokService.GetListByGrupAd(grupAd);
            if (result.Success)
            {
                return Ok(result.Data);
            }
            return BadRequest(result.Message);
        }
        [HttpPost("add")]
        public IActionResult Add(Stok stok)
        {
            var result = _stokService.Add(stok);
            if (result.Success)
            {
                return Ok(result.Message);
            }
            return BadRequest(result.Message);
        }
        [HttpPost("delete")]
        public IActionResult Delete(Stok stok)
        {
            var result = _stokService.Delete(stok);
            if (result.Success)
            {
                return Ok(result.Message);
            }
            return BadRequest(result.Message);
        }
        [HttpPost("update")]
        public IActionResult Update(Stok stok)
        {
            var result = _stokService.Update(stok);
            if (result.Success)
            {
                return Ok(result.Message);
            }
            return BadRequest(result.Message);
        }
    }
}