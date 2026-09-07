using Dominio.DTOs;
using Interface.Service;
using Microsoft.AspNetCore.Mvc;

namespace Inside_TCC.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class Tipo_ProdutoController : ControllerBase
    {
        private readonly ITipo_ProdutoService service;

        public Tipo_ProdutoController(
            ITipo_ProdutoService service)
        {
            this.service = service;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Tipo_ProdutoDTO>>> Get()
        {
            var lista = await service.getAllAsync(t => true);

            return Ok(lista);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Tipo_ProdutoDTO>> Get(int id)
        {
            var tipoProduto = await service.getAsync(id);

            if (tipoProduto == null)
                return NotFound();

            return Ok(tipoProduto);
        }

        [HttpPost]
        public async Task<ActionResult<Tipo_ProdutoDTO>> Post(
            [FromBody] Tipo_ProdutoDTO dto)
        {
            var tipoProduto = await service.addAsync(dto);

            return CreatedAtAction(
                nameof(Get),
                new { id = tipoProduto.Id },
                tipoProduto);
        }

        [HttpPut("{id}")]
        public async Task<ActionResult> Put(
            int id,
            [FromBody] Tipo_ProdutoDTO dto)
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