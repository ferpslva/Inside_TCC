using Dominio.DTOs;
using Interface.Service;
using Microsoft.AspNetCore.Mvc;

namespace Inside_TCC.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class VinculoController : ControllerBase
    {
        private readonly IVinculoService service;

        public VinculoController(IVinculoService service)
        {
            this.service = service;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<VinculoDTO>>> Get()
        {
            var lista = await service.getAllAsync(v => true);

            return Ok(lista);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<VinculoDTO>> Get(int id)
        {
            var vinculo = await service.getAsync(id);

            if (vinculo == null)
                return NotFound();

            return Ok(vinculo);
        }

        [HttpPost]
        public async Task<ActionResult<VinculoDTO>> Post(
            [FromBody] VinculoDTO dto)
        {
            var vinculo = await service.addAsync(dto);

            return CreatedAtAction(
                nameof(Get),
                new { id = vinculo.Id },
                vinculo);
        }

        [HttpPut("{id}")]
        public async Task<ActionResult> Put(
            int id,
            [FromBody] VinculoDTO dto)
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