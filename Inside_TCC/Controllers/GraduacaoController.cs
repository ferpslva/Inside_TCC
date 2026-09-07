using Dominio.DTOs;
using Dominio.Entidade;
using Interface.Service;
using Microsoft.AspNetCore.Mvc;

namespace Inside_TCC.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class GraduacaoController : ControllerBase
    {
        private readonly IGraduacaoService service;

        public GraduacaoController(IGraduacaoService service)
        {
            this.service = service;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<GraduacaoDTO>>> Get()
        {
            var lista = await service.getAllAsync(p => true);

            return Ok(lista);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<GraduacaoDTO>> Get(int id)
        {
            var graduacao = await service.getAsync(id);

            if (graduacao == null)
                return NotFound();

            return Ok(graduacao);
        }

        [HttpPost]
        public async Task<ActionResult<GraduacaoDTO>> Post(
            [FromBody] GraduacaoDTO dto)
        {
            var graduacao = await service.addAsync(dto);

            return CreatedAtAction(
                nameof(Get),
                new { id = graduacao.Id },
                graduacao);
        }

        [HttpPut("{id}")]
        public async Task<ActionResult> Put(
            int id,
            [FromBody] GraduacaoDTO dto)
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