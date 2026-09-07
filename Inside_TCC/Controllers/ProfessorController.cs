using Dominio.DTOs;
using Interface.Service;
using Microsoft.AspNetCore.Mvc;

namespace Inside_TCC.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ProfessorController : ControllerBase
    {
        private readonly IProfessorService service;

        public ProfessorController(IProfessorService service)
        {
            this.service = service;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<ProfessorDTO>>> Get()
        {
            var lista = await service.getAllAsync(a => true);

            return Ok(lista);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<ProfessorDTO>> Get(int id)
        {
            var professor = await service.getAsync(id);

            if (professor == null)
                return NotFound();

            return Ok(professor);
        }

        [HttpPost]
        public async Task<ActionResult<ProfessorDTO>> Post(
            [FromBody] ProfessorDTO dto)
        {
            var professor = await service.addAsync(dto);

            return CreatedAtAction(
                nameof(Get),
                new { id = professor.Id },
                professor);
        }

        [HttpPut("{id}")]
        public async Task<ActionResult> Put(
            int id,
            [FromBody] ProfessorDTO dto)
        {
            if (id != dto.Id)
                return BadRequest();

            await service.updateAsync(dto);

            return NoContent();
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult> Delete(int id)
        {
            await service.removeAsync(id);

            return NoContent();
        }
    }
}