using Dominio.DTOs;
using Dominio.Entidade;
using Interface.Service;
using Microsoft.AspNetCore.Mvc;

namespace Inside_TCC.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ProdutoController : ControllerBase
    {
        private readonly IProdutoService service;

        public ProdutoController(IProdutoService service)
        {
            this.service = service;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<ProdutoDTO>>> Get()
        {
            var lista = await service.getAllAsync(p => true);

            return Ok(lista);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<ProdutoDTO>> Get(int id)
        {
            var produto = await service.getAsync(id);

            if (produto == null)
                return NotFound();

            return Ok(produto);
        }

        [HttpPost]
        public async Task<ActionResult<ProdutoDTO>> Post(
            [FromBody] ProdutoDTO dto)
        {
            var produto = await service.addAsync(dto);

            return CreatedAtAction(
                nameof(Get),
                new { id = produto.Id },
                produto);
        }

        [HttpPut("{id}")]
        public async Task<ActionResult> Put(
            int id,
            [FromBody] ProdutoDTO dto)
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