using Dominio.DTOs;
using Interface.Service;
using Microsoft.AspNetCore.Mvc;

namespace Inside_TCC.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ModalidadeController : ControllerBase
    {
        private readonly IModalidadeService service;

        public ModalidadeController(IModalidadeService service)
        {
            this.service = service;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<ModalidadeDTO>>> Get()
        {
            var lista = await service.getAllAsync(p => true);

            return Ok(lista);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<ModalidadeDTO>> Get(int id)
        {
            var modalidade = await service.getAsync(id);

            if (modalidade == null)
                return NotFound();

            return Ok(modalidade);
        }

        [HttpPost]
        public async Task<ActionResult<ModalidadeDTO>> Post(
            [FromBody] ModalidadeDTO dto)
        {
            var modalidade = await service.addAsync(dto);

            return CreatedAtAction(
                nameof(Get),
                new { id = modalidade.Id },
                modalidade);
        }

        [HttpPut("{id}")]
        public async Task<ActionResult> Put(
            int id,
            [FromBody] ModalidadeDTO dto)
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