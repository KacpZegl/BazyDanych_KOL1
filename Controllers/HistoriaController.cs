using BLL.DTOModels;
using BLL.ServiceInterfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BazyDanych.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HistoriaController : ControllerBase
    {
        private readonly IHistoriaService _historiaService;

        public HistoriaController(IHistoriaService historiaService)
        {
            _historiaService = historiaService;
        }

        [HttpGet]
        public IActionResult GetHistorie([FromQuery] int pageNumber, [FromQuery] int pageSize)
        {
            var historie = _historiaService.GetHistoriaPage(pageNumber, pageSize);
            return Ok(historie);
        }
    }
}
