using Microsoft.AspNetCore.Mvc;
using Prefeitura.Api.Interfaces;
using Prefeitura.Core.Entities;

namespace Prefeitura.Api.Controllers;

[ApiController]
[Route("api/[controller]")]
public class CidadaoController : BaseController
{
    private readonly ICidadaoService _cidadaoService;

    public CidadaoController(ICidadaoService cidadaoService)
    {
        _cidadaoService = cidadaoService;
    }

    [HttpGet("{id}")]
    public async Task<IActionResult> GetById(Guid id)
    {
        var cidadao = await _cidadaoService.ObterCidadaoPorIdAsync(id);
        if (cidadao == null)
        {
            return NotFound();
        }
        return Ok(cidadao);
    }

    [HttpGet]
    public async Task<IActionResult> GetAll()
    {
        var cidadaos = await _cidadaoService.ObterCidadaosAsync();
        return Ok(cidadaos);
    }

    [HttpPost]
    public async Task<IActionResult> Create([FromBody] Cidadao cidadao)
    {
        await _cidadaoService.AdicionarCidadaoAsync(cidadao);
        return CreatedAtAction(nameof(GetById), new { id = cidadao.Id }, cidadao);
    }

    [HttpPut("{id}")]
    public async Task<IActionResult> Update(Guid id, [FromBody] Cidadao cidadao)
    {
        if (id != cidadao.Id)
        {
            return BadRequest();
        }

        await _cidadaoService.AtualizarCidadaoAsync(cidadao);
        return NoContent();
    }

    [HttpDelete("{id}")]
    public async Task<IActionResult> Delete(Guid id)
    {
        var cidadao = await _cidadaoService.ObterCidadaoPorIdAsync(id);
        if (cidadao == null)
        {
            return NotFound();
        }

        await _cidadaoService.RemoverCidadaoAsync(cidadao);
        return NoContent();
    }
}
