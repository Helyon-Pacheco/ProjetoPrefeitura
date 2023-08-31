using Microsoft.AspNetCore.Mvc;
using Prefeitura.Api.Interfaces;
using Prefeitura.Core.Entities;

namespace Prefeitura.Api.Controllers;

[ApiController]
[Route("api/[controller]")]
public class PropriedadeController : BaseController
{
    private readonly IPropriedadeService _propriedadeService;

    public PropriedadeController(IPropriedadeService propriedadeService)
    {
        _propriedadeService = propriedadeService;
    }

    [HttpGet("{id}")]
    public async Task<IActionResult> GetById(Guid id)
    {
        var propriedade = await _propriedadeService.ObterPorIdAsync(id);
        if (propriedade == null)
        {
            return NotFound();
        }
        return Ok(propriedade);
    }

    [HttpGet]
    public async Task<IActionResult> GetAll()
    {
        var propriedades = await _propriedadeService.ObterTodosAsync();
        return Ok(propriedades);
    }

    [HttpPost]
    public async Task<IActionResult> Create([FromBody] Propriedade propriedade)
    {
        await _propriedadeService.AdicionarPropriedadeAsync(propriedade);
        return CreatedAtAction(nameof(GetById), new { id = propriedade.Id }, propriedade);
    }


    [HttpPut("{id}")]
    public async Task<IActionResult> Update(Guid id, [FromBody] Propriedade propriedade)
    {
        if (id != propriedade.Id)
        {
            return BadRequest();
        }

        await _propriedadeService.AtualizarPropriedadeAsync(propriedade);
        return NoContent();
    }

    [HttpDelete("{id}")]
    public async Task<IActionResult> Delete(Guid id)
    {
        var propriedade = await _propriedadeService.ObterPorIdAsync(id);
        if (propriedade == null)
        {
            return NotFound();
        }

        await _propriedadeService.RemoverPropriedadeAsync(propriedade);
        return NoContent();
    }
}
