using Dominio.DTOs;
using Interface.Service;
using Microsoft.AspNetCore.Mvc;

namespace Inside_TCC.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class AlunoController : ControllerBase
    {
        private readonly IAlunoService service;

        public AlunoController(IAlunoService service)
        {
            this.service = service;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<AlunoDTO>>> Get()
        {
            var lista = await service.getAllAsync(a => true);

            return Ok(lista);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<AlunoDTO>> Get(int id)
        {
            var aluno = await service.getAsync(id);

            if (aluno == null)
                return NotFound();

            return Ok(aluno);
        }

        [HttpPost]
        public async Task<ActionResult<AlunoDTO>> Post(
            [FromBody] AlunoDTO dto)
        {
            var aluno = await service.addAsync(dto);

            return CreatedAtAction(
                nameof(Get),
                new { id = aluno.Id },
                aluno);
        }

        [HttpPut("{id}")]
        public async Task<ActionResult> Put(
            int id,
            [FromBody] AlunoDTO dto)
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