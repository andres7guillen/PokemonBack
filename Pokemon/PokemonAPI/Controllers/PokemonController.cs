using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PokemonDomain.Services;

namespace PokemonAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize(AuthenticationSchemes = JwtBearerDefaults.AuthenticationScheme)]
    public class PokemonController : ControllerBase
    {
        private readonly IPokemonService _service;
        public PokemonController(IPokemonService service)
        {
            _service = service;
        }

        [HttpGet]
        public async Task<IActionResult> getAll()
        {
            var result = await _service.getAll();
            if (result.count >= 1)
            {
                return Ok(result.results);
            }
            else
            {
                return BadRequest();
            }
        }

        [HttpGet("getById")]
        public async Task<IActionResult> getById([FromQuery]string url)
        {
            var result = await _service.getPokemonById(url);
            if (result != null)
            {
                return Ok(result);
            }
            else
            {
                return NotFound();
            }
        }

        [HttpGet("getByName")]
        public async Task<IActionResult> getByName([FromQuery]string name)
        {
            var result = await _service.getPokemonByName(name);
            if (result != null)
            {
                return Ok(result);
            }
            else
            {
                return NotFound();
            }
        }

    }
}