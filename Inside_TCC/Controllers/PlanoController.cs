using Dominio.DTOs;
using Interface.Service;
using Microsoft.AspNetCore.Mvc;

namespace Inside_TCC.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class PlanoController : ControllerBase
    {
        private readonly IPlanoService service;

        public PlanoController(IPlanoService service)
        {
            this.service = service;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<PlanoDTO>>> Get()
        {
            var lista = await service.getAllAsync(p => true);

            return Ok(lista);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<PlanoDTO>> Get(int id)
        {
            var plano = await service.getAsync(id);

            if (plano == null)
                return NotFound();

            return Ok(plano);
        }

        [HttpPost]
        public async Task<ActionResult<PlanoDTO>> Post(
            [FromBody] PlanoDTO dto)
        {
            var plano = await service.addAsync(dto);

            return CreatedAtAction(
                nameof(Get),
                new { id = plano.Id },
                plano);
        }

        [HttpPut("{id}")]
        public async Task<ActionResult> Put(
            int id,
            [FromBody] PlanoDTO dto)
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