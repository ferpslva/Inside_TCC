using Dominio.DTOs;
using Interface.Service;
using Microsoft.AspNetCore.Mvc;

using Dominio.DTOs;
using Dominio.Entidade;
using Interface.Service;
using Microsoft.AspNetCore.Mvc;

namespace Inside_TCC.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class MatriculaController : ControllerBase
    {
        private readonly IMatriculaService service;

        public MatriculaController(IMatriculaService service)
        {
            this.service = service;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<MatriculaDTO>>> Get()
        {
            var lista = await service.getAllAsync(p => true);

            return Ok(lista);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<MatriculaDTO>> Get(int id)
        {
            var matricula = await service.getAsync(id);

            if (matricula == null)
                return NotFound();

            return Ok(matricula);
        }

        [HttpPost]
        public async Task<ActionResult<MatriculaDTO>> Post(
            [FromBody] MatriculaDTO dto)
        {
            var matricula = await service.addAsync(dto);

            return CreatedAtAction(
                nameof(Get),
                new { id = matricula.Id },
                matricula);
        }

        [HttpPut("{id}")]
        public async Task<ActionResult> Put(
            int id,
            [FromBody] MatriculaDTO dto)
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