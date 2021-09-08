using Business.Abstract;
using Entities.Concrete;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LeafletController : Controller
    {
        ILeafletService _leafletService;

        public LeafletController(ILeafletService leafletService)
        {
            _leafletService = leafletService;
        }

        [HttpGet("getall")]
        public IActionResult GetAll()
        {

            var result = _leafletService.GetLeafletDetails();
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);

        }
        [HttpGet("getbyleafletid")]
        public IActionResult GetByLeafletId(int leafletId)
        {

            var result = _leafletService.GetAllByLeafletId(leafletId);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);

        }

        [HttpPost("add")]
        public IActionResult Add(Leaflet leaflet)
        {
            var result = _leafletService.Add(leaflet);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);

        }

        [HttpPost("delete")]
        public IActionResult Delete(Leaflet leaflet)
        {
            var result = _leafletService.Delete(leaflet);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);

        }

        [HttpPost("update")]
        public IActionResult Update(Leaflet leaflet)
        {
            var result = _leafletService.Update(leaflet);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);

        }
    }
}
