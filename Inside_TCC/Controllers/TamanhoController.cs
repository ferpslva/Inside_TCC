using Dominio.DTOs;
using Interface.Service;
using Microsoft.AspNetCore.Mvc;

namespace Inside_TCC.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class TamanhoController : ControllerBase
    {
        private readonly ITamanhoService service;

        public TamanhoController(ITamanhoService service)
        {
            this.service = service;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<TamanhoDTO>>> Get()
        {
            var lista = await service.getAllAsync(t => true);

            return Ok(lista);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<TamanhoDTO>> Get(int id)
        {
            var tamanho = await service.getAsync(id);

            if (tamanho == null)
                return NotFound();

            return Ok(tamanho);
        }

        [HttpPost]
        public async Task<ActionResult<TamanhoDTO>> Post(
            [FromBody] TamanhoDTO dto)
        {
            var tamanho = await service.addAsync(dto);

            return CreatedAtAction(
                nameof(Get),
                new { id = tamanho.Id },
                tamanho);
        }

        [HttpPut("{id}")]
        public async Task<ActionResult> Put(
            int id,
            [FromBody] TamanhoDTO dto)
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