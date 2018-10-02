using System.Collections.Generic;
using System.Diagnostics;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using UtahRepeaters.Api.Database;
using UtahRepeaters.Api.Database.Models;

namespace utahrepeaters.server.Controllers {
    [Produces ("application/json")]
    [Route ("api/[controller]")]
    [ApiController]
    public class RepeaterController : ControllerBase {
        private readonly IRepeaterRepository _repository;
        private readonly IMapper _mapper;

        public RepeaterController (IRepeaterRepository repository, IMapper mapper) {
            _mapper = mapper;
            _repository = repository;
        }

        [HttpGet]
        public async Task<ActionResult<List<Repeater>>> GetAllAsync () {
            return await _repository.GetAllAsync ().ToListAsync ();
        }

        [HttpGet ("{id}")]
        [ProducesResponseType (404)]
        public async Task<ActionResult<Repeater>> GetByIdAsync (int id) {
            var repeater = await _repository.GetAsync (id);

            if (repeater == null) {
                return NotFound ();
            }

            return repeater;
        }

        [HttpPost]
        [ProducesResponseType (400)]
        public async Task<ActionResult<Repeater>> CreateAsync (Repeater repeater) {
            if (!ModelState.IsValid) {
                return BadRequest (ModelState);
            }

            await _repository.AddAsync (repeater);

            return CreatedAtAction (nameof (GetByIdAsync),
                new { id = repeater.RepeaterId }, repeater);
        }

        [HttpPost]
        [Route ("import")]
        public IActionResult Import ([FromBody] List<RawRepeater> value) {
            if (!ModelState.IsValid) {
                return BadRequest (ModelState);
            } else {
                List<RawRepeater> data = value;
                List<Repeater> repeaters = _mapper.Map<List<Repeater>>(value);
                return Ok ();
            }
        }
    }
}