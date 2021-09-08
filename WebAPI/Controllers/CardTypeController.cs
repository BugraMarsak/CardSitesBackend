using Business.Abstract;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NewWebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CardTypeController : ControllerBase
    {
        private ICardTypeService _cardTypeService;

        public CardTypeController(ICardTypeService cardTypeService)
        {
            _cardTypeService = cardTypeService;
        }

        [HttpGet("getall")]
        public IActionResult GetAll()
        {

            var result = _cardTypeService.GetAll();
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);

        }
    }
}
